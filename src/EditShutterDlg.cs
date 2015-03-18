using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betty
{
  public partial class EditShutterDlg : Form
  {
    Shutter m_shutter = new Shutter();

    //-------------------------------------------------------------------------

    public EditShutterDlg()
    {
      InitializeComponent();

      uiName.Text = m_shutter.Name;
      uiWidth.Text = m_shutter.Width.ToString();
      uiHeight.Text = m_shutter.Height.ToString();

      ValidateAndUpdate();
    }

    //-------------------------------------------------------------------------

    private void ValidateAndUpdate()
    {
      try
      {
        // Validate width & height.
        ushort w = Convert.ToUInt16( uiWidth.Text );
        ushort h = Convert.ToUInt16( uiHeight.Text );

        if( w <= 0 || h <= 0 )
        {
          throw new Exception();
        }

        // Update the object.
        m_shutter.Name = uiName.Text;
        m_shutter.Width = Convert.ToUInt16( uiWidth.Text );
        m_shutter.Height = Convert.ToUInt16( uiHeight.Text );

        // Update the description text.
        uiDescription.Text = m_shutter.Description;

        // Enable the OK button.
        uiOk.Enabled = true;
      }
      catch
      {
        uiDescription.Text = "Error";
        uiOk.Enabled = false;
      }
    }

    //-------------------------------------------------------------------------

    private void uiOk_Click( object sender, EventArgs e )
    {
      Hide();
      DialogResult = DialogResult.OK;
    }

    //-------------------------------------------------------------------------

    private void uiWidth_TextChanged( object sender, EventArgs e )
    {
      try
      {
        Convert.ToUInt16( uiWidth.Text );
        uiWidth.BackColor = Color.White;
      }
      catch
      {
        uiWidth.BackColor = Color.Red;
      }

      ValidateAndUpdate();
    }

    //-------------------------------------------------------------------------

    private void uiHeight_TextChanged( object sender, EventArgs e )
    {
      try
      {
        Convert.ToUInt16( uiHeight.Text );
        uiHeight.BackColor = Color.White;
      }
      catch
      {
        uiHeight.BackColor = Color.Red;
      }

      ValidateAndUpdate();
    }

    //-------------------------------------------------------------------------

    private void uiName_TextChanged( object sender, EventArgs e )
    {
      ValidateAndUpdate();
    }

    //-------------------------------------------------------------------------

    private void uiWidth_Enter( object sender, EventArgs e )
    {
      uiWidth.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiHeight_Enter( object sender, EventArgs e )
    {
      uiHeight.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiName_Enter( object sender, EventArgs e )
    {
      uiName.SelectAll();
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
