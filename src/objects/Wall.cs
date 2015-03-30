using System;
using System.Collections.Generic;
using System.Xml;

namespace Betty
{
  public class Wall
  {
    private string m_name = "Unknown";
    private ushort m_length;
    private bool m_isExternalWall;
    private List< WallFeature > m_features = new List< WallFeature >();

    //-------------------------------------------------------------------------

    public static Wall CreateFromXml( XmlElement xml )
    {
      try
      {
        // Wall properties.
        XmlElement nameXml = xml.SelectSingleNode( "Name" ) as XmlElement;
        XmlElement lengthXml = xml.SelectSingleNode( "Length" ) as XmlElement;
        XmlElement externalWallXml = xml.SelectSingleNode( "ExternalWall" ) as XmlElement;

        // Features.
        XmlElement featureCollectionXml = xml.SelectSingleNode( "FeatureCollection" ) as XmlElement;
        XmlNodeList featuresXml = featureCollectionXml.SelectNodes( "WallFeature" );

        List<WallFeature> features = new List<WallFeature>();

        foreach( XmlElement featureXml in featuresXml )
        {
          features.Add( WallFeature.CreateFromXml( featureXml ) );
        }

        // Create the wall.
        Wall wall = new Wall( nameXml.InnerText );
        wall.Length = Convert.ToUInt16( lengthXml.InnerText );
        wall.IsExternalWall = bool.Parse( externalWallXml.InnerText );
        wall.Features = features;

        return wall;
      }
      catch
      {
        return null;
      }
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

    public bool IsExternalWall
    {
      get
      {
        return m_isExternalWall;
      }

      set
      {
        m_isExternalWall = value;
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

      XmlElement lengthXml = doc.CreateElement( "Length" );
      wallXml.AppendChild( lengthXml );
      lengthXml.InnerText = m_length.ToString();

      XmlElement externalWallXml = doc.CreateElement( "ExternalWall" );
      wallXml.AppendChild( externalWallXml );
      externalWallXml.InnerText = m_isExternalWall.ToString();

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
