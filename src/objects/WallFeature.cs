using System;
using System.Collections.Generic;
using System.Xml;

namespace Betty
{
  public class WallFeature : WallObject
  {
    private string m_type = "Unknown";
    private ushort m_length;        // mm
    private ushort m_height;        // mm
    private ushort m_distanceFromOrigin;    // DFO (mm)
    private bool m_useShutter;

    //-------------------------------------------------------------------------

    public WallFeature( WallFeature copyFrom )
    {
      m_type = copyFrom.Type;
      m_length = copyFrom.Length;
      m_height = copyFrom.Height;
      m_distanceFromOrigin = copyFrom.DistanceFromOrigin;
      m_useShutter = copyFrom.UseShutter;
    }

    //-------------------------------------------------------------------------

    public WallFeature( string type,
                        ushort length,
                        ushort height,
                        ushort distanceFromOrigin,
                        bool useShutter )
    {
      m_type = type;
      m_length = length;
      m_height = height;
      m_distanceFromOrigin = distanceFromOrigin;
      m_useShutter = useShutter;
    }

    //-------------------------------------------------------------------------

    public string Type
    {
      get
      {
        return m_type;
      }

      set
      {
        m_type = value;
      }
    }

    //-------------------------------------------------------------------------

    public ushort Length
    {
      get
      {
        return m_length;
      }

      set
      {
        m_length = value;
      }
    }

    //-------------------------------------------------------------------------

    public ushort Height
    {
      get
      {
        return m_height;
      }

      set
      {
        m_height = value;
      }
    }

    //-------------------------------------------------------------------------

    // Returns a string of the value in the units we are using for displayed
    // values.

    public string LengthForDisplay
    {
      get
      {
        return Program.UnitConvertForDisplay( m_length ).ToString();
      }
    }

    //-------------------------------------------------------------------------

    // Returns a string of the value in the units we are using for displayed
    // values.

    public string HeightForDisplay
    {
      get
      {
        return Program.UnitConvertForDisplay( m_height ).ToString();
      }
    }

    //-------------------------------------------------------------------------

    public ushort DistanceFromOrigin
    {
      get
      {
        return m_distanceFromOrigin;
      }

      set
      {
        m_distanceFromOrigin = value;
      }
    }

    //-------------------------------------------------------------------------

    public string DistanceFromOriginForDisplay
    {
      get
      {
        return Program.UnitConvertForDisplay( m_distanceFromOrigin ).ToString();
      }
    }

    //-------------------------------------------------------------------------

    public bool UseShutter
    {
      get
      {
        return m_useShutter;
      }

      set
      {
        m_useShutter = value;
      }
    }

    //-------------------------------------------------------------------------

    public override string ToString()
    {
      // Length & height (if any).
      string s = m_type + " [ " + LengthForDisplay;

      if( m_height > 0 )
      {
        s += " x " + HeightForDisplay;
      }

      s += " ]";

      // Use shutter.
      if( m_useShutter )
      {
        s += " (S)";
      }

      // DFO.
      if( m_distanceFromOrigin > 0 )
      {
        s += " ( DFO = " + DistanceFromOriginForDisplay + " )";
      }

      return s;
    }

    //-------------------------------------------------------------------------

    public XmlElement ToXml( XmlDocument doc )
    {
      XmlElement wallSection = doc.CreateElement( "WallFeature" );
      
      XmlElement type = doc.CreateElement( "Type" );
      wallSection.AppendChild( type );
      type.InnerText = m_type;
      
      XmlElement length = doc.CreateElement( "Length" );
      wallSection.AppendChild( length );
      length.InnerText = m_length.ToString();

      XmlElement height = doc.CreateElement( "Height" );
      wallSection.AppendChild( height );
      height.InnerText = m_height.ToString();

      XmlElement dfo = doc.CreateElement( "DistanceFromOrigin" );
      wallSection.AppendChild( dfo );
      dfo.InnerText = m_distanceFromOrigin.ToString();

      XmlElement useShutter = doc.CreateElement( "UseShutter" );
      wallSection.AppendChild( useShutter );
      useShutter.InnerText = m_useShutter.ToString();

      return wallSection;
    }

    //-------------------------------------------------------------------------

    public static WallFeature CreateFromXml( XmlElement wallSectionXml )
    {
      try
      {
        XmlElement typeXml = wallSectionXml.SelectSingleNode( "Type" ) as XmlElement;
        XmlElement lengthXml = wallSectionXml.SelectSingleNode( "Length" ) as XmlElement;
        XmlElement heightXml = wallSectionXml.SelectSingleNode( "Height" ) as XmlElement;
        XmlElement dfoXml = wallSectionXml.SelectSingleNode( "DistanceFromOrigin" ) as XmlElement;
        XmlElement useShutterXml = wallSectionXml.SelectSingleNode( "UseShutter" ) as XmlElement;

        return new WallFeature( typeXml.InnerText,
                                Convert.ToUInt16( lengthXml.InnerText ),
                                Convert.ToUInt16( heightXml.InnerText ),
                                Convert.ToUInt16( dfoXml.InnerText ),
                                bool.Parse( useShutterXml.InnerText ) );
      }
      catch
      {
        return null;
      }
    }

    //-------------------------------------------------------------------------

    public override int CompareTo( WallObject ob )
    {
      WallFeature compareToOb = ob as WallFeature;

      if( compareToOb.DistanceFromOrigin > m_distanceFromOrigin )
      {
        return -1;
      }
      else if( compareToOb.DistanceFromOrigin < m_distanceFromOrigin )
      {
        return 1;
      }

      return 0;
    }
 
    //-------------------------------------------------------------------------

    public override string Description
    {
      get
      {
        return ToString();
      }
    }

    //-------------------------------------------------------------------------

    public override string ShortDescription
    {
      get
      {
        return ToString();
      }
    }

    //-------------------------------------------------------------------------
  }
}
