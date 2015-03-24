using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betty
{
  static class Program
  {
    //-------------------------------------------------------------------------

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

    //-------------------------------------------------------------------------

    public static string Unit
    {
      get
      {
        return "cm";
      }

    }

    //-------------------------------------------------------------------------

    // We store all values in mm, but this method allows us to convert to
    // whatever we wish to display. All displayed values should be passed
    // through this method first.

    public static ushort UnitConvert( ushort value )
    {
      return (ushort)( value * 10 );
    }

    //-------------------------------------------------------------------------
  }
}
