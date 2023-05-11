using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winInventoryMs
{
    class MainClass
    {
        public static void showWindow(Form openWin,Form closeWin,Form mdiWin  )
        {
            closeWin.Close();
            openWin.MdiParent = mdiWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void showWindow(Form openWin, Form mdiWin)
        { 
            openWin.MdiParent = mdiWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void disable_reset(Panel p)
        {
            foreach(Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox obj = (TextBox)c;
                    obj.Visible = false;
                    obj.Text = "";
                }
                else if (c is ListBox)
                {
                    ListBox obj = (ListBox)c;
                    obj.Visible = false;
                    obj.SelectedIndex =-1;
                }
                else if (c is ComboBox)
                {
                    ComboBox obj = (ComboBox)c;
                    obj.Visible = false;
                    obj.SelectedIndex = -1;
                }
                else if (c is RadioButton)
                {
                    RadioButton obj = (RadioButton)c;
                    obj.Visible = false;
                    obj.Checked = false;
                }
                else if (c is CheckBox)
                {
                    CheckBox obj = (CheckBox)c;
                    obj.Visible = false;
                    obj.Checked = false;
                }
                else if (c is Button)
                {
                    Button obj = (Button)c;
                    obj.Visible = false;
                    
                }
                else if (c is Label)
                {
                    Label obj = (Label)c;
                    obj.Visible = false;

                }
            }
        }
        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox obj = (TextBox)c;
                    obj.Visible = false;
                }
                else if (c is ListBox)
                {
                    ListBox obj = (ListBox)c;
                    obj.Visible = false;
                }
                else if (c is ComboBox)
                {
                    ComboBox obj = (ComboBox)c;
                    obj.Visible = false;
                    
                }
                else if (c is RadioButton)
                {
                    RadioButton obj = (RadioButton)c;
                    obj.Visible = false;
                    
                }
                else if (c is CheckBox)
                {
                    CheckBox obj = (CheckBox)c;
                    obj.Visible = false;
                    
                }
                else if (c is Button)
                {
                    Button obj = (Button)c;
                    obj.Visible = false;

                }
                else if (c is Label)
                {
                    Label obj = (Label)c;
                    obj.Visible = false;

                }
            }
        }
        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox obj = (TextBox)c;
                    obj.Visible = true;
                    obj.Text = "";
                }
                else if (c is ListBox)
                {
                    ListBox obj = (ListBox)c;
                    obj.Visible = true;
                    obj.SelectedIndex = -1;
                }
                else if (c is ComboBox)
                {
                    ComboBox obj = (ComboBox)c;
                    obj.Visible = true;
                    obj.SelectedIndex = -1;
                }
                else if (c is RadioButton)
                {
                    RadioButton obj = (RadioButton)c;
                    obj.Visible = true;
                    obj.Checked = false;
                }
                else if (c is CheckBox)
                {
                    CheckBox obj = (CheckBox)c;
                    obj.Visible = true;
                    obj.Checked = false;
                }
                else if (c is Button)
                {
                    Button obj = (Button)c;
                    obj.Visible = true;

                }
                else if (c is Label)
                {
                    Label obj = (Label)c;
                    obj.Visible = true;

                }
            }
        }
        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox obj = (TextBox)c;
                    obj.Visible = true;
                }
                else if (c is ListBox)
                {
                    ListBox obj = (ListBox)c;
                    obj.Visible = true;
                }
                else if (c is ComboBox)
                {
                    ComboBox obj = (ComboBox)c;
                    obj.Visible = true;

                }
                else if (c is RadioButton)
                {
                    RadioButton obj = (RadioButton)c;
                    obj.Visible = true;

                }
                else if (c is CheckBox)
                {
                    CheckBox obj = (CheckBox)c;
                    obj.Visible = true;

                }
                else if (c is Button)
                {
                    Button obj = (Button)c;
                    obj.Visible = true;

                }
                else if (c is Label)
                {
                    Label obj = (Label)c;
                    obj.Visible = true;

                }
            }
        }

    }
}
