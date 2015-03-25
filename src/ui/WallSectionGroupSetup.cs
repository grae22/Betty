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

      uiUnit.Text = Program.Unit;
    }

    //-------------------------------------------------------------------------

    private void PopulateGroupSectionsTree()
    {
      // Remember what was selected.
      WallSection selectedItem = null;
      
      if( uiGroupsAndSections.SelectedNode != null )
      {
        selectedItem = uiGroupsAndSections.SelectedNode.Tag as WallSection;
      }

      // Clear the tree.
      uiGroupsAndSections.Nodes.Clear();
      uiGroupName.Items.Clear();

      // Iterate through the section groups and add each one.
      foreach( string groupName in m_floorPlan.WallSectionGroupNames )
      {
        // Create a node for this group.
        TreeNode groupNode = uiGroupsAndSections.Nodes.Add( groupName );

        // Add the name to the groups combobox.
        uiGroupName.Items.Add( groupName );

        // Iterate through this group's sections and add as children to
        // the group.
        foreach( WallSection section in m_floorPlan.GetSectionsForGroup( groupName ) )
        {
          TreeNode node = new TreeNode( section.ToString() );
          node.Tag = section;

          groupNode.Nodes.Add( node );

          // Was previously selected? Re-select.
          if( section == selectedItem )
          {
            uiGroupsAndSections.SelectedNode = node;
          }
        }
      }

      uiGroupsAndSections.ExpandAll();
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

    private void uiRemove_Click( object sender, EventArgs e )
    {
      // The nodes for sections have a 'tag' that is the section object,
      // if the selected node has this - remove the section.
      if( uiGroupsAndSections.SelectedNode != null &&
          uiGroupsAndSections.SelectedNode.Tag != null )
      {
        m_floorPlan.RemoveWallSectionType(
          uiGroupsAndSections.SelectedNode.Tag as WallSection );

        PopulateGroupSectionsTree();
      }
    }

    //-------------------------------------------------------------------------

    private void uiPrioritise_Click( object sender, EventArgs e )
    {
      // The nodes for sections have a 'tag' that is the section object.
      if( uiGroupsAndSections.SelectedNode != null &&
          uiGroupsAndSections.SelectedNode.Tag != null )
      {
        m_floorPlan.PrioritiseWallSectionType(
          uiGroupsAndSections.SelectedNode.Tag as WallSection );

        PopulateGroupSectionsTree();
      }
    }

    //-------------------------------------------------------------------------

    private void uiDeprioritise_Click( object sender, EventArgs e )
    {
      // The nodes for sections have a 'tag' that is the section object.
      if( uiGroupsAndSections.SelectedNode != null &&
          uiGroupsAndSections.SelectedNode.Tag != null )
      {
        m_floorPlan.DeprioritiseWallSectionType(
          uiGroupsAndSections.SelectedNode.Tag as WallSection );

        PopulateGroupSectionsTree();
      }
    }

    //-------------------------------------------------------------------------
  }
}
