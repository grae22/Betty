using System;
using System.Collections.Generic;
using System.Xml;

namespace Betty
{
  public class Shutter : WallObject
  {
    private ushort m_length;        // mm

    //-------------------------------------------------------------------------

    public Shutter( ushort length )
    {
      m_length = length;
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

    public override string ToString()
    {
      return "Shutter [ " + LengthForDisplay + " ]";
    }

    //-------------------------------------------------------------------------

    public XmlElement ToXml( XmlDocument doc )
    {
      XmlElement shutterXml = doc.CreateElement( "Shutter" );
      
      XmlElement length = doc.CreateElement( "Length" );
      shutterXml.AppendChild( length );
      length.InnerText = m_length.ToString();

      return shutterXml;
    }

    //-------------------------------------------------------------------------

    public static Shutter CreateFromXml( XmlElement shutterXml )
    {
      try
      {
        XmlElement lengthXml = shutterXml.SelectSingleNode( "Length" ) as XmlElement;

        return new Shutter( Convert.ToUInt16( lengthXml.InnerText ) );
      }
      catch
      {
        return null;
      }
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
        return "S[" + LengthForDisplay + "]";
      }
    }

    //-------------------------------------------------------------------------

    public override int CompareTo( WallFeature ob )
    {
      throw new NotImplementedException();
    }

    //-------------------------------------------------------------------------
  }
}
