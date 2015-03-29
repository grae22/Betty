using System;
using System.Collections.Generic;
using System.Xml;
using System.Diagnostics;

namespace Betty
{
  public class FloorPlan
  {
    private List< Wall > m_walls = new List< Wall >();
    private Dictionary< string, List< WallFeature > > m_wallFeatureTypes = new Dictionary< string, List<WallFeature > >();
    private List< Shutter > m_shutterTypes = new List< Shutter >();

    //-------------------------------------------------------------------------

    public FloorPlan()
    {
      
    }

    //-------------------------------------------------------------------------

    public List< string > WallFeatureTypeNames
    {
      get
      {
        List< string > names = new List< string >();
        foreach( string s in m_wallFeatureTypes.Keys )
        {
          names.Add( s );
        }
        return names;
      }
    }

    //-------------------------------------------------------------------------

    public List< WallFeature > WallFeatureTypes
    {
      get
      {
        List< WallFeature > list = new List< WallFeature >();
        foreach( List< WallFeature > features in m_wallFeatureTypes.Values )
        {
          foreach( WallFeature f in features )
          {
            list.Add( f );
          }
        }
        return list;
      }
    }

    //-------------------------------------------------------------------------

    // Returns null if type not found.

    public List< WallFeature > GetFeaturesForType( string name )
    {
      if( m_wallFeatureTypes.ContainsKey( name ) )
      {
        return m_wallFeatureTypes[ name ];
      }

      return null;
    }

    //-------------------------------------------------------------------------

    public WallFeature GetFeatureFromDescription( string description )
    {
      // Iterate through each type.
      foreach( List< WallFeature > typeFeatures in m_wallFeatureTypes.Values )
      {
        // Iterate throught the type's features.
        foreach( WallFeature feature in typeFeatures )
        {
          if( feature.ToString() == description )
          {
            return feature;
          }
        }
      }

      return null;
    }

    //-------------------------------------------------------------------------

    public bool AddWallFeatureType( WallFeature featureType )
    {
      // Already exists?
      if( GetFeatureFromDescription( featureType.ToString() ) != null )
      {
        return false;
      }

      // Type exists already?
      if( m_wallFeatureTypes.ContainsKey( featureType.Type ) )
      {
        m_wallFeatureTypes[ featureType.Type ].Add( featureType );
      }
      else  // Type doesn't exist, add it.
      {
        List< WallFeature > list = new List< WallFeature >();
        list.Add( featureType );
        m_wallFeatureTypes.Add( featureType.Type, list );
      }

      return true;
    }

    //-------------------------------------------------------------------------

    public bool RemoveWallFeatureType( WallFeature featureTypeToRemove )
    {
      // Iterate through each type.
      foreach( List< WallFeature > typeFeatures in m_wallFeatureTypes.Values )
      {
        // Iterate throught the type's features.
        foreach( WallFeature feature in typeFeatures )
        {
          if( feature == featureTypeToRemove )
          {
            typeFeatures.Remove( featureTypeToRemove );

            // Type is now empty? Remove it from the map.
            if( typeFeatures.Count == 0 )
            {
              m_wallFeatureTypes.Remove( featureTypeToRemove.Type );
            }

            return true;
          }
        }
      }

      return false;
    }

    //-------------------------------------------------------------------------

    public void AddWall( Wall wall )
    {
      // Null?
      if( wall == null )
      {
        Debug.Assert( false );
        return;
      }
      
      // No name?
      wall.Name = wall.Name.Trim();

      if( wall.Name.Length == 0 )
      {
        throw new Exception( "Wall must have a name." );
      }

      // Already have a wall with this wall's name?
      if( GetWall( wall.Name ) != null )
      {
        throw new Exception( "Wall already exists with name '" + wall.Name + "'." );
      }

      // All is good, add it.
      m_walls.Add( wall );
    }

    //-------------------------------------------------------------------------

    public Wall GetWall( string name )
    {
      foreach( Wall wall in m_walls )
      {
        if( wall.Name == name )
        {
          return wall;
        }
      }

      return null;
    }

    //-------------------------------------------------------------------------

    public List< Wall > Walls
    {
      get
      {
        return m_walls;
      }
    }

    //-------------------------------------------------------------------------

    public List< Shutter > ShutterTypes
    {
      get
      {
        return m_shutterTypes;
      }

      set
      {
        m_shutterTypes = value;
      }
    }

    //-------------------------------------------------------------------------

    public XmlElement ToXml( XmlDocument doc )
    {
      //-- Floor plan element.
      XmlElement floorPlan = doc.CreateElement( "FloorPlan" );

      //-- Wall feature types.
      XmlElement wallFeatureTypeCollection = doc.CreateElement( "WallFeatureTypeCollection" );
      floorPlan.AppendChild( wallFeatureTypeCollection );
      
      foreach( List< WallFeature > typeFeatures in m_wallFeatureTypes.Values )
      {
        foreach( WallFeature feature in typeFeatures )
        {
          wallFeatureTypeCollection.AppendChild( feature.ToXml( doc ) );
        }
      }

      //-- Shutter types.
      XmlElement shutterTypeCollection = doc.CreateElement( "ShutterTypeCollection" );
      floorPlan.AppendChild( shutterTypeCollection );

      foreach( Shutter shutter in m_shutterTypes )
      {
        shutterTypeCollection.AppendChild( shutter.ToXml( doc ) );
      }

      return floorPlan;
    }

    //-------------------------------------------------------------------------

    public static FloorPlan CreateFromXml( XmlElement floorPlanXml )
    {
      FloorPlan newFloorPlan = new FloorPlan();

      //-- Wall feature types.
      XmlElement wallFeatureTypeCollection =
        floorPlanXml.SelectSingleNode( "./WallFeatureTypeCollection" ) as XmlElement;

      XmlNodeList wallFeatures = wallFeatureTypeCollection.SelectNodes( "./WallFeature" );

      foreach( XmlElement featureXml in wallFeatureTypeCollection )
      {
        WallFeature newFeature = WallFeature.CreateFromXml( featureXml );

        if( newFeature != null )
        {
          newFloorPlan.AddWallFeatureType( newFeature );
        }
      }

      return newFloorPlan;
    }

    //-------------------------------------------------------------------------

    public void WriteToFile()
    {
      XmlDocument doc = new XmlDocument();
      doc.AppendChild( ToXml( doc ) );
      doc.Save( "Test.floorplan" );
    }

    //-------------------------------------------------------------------------
  }
}
