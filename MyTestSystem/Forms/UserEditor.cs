using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestSystem.Forms
{
    public partial class UserEditor : Form
    {
        UsersDataBase userDatabase;

        public UserEditor()
        {
            InitializeComponent();
            this.CenterToScreen();
            userDatabase = UsersDataBase.getInstance();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (userDatabase.addNewUser(nickTbx.Text, loginTbx.Text, passwordTbx.Text))
            {
                userListBox.Items.Add(nickTbx.Text);
            }
            else
            {
                MessageBox.Show("Failed to create new user. User with same nick or login exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkIfFieldsAreEmpty() {
            if (nickTbx.Text == "" || loginTbx.Text == "" || passwordTbx.Text == "") {
                addBtn.Enabled = false;
                return true;
            }
                addBtn.Enabled = true;
            return false;
        }

        private void nickTbx_TextChanged(object sender, EventArgs e)
        {
            checkIfFieldsAreEmpty();
        }
    }
}
