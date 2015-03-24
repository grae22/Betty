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

    public static ushort UnitConvertForDisplay( ushort value )
    {
      return (ushort)( value / 10 );
    }

    //-------------------------------------------------------------------------

    // We store all values in mm, but we may (probably) display using a
    // different unit (e.g. cm). This method should typically be used to
    // convert input from the displayed unit to mm.

    public static ushort UnitConvertToMm( ushort value )
    {
      return (ushort)( value * 10 );
    }

    //-------------------------------------------------------------------------

    public static bool TryConvertStringToUShort( string text,
                                                 bool showMessageOnFail,
                                                 Control giveFocusTo,
                                                 out ushort value )
    {
      value = 0;

      try
      {
        value = Convert.ToUInt16( text );
      }
      catch
      {
        if( showMessageOnFail )
        {
          MessageBox.Show( "Text is not a valid number.",
                           "Invalid Input",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error );
        }

        if( giveFocusTo != null )
        {
          giveFocusTo.Focus();
        }

        return false;
      }

      return true;
    }

    //-------------------------------------------------------------------------
  }
}
