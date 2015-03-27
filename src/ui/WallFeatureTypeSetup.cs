using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Betty
{
  public partial class WallFeatureTypeSetup : Form
  {
    FloorPlan m_floorPlan = null;

    //-------------------------------------------------------------------------

    public WallFeatureTypeSetup( FloorPlan floorPlan )
    {
      Debug.Assert( floorPlan != null );
      m_floorPlan = floorPlan;

      InitializeComponent();
      PopulateTypeSectionsTree();

      uiUnit.Text = Program.Unit;
    }

    //-------------------------------------------------------------------------

    private void PopulateTypeSectionsTree()
    {
      // Remember what was selected.
      WallFeature selectedItem = null;
      
      if( uiTypesAndFeatures.SelectedNode != null )
      {
        selectedItem = uiTypesAndFeatures.SelectedNode.Tag as WallFeature;
      }

      // Clear the tree.
      uiTypesAndFeatures.Nodes.Clear();
      uiGroupName.Items.Clear();

      // Iterate through the section types and add each one.
      foreach( string typeName in m_floorPlan.WallFeatureTypeNames )
      {
        // Create a node for this type.
        TreeNode typeNode = uiTypesAndFeatures.Nodes.Add( typeName );

        // Add the name to the types combobox.
        uiGroupName.Items.Add( typeName );

        // Iterate through this type's sections and add as children to
        // the type.
        foreach( WallFeature section in m_floorPlan.GetFeaturesForType( typeName ) )
        {
          TreeNode node = new TreeNode( section.ToString() );
          node.Tag = section;

          typeNode.Nodes.Add( node );

          // Was previously selected? Re-select.
          if( section == selectedItem )
          {
            uiTypesAndFeatures.SelectedNode = node;
          }
        }
      }

      uiTypesAndFeatures.ExpandAll();
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
      // Type name.
      if( uiGroupName.Text.Length == 0 )
      {
        ShowMissingInfoMessage( "Type Name" );
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
      WallFeature section =
        new WallFeature( uiGroupName.Text,
                         length,
                         height );

      if( m_floorPlan.GetFeatureFromDescription( section.ToString() ) != null )
      {
        MessageBox.Show( "A feature already exists with these settings.",
                         "Already exists",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information );
        return;
      }

      if( m_floorPlan.AddWallFeatureType( section ) )
      {
        PopulateTypeSectionsTree();
      }
    }

    //-------------------------------------------------------------------------

    private void uiRemove_Click( object sender, EventArgs e )
    {
      // The nodes for sections have a 'tag' that is the section object,
      // if the selected node has this - remove the section.
      if( uiTypesAndFeatures.SelectedNode != null &&
          uiTypesAndFeatures.SelectedNode.Tag != null )
      {
        m_floorPlan.RemoveWallFeatureType(
          uiTypesAndFeatures.SelectedNode.Tag as WallFeature );

        PopulateTypeSectionsTree();
      }
    }

    //-------------------------------------------------------------------------
  }
}
