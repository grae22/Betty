using System;
using System.Collections.Generic;

namespace Betty
{
  public class WallSection
  {
    private string m_group = "Unknown";
    private ushort m_length;        // mm
    private ushort m_height;        // mm

    //-------------------------------------------------------------------------

    public WallSection( string group,
                        ushort length,
                        ushort height )
    {
      m_group = group;
      m_length = length;
      m_height = height;
    }

    //-------------------------------------------------------------------------

    public string Group
    {
      get
      {
        return m_group;
      }

      set
      {
        m_group = value;
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

    public ushort Height
    {
      get
      {
        return m_height;
      }

      set
      {
        m_height = value;
      }
    }

    //-------------------------------------------------------------------------

    // Returns a string of the value in the units we are using for displayed
    // values.

    public string LengthForDisplay
    {
      get
      {
        return Program.UnitConvertForDisplay( m_length ).ToString();
      }
    }

    //-------------------------------------------------------------------------

    // Returns a string of the value in the units we are using for displayed
    // values.

    public string HeightForDisplay
    {
      get
      {
        return Program.UnitConvertForDisplay( m_height ).ToString();
      }
    }

    //-------------------------------------------------------------------------

    public override string ToString()
    {
      // Length & height (if any).
      string s = m_group + " [ " + LengthForDisplay;

      if( m_height > 0 )
      {
        s += " x " + HeightForDisplay;
      }

      s += " ]";

      return s;
    }

    //-------------------------------------------------------------------------
  }
}
