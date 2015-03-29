using System;
using System.Collections.Generic;
using System.Xml;

namespace Betty
{
  public class Wall
  {
    private string m_name = "Unknown";
    private ushort m_length;
    private List< WallFeature > m_features = new List< WallFeature >();

    //-------------------------------------------------------------------------

    public static Wall CreateFromXml( XmlElement xml )
    {
      return null;    // TODO
    }

    //-------------------------------------------------------------------------

    public Wall( string name )
    {
      m_name = name;
    }

    //-------------------------------------------------------------------------

    public string Name
    {
      get
      {
        return m_name;
      }

      set
      {
        m_name = value;
      }
    }

    //-------------------------------------------------------------------------

    public List< WallFeature > Features
    {
      get
      {
        return m_features;
      }

      set
      {
        m_features = value;
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

    public override string ToString()
    {
      return m_name;
    }

    //-------------------------------------------------------------------------

    public XmlElement ToXml( XmlDocument doc )
    {
      XmlElement wallXml = doc.CreateElement( "Wall" );

      XmlElement nameXml = doc.CreateElement( "Name" );
      wallXml.AppendChild( nameXml );
      nameXml.InnerText = m_name;

      XmlElement featureCollectionXml = doc.CreateElement( "FeatureCollection" );
      wallXml.AppendChild( featureCollectionXml );

      foreach( WallFeature feature in m_features )
      {
        featureCollectionXml.AppendChild(
          feature.ToXml( doc ) );
      }

      return wallXml;
    }

    //-------------------------------------------------------------------------
  }
}
