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

      InitializeComponent();
    }

    //-------------------------------------------------------------------------

    private void uiBtnClose_Click( object sender, EventArgs e )
    {

    }

    //-------------------------------------------------------------------------
  }
}
