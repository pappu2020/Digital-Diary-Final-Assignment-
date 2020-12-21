using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Digital_Diary
{
    public partial class LogIn : Form
    {

       
        public LogIn()
        {
            InitializeComponent();
            
            
        }

        public TextBox UserNameText
        {
            get { return this.UserNametextBox; }
        }




        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRegistration ur = new UserRegistration();
            ur.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNametextBox.Text == "" || UserPasswordtextBox.Text == "")
            {
                MessageBox.Show("Username or Password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LoginValidation(UserNametextBox.Text, UserPasswordtextBox.Text);
                if (result)
                {
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
    }
}
