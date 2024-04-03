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
namespace HotelCard
{
    public partial class Form1 : Form
    {
        private GridView db;
        public Form1()
        {
            InitializeComponent();
            db = new GridView();
            tbSearch.Text = "Поиск...";


        }

        private void btCardView_Click(object sender, EventArgs e)
        {
            CardViewForm cardViewForm = new CardViewForm();
            cardViewForm.ShowDialog();

        }
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Поиск...")
            {
                tbSearch.Text = "";
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            tbSearch.Text = "Поиск...";
        }

        private void cbReserved_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbReserved.Checked)
            {
                string status1 = "Зарезервировано";
                var quary1 = $"SELECT * FROM `info` WHERE `status` = '{status1}'";

                db.MySqlReturnData(quary1, gwInfo);
            }
            else
            {

            }

        }

        private void cbEmpty_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbReserved.Checked)
            {
                string status2 = "Свободные";
                var quary2 = $"SELECT * FROM `info` WHERE `status` = '{status2}'";

                db.MySqlReturnData(quary2, gwInfo);
            }
            else
            {

            }
        }

        private void cbBusy_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbReserved.Checked)
            {
                string status3 = "Заняты";
                var quary3 = $"SELECT * FROM `info` WHERE `status` = '{status3}'";

                db.MySqlReturnData(quary3, gwInfo);
            }
            else
            {

            }
        }

        private void cbDischarged_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbReserved.Checked)
            {
                string status4 = "Выписываются";
                var quary4 = $"SELECT * FROM `info` WHERE `status` = '{status4}'";

                db.MySqlReturnData(quary4, gwInfo);
            }

        }

        private void cbResserved_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbReserved.Checked)
            {
                string status1 = "Зарезервировано";
                var quary1 = $"SELECT * FROM `info` WHERE `status` = '{status1}'";

                db.MySqlReturnData(quary1, gwInfo);
            }

        }

        private void gwInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gwInfo.Rows.Count)
            {
                DataGridViewRow selectedRow = gwInfo.Rows[e.RowIndex];
                string name = selectedRow.Cells["fullName"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();
                string inDate = selectedRow.Cells["inDate"].Value.ToString();
                string outDate = selectedRow.Cells["outDate"].Value.ToString();
                cbStatus.Text = status;
                tbFullName.Text = name;
                tbCheckInDate.Text = inDate;
                tbDepartureDate.Text = outDate;
                switch (name)
                {
                    case "Сагири Изуми":
                        Photo.Image = Properties.Resources.eromanga;
                        break;
                    case "Zero two":
                        Photo.Image = Properties.Resources.zerotwo;
                        break;
                    case "Наначи":
                        Photo.Image = Properties.Resources.nanachi;
                        break;
                    case "Неко тян":
                        Photo.Image = Properties.Resources.neko;
                        break;

                }

            }
        }

    }
}
