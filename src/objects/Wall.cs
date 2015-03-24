using System;
using System.Collections.Generic;

namespace Betty
{
  class Wall
  {
    private List< WallSection > m_sections = new List< WallSection >();

    //-------------------------------------------------------------------------

    public List< WallSection > Sections
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

        foreach( WallSection section in m_sections )
        {
          length += section.Length;
        }

        return length;
      }
    }

    //-------------------------------------------------------------------------
  }
}
