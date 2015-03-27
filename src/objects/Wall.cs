using System;
using System.Collections.Generic;

namespace Betty
{
  public class Wall
  {
    private string m_name = "Unknown";
    private List< WallFeature > m_sections = new List< WallFeature >();

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

    public override string ToString()
    {
      return m_name;
    }

    //-------------------------------------------------------------------------
  }
}
