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
  public partial class MainForm : Form
  {
    private ushort m_wallTotalLength;
    private Wall m_wall = new Wall();
    private WallSection m_section = new WallSection();

    //-------------------------------------------------------------------------

    public MainForm()
    {
      InitializeComponent();

      uiSectionType.Text = uiSectionType.Items[ 0 ] as string;
      uiAddWallSection.Enabled = false;
    }

    //-------------------------------------------------------------------------

    private void uiAddShutter_Click( object sender, EventArgs e )
    {
      EditShutterDlg dlg = new EditShutterDlg();
      DialogResult result = dlg.ShowDialog( this );
      Shutter newShutter = dlg.Shutter;
      dlg.Dispose();
      dlg = null;

      if( result == DialogResult.OK )
      {
        // Already in list?
        foreach( Shutter shutter in uiShutters.Items )
        {
          if( shutter.Description == newShutter.Description )
          {
            return;
          }
        }

        // Add it.
        uiShutters.Items.Add( newShutter );

        // Update all the windows.
        UpdateWindowsWithShutters();
      }
    }

    //-------------------------------------------------------------------------

    private void uiRemoveShutter_Click( object sender, EventArgs e )
    {
      if( uiShutters.SelectedItem == null )
      {
        return;
      }

      Shutter toRemove = uiShutters.SelectedItem as Shutter;

      if( MessageBox.Show( "Remove '" + toRemove.Description + "'?",
                           "Sure?",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question ) == System.Windows.Forms.DialogResult.No )
      {
        return;
      }

      uiShutters.Items.Remove( toRemove );

      // Update all the windows.
      UpdateWindowsWithShutters();
    }

    //-------------------------------------------------------------------------

    private void uiRaiseShutterPriority_Click( object sender, EventArgs e )
    {
      if( uiShutters.SelectedItem == null ||
          uiShutters.SelectedIndex == 0 )
      {
        return;
      }

      int index = uiShutters.SelectedIndex;
      Shutter shutter = uiShutters.SelectedItem as Shutter;

      uiShutters.Items.Remove( shutter );
      uiShutters.Items.Insert( index - 1, shutter );
      uiShutters.SelectedItem = shutter;

      // Update all the windows.
      UpdateWindowsWithShutters();
    }

    //-------------------------------------------------------------------------

    private void uiLowerShutterPriority_Click( object sender, EventArgs e )
    {
      if( uiShutters.SelectedItem == null ||
          uiShutters.SelectedIndex == uiShutters.Items.Count - 1 )
      {
        return;
      }

      int index = uiShutters.SelectedIndex;
      Shutter shutter = uiShutters.SelectedItem as Shutter;

      uiShutters.Items.Remove( shutter );
      uiShutters.Items.Insert( index + 1, shutter );
      uiShutters.SelectedItem = shutter;

      // Update all the windows.
      UpdateWindowsWithShutters();
    }

    //-------------------------------------------------------------------------

    private void uiAddWallSection_Click( object sender, EventArgs e )
    {
      m_wall.Sections.Add( m_section );
      uiWallSections.Items.Add( m_section );

      m_section = new WallSection();

      uiWallSectionLength.Text = "";
      uiWallSectionLength.Focus();
      uiAddWallSection.Enabled = false;

      if( m_wallTotalLength > 0 )
      {
        int remainingLength = ( (int)m_wallTotalLength - (int)m_wall.Length );
        uiWallRemainingLength.Text = ( (int)m_wallTotalLength - (int)m_wall.Length ).ToString();
        if( remainingLength < 0 )
        {
          uiWallRemainingLength.BackColor = ( remainingLength < 0 ? Color.Red : Color.White );
        }
      }
      else
      {
        uiWallRemainingLength.Text = "";
      }
    }

    //-------------------------------------------------------------------------

    private void uiWallTotalLength_TextChanged( object sender, EventArgs e )
    {
      try
      {
        m_wallTotalLength = Convert.ToUInt16( uiWallTotalLength.Text );

        uiWallTotalLength.BackColor = Color.White;
      }
      catch
      {
        m_wallTotalLength = 0;

        uiWallTotalLength.BackColor = Color.Red;
      }
    }

    //-------------------------------------------------------------------------

    private void uiSectionType_TextChanged( object sender, EventArgs e )
    {
      switch( uiSectionType.Text )
      {
        case "Wall":
          m_section.Type = WallSection.SectionType.WALL;
          break;

        case "Window":
          m_section.Type = WallSection.SectionType.WINDOW;
          break;

        case "Door":
          m_section.Type = WallSection.SectionType.DOOR;
          break;
      }
    }

    //-------------------------------------------------------------------------

    private void uiWallSectionLength_Enter( object sender, EventArgs e )
    {
      uiWallSectionLength.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiWallSectionLength_TextChanged( object sender, EventArgs e )
    {
      if( uiWallSectionLength.Text == "" )
      {
        uiWallSectionLength.BackColor = Color.White;
        uiAddWallSection.Enabled = false;
        return;
      }

      try
      {
        m_section.Length = Convert.ToUInt16( uiWallSectionLength.Text );

        if( m_section.Length == 0 )
        {
          throw new Exception();
        }

        uiWallSectionLength.BackColor = Color.White;

        uiAddWallSection.Enabled = true;
      }
      catch
      {
        uiWallSectionLength.BackColor = Color.Red;

        uiAddWallSection.Enabled = false;
      }
    }

    //-------------------------------------------------------------------------

    private void uiWallSectionLength_KeyDown( object sender, KeyEventArgs e )
    {
      if( e.KeyCode == Keys.Enter )
      {
        uiAddWallSection_Click( null, null );
      }
      else if( e.KeyCode == Keys.Up )
      {
        if( uiSectionType.SelectedIndex > 0 )
        {
          uiSectionType.SelectedIndex--;
        }
      }
      else if( e.KeyCode == Keys.Down )
      {
        if( uiSectionType.SelectedIndex < uiSectionType.Items.Count - 1 )
        {
          uiSectionType.SelectedIndex++;
        }
      }
    }

    //-------------------------------------------------------------------------

    private void UpdateWindowsWithShutters()
    {
      foreach( WallSection section in m_wall.Sections )
      {
        if( section.Type != WallSection.SectionType.WINDOW )
        {
          continue;
        }

        section.Shutter = null;

        foreach( Shutter shutter in uiShutters.Items )
        {
          if( shutter.Width < section.Length )
          {
            section.Shutter = shutter;
            break;
          }
        }
      }

      // Refresh the items in the list.
      for( int i = 0; i < uiWallSections.Items.Count; i++ )
      {
        uiWallSections.Items[ i ] = uiWallSections.Items[ i ];
      }
    }

    //-------------------------------------------------------------------------
  }
}
