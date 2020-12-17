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
        }


        EventService es = new EventService();
        private void CheckEvent_Load(object sender, EventArgs e)
        {
            
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
    }
}
