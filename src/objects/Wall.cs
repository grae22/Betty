using System;
using System.Collections.Generic;

namespace Betty
{
  class Wall
  {
    private List< WallFeature > m_sections = new List< WallFeature >();

    //-------------------------------------------------------------------------

    public List< WallFeature > Sections
    {
      get
      {
        return m_sections;
      }

      set
      {
        m_sections = value;
      }
    }

    //-------------------------------------------------------------------------

    public ushort Length
    {
      get
      {
        ushort length = 0;

        foreach( WallFeature section in m_sections )
        {
          length += section.Length;
        }

        return length;
      }
    }

    //-------------------------------------------------------------------------
  }
}
