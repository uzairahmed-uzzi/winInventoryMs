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
    public partial class User : Sample2
    {
        public User()
        {
            InitializeComponent();
        }

        private void leftTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);

        }
    }
}
