using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelCard;
using MySql.Data.MySqlClient;

namespace Hotel
{
    public partial class HotelForm : Form
    {
        public static class UserName
        {
            public static string userName { get; set; }
        }
        private GridView db;
        public HotelForm()
        {
            InitializeComponent();
            db = new GridView();
            tbSearch1.Text = "Поиск...";
        }
        private void btCardView1_Click(object sender, EventArgs e)
        {
            CardViewForm cardViewForm = new CardViewForm();
            cardViewForm.ShowDialog();
        }

        private void tbSearch1_Enter(object sender, EventArgs e)
        {
            if (tbSearch1.Text == "Поиск...")
            {
                tbSearch1.Text = "";
            }
        }

        private void tbSearch1_Leave(object sender, EventArgs e)
        {
            tbSearch1.Text = "Поиск...";
        }

        private void cbReserved1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReserved1.Checked)
            {
                string status1 = "Зарезервировано";
                var quary1 = $"SELECT * FROM `info` WHERE `status` = '{status1}'";

                db.MySqlReturnData(quary1, gwInfo1);
            }
        }

        private void cbEmpty1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReserved1.Checked)
            {
                string status2 = "Свободные";
                var quary2 = $"SELECT * FROM `info` WHERE `status` = '{status2}'";

                db.MySqlReturnData(quary2, gwInfo1);
            }
        }

        private void cbBusy1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReserved1.Checked)
            {
                string status3 = "Заняты";
                var quary3 = $"SELECT * FROM `info` WHERE `status` = '{status3}'";

                db.MySqlReturnData(quary3, gwInfo1);
            }
        }

        private void cbDischarged1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReserved1.Checked)
            {
                string status4 = "Выписываются";
                var quary4 = $"SELECT * FROM `info` WHERE `status` = '{status4}'";

                db.MySqlReturnData(quary4, gwInfo1);
            }
        }

        private void cbRessserved_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRessserved.Checked)
            {
                string status5 = "Зарезервировано";
                var quary5 = $"SELECT * FROM `info` WHERE `status` = '{status5}'";

                db.MySqlReturnData(quary5, gwInfo1);
            }
        }

        private void gwInfo1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < gwInfo1.Rows.Count)
            {
                DataGridViewRow selectedRow = gwInfo1.Rows[e.RowIndex];
                string name = selectedRow.Cells["fullName"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();
                string inDate = selectedRow.Cells["inDate"].Value.ToString();
                string outDate = selectedRow.Cells["outDate"].Value.ToString();
                cbStatus1.Text = status;
                tbFullName1.Text = name;
                tbInDate1.Text = inDate;
                tbOutDate1.Text = outDate;
                switch (name)
                {
                    case "Сагири Изуми":
                        Photo1.Image = Properties.Resources.eromanga;
                        break;
                    case "Zero two":
                        Photo1.Image = Properties.Resources.zerotwo;
                        break;
                    case "Наначи":
                        Photo1.Image = Properties.Resources.nanachi;
                        break;
                    case "Неко тян":
                        Photo1.Image = Properties.Resources.neko;
                        break;

                }
                UserName.userName = tbFullName1.Text;

            }
        }
    }
}
