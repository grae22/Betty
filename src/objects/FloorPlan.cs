using System;
using System.Collections.Generic;

namespace Betty
{
  class FloorPlan
  {
    private List< Wall > m_walls = new List< Wall >();
    private Dictionary< string, List< WallSection > > m_wallSectionGroups = new Dictionary< string, List<WallSection > >();

    //-------------------------------------------------------------------------

    public FloorPlan()
    {
      List< WallSection > list = new List< WallSection >();
      WallSection section = new WallSection();
      section.Group = "Shutter";
      section.Length = 100;
      list.Add( section );
      section = new WallSection();
      section.Group = "Shutter";
      section.Length = 200;
      list.Add( section );
      m_wallSectionGroups.Add( "Shutter", list);

      list.Clear();
      section = new WallSection();
      section.Group = "Door";
      section.Length = 100;
      list.Add( section );
      section = new WallSection();
      section.Group = "Door";
      section.Length = 180;
      list.Add( section );
      m_wallSectionGroups.Add( "Door", list );

      list.Clear();
      section = new WallSection();
      section.Group = "Window";
      section.Length = 100;
      list.Add( section );
      section = new WallSection();
      section.Group = "Window";
      section.Length = 200;
      list.Add( section );
      m_wallSectionGroups.Add( "Window", list );
    }

    //-------------------------------------------------------------------------

    public List< string > WallSectionGroupNames
    {
      get
      {
        List< string > names = new List< string >();
        foreach( string s in m_wallSectionGroups.Keys )
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
      if( m_wallSectionGroups.ContainsKey( name ) )
      {
        return m_wallSectionGroups[ name ];
      }

      return null;
    }

    //-------------------------------------------------------------------------
  }
}
