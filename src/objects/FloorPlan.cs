using System;
using System.Collections.Generic;
using System.Xml;

namespace Betty
{
  public class FloorPlan
  {
    private List< Wall > m_walls = new List< Wall >();
    private Dictionary< string, List< WallSection > > m_wallSectionTypeGroups = new Dictionary< string, List<WallSection > >();

    //-------------------------------------------------------------------------

    public FloorPlan()
    {
      //List< WallSection > list = new List< WallSection >();
      //WallSection section = new WallSection( "Shutter", 1000, 1000 );
      //list.Add( section );
      //section = new WallSection( "Shutter", 2000, 1000 );
      //list.Add( section );
      //m_wallSectionTypeGroups.Add( "Shutter", list );

      //list = new List<WallSection>();
      //section = new WallSection( "Door", 800, 1000 );
      //list.Add( section );
      //section = new WallSection( "Door", 1200, 1000 );
      //list.Add( section );
      //m_wallSectionTypeGroups.Add( "Door", list );

      //list = new List<WallSection>();
      //section = new WallSection( "Window", 2000, 500 );
      //list.Add( section );
      //m_wallSectionTypeGroups.Add( "Window", list );
    }

    //-------------------------------------------------------------------------

    public List< string > WallSectionGroupNames
    {
      get
      {
        List< string > names = new List< string >();
        foreach( string s in m_wallSectionTypeGroups.Keys )
        {
          names.Add( s );
        }
        return names;
      }
    }

    //-------------------------------------------------------------------------

    // Returns null if group not found.

    public List< WallSection > GetSectionsForGroup( string name )
    {
      if( m_wallSectionTypeGroups.ContainsKey( name ) )
      {
        return m_wallSectionTypeGroups[ name ];
      }

      return null;
    }

    //-------------------------------------------------------------------------

    public WallSection GetSectionFromDescription( string description )
    {
      // Iterate through each group.
      foreach( List< WallSection > groupSections in m_wallSectionTypeGroups.Values )
      {
        // Iterate throught the group's sections.
        foreach( WallSection section in groupSections )
        {
          if( section.ToString() == description )
          {
            return section;
          }
        }
      }

      return null;
    }

    //-------------------------------------------------------------------------

    public bool AddWallSectionType( WallSection sectionType )
    {
      // Already exists?
      if( GetSectionFromDescription( sectionType.ToString() ) != null )
      {
        return false;
      }

      // Group exists already?
      if( m_wallSectionTypeGroups.ContainsKey( sectionType.Group ) )
      {
        m_wallSectionTypeGroups[ sectionType.Group ].Add( sectionType );
      }
      else  // Group doesn't exist, add it.
      {
        List< WallSection > list = new List< WallSection >();
        list.Add( sectionType );
        m_wallSectionTypeGroups.Add( sectionType.Group, list );
      }

      return true;
    }

    //-------------------------------------------------------------------------

    public bool RemoveWallSectionType( WallSection sectionTypeToRemove )
    {
      // Iterate through each group.
      foreach( List< WallSection > groupSections in m_wallSectionTypeGroups.Values )
      {
        // Iterate throught the group's sections.
        foreach( WallSection section in groupSections )
        {
          if( section == sectionTypeToRemove )
          {
            groupSections.Remove( sectionTypeToRemove );

            // Group is now empty? Remove it from the map.
            if( groupSections.Count == 0 )
            {
              m_wallSectionTypeGroups.Remove( sectionTypeToRemove.Group );
            }

            return true;
          }
        }
      }

      return false;
    }

    //-------------------------------------------------------------------------

    public void PrioritiseWallSectionType( WallSection sectionToPrioritise )
    {
      // Iterate through each group.
      foreach( List< WallSection > groupSections in m_wallSectionTypeGroups.Values )
      {
        // Iterate throught the group's sections.
        // Start at 2nd item since if the section is already the 1st then
        // we can't prioritise it further.
        for( int i = 1; i < groupSections.Count; i++ )
        {
          if( groupSections[ i ] == sectionToPrioritise )
          {
            WallSection tmp = groupSections[ i - 1 ];
            groupSections[ i - 1 ] = groupSections[ i ];
            groupSections[ i ] = tmp;
          }
        }
      }
    }

    //-------------------------------------------------------------------------

    public void DeprioritiseWallSectionType( WallSection sectionToPrioritise )
    {
      // Iterate through each group.
      foreach( List< WallSection > groupSections in m_wallSectionTypeGroups.Values )
      {
        // Iterate throught the group's sections.
        // Stop at 1 before the end since if the section is already the last
        // then we can't deprioritise it further.
        for( int i = 0; i < groupSections.Count - 1; i++ )
        {
          if( groupSections[ i ] == sectionToPrioritise )
          {
            WallSection tmp = groupSections[ i + 1 ];
            groupSections[ i + 1 ] = groupSections[ i ];
            groupSections[ i ] = tmp;
          }
        }
      }
    }

    //-------------------------------------------------------------------------

    public XmlElement ToXml( XmlDocument doc )
    {
      //-- Floor plan element.
      XmlElement floorPlan = doc.CreateElement( "FloorPlan" );

      //-- Wall section types.
      XmlElement wallSectionTypeCollection = doc.CreateElement( "WallSectionTypeCollection" );
      floorPlan.AppendChild( wallSectionTypeCollection );
      
      foreach( List< WallSection > groupSections in m_wallSectionTypeGroups.Values )
      {
        foreach( WallSection section in groupSections )
        {
          wallSectionTypeCollection.AppendChild( section.ToXml( doc ) );
        }
      }

      return floorPlan;
    }

    //-------------------------------------------------------------------------

    public static FloorPlan CreateFromXml( XmlElement floorPlanXml )
    {
      FloorPlan newFloorPlan = new FloorPlan();

      //-- Wall section types.
      XmlElement wallSectionTypeCollection =
        floorPlanXml.SelectSingleNode( "./WallSectionTypeCollection" ) as XmlElement;

      XmlNodeList wallSections = wallSectionTypeCollection.SelectNodes( "./WallSection" );

      foreach( XmlElement sectionXml in wallSectionTypeCollection )
      {
        WallSection newSection = WallSection.CreateFromXml( sectionXml );

        if( newSection != null )
        {
          newFloorPlan.AddWallSectionType( newSection );
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
