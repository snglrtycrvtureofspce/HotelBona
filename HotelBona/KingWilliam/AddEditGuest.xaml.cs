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
    /// Interaction logic for AddEditGuest.xaml
    /// </summary>
    public partial class AddEditGuest : Window
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");

        string id = "";
        public AddEditGuest()
        {
            InitializeComponent();
            conn.Open();
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 GuestID FROM tblGuests ORDER BY GuestID DESC", conn);
            rdr = cmd.ExecuteReader();
            string guestid = "";
            while (rdr.Read())
            {
                guestid = rdr["GuestID"].ToString();
            }

            int id = int.Parse(guestid.Substring(1)) + 1;
            guestid = "G" + id.ToString().PadLeft(5, '0'); ;
            txtGuestID.Text = guestid;
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
            txtGuestID.Focus();
        }
        private void rdbNewGuest_Checked(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 GuestID FROM tblGuests ORDER BY GuestID DESC", conn);
            rdr = cmd.ExecuteReader();
            string guestid = "";
            while (rdr.Read())
            {
                guestid = rdr["GuestID"].ToString();
            }

            int id = int.Parse(guestid.Substring(1)) + 1;
            guestid = "G" + id.ToString().PadLeft(5, '0'); ;
            txtGuestID.Text = guestid;
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
            txtGuestID.Focus();
        }

        public AddEditGuest(string id)
        {
            InitializeComponent();
            this.id = id;
            txtGuestID.Text = id;
            conn.Open();
            SqlCommand reservation = new SqlCommand("select * from tblGuests where guestID =  '" + txtGuestID.Text + "'", conn);
            SqlDataReader rdr = null;
            rdr = reservation.ExecuteReader();

            while (rdr.Read())
            {
                txtGuestID.Text = rdr["GuestID"].ToString();
                txtFirstName.Text = rdr["FirstName"].ToString();
                txtLastName.Text = rdr["LastName"].ToString();
                txtPhone.Text = rdr["Phone"].ToString();
                txtAddress.Text = rdr["GuestAddress"].ToString();
                pol.Text = rdr["PostalCode"].ToString();
                txtEmail.Text = rdr["EmailAddress"].ToString();


            }
            conn.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (id != "")
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || pol.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Заполните все поля");
                }

                else
                {
                    conn.Open();
                    SqlCommand update = new SqlCommand("UPDATE tblGuests SET FirstName='" + txtFirstName.Text + "' ,LastName='" + txtLastName.Text + "' ,GuestAddress='" + txtAddress.Text + "', Phone='" + txtPhone.Text + "', PostalCode='" + pol.Text + "' ,EmailAddress = '" + txtEmail.Text + "' where GuestID = '" + txtGuestID.Text + "'", conn);
                    int r = update.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Гость обновлен успешно!");
                        this.Close();
                    }
                    conn.Close();
                }
            }
        }
        private void btnaddguest(object sender, RoutedEventArgs e)
        {

            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || pol.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            
            else
            {
                conn.Open();
                SqlCommand insertGuest = new SqlCommand("INSERT INTO tblGuests (GuestID,FirstName,LastName,GuestAddress, PostalCode,Phone,EmailAddress) VALUES (@guest,@first,@last,@address,@postal,@phone,@email)", conn);

                insertGuest.Parameters.Add(new SqlParameter("guest", txtGuestID.Text));
                insertGuest.Parameters.Add(new SqlParameter("first", txtFirstName.Text));
                insertGuest.Parameters.Add(new SqlParameter("last", txtLastName.Text));
                insertGuest.Parameters.Add(new SqlParameter("address", txtAddress.Text));
                insertGuest.Parameters.Add(new SqlParameter("postal", (pol.Text).ToUpper()));
                insertGuest.Parameters.Add(new SqlParameter("phone", txtPhone.Text));
                insertGuest.Parameters.Add(new SqlParameter("email", txtEmail.Text));
                int result = insertGuest.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Невозможно добавить гостя");
                }
                else
                {
                    MessageBox.Show("Гость успешно добавлен");
                    this.Close();
                }
            }
            conn.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
