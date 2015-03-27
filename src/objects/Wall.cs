using System;
using System.Collections.Generic;

namespace Betty
{
  public class Wall
  {
    private string m_name = "Unknown";
    private ushort m_length;
    private List< WallFeature > m_features = new List< WallFeature >();

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

    public List< WallFeature > Features
    {
      get
      {
        return m_features;
      }

      set
      {
        m_features = value;
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
      return m_name;
    }

    //-------------------------------------------------------------------------
  }
}
