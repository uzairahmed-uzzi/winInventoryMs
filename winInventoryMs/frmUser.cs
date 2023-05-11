using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winInventoryMs
{
    public partial class frmUser : Sample3
    {
        public frmUser()
        {
            InitializeComponent();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);

        }
        public override void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {

        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public override void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
