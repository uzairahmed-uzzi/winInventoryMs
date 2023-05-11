using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winInventoryMs
{
    public partial class Setting : Sample
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void chkIntegrated_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIntegrated.Checked)
            {
                txtUserid.Enabled = false;
                txtPass.Enabled = false;
                txtUserid.Text = "";
                txtPass.Text = "";
            }
            else
            {
                txtUserid.Enabled = true;
                txtPass.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool comp = false;
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            path = Path.Combine(path, "connect");
            
                if (chkIntegrated.Checked)
                {

                    if (txtServer.Text != "" && txtDatabase.Text != "")
                    {

                        s = "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtDatabase.Text.Trim() + ";Integrated Security=true;";
                        File.WriteAllText(path, s);
                        comp = true;
                    }
                    else
                    {
                        MessageBox.Show("CAN'T LEAVE FIELDS EMPTY ");
                    }

                }
                else
                {
                    if (txtServer.Text != "" && txtDatabase.Text != "" && txtUserid.Text != "" && txtPass.Text != "")
                    {
                        s = "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtDatabase.Text.Trim() + ";User ID=;" + txtUserid.Text.Trim() + ";Password=" + txtPass.Text + ";";
                        File.WriteAllText(path, s);
                        comp = true;
                    }
                    else
                    {
                        MessageBox.Show("CAN'T LEAVE FIELDS EMPTY ");
                    }
                }
            
            
             
            if (comp == true)
            {

            
            DialogResult dr = MessageBox.Show("SETTINGS HAS BEEN SAVED SUCCESSFULLY...","INFORMATION......",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                login log = new login();
                MainClass.showWindow(log, this, MDI.ActiveForm);
            }
            }
        }
    }
}
