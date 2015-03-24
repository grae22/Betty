using System;
using System.Collections.Generic;

namespace Betty
{
  class FloorPlan
  {
    private List< Wall > m_walls = new List< Wall >();
    private Dictionary< string, List< WallSection > > m_wallSectionGroups = new Dictionary< string, List<WallSection > >();

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
