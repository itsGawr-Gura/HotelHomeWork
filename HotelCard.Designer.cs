namespace HotelCard
{
    partial class HotelCard
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbResserved = new System.Windows.Forms.CheckBox();
            this.cbDischarged = new System.Windows.Forms.CheckBox();
            this.cbBusy = new System.Windows.Forms.CheckBox();
            this.cbEmpty = new System.Windows.Forms.CheckBox();
            this.cbReserved = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gwInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDepartureDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCheckInDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCardView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwInfo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbResserved);
            this.panel1.Controls.Add(this.cbDischarged);
            this.panel1.Controls.Add(this.cbBusy);
            this.panel1.Controls.Add(this.cbEmpty);
            this.panel1.Controls.Add(this.cbReserved);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 905);
            this.panel1.TabIndex = 0;
            // 
            // cbResserved
            // 
            this.cbResserved.AutoSize = true;
            this.cbResserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbResserved.Location = new System.Drawing.Point(36, 124);
            this.cbResserved.Name = "cbResserved";
            this.cbResserved.Size = new System.Drawing.Size(306, 41);
            this.cbResserved.TabIndex = 5;
            this.cbResserved.Text = "Зарезервировано";
            this.cbResserved.UseVisualStyleBackColor = true;
            this.cbResserved.CheckStateChanged += new System.EventHandler(this.cbResserved_CheckStateChanged);
            // 
            // cbDischarged
            // 
            this.cbDischarged.AutoSize = true;
            this.cbDischarged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDischarged.Location = new System.Drawing.Point(36, 280);
            this.cbDischarged.Name = "cbDischarged";
            this.cbDischarged.Size = new System.Drawing.Size(253, 41);
            this.cbDischarged.TabIndex = 4;
            this.cbDischarged.Text = "Выписываются";
            this.cbDischarged.UseVisualStyleBackColor = true;
            this.cbDischarged.CheckStateChanged += new System.EventHandler(this.cbDischarged_CheckStateChanged);
            // 
            // cbBusy
            // 
            this.cbBusy.AutoSize = true;
            this.cbBusy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBusy.Location = new System.Drawing.Point(36, 227);
            this.cbBusy.Name = "cbBusy";
            this.cbBusy.Size = new System.Drawing.Size(152, 41);
            this.cbBusy.TabIndex = 3;
            this.cbBusy.Text = "Заняты";
            this.cbBusy.UseVisualStyleBackColor = true;
            this.cbBusy.CheckStateChanged += new System.EventHandler(this.cbBusy_CheckStateChanged);
            // 
            // cbEmpty
            // 
            this.cbEmpty.AutoSize = true;
            this.cbEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEmpty.Location = new System.Drawing.Point(36, 177);
            this.cbEmpty.Name = "cbEmpty";
            this.cbEmpty.Size = new System.Drawing.Size(207, 41);
            this.cbEmpty.TabIndex = 2;
            this.cbEmpty.Text = "Свободные";
            this.cbEmpty.UseVisualStyleBackColor = true;
            this.cbEmpty.CheckStateChanged += new System.EventHandler(this.cbEmpty_CheckStateChanged);
            // 
            // cbReserved
            // 
            this.cbReserved.AutoSize = true;
            this.cbReserved.Checked = true;
            this.cbReserved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbReserved.Location = new System.Drawing.Point(36, 124);
            this.cbReserved.Name = "cbReserved";
            this.cbReserved.Size = new System.Drawing.Size(306, 41);
            this.cbReserved.TabIndex = 1;
            this.cbReserved.Text = "Зарезервировано";
            this.cbReserved.UseVisualStyleBackColor = true;
            this.cbReserved.Visible = false;
            this.cbReserved.CheckStateChanged += new System.EventHandler(this.cbReserved_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gwInfo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(395, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 905);
            this.panel2.TabIndex = 1;
            // 
            // gwInfo
            // 
            this.gwInfo.AllowUserToAddRows = false;
            this.gwInfo.AllowUserToDeleteRows = false;
            this.gwInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gwInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwInfo.Location = new System.Drawing.Point(12, 89);
            this.gwInfo.Name = "gwInfo";
            this.gwInfo.ReadOnly = true;
            this.gwInfo.RowHeadersWidth = 82;
            this.gwInfo.RowTemplate.Height = 33;
            this.gwInfo.Size = new System.Drawing.Size(583, 811);
            this.gwInfo.TabIndex = 1;
            this.gwInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwInfo_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "Список гостей";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Photo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbDepartureDate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbCheckInDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbFullName);
            this.panel3.Controls.Add(this.cbStatus);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btCardView);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1014, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 905);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(-2, 741);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Дата выезда";
            // 
            // tbDepartureDate
            // 
            this.tbDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDepartureDate.Location = new System.Drawing.Point(249, 736);
            this.tbDepartureDate.Name = "tbDepartureDate";
            this.tbDepartureDate.Size = new System.Drawing.Size(169, 44);
            this.tbDepartureDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(-2, 660);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "Дата заезда";
            // 
            // tbCheckInDate
            // 
            this.tbCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckInDate.Location = new System.Drawing.Point(249, 660);
            this.tbCheckInDate.Name = "tbCheckInDate";
            this.tbCheckInDate.Size = new System.Drawing.Size(169, 44);
            this.tbCheckInDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(3, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "ФИО";
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFullName.Location = new System.Drawing.Point(116, 574);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(348, 44);
            this.tbFullName.TabIndex = 5;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Зарезервировано",
            "Свободные",
            "Заняты",
            "Выписываются"});
            this.cbStatus.Location = new System.Drawing.Point(142, 466);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(322, 45);
            this.cbStatus.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(3, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Статус";
            // 
            // btCardView
            // 
            this.btCardView.Location = new System.Drawing.Point(220, 842);
            this.btCardView.Name = "btCardView";
            this.btCardView.Size = new System.Drawing.Size(244, 50);
            this.btCardView.TabIndex = 1;
            this.btCardView.Text = "Просмотр карточки";
            this.btCardView.UseVisualStyleBackColor = true;
            this.btCardView.Click += new System.EventHandler(this.btCardView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер №";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(107, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(149, 31);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(395, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(1016, 44);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelCard.Properties.Resources.time;
            this.pictureBox3.Location = new System.Drawing.Point(221, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelCard.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(1357, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Photo
            // 
            this.Photo.Image = global::HotelCard.Properties.Resources.smile;
            this.Photo.Location = new System.Drawing.Point(43, 105);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(375, 345);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 11;
            this.Photo.TabStop = false;
            // 
            // HotelCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1491, 1009);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotelCard";
            this.Text = "Карта отеля";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
    }
}

