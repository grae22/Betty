using System;
using System.Collections.Generic;
using System.Xml;

namespace Betty
{
  public class FloorPlan
  {
    private List< Wall > m_walls = new List< Wall >();
    private Dictionary< string, List< WallFeature > > m_wallFeatureTypes = new Dictionary< string, List<WallFeature > >();

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
/*
    public void PrioritiseWallSectionType( WallFeature sectionToPrioritise )
    {
      // Iterate through each group.
      foreach( List< WallFeature > groupSections in m_wallSectionTypeGroups.Values )
      {
        // Iterate throught the group's sections.
        // Start at 2nd item since if the section is already the 1st then
        // we can't prioritise it further.
        for( int i = 1; i < groupSections.Count; i++ )
        {
          if( groupSections[ i ] == sectionToPrioritise )
          {
            WallFeature tmp = groupSections[ i - 1 ];
            groupSections[ i - 1 ] = groupSections[ i ];
            groupSections[ i ] = tmp;
          }
        }
      }
    }
*/
    //-------------------------------------------------------------------------
/*
    public void DeprioritiseWallSectionType( WallFeature sectionToPrioritise )
    {
      // Iterate through each group.
      foreach( List< WallFeature > groupSections in m_wallSectionTypeGroups.Values )
      {
        // Iterate throught the group's sections.
        // Stop at 1 before the end since if the section is already the last
        // then we can't deprioritise it further.
        for( int i = 0; i < groupSections.Count - 1; i++ )
        {
          if( groupSections[ i ] == sectionToPrioritise )
          {
            WallFeature tmp = groupSections[ i + 1 ];
            groupSections[ i + 1 ] = groupSections[ i ];
            groupSections[ i ] = tmp;
          }
        }
      }
    }
*/
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
