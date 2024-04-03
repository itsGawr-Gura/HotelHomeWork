using Hotel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCard
{
    public partial class CardViewForm : Form
    {
        public CardViewForm()
        {
            InitializeComponent();
            dbconnect db = new dbconnect();
            var quary = $"SELECT fullname, burnDate, payment, days, animals FROM info WHERE fullname='{HotelMainPage.UserName.userName}'";
            MySqlCommand cm = new MySqlCommand(quary, db.GetConnection());


            try
            {
                db.OpenConnection();

                using (MySqlDataReader reader = cm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tbFullName.Text = (reader[0].ToString());
                        tbBurnDate.Text = (reader[1].ToString());
                        cbPayment.Text = (reader[2].ToString());
                        numDays.Text = (reader[3].ToString());
                        cbAnimals.Text = (reader[4].ToString());

                    }
                }
            }
            finally
            {
                db.CloseConnection();
            }

        }
    }
}

