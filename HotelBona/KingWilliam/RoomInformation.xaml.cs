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
    /// Interaction logic for EmployeeInformation.xaml
    /// </summary>
    public partial class RoomInformation : Window
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");


        public RoomInformation()
        {
            InitializeComponent();
            txtRoomID.Focus();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Close();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            if (txtRoomID.Text != "")
            {
                conn.Open();
                SqlCommand reservation = new SqlCommand("select * from tblRooms where RoomID =  '" + txtRoomID.Text + "'", conn);
                SqlDataReader rdr = null;
                rdr = reservation.ExecuteReader();
                bool found = false;
                while (rdr.Read())
                {
                    cnvRoom.Visibility = Visibility.Visible;
                    lblID.Content = rdr["RoomID"].ToString();
                    lblFirstName.Content = rdr["RoomTypeID"].ToString();

                    lblLastName.Content = rdr["StatusID"];
                    lblPhone.Content = rdr["Cost"];
                    lblAddress.Content = rdr["RoomFloor"].ToString();

                    found = true;


                }

                if (found == false)
                {
                    cnvRoom.Visibility = Visibility.Collapsed;
                    MessageBox.Show("Employee ID not found. Please try again!");

                }
                rdr.Close();
                conn.Close();




            }
            else
            {
                MessageBox.Show("Enter Reservation ID to find Reservation details");
                txtRoomID.Focus();
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditRoom add = new AddEditRoom();
            add.ShowDialog();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditRoom win = new AddEditRoom(txtRoomID.Text);
            win.ShowDialog();
        }
    }
}
