using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
           
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserService user = new UserService();
            int result = user.AddNewUser(NameTextBox.Text,UserNametextBox.Text,PasswordtextBox.Text, EmailtextBox.Text,dateTimePicker1.Text,comboBox1.Text);
            if (result > 0)
            {
                MessageBox.Show("Registration successfully");
                NameTextBox.Text = UserNametextBox.Text = PasswordtextBox.Text =ConfirmPasswordtextBox.Text= EmailtextBox.Text = dateTimePicker1.Text = comboBox1.Text = string.Empty;


            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        
    }
}
