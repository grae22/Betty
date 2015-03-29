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
      PopulateWallList();
      RefreshWallInfoEnabledState();
      PopulateFeatureTypesBox();
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

    private void uiWallFeatureLength_Enter( object sender, EventArgs e )
    {
      uiFeatureDistanceFromOrigin.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiRemoveWallFeaure_Click( object sender, EventArgs e )
    {
      if( uiWallFeatures.SelectedItem == null )
      {
        return;
      }

      // TODO
    }

    //-------------------------------------------------------------------------

    private void uiSetupWallFeatureTypes_Click( object sender, EventArgs e )
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
      uiGrpWallFeatures.Enabled = ( m_wall != null );
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
        uiFeatureDistanceFromOrigin.Text = "0";

        return;
      }

      uiWallName.Text = m_wall.Name;
      uiTotalWallLength.Text = m_wall.Length.ToString();
      uiFeatureDistanceFromOrigin.Text = "0";
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

    private void uiFeatureDistanceFromOrigin_Enter( object sender, EventArgs e )
    {
      uiFeatureDistanceFromOrigin.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiFeatureDistanceFromOrigin_Click( object sender, EventArgs e )
    {
      uiFeatureDistanceFromOrigin.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiFeatureDistanceFromOrigin_Validating( object sender, System.ComponentModel.CancelEventArgs e )
    {
      try
      {
        if( uiFeatureDistanceFromOrigin.Text.Length == 0 )
        {
          uiFeatureDistanceFromOrigin.Text = "0";
        }

        Convert.ToUInt16( uiFeatureDistanceFromOrigin.Text );
      }
      catch
      {
        ShowErrorMessage( "Please enter a valid distance.",
                          "Invalid Input" );
        e.Cancel = true;
      }
    }

    //-------------------------------------------------------------------------

    private void uiFeatureDistanceFromOrigin_KeyDown( object sender, KeyEventArgs e )
    {
      try
      {
        if( e.KeyCode == Keys.Enter )
        {
          uiAddWallFeature_Click( null, null );
        }
        else if( e.KeyCode == Keys.Up )
        {
          if( uiFeatures.SelectedIndex > 0 )
          {
            uiFeatures.SelectedIndex--;
          }
        }
        else if( e.KeyCode == Keys.Down )
        {
          if( uiFeatures.SelectedIndex < uiFeatures.Items.Count - 1 )
          {
            uiFeatures.SelectedIndex++;
          }
        }
        else if( e.KeyCode == Keys.PageUp )
        {
          if( uiFeatureType.SelectedIndex > 0 )
          {
            uiFeatureType.SelectedIndex--;
          }
        }
        else if( e.KeyCode == Keys.PageDown )
        {
          if( uiFeatureType.SelectedIndex < uiFeatureType.Items.Count - 1 )
          {
            uiFeatureType.SelectedIndex++;
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
      uiFeatureType.Items.Clear();

      foreach( string s in m_floorPlan.WallFeatureTypeNames )
      {
        uiFeatureType.Items.Add( s );
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
        uiFeatureDistanceFromOrigin.Focus();
      }
    }

    //-------------------------------------------------------------------------

    private void uiFeatureType_SelectedIndexChanged( object sender, EventArgs e )
    {
      PopulateFeaturesBox();
    }

    //-------------------------------------------------------------------------

    private void PopulateFeaturesBox()
    {
      uiFeatures.Items.Clear();

      foreach( WallFeature f in m_floorPlan.GetFeaturesForType( uiFeatureType.Text ) )
      {
        uiFeatures.Items.Add( f );
      }

      if( uiFeatures.Items.Count > 0 )
      {
        uiFeatures.SelectedIndex = 0;
      }
    }

    //-------------------------------------------------------------------------

    private void uiAddWallFeature_Click( object sender, EventArgs e )
    {
      // Feature.
      if( uiFeatures.SelectedItem == null )
      {
        MessageBox.Show( "Please select a 'Feature'.",
                         "Missing Information",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information );
        uiFeatureDistanceFromOrigin.Focus();
        return;
      }

      // DFO.
      ushort dfo;

      try
      {
        dfo = Convert.ToUInt16( uiFeatureDistanceFromOrigin.Text );
      }
      catch
      {
        MessageBox.Show( "Please enter a valid DFO.",
                         "Invalid Input",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information );
        uiFeatureDistanceFromOrigin.Focus();
        return;
      }

      // Add the feature to the wall.
      WallFeature newFeature =
        new WallFeature( uiFeatures.SelectedItem as WallFeature );

      newFeature.DistanceFromOrigin = dfo;

      m_wall.Features.Add( newFeature );

      PopulateWallFeatures();

      // Reset the DFO box.
      uiFeatureDistanceFromOrigin.Focus();
      uiFeatureDistanceFromOrigin.Text = "";
    }

    //-------------------------------------------------------------------------

    private void PopulateWallFeatures()
    {
      uiWallFeatures.Items.Clear();

      if( m_wall == null )
      {
        return;
      }

      // Add to a list first so we can sort it.
      List< WallFeature > items = new List< WallFeature >();

      foreach( WallFeature f in m_wall.Features )
      {
        items.Add( f );
      }

      items.Sort();
      
      // Add to ui list.
      foreach( WallFeature f in items )
      {
        uiWallFeatures.Items.Add( f );
      }
    }

    //-------------------------------------------------------------------------
  }
}
