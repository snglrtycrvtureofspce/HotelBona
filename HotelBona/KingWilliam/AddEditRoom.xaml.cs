using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace KingWilliam
{
    /// <summary>
    /// Interaction logic for AddEditEmployee.xaml
    /// </summary>
    public partial class AddEditRoom : Window
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");

        string id = "";
        public AddEditRoom()
        {
            InitializeComponent();
            lblHeader.Content = "Добавить номер";
            btnEdit.Content = "Добавить";

            conn.Open();
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 RoomID FROM tblRooms ORDER BY RoomID DESC", conn);
            rdr = cmd.ExecuteReader();
            string RoomID = "";
            while (rdr.Read())
            {
                RoomID = rdr["RoomID"].ToString();
            }
            int id = int.Parse(RoomID.Substring(1)) + 1;
            RoomID = "U" + id.ToString().PadLeft(2, '0'); ;
            txtID.Text = RoomID;
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
            txtID.Focus();
        }
        public AddEditRoom(string id)
        {
            InitializeComponent();
            lblHeader.Content = "Edit Employee";
            btnEdit.Content = "Update";
            this.id = id;
            txtID.Text = id;
            conn.Open();
            SqlCommand reservation = new SqlCommand("select * from tblEmployee where employeeID =  '" + txtID.Text + "'", conn);
            SqlDataReader rdr = null;
            rdr = reservation.ExecuteReader();

            while (rdr.Read())
            {
                cnvRoom.Visibility = Visibility.Visible;
                txtID.Text = rdr["RoomID"].ToString();
                txtType.Text = rdr["RoomTypeID"].ToString();
                txtStatusID.Text = rdr["StatusID"].ToString();
                txtCost.Text = rdr["Cost"].ToString();
                txtFloor.Text = rdr["RoomFloor"].ToString();
            }
            conn.Close();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (id != "")
            {
                if (txtID.Text == "" || txtType.Text == "" || txtStatusID.Text == "" || txtCost.Text == "" || txtFloor.Text == "")
                {
                    MessageBox.Show("Все поля должны быть заполнены.");
                }
                else
                {
                    conn.Open();
                    SqlCommand update = new SqlCommand("UPDATE tblRooms SET RoomTypeID='" + txtType.Text + "' ,StatusID='" + txtStatusID.Text + "' ,Cost='" + txtCost.Text + "',RoomFloor='" + txtFloor.Text + "'", conn);
                    int r = update.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Номер обновлен успешно!");
                        this.Close();
                    }
                    conn.Close();
                }
            }
            else
            {
                if (txtID.Text == "" || txtType.Text == "" || txtStatusID.Text == "" || txtCost.Text == "" || txtFloor.Text == "")
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                }
                else
                {
                    conn.Open();
                    SqlCommand insertReservation = new SqlCommand("INSERT INTO tblRooms (RoomID,RoomTypeID,StatusID,Cost,RoomFloor) VALUES (@id,@type,@statusid,@cost,@floor)", conn);
                    insertReservation.Parameters.Add(new SqlParameter("id", txtID.Text));
                    insertReservation.Parameters.Add(new SqlParameter("type", txtType.Text));
                    insertReservation.Parameters.Add(new SqlParameter("statusid", txtStatusID.Text));
                    insertReservation.Parameters.Add(new SqlParameter("cost", txtCost.Text));
                    insertReservation.Parameters.Add(new SqlParameter("floor", txtFloor.Text));

                    int r = insertReservation.ExecuteNonQuery();
                    if (r == 0)
                    {
                        MessageBox.Show("Невозможно обновить информацию");
                    }
                    else
                    {
                        MessageBox.Show("Номер успешно добавлен");
                        this.Close();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
