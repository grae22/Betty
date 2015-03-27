﻿using System;
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
    private Wall m_wall = new Wall();
    private WallFeature m_section = new WallFeature( "Unknown", 1000, 0 );

    //-------------------------------------------------------------------------

    public MainForm( string floorPlanFilename )
    {
      InitializeComponent();

      uiSectionType.Text = uiSectionType.Items[ 0 ] as string;
      uiAddWallSection.Enabled = false;

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
    }

    //-------------------------------------------------------------------------

    private void uiAddWallSection_Click( object sender, EventArgs e )
    {
      m_wall.Sections.Add( m_section );
      uiWallSections.Items.Add( m_section );

      m_section = new WallFeature( "Unknown", 1000, 0 );

      uiSectionDistanceFromOrigin.Text = "";
      uiSectionDistanceFromOrigin.Focus();
      uiAddWallSection.Enabled = false;
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

    private void uiWallSectionLength_TextChanged( object sender, EventArgs e )
    {
      if( uiSectionDistanceFromOrigin.Text == "" )
      {
        uiSectionDistanceFromOrigin.BackColor = Color.White;
        uiAddWallSection.Enabled = false;
        return;
      }

      try
      {
        m_section.Length = Convert.ToUInt16( uiSectionDistanceFromOrigin.Text );

        if( m_section.Length == 0 )
        {
          throw new Exception();
        }

        uiSectionDistanceFromOrigin.BackColor = Color.White;

        uiAddWallSection.Enabled = true;
      }
      catch
      {
        uiSectionDistanceFromOrigin.BackColor = Color.Red;

        uiAddWallSection.Enabled = false;
      }
    }

    //-------------------------------------------------------------------------

    private void uiWallSectionLength_KeyDown( object sender, KeyEventArgs e )
    {
      if( e.KeyCode == Keys.Enter )
      {
        uiAddWallSection_Click( null, null );
      }
      else if( e.KeyCode == Keys.Up )
      {
        if( uiSectionType.SelectedIndex > 0 )
        {
          uiSectionType.SelectedIndex--;
        }
      }
      else if( e.KeyCode == Keys.Down )
      {
        if( uiSectionType.SelectedIndex < uiSectionType.Items.Count - 1 )
        {
          uiSectionType.SelectedIndex++;
        }
      }
    }

    //-------------------------------------------------------------------------

    private void uiRemoveWallSection_Click( object sender, EventArgs e )
    {
      if( uiWallSections.SelectedItem == null )
      {
        return;
      }

      m_wall.Sections.Remove( uiWallSections.SelectedItem as WallFeature );
      uiWallSections.Items.Remove( uiWallSections.SelectedItem );
    }

    //-------------------------------------------------------------------------

    private void uiSectionMoveUp_Click( object sender, EventArgs e )
    {
      if( uiWallSections.SelectedItem != null &&
          uiWallSections.SelectedIndex > 0 )
      {
        int index = uiWallSections.SelectedIndex;
        WallFeature section = uiWallSections.SelectedItem as WallFeature;
        uiWallSections.Items.RemoveAt( index );
        uiWallSections.Items.Insert( index - 1, section );
        uiWallSections.SelectedItem = section;
      }
    }

    //-------------------------------------------------------------------------

    private void uiSectionMoveDown_Click( object sender, EventArgs e )
    {
      if( uiWallSections.SelectedItem != null &&
          uiWallSections.SelectedIndex < uiWallSections.Items.Count - 1 )
      {
        int index = uiWallSections.SelectedIndex;
        WallFeature section = uiWallSections.SelectedItem as WallFeature;
        uiWallSections.Items.RemoveAt( index );
        uiWallSections.Items.Insert( index + 1, section );
        uiWallSections.SelectedItem = section;
      }
    }

    //-------------------------------------------------------------------------

    private void uiSetupWallSectionGroups_Click( object sender, EventArgs e )
    {
      WallSectionTypeSetup dlg = new WallSectionTypeSetup( m_floorPlan );
      dlg.ShowDialog( this );
    }

    //-------------------------------------------------------------------------

    private void uiSave_Click( object sender, EventArgs e )
    {
      m_floorPlan.WriteToFile();
    }

    //-------------------------------------------------------------------------
  }
}
