using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace otobus_application
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-034MF6P;Initial Catalog=BusProgram;Integrated Security=True");

        private void cleaner()
        {
            CmbCompanyName.Text = "";
            TxtCustomerName.Clear();
            TxtCustomerSurname.Clear();
            TxtCustomerPhone.Clear();
            TxtCustomerEmail.Clear();
            TxtCustomerTC.Clear();
            CmbStratLocation.Text = "";
            CmbFinishLocation.Text = "";
            TxtTicketPrice.Clear();
            TxtSeatNo.Clear();
            TxtSelectedSeatCount.Clear();
        }
        private void control()
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("exec COMPARIES_ROAD @x,@y,@z,@k", connection);
            sqlCommand.Parameters.AddWithValue("@x", Convert.ToInt32(TxtCompId.Text));
            sqlCommand.Parameters.AddWithValue("@y", TxtDepartureTime.Text);
            sqlCommand.Parameters.AddWithValue("@z", CmbStratLocation.Text);
            sqlCommand.Parameters.AddWithValue("@k", CmbFinishLocation.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                string seat = sqlDataReader[0].ToString();
                switch (seat)
                {
                    case "1":
                        BtnSeat1.Enabled = false;
                        BtnSeat1.BackColor = Color.Red;
                        break;
                    case "2":
                        BtnSeat2.Enabled = false;
                        BtnSeat2.BackColor = Color.Red;
                        break;
                    case "3":
                        BtnSeat3.Enabled = false;
                        BtnSeat3.BackColor = Color.Red;
                        break;
                    case "4":
                        BtnSeat4.Enabled = false;
                        BtnSeat4.BackColor = Color.Red;
                        break;
                    case "5":
                        BtnSeat5.Enabled = false;
                        BtnSeat5.BackColor = Color.Red;
                        break;
                    case "6":
                        BtnSeat6.Enabled = false;
                        BtnSeat6.BackColor = Color.Red;
                        break;
                    case "7":
                        BtnSeat7.Enabled = false;
                        BtnSeat7.BackColor = Color.Red;
                        break;
                    case "8":
                        BtnSeat8.Enabled = false;
                        BtnSeat8.BackColor = Color.Red;
                        break;
                    case "9":
                        BtnSeat9.Enabled = false;
                        BtnSeat9.BackColor = Color.Red;
                        break;
                    case "10":
                        BtnSeat10.Enabled = false;
                        BtnSeat10.BackColor = Color.Red;
                        break;
                    case "11":
                        BtnSeat11.Enabled = false;
                        BtnSeat11.BackColor = Color.Red;
                        break;
                    case "12":
                        BtnSeat12.Enabled= false;
                        BtnSeat12.BackColor = Color.Red;
                        break;
                    case "13":
                        BtnSeat13.Enabled = false;
                        BtnSeat13.BackColor = Color.Red;
                        break;
                    case "14":
                        BtnSeat14.Enabled = false;
                        BtnSeat14.BackColor = Color.Red;
                        break;
                    case "15":
                        BtnSeat15.Enabled = false;
                        BtnSeat15.BackColor = Color.Red;
                        break;
                    case "16":
                        BtnSeat16.Enabled = false;
                        BtnSeat16.BackColor = Color.Red;
                        break;
                    case "17":
                        BtnSeat17.Enabled = false;
                        BtnSeat17.BackColor = Color.Red;
                        break;
                    case "18":
                        BtnSeat18.Enabled = false;
                        BtnSeat18.BackColor = Color.Red;
                        break;
                    case "19":
                        BtnSeat19.Enabled = false;
                        BtnSeat19.BackColor = Color.Red;
                        break;
                    case "20":
                        BtnSeat20.Enabled = false;
                        BtnSeat20.BackColor = Color.Red;
                        break;
                    case "21":
                        BtnSeat21.Enabled = false;
                        BtnSeat21.BackColor = Color.Red;
                        break;
                    case "22":
                        BtnSeat22.Enabled = false;
                        BtnSeat22.BackColor = Color.Red;
                        break;
                    case "23":
                        BtnSeat23.Enabled = false;
                        BtnSeat23.BackColor = Color.Red;
                        break;
                    case "24":
                        BtnSeat24.Enabled = false;
                        BtnSeat24.BackColor = Color.Red;
                        break;
                    case "25":
                        BtnSeat25.Enabled = false;
                        BtnSeat25.BackColor = Color.Red;
                        break;
                    case "26":
                        BtnSeat26.Enabled = false;
                        BtnSeat26.BackColor = Color.Red;
                        break;
                    case "27":
                        BtnSeat27.Enabled = false;
                        BtnSeat27.BackColor = Color.Red;
                        break;
                    case "28":
                        BtnSeat28.Enabled = false;
                        BtnSeat28.BackColor = Color.Red;
                        break;
                    case "29":
                        BtnSeat29.Enabled = false;
                        BtnSeat29.BackColor = Color.Red;
                        break;
                    case "30":
                        BtnSeat30.Enabled = false;
                        BtnSeat30.BackColor = Color.Red;
                        break;
                    case "31":
                        BtnSeat31.Enabled = false;
                        BtnSeat31.BackColor = Color.Red;
                        break;
                    case "32":
                        BtnSeat32.Enabled = false;
                        BtnSeat32.BackColor = Color.Red;
                        break;
                    case "33":
                        BtnSeat33.Enabled = false;
                        BtnSeat33.BackColor = Color.Red;
                        break;
                    default:
                        break;
                }
            }
            connection.Close();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT *FROM Company ", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                CmbCompanyName.Items.Add(dataReader[1]);
            }
            connection.Close();
            
        }

        private void CmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT *FROM Company WHERE CompanyName LIKE @compname AND CompanyName LIKE @compname", connection);
            command.Parameters.AddWithValue("@compname", CmbCompanyName.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                TxtTicketPrice.Text = dataReader[3].ToString();
                TxtCompId.Text = dataReader[0].ToString();
            }
            else
            {
                MessageBox.Show("Böyle bir firma yok");
                CmbCompanyName.Text = "";
            }
            connection.Close();
        }

        private void BtnTicketPurchase_Click(object sender, EventArgs e)
        {
            if (CmbCompanyName.Text == "")
            {
                MessageBox.Show("Lütfen bir firma seçiniz");
            }
            else
            {
                if (TxtDepartureTime.Text == "" || CmbStratLocation.Text == "" || CmbFinishLocation.Text == "" || TxtSeatNo.Text == "") 
                {
                    MessageBox.Show("Eksik Değer girdiniz");
                }
                else
                {
                    
                    connection.Open();
                    SqlCommand sqlCommand1 = new SqlCommand("exec LOCATION_COMPARE @x,@y,@z", connection);

                    sqlCommand1.Parameters.AddWithValue("@x", TxtDepartureTime.Text);
                    sqlCommand1.Parameters.AddWithValue("@y", CmbStratLocation.Text);
                    sqlCommand1.Parameters.AddWithValue("@z", CmbFinishLocation.Text);
                    SqlDataReader dataReader = sqlCommand1.ExecuteReader();
                    if (dataReader.Read())
                    {
                        TxtBusPlate.Text = dataReader[0].ToString();
                        dataReader.Close();
                        SqlCommand command = new SqlCommand("INSERT INTO Customer (CustomerTcId,CustomerName,CustomerSurname,CustomerPhone,CustomerMail) values (@custc,@cusname,@cussurnme,@cusphone,@cusmail)", connection);
                        SqlCommand sql = new SqlCommand("INSERT INTO Ticket (CustomerTcId,SeatId,BusPlate,TicketCount,TicketPrice) values (@tc,@seat,@plate,@count,@price)", connection);
                        //SqlCommand sqlCommand = new SqlCommand("INSERT INTO Bus (DepartureTime,DepartureDate,SeatNumber,StartLocation,FinishLocation) values (@time,@date,@seat,@start,@finish)", connection);
                        sql.Parameters.AddWithValue("@tc", TxtCustomerTC.Text);
                        sql.Parameters.AddWithValue("@seat", TxtSeatNo.Text);
                        sql.Parameters.AddWithValue("@plate", TxtBusPlate.Text);
                        sql.Parameters.AddWithValue("@count", 1);
                        sql.Parameters.AddWithValue("@price", TxtTicketPrice.Text);
                        command.Parameters.AddWithValue("@custc", TxtCustomerTC.Text);
                        command.Parameters.AddWithValue("@cusname", TxtCustomerName.Text);
                        command.Parameters.AddWithValue("@cussurnme", TxtCustomerSurname.Text);
                        command.Parameters.AddWithValue("@cusphone", TxtCustomerPhone.Text);
                        command.Parameters.AddWithValue("@cusmail", TxtCustomerEmail.Text);
                        /*sqlCommand.Parameters.AddWithValue("@time", TxtDepartureTime.Text);
                        sqlCommand.Parameters.AddWithValue("@date", TxtDepartureDate.Text);
                        sqlCommand.Parameters.AddWithValue("@seat", TxtSeatNo.Text);
                        sqlCommand.Parameters.AddWithValue("@start", CmbStratLocation.Text);
                        sqlCommand.Parameters.AddWithValue("@finish", CmbFinishLocation.Text);*/
                        command.ExecuteNonQuery();
                        sql.ExecuteNonQuery();
                        //sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir sefer yok");
                    }
                    connection.Close();
                    MessageBox.Show("Bilet Satın Alımı gerçekleşti");
                    cleaner();
                }
            }
        }

        private void BtnGotoAdmin_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void BtnSeat1_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "1";
        }

        private void BtnSeat2_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "2";
        }

        private void BtnSeat3_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "3";
        }

        private void BtnSeat4_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "4";
        }

        private void BtnSeat5_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "5";
        }

        private void BtnSeat6_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "6";
        }

        private void BtnSeat7_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "7";
        }

        private void BtnSeat8_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "8";
        }

        private void BtnSeat9_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "9";
        }

        private void BtnSeat10_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "10";
        }

        private void BtnSeat11_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "11";
        }

        private void BtnSeat12_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "12";
        }

        private void BtnSeat13_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "13";
        }

        private void BtnSeat14_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "14";
        }

        private void BtnSeat15_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "15";
        }

        private void BtnSeat16_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "16";
        }

        private void BtnSeat17_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "17";
        }

        private void BtnSeat18_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "18";
        }

        private void BtnSeat19_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "19";
        }

        private void BtnSeat20_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "20";
        }

        private void BtnSeat21_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "21";
        }

        private void BtnSeat22_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "22";
        }

        private void BtnSeat23_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "23";
        }

        private void BtnSeat24_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "24";
        }

        private void BtnSeat25_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "25";
        }

        private void BtnSeat26_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "26";
        }

        private void BtnSeat27_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "27";
        }

        private void BtnSeat28_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "28";
        }

        private void BtnSeat29_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "29";
        }

        private void BtnSeat30_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "30";
        }

        private void BtnSeat31_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "31";
        }

        private void BtnSeat32_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "32";
        }

        private void BtnSeat33_Click(object sender, EventArgs e)
        {
            TxtSeatNo.Text = "33";
        }

        private void BtnDepartureTime6_Click(object sender, EventArgs e)
        {
            TxtDepartureTime.Text = "06.00";
        }

        private void BtnDepartureTime8_Click(object sender, EventArgs e)
        {
            TxtDepartureTime.Text = "08.00";
        }

        private void BtnDepartureTime10_Click(object sender, EventArgs e)
        {
            TxtDepartureTime.Text = "10.00";
        }

        private void BtnDepartureTime12_Click(object sender, EventArgs e)
        {
            TxtDepartureTime.Text = "12.00";
        }

        private void BtnDepartureTime14_Click(object sender, EventArgs e)
        {
            TxtDepartureTime.Text = "14.00";
        }

        private void BtnDepartureTime16_Click(object sender, EventArgs e)
        {
            TxtDepartureTime.Text = "16.00";
        }

        private void BtnDepartureTime18_Click(object sender, EventArgs e)
        {
            TxtDepartureTime.Text = "18.00";
        }

        private void BtnDepartureTime20_Click(object sender, EventArgs e)
        {
            TxtDepartureTime.Text = "20.00";
        }

        private void BtnDepartureTime22_Click(object sender, EventArgs e)
        {
            TxtDepartureTime.Text = "22.00";
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            control();
        }
    }
}
