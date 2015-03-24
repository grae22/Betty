using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Betty
{
  public partial class WallSectionGroupSetup : Form
  {
    FloorPlan m_floorPlan = null;

    //-------------------------------------------------------------------------

    public WallSectionGroupSetup( FloorPlan floorPlan )
    {
      Debug.Assert( floorPlan != null );
      m_floorPlan = floorPlan;

      InitializeComponent();
      PopulateGroupSectionsTree();
    }

    //-------------------------------------------------------------------------

    private void PopulateGroupSectionsTree()
    {
      uiPredefinedWallSections.Nodes.Clear();

      // Iterate through the section groups and add each one.
      foreach( string groupName in m_floorPlan.WallSectionGroupNames )
      {
        TreeNode groupNode = uiPredefinedWallSections.Nodes.Add( groupName );

        // Iterate through this group's sections and add as children to
        // the group.
        foreach( WallSection section in m_floorPlan.GetSectionsForGroup( groupName ) )
        {
          groupNode.Nodes.Add( section.ToString() );
        }
      }

      uiPredefinedWallSections.ExpandAll();
    }

    //-------------------------------------------------------------------------

    private void ShowMissingInfoMessage( string info )
    {
      MessageBox.Show( "Please enter info for '" + info + "'.",
                       "Incomplete Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation );
    }

    //-------------------------------------------------------------------------

    private void uiAdd_Click( object sender, EventArgs e )
    {
      // Group name.
      if( uiGroupName.Text.Length == 0 )
      {
        ShowMissingInfoMessage( "Group Name" );
        uiGroupName.Focus();
        return;
      }

      // Name.
      if( uiName.Text.Length == 0 )
      {
        ShowMissingInfoMessage( "Name" );
        uiName.Focus();
        return;
      }

      // Length.
      if( uiLength.Text.Length == 0 )
      {
        ShowMissingInfoMessage( "Length" );
        uiLength.Focus();
        return;
      }

      ushort length;
      
      if( Program.TryConvertStringToUShort( uiLength.Text,
                                            true,
                                            uiLength,
                                            out length ) == false )
      {
        return;
      }

      length = Program.UnitConvertToMm( length );

      // Height.
      if( uiHeight.Text.Length == 0 )
      {
        uiHeight.Text = "0";
      }

      ushort height;

      if( Program.TryConvertStringToUShort( uiHeight.Text,
                                            true,
                                            uiHeight,
                                            out height ) == false )
      {
        return;
      }

      height = Program.UnitConvertToMm( height );

      // Create a new section and try add it to the floor plan.
      WallSection section =
        new WallSection( uiGroupName.Text,
                         length,
                         height );

      if( m_floorPlan.GetSectionFromDescription( section.ToString() ) != null )
      {
        MessageBox.Show( "A section already exists with these settings.",
                         "Already exists",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information );
        return;
      }

      if( m_floorPlan.AddWallSectionType( section ) )
      {
        PopulateGroupSectionsTree();
      }
    }

    //-------------------------------------------------------------------------
  }
}
