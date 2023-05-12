using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winInventoryMs
{
    public partial class frmUser : Sample3
    {
        
        int edit = 0;//this zero is an indication of that the operation is add
        public frmUser()
        {
            InitializeComponent();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }
        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") { lblNameError.Visible = true; } else { lblNameError.Visible = false; }
            if ( txtUserName.Text=="") { lblUserNameError.Visible = true; } else { lblUserNameError.Visible = false; }
            if (txtEmail.Text == "") { lblEmailError.Visible = true; } else { lblEmailError.Visible = false; }
            if (txtPass.Text == "") { lblPassError.Visible = true; } else { lblPassError.Visible = false; }
            if (txtPhone.Text == "") { lblPhoneError.Visible = true; } else { lblPhoneError.Visible = false; }

            if (lblNameError.Visible || lblUserNameError.Visible || lblEmailError.Visible || lblPassError.Visible || lblPhoneError.Visible)
            {
                MainClass.showMsg("Fields with * are mandatory","FIELDS EMPTY ERROR","error");
            }
            else
            {
                if (edit == 0)//code for insertion
                {
                    Insertion inst = new Insertion(txtName.Text, txtUserName.Text, txtPass.Text, txtPhone.Text, txtEmail.Text, 1);
                }
                else if(edit==1) //code for updation
                {
                  //  Updation inst = new Updation(txtName.Text, txtUserName.Text, txtPass.Text, txtPhone.Text, txtEmail.Text, 1,Convert.ToInt16(txtUserId.Text));
                }
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeScreen hms=new HomeScreen();
            MainClass.showWindow(hms,this,MDI.ActiveForm);
        }

        
    }
}
