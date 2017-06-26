using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestSystem
{
    public partial class TestSystemMain : Form
    {
        UsersDataBase userDataBase;
        public TestSystemMain()
        {
            InitializeComponent();
            userDataBase = UsersDataBase.getInstance();
            Forms.LoginForm lf = new Forms.LoginForm();
            this.CenterToScreen();
            lf.ShowDialog(this);


        }

        public void init()
        {
                editTestsToolStripMenuItem.Enabled = userDataBase.currentUserIsAdmin();
                editUsersToolStripMenuItem.Enabled = userDataBase.currentUserIsAdmin();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.LoginForm lf = new Forms.LoginForm();
            lf.ShowDialog(this);

        }

        private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.UserEditor userEditor = new Forms.UserEditor();
            userEditor.ShowDialog();
        }
    }

    
}
