using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace Betty
{
  public partial class MainForm : Form
  {
    private FloorPlan m_floorPlan = new FloorPlan();
    private ushort m_wallTotalLength;
    private Wall m_wall = null;

    //-------------------------------------------------------------------------

    public MainForm( string floorPlanFilename )
    {
      InitializeComponent();

      //-- Load floor plan from xml doc.
      try
      {
        if( floorPlanFilename.Length > 0 )
        {
          XmlDocument doc = new XmlDocument();
          doc.Load( floorPlanFilename );
          XmlElement floorPlanXml = doc.FirstChild as XmlElement;
          m_floorPlan = FloorPlan.CreateFromXml( floorPlanXml );
        }
      }
      catch( Exception ex )
      {
        MessageBox.Show( "Error loading FloorPlan from file '" + floorPlanFilename + "'." +
                          Environment.NewLine + Environment.NewLine + ex.Message,
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error );
      }

      //-- Init some UI components.
      uiAddWallSection.Enabled = false;
      
      PopulateWallList();
      RefreshWallInfoEnabledState();
      PopulateFeatureTypesBox();
    }

    //-------------------------------------------------------------------------

    private void uiAddWallSection_Click( object sender, EventArgs e )
    {

    }

    //-------------------------------------------------------------------------

    private void uiWallTotalLength_TextChanged( object sender, EventArgs e )
    {
      try
      {
        m_wallTotalLength = Convert.ToUInt16( uiTotalWallLength.Text );

        uiTotalWallLength.BackColor = Color.White;
      }
      catch
      {
        m_wallTotalLength = 0;

        uiTotalWallLength.BackColor = Color.Red;
      }
    }

    //-------------------------------------------------------------------------

    private void uiSectionType_TextChanged( object sender, EventArgs e )
    {

    }

    //-------------------------------------------------------------------------

    private void uiWallSectionLength_Enter( object sender, EventArgs e )
    {
      uiSectionDistanceFromOrigin.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiRemoveWallSection_Click( object sender, EventArgs e )
    {
      if( uiWallFeatures.SelectedItem == null )
      {
        return;
      }

      // TODO
    }

    //-------------------------------------------------------------------------

    private void uiSectionMoveUp_Click( object sender, EventArgs e )
    {
      if( uiWallFeatures.SelectedItem != null &&
          uiWallFeatures.SelectedIndex > 0 )
      {
        int index = uiWallFeatures.SelectedIndex;
        WallFeature section = uiWallFeatures.SelectedItem as WallFeature;
        uiWallFeatures.Items.RemoveAt( index );
        uiWallFeatures.Items.Insert( index - 1, section );
        uiWallFeatures.SelectedItem = section;
      }
    }

    //-------------------------------------------------------------------------

    private void uiSectionMoveDown_Click( object sender, EventArgs e )
    {
      if( uiWallFeatures.SelectedItem != null &&
          uiWallFeatures.SelectedIndex < uiWallFeatures.Items.Count - 1 )
      {
        int index = uiWallFeatures.SelectedIndex;
        WallFeature section = uiWallFeatures.SelectedItem as WallFeature;
        uiWallFeatures.Items.RemoveAt( index );
        uiWallFeatures.Items.Insert( index + 1, section );
        uiWallFeatures.SelectedItem = section;
      }
    }

    //-------------------------------------------------------------------------

    private void uiSetupWallSectionGroups_Click( object sender, EventArgs e )
    {
      WallFeatureTypeSetup dlg = new WallFeatureTypeSetup( m_floorPlan );
      dlg.ShowDialog( this );
    }

    //-------------------------------------------------------------------------

    private void uiSave_Click( object sender, EventArgs e )
    {
      m_floorPlan.WriteToFile();
    }

    //-------------------------------------------------------------------------

    private void RefreshWallInfoEnabledState()
    {
      uiWallInfo.Enabled = ( m_wall != null );
    }

    //-------------------------------------------------------------------------

    private void PopulateWallList()
    {
      Wall selectedWall = uiWalls.SelectedItem as Wall;

      uiWalls.Items.Clear();

      foreach( Wall wall in m_floorPlan.Walls )
      {
        uiWalls.Items.Add( wall );
      }

      uiWalls.SelectedItem = selectedWall;
    }

    //-------------------------------------------------------------------------

    private void PopulateWallInfo()
    {
      if( m_wall == null )
      {
        uiWallName.Text = "";
        uiTotalWallLength.Text = "0";
        uiSectionDistanceFromOrigin.Text = "0";

        return;
      }

      uiWallName.Text = m_wall.Name;
      uiTotalWallLength.Text = m_wall.Length.ToString();
      uiSectionDistanceFromOrigin.Text = "0";
    }

    //-------------------------------------------------------------------------

    private void uiAddWall_Click( object sender, EventArgs e )
    {
      try
      {
        // Find a unique name.
        string name = "New wall";
        ushort newWallNumber = 2;

        while( m_floorPlan.GetWall( name ) != null )
        {
          name = "New wall " + newWallNumber.ToString();
          newWallNumber++;
        }

        // Create a new wall object & add to the floorplan.
        m_wall = new Wall( name );

        m_floorPlan.AddWall( m_wall );

        // Refresh UI.
        PopulateWallList();

        uiWalls.SelectedItem = m_wall;
      }
      catch( Exception ex )
      {
        MessageBox.Show( ex.Message,
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error );
      }
    }

    //-------------------------------------------------------------------------

    private void uiWalls_SelectedIndexChanged( object sender, EventArgs e )
    {
      m_wall = uiWalls.SelectedItem as Wall;

      RefreshWallInfoEnabledState();
      PopulateWallInfo();

      uiWallName.Focus();
      uiWallName.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiWallName_KeyDown( object sender, KeyEventArgs e )
    {
      if( e.KeyCode == Keys.Enter )
      {
        uiTotalWallLength.Focus();
      }
    }

    //-------------------------------------------------------------------------

    private void uiWallName_Validating( object sender, System.ComponentModel.CancelEventArgs e )
    {
      try
      {
        // Has name?
        uiWallName.Text = uiWallName.Text.Trim();

        if( uiWallName.Text.Length == 0 )
        {
          MessageBox.Show( "You must enter a name.",
                           "Invalid Input",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error );
          e.Cancel = true;
          return;
        }

        // Name already exist?
        Wall testWall = m_floorPlan.GetWall( uiWallName.Text );

        if( testWall != m_wall &&
            testWall != null )
        {
          MessageBox.Show( "A wall named '" + uiWallName.Text + "' already exists.",
                           "Duplicate Name",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error );
          e.Cancel = true;
          return;
        }

        // Update the wall's name.
        m_wall.Name = uiWallName.Text;

        // Update the item in the wall's list box.
        PopulateWallList();

        // Move on to next field.
        uiTotalWallLength.Focus();
      }
      catch( Exception ex )
      {
        ShowErrorMessage( ex.Message, "Error" );
      }
    }

    //-------------------------------------------------------------------------

    private void ShowErrorMessage( string msg,
                                   string title )
    {
      MessageBox.Show( msg,
                       title,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error );
    }

    //-------------------------------------------------------------------------

    private void uiWallName_Enter( object sender, EventArgs e )
    {
      uiWallName.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiWallName_Click( object sender, EventArgs e )
    {
      uiWallName.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiTotalWallLength_Enter( object sender, EventArgs e )
    {
      uiTotalWallLength.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiTotalWallLength_Click( object sender, EventArgs e )
    {
      uiTotalWallLength.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiTotalWallLength_Validating( object sender, System.ComponentModel.CancelEventArgs e )
    {
      try
      {
        m_wall.Length = Convert.ToUInt16( uiTotalWallLength.Text );
      }
      catch
      {
        ShowErrorMessage( "Please enter a valid length.",
                          "Invalid Input" );
        e.Cancel = true;
      }
    }

    //-------------------------------------------------------------------------

    private void uiSectionDistanceFromOrigin_Enter( object sender, EventArgs e )
    {
      uiSectionDistanceFromOrigin.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiSectionDistanceFromOrigin_Click( object sender, EventArgs e )
    {
      uiSectionDistanceFromOrigin.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiSectionDistanceFromOrigin_Validating( object sender, System.ComponentModel.CancelEventArgs e )
    {
      try
      {
        if( uiSectionDistanceFromOrigin.Text.Length == 0 )
        {
          uiSectionDistanceFromOrigin.Text = "0";
        }

        Convert.ToUInt16( uiSectionDistanceFromOrigin.Text );
      }
      catch
      {
        ShowErrorMessage( "Please enter a valid distance.",
                          "Invalid Input" );
        e.Cancel = true;
      }
    }

    //-------------------------------------------------------------------------

    private void uiSectionDistanceFromOrigin_KeyDown( object sender, KeyEventArgs e )
    {
      try
      {
        if( e.KeyCode == Keys.Enter )
        {
          uiAddWallSection_Click( null, null );
        }
        else if( e.KeyCode == Keys.Up )
        {
          if( uiFeatureType.SelectedIndex > 0 )
          {
            uiFeatureType.SelectedIndex--;
          }
        }
        else if( e.KeyCode == Keys.Down )
        {
          if( uiFeatureType.SelectedIndex < uiFeatureType.Items.Count - 1 )
          {
            uiFeatureType.SelectedIndex++;
          }
        }
        else if( e.KeyCode == Keys.PageUp )
        {
          // Find the next feature type up and select it's first feature.
          if( uiFeatureType.SelectedItem == null )
          {
            return;
          }

          string currentFeatureTypeName =
            ( uiFeatureType.SelectedItem as WallFeature ).Type;
          string nextFeatureTypeName = null;

          for( ; uiFeatureType.SelectedIndex > 0; uiFeatureType.SelectedIndex-- )
          {
            if( currentFeatureTypeName != ( uiFeatureType.SelectedItem as WallFeature ).Type )
            {
              nextFeatureTypeName = ( uiFeatureType.SelectedItem as WallFeature ).Type;
              break;
            }
          }

          for( ; uiFeatureType.SelectedIndex > 0; uiFeatureType.SelectedIndex-- )
          {
            if( ( uiFeatureType.SelectedItem as WallFeature ).Type != nextFeatureTypeName )
            {
              uiFeatureType.SelectedIndex++;
              break;
            }
          }
        }
        else if( e.KeyCode == Keys.PageDown )
        {
          // Find the next feature type down and select it's first feature.
          if( uiFeatureType.SelectedItem == null )
          {
            return;
          }

          string currentFeatureTypeName =
            ( uiFeatureType.SelectedItem as WallFeature ).Type;

          for( ; uiFeatureType.SelectedIndex < uiFeatureType.Items.Count - 1; uiFeatureType.SelectedIndex++ )
          {
            if( currentFeatureTypeName != ( uiFeatureType.SelectedItem as WallFeature ).Type )
            {
              break;
            }
          }
        }
      }
      catch( Exception ex )
      {
        ShowErrorMessage( ex.Message, "Error" );
      }
    }

    //-------------------------------------------------------------------------

    private void PopulateFeatureTypesBox()
    {
      foreach( WallFeature f in m_floorPlan.WallFeatureTypes )
      {
        uiFeatureType.Items.Add( f );
      }

      if( uiFeatureType.Items.Count > 0 )
      {
        uiFeatureType.SelectedIndex = 0;
      }
    }

    //-------------------------------------------------------------------------

    private void uiTotalWallLength_KeyDown( object sender, KeyEventArgs e )
    {
      if( e.KeyCode == Keys.Enter )
      {
        uiSectionDistanceFromOrigin.Focus();
      }
    }

    //-------------------------------------------------------------------------
  }
}
