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
    public partial class CheckEvent : Form
    {
       
        public CheckEvent()
        {
            
            InitializeComponent();
            Deletebutton.Click += this.RefreshGridView;
        }


        

        private void CheckEvent_Load(object sender, EventArgs e)
        {
            EventService es = new EventService();
            eventDataLoadGridView.DataSource = es.GetDataList();
        }

        private void RefreshGridView(object sender, EventArgs e)
        {
            EventService es = new EventService();
            eventDataLoadGridView.DataSource = es.GetDataList();
        }

        private void CheckEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            EventService es = new EventService();
            int result = es.DeleteEvents(Convert.ToInt32(DeleteEventTextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("Category deleted successfully");
                DeleteEventTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error in deleting category");
            }
        }
    }
}
