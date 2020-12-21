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
    public partial class Home : Form
    {
        
       
        public Home()
        {
            InitializeComponent();
            
        
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        

        private void Addbutton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            
            
            int result = eventService.AddnewEntities(dateTimePicker1.Text, EventNametextBox.Text, DescriptiontextBox.Text, comboBox1.Text);
            if (result > 0)
            {
                MessageBox.Show("New Event added successfully");
                dateTimePicker1.Text = EventNametextBox.Text = DescriptiontextBox.Text = comboBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error in adding new Event");
            }


        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void showEventbutton_Click(object sender, EventArgs e)
        {
            CheckEvent ce = new CheckEvent();
            ce.Show();
            this.Hide();
        }
    }
}
