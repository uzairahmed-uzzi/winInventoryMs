using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace winInventoryMs
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            if (File.Exists( path+"\\connect"))
            {
                login lForm = new login();
                MainClass.showWindow(lForm, this);
            }
            else
            {
                Setting setting = new Setting();
                MainClass.showWindow(setting, this);

            }

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
