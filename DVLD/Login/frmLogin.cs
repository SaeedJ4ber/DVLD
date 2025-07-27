using DVLD.Classes;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user= clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(),txtPassword.Text.Trim());

            if (user != null) 
            { 

                if (chkRememberMe.Checked )
                {
                    //store username and password
                    clsCredentialManager.RememberUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                } 
                  else
                {
                    //store empty username and password
                    clsCredentialManager.RememberUserNameAndPassword("", "");

                }

                //incase the user is not active
                if (!user.IsActive )
                {

                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string sourceName = "DVLD";
                    if (!EventLog.SourceExists(sourceName))
                    {
                        EventLog.CreateEventSource(sourceName, "Application");
                    }

                    EventLog.WriteEntry(sourceName, "Your accound is not Active, Contact Admin.", EventLogEntryType.Error);
                    return;
                }

                clsCredentialManager.CurrentUser = user;
                 this.Hide();
                 frmMain frm = new frmMain(this);
                 frm.ShowDialog();


            } else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsCredentialManager.GetStoredCredentials(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

        }

       
    }
}
