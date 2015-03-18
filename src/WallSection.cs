using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betty
{
  class WallSection
  {
    public enum SectionType
    {
      WALL,
      WINDOW,
      DOOR
    }

    private SectionType m_type = SectionType.WALL;
    private ushort m_length;
    private Shutter m_shutter = null;

    //-------------------------------------------------------------------------

    public SectionType Type
    {
      get
      {
        return m_type;
      }

      set
      {
        m_type = value;
      }
    }

    //-------------------------------------------------------------------------

    public static string TypeName( SectionType type )
    {
      switch( type )
      {
        case SectionType.WALL:
          return "Wall";

        case SectionType.WINDOW:
          return "Window";

        case SectionType.DOOR:
          return "Door";

        default:
          return "Unkown";
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
      string s = TypeName( m_type ) + " ( " + m_length.ToString() + " )";

      if( m_shutter != null )
      {
        s += " [" + m_shutter + "]";
      }

      return s;
    }

    //-------------------------------------------------------------------------

    public Shutter Shutter
    {
      get
      {
        return m_shutter;
      }

      set
      {
        m_shutter = value;
      }
    }

    //-------------------------------------------------------------------------
  }
}
