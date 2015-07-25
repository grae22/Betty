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
    static void Main( string[] args )
    {
      string floorPlanFilename = ( args.Length == 0 ? "" : args[ 0 ] );

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault( false );
      Application.Run( new MainForm( floorPlanFilename ) );
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

    public static bool DetermineShutterCombinationForWall( Wall wall,
                                                           List< Shutter > shutterTypes,
                                                           out List< WallObject > finalWallObjectCombination )
    {
      finalWallObjectCombination = new List< WallObject >();
      ushort lastFeatureEndOffset = 0;

      foreach( WallFeature feature in wall.Features )
      {
        if( feature.DistanceFromOrigin < lastFeatureEndOffset )
        {
          throw new Exception(
            "Feature '" + feature.Type + "' at DFO " +
              feature.DistanceFromOriginForDisplay +
              " starts before the previous feature ends." );
        }

        ushort distance = (ushort)( feature.DistanceFromOrigin - lastFeatureEndOffset );

        List<WallObject> wallObjects = new List<WallObject>();
        bool foundCombination =
          DetermineShutterForDistance( shutterTypes,
                                       wallObjects,
                                       ref distance );

        if( foundCombination == false )
        {
          throw new Exception(
            "No shutter combination could be found to go between " +
              "feature '" + feature.Type + "' (DFO=" + feature.DistanceFromOriginForDisplay + ") " +
              "and the previous feature (if any)." );
        }

        foreach( WallObject w in wallObjects )
        {
          finalWallObjectCombination.Add( w );
        }

        finalWallObjectCombination.Add( feature );

        lastFeatureEndOffset = (ushort)( feature.DistanceFromOrigin + feature.Length );
      }

      // From last feature to wall end.
      if( lastFeatureEndOffset < wall.Length )
      {
        ushort distance = (ushort)( wall.Length - lastFeatureEndOffset );

        List<WallObject> wallObjects = new List<WallObject>();
        bool foundCombination =
          DetermineShutterForDistance( shutterTypes,
                                       wallObjects,
                                       ref distance );

        if( foundCombination == false )
        {
          throw new Exception(
            "No shutter combination could be found to go between " +
              "the last feature (if any) and the end of the wall." +
              Environment.NewLine + Environment.NewLine +
              "Distance = " + ( wall.Length - lastFeatureEndOffset ).ToString() + "mm" );
        }

        foreach( WallObject w in wallObjects )
        {
          finalWallObjectCombination.Add( w );
        }
      }

      return true;
    }

    //-------------------------------------------------------------------------

    private static bool DetermineShutterForDistance( List< Shutter > shutterTypes,
                                                     List< WallObject > wallObjects,
                                                     ref ushort distance )
    {
      bool foundShutter = false;

      foreach( Shutter shutterType in shutterTypes )
      {
        if( shutterType.Length <= distance )
        {
          wallObjects.Add( shutterType );
          distance -= shutterType.Length;

          if( distance == 0 )
          {
            return true;
          }

          foundShutter =
            DetermineShutterForDistance( shutterTypes,
                                         wallObjects,
                                         ref distance );

          if( foundShutter == false )
          {
            wallObjects.Clear();
            return false;
          }
        }
      }

      return foundShutter;
    }

    //-------------------------------------------------------------------------
  }
}
