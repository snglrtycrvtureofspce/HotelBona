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
using System.IO;

namespace KingWilliam
{
    /// <summary>
    /// Interaction logic for AddEditGuest.xaml
    /// </summary>
    public partial class EditGuest : Window
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");

        string id = "";
        public EditGuest()
        {
            InitializeComponent();
        }
        public EditGuest(string id)
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


       /* private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }*/

        private void btnaddguest(object sender, RoutedEventArgs e)
        {
            if (id != "")
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || pol.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Поля не заполнены.");
                }

                else
                {
                    conn.Open();

                    SqlCommand update = new SqlCommand("UPDATE tblGuests SET FirstName='" + txtFirstName.Text + "' ,LastName='" + txtLastName.Text + "' ,GuestAddress='" + txtAddress.Text + "', Phone='" + txtPhone.Text + "', PostalCode='" + pol.Text + "' ,EmailAddress = '" + txtEmail.Text + "' where GuestID = '" + txtGuestID.Text + "'", conn);
                    update.Parameters.Add(new SqlParameter("FirstName", txtFirstName.Text));
                    update.Parameters.Add(new SqlParameter("LastName", txtLastName.Text));
                    update.Parameters.Add(new SqlParameter("GuestAddress", txtAddress.Text));
                    update.Parameters.Add(new SqlParameter("PostalCode", (pol.Text).ToUpper()));
                    update.Parameters.Add(new SqlParameter("Phone", txtPhone.Text));
                    update.Parameters.Add(new SqlParameter("EmailAddress", txtEmail.Text));
                    int result = update.ExecuteNonQuery();

                    int r = update.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Данные гостя обновлены!");
                        this.Close();
                    }
                    conn.Close();
                }

            }
            else
            {


            }
        }
    }
}
