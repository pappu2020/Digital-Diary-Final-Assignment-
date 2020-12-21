
namespace Digital_Diary
{
    partial class CheckEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckEvent));
            this.Backbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventDataLoadGridView = new System.Windows.Forms.DataGridView();
            this.Modifybutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeleteEventTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataLoadGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(1226, 613);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(141, 44);
            this.Backbutton.TabIndex = 0;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 107);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(750, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 71);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digital Diary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(871, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event List";
            // 
            // eventDataLoadGridView
            // 
            this.eventDataLoadGridView.AllowUserToAddRows = false;
            this.eventDataLoadGridView.AllowUserToDeleteRows = false;
            this.eventDataLoadGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eventDataLoadGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataLoadGridView.Location = new System.Drawing.Point(12, 120);
            this.eventDataLoadGridView.Name = "eventDataLoadGridView";
            this.eventDataLoadGridView.ReadOnly = true;
            this.eventDataLoadGridView.RowHeadersWidth = 51;
            this.eventDataLoadGridView.RowTemplate.Height = 24;
            this.eventDataLoadGridView.Size = new System.Drawing.Size(611, 545);
            this.eventDataLoadGridView.TabIndex = 2;
            this.eventDataLoadGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventDataLoadGridView_CellClick);
            // 
            // Modifybutton
            // 
            this.Modifybutton.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifybutton.Location = new System.Drawing.Point(1062, 256);
            this.Modifybutton.Name = "Modifybutton";
            this.Modifybutton.Size = new System.Drawing.Size(182, 77);
            this.Modifybutton.TabIndex = 3;
            this.Modifybutton.Text = "Modify";
            this.Modifybutton.UseVisualStyleBackColor = true;
            this.Modifybutton.Click += new System.EventHandler(this.Modifybutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(1017, 485);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(194, 66);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "Delete Event";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(629, 600);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 66);
            this.button3.TabIndex = 5;
            this.button3.Text = "Create Event";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteEventTextBox
            // 
            this.DeleteEventTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEventTextBox.Location = new System.Drawing.Point(629, 497);
            this.DeleteEventTextBox.Name = "DeleteEventTextBox";
            this.DeleteEventTextBox.Size = new System.Drawing.Size(348, 42);
            this.DeleteEventTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter the event ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(738, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select the event ID from Data sheet then update";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(636, 169);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 263);
            this.textBox1.TabIndex = 8;
            // 
            // CheckEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 662);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteEventTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Modifybutton);
            this.Controls.Add(this.eventDataLoadGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Backbutton);
            this.Name = "CheckEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckEvent_FormClosing);
            this.Load += new System.EventHandler(this.CheckEvent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataLoadGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView eventDataLoadGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Modifybutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox DeleteEventTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}