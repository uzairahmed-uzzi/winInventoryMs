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
    }
}
