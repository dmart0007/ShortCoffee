using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCoffee
{
    public partial class AddUserMenu : Form
    {
        public AddUserMenu()
        {
            InitializeComponent();
        }

        private void EnterUserID_BOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersMenu ss = new ManageUsersMenu();
            ss.Show();
        }
    }
}
