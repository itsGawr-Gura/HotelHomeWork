namespace Hotel
{
    partial class HotelForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbRessserved = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDischarged1 = new System.Windows.Forms.CheckBox();
            this.cbReserved1 = new System.Windows.Forms.CheckBox();
            this.cbBusy1 = new System.Windows.Forms.CheckBox();
            this.cbEmpty1 = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.gwInfo1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Photo1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btCardView1 = new System.Windows.Forms.Button();
            this.tbSearch1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbStatus1 = new System.Windows.Forms.ComboBox();
            this.tbFullName1 = new System.Windows.Forms.TextBox();
            this.tbInDate1 = new System.Windows.Forms.TextBox();
            this.tbOutDate1 = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwInfo1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbRessserved);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cbDischarged1);
            this.panel4.Controls.Add(this.cbReserved1);
            this.panel4.Controls.Add(this.cbBusy1);
            this.panel4.Controls.Add(this.cbEmpty1);
            this.panel4.Location = new System.Drawing.Point(-4, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 797);
            this.panel4.TabIndex = 0;
            // 
            // cbRessserved
            // 
            this.cbRessserved.AutoSize = true;
            this.cbRessserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRessserved.Location = new System.Drawing.Point(3, 126);
            this.cbRessserved.Name = "cbRessserved";
            this.cbRessserved.Size = new System.Drawing.Size(306, 41);
            this.cbRessserved.TabIndex = 5;
            this.cbRessserved.Text = "Зарезервировано";
            this.cbRessserved.UseVisualStyleBackColor = true;
            this.cbRessserved.CheckedChanged += new System.EventHandler(this.cbRessserved_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(57, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 53);
            this.label8.TabIndex = 4;
            this.label8.Text = "Статус";
            // 
            // cbDischarged1
            // 
            this.cbDischarged1.AutoSize = true;
            this.cbDischarged1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDischarged1.Location = new System.Drawing.Point(3, 310);
            this.cbDischarged1.Name = "cbDischarged1";
            this.cbDischarged1.Size = new System.Drawing.Size(253, 41);
            this.cbDischarged1.TabIndex = 3;
            this.cbDischarged1.Text = "Выписываются";
            this.cbDischarged1.UseVisualStyleBackColor = true;
            this.cbDischarged1.CheckedChanged += new System.EventHandler(this.cbDischarged1_CheckedChanged);
            // 
            // cbReserved1
            // 
            this.cbReserved1.AutoSize = true;
            this.cbReserved1.Checked = true;
            this.cbReserved1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReserved1.Enabled = false;
            this.cbReserved1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbReserved1.Location = new System.Drawing.Point(3, 126);
            this.cbReserved1.Name = "cbReserved1";
            this.cbReserved1.Size = new System.Drawing.Size(306, 41);
            this.cbReserved1.TabIndex = 0;
            this.cbReserved1.Text = "Зарезервировано";
            this.cbReserved1.UseVisualStyleBackColor = true;
            this.cbReserved1.Visible = false;
            this.cbReserved1.CheckedChanged += new System.EventHandler(this.cbReserved1_CheckedChanged);
            // 
            // cbBusy1
            // 
            this.cbBusy1.AutoSize = true;
            this.cbBusy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBusy1.Location = new System.Drawing.Point(3, 247);
            this.cbBusy1.Name = "cbBusy1";
            this.cbBusy1.Size = new System.Drawing.Size(152, 41);
            this.cbBusy1.TabIndex = 2;
            this.cbBusy1.Text = "Заняты";
            this.cbBusy1.UseVisualStyleBackColor = true;
            this.cbBusy1.CheckedChanged += new System.EventHandler(this.cbBusy1_CheckedChanged);
            // 
            // cbEmpty1
            // 
            this.cbEmpty1.AutoSize = true;
            this.cbEmpty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEmpty1.Location = new System.Drawing.Point(3, 185);
            this.cbEmpty1.Name = "cbEmpty1";
            this.cbEmpty1.Size = new System.Drawing.Size(207, 41);
            this.cbEmpty1.TabIndex = 1;
            this.cbEmpty1.Text = "Свободные";
            this.cbEmpty1.UseVisualStyleBackColor = true;
            this.cbEmpty1.CheckedChanged += new System.EventHandler(this.cbEmpty1_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.gwInfo1);
            this.panel5.Location = new System.Drawing.Point(309, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(749, 797);
            this.panel5.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(181, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 53);
            this.label9.TabIndex = 1;
            this.label9.Text = "Список гостей";
            // 
            // gwInfo1
            // 
            this.gwInfo1.AllowUserToAddRows = false;
            this.gwInfo1.AllowUserToDeleteRows = false;
            this.gwInfo1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gwInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwInfo1.Location = new System.Drawing.Point(-1, 58);
            this.gwInfo1.Name = "gwInfo1";
            this.gwInfo1.ReadOnly = true;
            this.gwInfo1.RowHeadersWidth = 82;
            this.gwInfo1.RowTemplate.Height = 33;
            this.gwInfo1.Size = new System.Drawing.Size(749, 740);
            this.gwInfo1.TabIndex = 0;
            this.gwInfo1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwInfo1_CellContentDoubleClick);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tbOutDate1);
            this.panel6.Controls.Add(this.tbInDate1);
            this.panel6.Controls.Add(this.tbFullName1);
            this.panel6.Controls.Add(this.cbStatus1);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.Photo1);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.btCardView1);
            this.panel6.Location = new System.Drawing.Point(1065, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(462, 799);
            this.panel6.TabIndex = 2;
            // 
            // Photo1
            // 
            this.Photo1.Image = global::Hotel.Properties.Resources.smile;
            this.Photo1.Location = new System.Drawing.Point(60, 58);
            this.Photo1.Name = "Photo1";
            this.Photo1.Size = new System.Drawing.Size(362, 343);
            this.Photo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo1.TabIndex = 2;
            this.Photo1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(139, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 53);
            this.label10.TabIndex = 1;
            this.label10.Text = "Номер№";
            // 
            // btCardView1
            // 
            this.btCardView1.Location = new System.Drawing.Point(180, 738);
            this.btCardView1.Name = "btCardView1";
            this.btCardView1.Size = new System.Drawing.Size(269, 46);
            this.btCardView1.TabIndex = 0;
            this.btCardView1.Text = "Просмотр карточки";
            this.btCardView1.UseVisualStyleBackColor = true;
            this.btCardView1.Click += new System.EventHandler(this.btCardView1_Click);
            // 
            // tbSearch1
            // 
            this.tbSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch1.Location = new System.Drawing.Point(428, 0);
            this.tbSearch1.Name = "tbSearch1";
            this.tbSearch1.Size = new System.Drawing.Size(1044, 44);
            this.tbSearch1.TabIndex = 3;
            this.tbSearch1.Enter += new System.EventHandler(this.tbSearch1_Enter);
            this.tbSearch1.Leave += new System.EventHandler(this.tbSearch1_Leave);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(12, -3);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(211, 44);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(177, -3);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 44);
            this.dateTimePicker4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.time;
            this.pictureBox1.Location = new System.Drawing.Point(324, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hotel.Properties.Resources.search;
            this.pictureBox4.Location = new System.Drawing.Point(1428, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(3, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 39);
            this.label11.TabIndex = 3;
            this.label11.Text = "Статус";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(3, 525);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 39);
            this.label12.TabIndex = 4;
            this.label12.Text = "ФИО";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(3, 594);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 39);
            this.label13.TabIndex = 5;
            this.label13.Text = "Дата заезда";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(3, 661);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 39);
            this.label14.TabIndex = 6;
            this.label14.Text = "Дата выезда";
            // 
            // cbStatus1
            // 
            this.cbStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStatus1.FormattingEnabled = true;
            this.cbStatus1.Items.AddRange(new object[] {
            "Выписываются",
            "Свободные",
            "Заняты",
            "Зарезервировано"});
            this.cbStatus1.Location = new System.Drawing.Point(156, 450);
            this.cbStatus1.Name = "cbStatus1";
            this.cbStatus1.Size = new System.Drawing.Size(293, 45);
            this.cbStatus1.TabIndex = 7;
            // 
            // tbFullName1
            // 
            this.tbFullName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFullName1.Location = new System.Drawing.Point(126, 522);
            this.tbFullName1.Name = "tbFullName1";
            this.tbFullName1.Size = new System.Drawing.Size(323, 44);
            this.tbFullName1.TabIndex = 8;
            // 
            // tbInDate1
            // 
            this.tbInDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInDate1.Location = new System.Drawing.Point(243, 594);
            this.tbInDate1.Name = "tbInDate1";
            this.tbInDate1.Size = new System.Drawing.Size(163, 44);
            this.tbInDate1.TabIndex = 9;
            // 
            // tbOutDate1
            // 
            this.tbOutDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutDate1.Location = new System.Drawing.Point(243, 661);
            this.tbOutDate1.Name = "tbOutDate1";
            this.tbOutDate1.Size = new System.Drawing.Size(163, 44);
            this.tbOutDate1.TabIndex = 10;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1527, 847);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.tbSearch1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "HotelForm";
            this.Text = "HotelForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwInfo1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.CheckBox cbReserved;
        private System.Windows.Forms.CheckBox cbDischarged;
        private System.Windows.Forms.CheckBox cbBusy;
        private System.Windows.Forms.CheckBox cbEmpty;
        private System.Windows.Forms.Button btCardView;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDepartureDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCheckInDate;
        private System.Windows.Forms.DataGridView gwInfo;
        private System.Windows.Forms.CheckBox cbResserved;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbSearch1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbDischarged1;
        private System.Windows.Forms.CheckBox cbBusy1;
        private System.Windows.Forms.CheckBox cbEmpty1;
        private System.Windows.Forms.CheckBox cbReserved1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView gwInfo1;
        private System.Windows.Forms.Button btCardView1;
        private System.Windows.Forms.CheckBox cbRessserved;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox Photo1;
        private System.Windows.Forms.TextBox tbOutDate1;
        private System.Windows.Forms.TextBox tbInDate1;
        private System.Windows.Forms.TextBox tbFullName1;
        private System.Windows.Forms.ComboBox cbStatus1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}