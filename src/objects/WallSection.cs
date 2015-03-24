using System;
using System.Collections.Generic;

namespace Betty
{
  class WallSection
  {
    private string m_group;
    private ushort m_length;        // mm
    private ushort m_height;        // mm
    private string m_description;

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
        return Program.UnitConvert( m_length ).ToString();
      }
    }

    //-------------------------------------------------------------------------

    // Returns a string of the value in the units we are using for displayed
    // values.

    public string HeightForDisplay
    {
      get
      {
        return Program.UnitConvert( m_height ).ToString();
      }
    }

    //-------------------------------------------------------------------------

    public string Description
    {
      get
      {
        return m_description;
      }

      set
      {
        m_description = value;
      }
    }

    //-------------------------------------------------------------------------

    public override string ToString()
    {
      // Length & height (if any).
      string s = m_group + " (" + LengthForDisplay;

      if( m_height > 0 )
      {
        s += " x " + m_height.ToString();
      }

      s += ")";

      // Description.
      if( m_description.Length > 0 )
      {
        s += ' ' + m_description;
      }

      return s;
    }

    //-------------------------------------------------------------------------
  }
}
