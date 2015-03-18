using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betty
{
  //---------------------------------------------------------------------------

  public class Shutter
  {
    private string m_name = "Shutter";
    private ushort m_width = 0;
    private ushort m_height = 0;

    //-------------------------------------------------------------------------

    public Shutter()
    {

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

    public ushort Width
    {
      get
      {
        return m_width;
      }

      set
      {
        m_width = value;
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

    public string Description
    {
      get
      {
        return m_name + " ( " + m_width.ToString() + " x " + m_height.ToString() + " )";
      }
    }

    //-------------------------------------------------------------------------

    public override string ToString()
    {
      return Description;
    }

    //-------------------------------------------------------------------------
  }

  //---------------------------------------------------------------------------
}
