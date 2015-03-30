using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Betty
{
  public partial class ShutterSetup : Form
  {
    FloorPlan m_floorPlan;

    //-------------------------------------------------------------------------

    public ShutterSetup( FloorPlan floorPlan )
    {
      Debug.Assert( floorPlan != null );
      m_floorPlan = floorPlan;

      InitializeComponent();
      PopulateShuttersList();
    }

    //-------------------------------------------------------------------------

    private void PopulateShuttersList()
    {
      Shutter selectedItem = uiLstShutters.SelectedItem as Shutter;

      uiLstShutters.Items.Clear();

      foreach( Shutter shutter in m_floorPlan.ShutterTypes )
      {
        uiLstShutters.Items.Add( shutter );
      }

      uiLstShutters.SelectedItem = selectedItem;
    }

    //-------------------------------------------------------------------------

    private void uiBtnClose_Click( object sender, EventArgs e )
    {

    }

    //-------------------------------------------------------------------------

    private void uiBtnAdd_Click( object sender, EventArgs e )
    {
      // No length specified?
      if( uiTxtLength.Text.Length == 0 )
      {
        MessageBox.Show( "Please enter a 'Length'.",
                         "Missing Information",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information );
        uiTxtLength.Focus();
        return;
      }

      // Invalid length specified?
      ushort length;

      try
      {
        length = Convert.ToUInt16( uiTxtLength.Text );
        length = Program.UnitConvertToMm( length );
      }
      catch
      {
        MessageBox.Show( "Please enter a valid 'Length'.",
                         "Invalid Information",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information );
        uiTxtLength.Focus();
        uiTxtLength.SelectAll();
        return;
      }

      // Create a new shutter.
      Shutter shutter = new Shutter( length );
      m_floorPlan.ShutterTypes.Add( shutter );

      PopulateShuttersList();

      uiTxtLength.Text = "";
      uiTxtLength.Focus();
    }

    //-------------------------------------------------------------------------

    private void uiBtnRemove_Click( object sender, EventArgs e )
    {
      if( uiLstShutters.SelectedItem == null )
      {
        return;
      }

      m_floorPlan.ShutterTypes.Remove(
        uiLstShutters.SelectedItem as Shutter );

      PopulateShuttersList();
    }

    //-------------------------------------------------------------------------

    private void uiBtnMoveUp_Click( object sender, EventArgs e )
    {
      if( uiLstShutters.SelectedItem != null )
      {
        m_floorPlan.PrioritiseShutterType(
          uiLstShutters.SelectedItem as Shutter );

        PopulateShuttersList();
      }
    }

    //-------------------------------------------------------------------------

    private void uiBtnMoveDown_Click( object sender, EventArgs e )
    {
      if( uiLstShutters.SelectedItem != null )
      {
        m_floorPlan.DeprioritiseShutterType(
          uiLstShutters.SelectedItem as Shutter );

        PopulateShuttersList();
      }
    }

    //-------------------------------------------------------------------------
  }
}
