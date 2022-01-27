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
//Data Source=DESKTOP-034MF6P;Initial Catalog=BusProgram;Integrated Security=True

namespace otobus_application
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-034MF6P;Initial Catalog=BusProgram;Integrated Security=True");

        #region Otobüs Butonları Renk Değişimi
        void BusColorChange()
        {
            BtnDepartureTime6.BackColor = Color.SpringGreen;
            BtnDepartureTime8.BackColor = Color.SpringGreen;
            BtnDepartureTime10.BackColor = Color.SpringGreen;
            BtnDepartureTime12.BackColor = Color.SpringGreen;
            BtnDepartureTime14.BackColor = Color.SpringGreen;
            BtnDepartureTime16.BackColor = Color.SpringGreen;
            BtnDepartureTime18.BackColor = Color.SpringGreen;
            BtnDepartureTime20.BackColor = Color.SpringGreen;
            BtnDepartureTime22.BackColor = Color.SpringGreen;
            BtnDepartureTime6.Enabled = true;
            BtnDepartureTime8.Enabled = true;
            BtnDepartureTime10.Enabled = true;
            BtnDepartureTime12.Enabled = true;
            BtnDepartureTime14.Enabled = true;
            BtnDepartureTime16.Enabled = true;
            BtnDepartureTime18.Enabled = true;
            BtnDepartureTime20.Enabled = true;
            BtnDepartureTime22.Enabled = true;


        }
        #endregion
        #region Müşteri Butonları Renk Değişimi
        void CustomerColorChange()
        {
            BtnCustomerSeat1.BackColor = Color.SpringGreen;
            BtnCustomerSeat2.BackColor = Color.SpringGreen;
            BtnCustomerSeat3.BackColor = Color.SpringGreen;
            BtnCustomerSeat4.BackColor = Color.SpringGreen;
            BtnCustomerSeat5.BackColor = Color.SpringGreen;
            BtnCustomerSeat6.BackColor = Color.SpringGreen;
            BtnCustomerSeat7.BackColor = Color.SpringGreen;
            BtnCustomerSeat8.BackColor = Color.SpringGreen;
            BtnCustomerSeat9.BackColor = Color.SpringGreen;
            BtnCustomerSeat10.BackColor = Color.SpringGreen;
            BtnCustomerSeat11.BackColor = Color.SpringGreen;
            BtnCustomerSeat12.BackColor = Color.SpringGreen;
            BtnCustomerSeat13.BackColor = Color.SpringGreen;
            BtnCustomerSeat14.BackColor = Color.SpringGreen;
            BtnCustomerSeat15.BackColor = Color.SpringGreen;
            BtnCustomerSeat16.BackColor = Color.SpringGreen;
            BtnCustomerSeat17.BackColor = Color.SpringGreen;
            BtnCustomerSeat18.BackColor = Color.SpringGreen;
            BtnCustomerSeat19.BackColor = Color.SpringGreen;
            BtnCustomerSeat20.BackColor = Color.SpringGreen;
            BtnCustomerSeat21.BackColor = Color.SpringGreen;
            BtnCustomerSeat22.BackColor = Color.SpringGreen;
            BtnCustomerSeat23.BackColor = Color.SpringGreen;
            BtnCustomerSeat24.BackColor = Color.SpringGreen;
            BtnCustomerSeat25.BackColor = Color.SpringGreen;
            BtnCustomerSeat26.BackColor = Color.SpringGreen;
            BtnCustomerSeat27.BackColor = Color.SpringGreen;
            BtnCustomerSeat28.BackColor = Color.SpringGreen;
            BtnCustomerSeat29.BackColor = Color.SpringGreen;
            BtnCustomerSeat30.BackColor = Color.SpringGreen;
            BtnCustomerSeat31.BackColor = Color.SpringGreen;
            BtnCustomerSeat32.BackColor = Color.SpringGreen;
            BtnCustomerSeat33.BackColor = Color.SpringGreen;
            BtnCustomerDepartureTime6.BackColor = Color.SpringGreen;
            BtnCustomerDepartureTime8.BackColor = Color.SpringGreen;
            BtnCustomerDepartureTime10.BackColor = Color.SpringGreen;
            BtnCustomerDepartureTime12.BackColor = Color.SpringGreen;
            BtnCustomerDepartureTime14.BackColor = Color.SpringGreen;
            BtnCustomerDepartureTime16.BackColor = Color.SpringGreen;
            BtnCustomerDepartureTime18.BackColor = Color.SpringGreen;
            BtnCustomerDepartureTime20.BackColor = Color.SpringGreen;
            BtnCustomerDepartureTime22.BackColor = Color.SpringGreen;
        }
        #endregion
        #region Müşteri Renk Kontrolü
        void CustomerColorControl()
        {
            switch (TxtSeatNo.Text)
            {
                case "1":
                    BtnCustomerSeat1.BackColor = Color.Red;
                    break;
                case "2":
                    BtnCustomerSeat2.BackColor = Color.Red;
                    break;
                case "3":
                    BtnCustomerSeat3.BackColor = Color.Red;
                    break;
                case "4":
                    BtnCustomerSeat4.BackColor = Color.Red;
                    break;
                case "5":
                    BtnCustomerSeat5.BackColor = Color.Red;
                    break;
                case "6":
                    BtnCustomerSeat6.BackColor = Color.Red;
                    break;
                case "7":
                    BtnCustomerSeat7.BackColor = Color.Red;
                    break;
                case "8":
                    BtnCustomerSeat8.BackColor = Color.Red;
                    break;
                case "9":
                    BtnCustomerSeat9.BackColor = Color.Red;
                    break;
                case "10":
                    BtnCustomerSeat10.BackColor = Color.Red;
                    break;
                case "11":
                    BtnCustomerSeat11.BackColor = Color.Red;
                    break;
                case "12":
                    BtnCustomerSeat12.BackColor = Color.Red;
                    break;
                case "13":
                    BtnCustomerSeat13.BackColor = Color.Red;
                    break;
                case "14":
                    BtnCustomerSeat14.BackColor = Color.Red;
                    break;
                case "15":
                    BtnCustomerSeat15.BackColor = Color.Red;
                    break;
                case "16":
                    BtnCustomerSeat16.BackColor = Color.Red;
                    break;
                case "17":
                    BtnCustomerSeat17.BackColor = Color.Red;
                    break;
                case "18":
                    BtnCustomerSeat18.BackColor = Color.Red;
                    break;
                case "19":
                    BtnCustomerSeat19.BackColor = Color.Red;
                    break;
                case "20":
                    BtnCustomerSeat20.BackColor = Color.Red;
                    break;
                case "21":
                    BtnCustomerSeat21.BackColor = Color.Red;
                    break;
                case "22":
                    BtnCustomerSeat22.BackColor = Color.Red;
                    break;
                case "23":
                    BtnCustomerSeat23.BackColor = Color.Red;
                    break;
                case "24":
                    BtnCustomerSeat24.BackColor = Color.Red;
                    break;
                case "25":
                    BtnCustomerSeat25.BackColor = Color.Red;
                    break;
                case "26":
                    BtnCustomerSeat26.BackColor = Color.Red;
                    break;
                case "27":
                    BtnCustomerSeat27.BackColor = Color.Red;
                    break;
                case "28":
                    BtnCustomerSeat28.BackColor = Color.Red;
                    break;
                case "29":
                    BtnCustomerSeat29.BackColor = Color.Red;
                    break;
                case "30":
                    BtnCustomerSeat30.BackColor = Color.Red;
                    break;
                case "31":
                    BtnCustomerSeat31.BackColor = Color.Red;
                    break;
                case "32":
                    BtnCustomerSeat32.BackColor = Color.Red;
                    break;
                case "33":
                    BtnCustomerSeat33.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region DataGridView Listeleme
        void AssistantDataGridViewSelection()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sadp = new SqlDataAdapter("select * from Assistant", connection);
            sadp.Fill(dt);

            DataGridAssistant.DataSource = dt;
            this.DataGridAssistant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   
        }
         void CustomerDataGridViewSelection()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sadp = new SqlDataAdapter("select Customer.CustomerTcId,Customer.CustomerName,Customer.CustomerSurname,Customer.CustomerPhone,Customer.CustomerMail,Ticket.TicketId,Ticket.SeatId,Bus.DepartureTime,Ticket.TicketCount,Ticket.TicketPrice,Bus.CompanyId,Bus.StartLocation,Bus.FinishLocation,Ticket.BusPlate from Customer inner join Ticket on Customer.CustomerTcId=Ticket.CustomerTcId inner join Bus on Ticket.TicketId=Bus.TicketId ", connection);
            sadp.Fill(dt);

            DataGridCustomer.DataSource = dt;
            this.DataGridCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void BusDataGridViewSelection()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter oda = new SqlDataAdapter("select Bus.BusPlate,Bus.DepartureTime,Bus.DepartureDate,Bus.StartLocation,Bus.FinishLocation,Company.CompanyId,Company.CompanyName,Company.BusTicketPrice,Driver.DriverId,Driver.DriverName,Driver.DriverSurname,Assistant.AssistantId,Assistant.AssistantName,Assistant.AssistantSurname from Bus inner join Company on Bus.CompanyId=Company.CompanyId inner join Driver on Bus.DriverId=Driver.DriverId inner join Assistant on Bus.AssistantId=Assistant.AssistantId", connection);
            oda.Fill(dt);

            DataGridBus.DataSource = dt;
            this.DataGridBus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion
        #region ComboBox Veri Çekme
        void AssistantComboBoxCompanySelection()
        {
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select CompanyId from Company", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbAssistantCompanyName.Items.Add(dr["CompanyId"].ToString());
                CmbBusCompany.Items.Add(dr["CompanyId"].ToString());
            }
            connection.Close();
        }
        void BusComboBoxDriverControl()
        {
            CmbBusDriverName.Items.Clear();
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select DriverName,DriverSurname,CompanyId,BusPlate from Driver where CompanyId=@companyid and BusPlate=@busplate ", connection);
            komut.Parameters.AddWithValue("@companyid", CmbBusCompany.Text);
            komut.Parameters.AddWithValue("@busplate", " ");
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBusDriverName.Items.Add(dr["DriverName"].ToString() + " " + dr["DriverSurname"].ToString());

            }
            connection.Close();
        }
        void BusComboBoxAssistantControl()
        {
            CmbBusAssistantName.Items.Clear();
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select AssistantName,AssistantSurname,CompanyId,BusPlate from Assistant where CompanyId=@companyid and BusPlate=@busplate", connection);
            komut.Parameters.AddWithValue("@companyid", CmbBusCompany.Text);
            komut.Parameters.AddWithValue("@busplate", "");
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                CmbBusAssistantName.Items.Add(dr["AssistantName"].ToString() + " " + dr["AssistantSurname"].ToString());
            }
            connection.Close();
        }
        #endregion
        #region Kalkış Tarihi-Saati Kontrolü
        void BusDepartureDateControl()
        {
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select * from Bus where DepartureDate=@departuredate and CompanyId=@companyid", connection);
            komut.Parameters.AddWithValue("@departuredate", Convert.ToDateTime(DtpBusDepatureDate.Text));
            komut.Parameters.AddWithValue("@companyid", CmbBusCompany.Text);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string time = dr[5].ToString();
                switch (time)
                {
                    case "06:00":
                        BtnDepartureTime6.BackColor = Color.Red;
                        BtnDepartureTime6.Enabled = false;
                        break;
                    case "08:00":
                        BtnDepartureTime8.BackColor = Color.Red;
                        BtnDepartureTime8.Enabled = false;
                        break;
                    case "10:00":
                        BtnDepartureTime10.BackColor = Color.Red;
                        BtnDepartureTime10.Enabled = false;
                        break;
                    case "12:00":
                        BtnDepartureTime12.BackColor = Color.Red;
                        BtnDepartureTime12.Enabled = false;
                        break;
                    case "14:00":
                        BtnDepartureTime14.BackColor = Color.Red;
                        BtnDepartureTime14.Enabled = false;
                        break;
                    case "16:00":
                        BtnDepartureTime16.BackColor = Color.Red;
                        BtnDepartureTime16.Enabled = false;
                        break;
                    case "18:00":
                        BtnDepartureTime18.BackColor = Color.Red;
                        BtnDepartureTime18.Enabled = false;
                        break;
                    case "20:00":
                        BtnDepartureTime20.BackColor = Color.Red;
                        BtnDepartureTime20.Enabled = false;
                        break;
                    case "22:00":
                        BtnDepartureTime22.BackColor = Color.Red;
                        BtnDepartureTime22.Enabled = false;
                        break;

                    default:

                        break;
                }
            }
            connection.Close();
        }
        void BusDepatureTimeControl()
        {
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select StartLocation,FinishLocation,DepartureTime,DepartureDate,CompanyId from Bus where CompanyId=@companyid and StartLocation=@startlocation and FinishLocation=@finishlocation and DepartureTime=@depatureTime and DepartureDate=@depaturedate", connection);
            komut.Parameters.AddWithValue("@companyid", CmbBusCompany.Text);
            komut.Parameters.AddWithValue("@startlocation", CmbBusStartLocation.Text);
            komut.Parameters.AddWithValue("@finishlocation", CmbBusFinishLocation.Text);
            komut.Parameters.AddWithValue("@depaturetime", TxtBusDepatureTime.Text);
            komut.Parameters.AddWithValue("@depaturedate", Convert.ToDateTime(DtpBusDepatureDate.Text));

            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == CmbBusStartLocation.Text && dr[1].ToString() == CmbBusFinishLocation.Text && dr[3].ToString() == DtpBusDepatureDate.Text && dr[4].ToString() == CmbBusCompany.Text)
                {
                    switch (dr[2].ToString())
                    {
                        case "06:00":
                            BtnDepartureTime6.BackColor = Color.Red;
                            BtnDepartureTime6.Enabled = false;
                            break;
                        case "08:00":
                            BtnDepartureTime8.BackColor = Color.Red;
                            BtnDepartureTime8.Enabled = false;
                            break;
                        case "10:00":
                            BtnDepartureTime10.BackColor = Color.Red;
                            BtnDepartureTime10.Enabled = false;
                            break;
                        case "12:00":
                            BtnDepartureTime12.BackColor = Color.Red;
                            BtnDepartureTime12.Enabled = false;
                            break;
                        case "14:00":
                            BtnDepartureTime14.BackColor = Color.Red;
                            BtnDepartureTime14.Enabled = false;
                            break;
                        case "16:00":
                            BtnDepartureTime16.BackColor = Color.Red;
                            BtnDepartureTime16.Enabled = false;
                            break;
                        case "18:00":
                            BtnDepartureTime18.BackColor = Color.Red;
                            BtnDepartureTime18.Enabled = false;
                            break;
                        case "20:00":
                            BtnDepartureTime20.BackColor = Color.Red;
                            BtnDepartureTime20.Enabled = false;
                            break;
                        case "22:00":
                            BtnDepartureTime22.BackColor = Color.Red;
                            BtnDepartureTime22.Enabled = false;
                            break;

                        default:

                            break;
                    }
                }
                
            }
            connection.Close();
        }
        #endregion
        #region ComboBox Veri Kontrolü
        void CustomerComboBoxCompanyControl()
        {
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select CompanyId,CompanyName from Company", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == CmbCompanyName.Text)
                {
                    LblCustomerCompany.Text = dr[1].ToString();
                }
            }
            connection.Close();
        }
        void AssistantComboBoxCompanyControl()
        {
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select CompanyId,CompanyName from Company", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString()== CmbAssistantCompanyName.Text)
                {
                    LblAssistantCompany.Text = dr[1].ToString();
                }
            }
            connection.Close();
        }
        void BusTicketPriceControl()
        {
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select CompanyId,CompanyName,BusTicketPrice from Company", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == CmbBusCompany.Text)
                {
                    CmbBusTicketPrice.Text = dr[2].ToString();
                }
            }
            connection.Close();
        }
        void BusComboBoxCompanyControl()
        {
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select CompanyId,CompanyName from Company", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == CmbBusCompany.Text)
                {
                    LblBusCompany.Text = dr[1].ToString();
                }
            }
            connection.Close();
        }
        void BusDriverIdControl()
        {
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select DriverId,DriverName,DriverSurname from Driver", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["DriverName"].ToString() == BusDriverName.Text && dr["DriverSurname"].ToString() == BusDriverSurname.Text)
                {
                    LblBusDriverId.Text = dr[0].ToString();
                }
            }
            connection.Close();
        }
        void BusAssistantIdControl()
        {
            connection.Open();
            SqlCommand komut;
            komut = new SqlCommand("select AssistantId,AssistantName,AssistantSurname from Assistant", connection);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr[1].ToString() == BusAssistantName.Text && dr[2].ToString() == BusAssistantSurname.Text)
                {
                    LblBusAssistantId.Text = dr[0].ToString();
                }
            }
            connection.Close();
        }
        #endregion
        #region Temizleme İşlemleri
        void TxtCustomerClear()
        {
            CmbCompanyName.Text = "";
            TxtCustomerName.Clear();
            TxtCustomerSurname.Clear();
            TxtCustomerPhone.Clear();
            TxtCustomerEmail.Clear();
            TxtCustomerTC.Clear();
            CmbStratLocation.Text = "";
            CmbFinishLocation.Text = "";
            TxtCustomerTicketPrice.Clear();
            TxtSeatNo.Clear();
            TxtSelectedSeatCount.Clear();
        }
        void TxtAsistantClear()
        {
            TxtAssistantName.Clear();
            TxtAssistantSalary.Clear();
            TxtAssistantSurname.Clear();
            TxtAssistantId.Clear();
        }
        void TxtBusClear()
        {
            CmbBusStartLocation.Text = "";
            CmbBusFinishLocation.Text = "";
            CmbBusTicketPrice.Clear();
            TxtBusDepatureTime.Clear();
            TxtBusBusPlate.Clear();
            CmbBusDriverName.Text = "";
            CmbBusAssistantName.Text = "";
            CmbBusCompany.Text = "";
            LblBusCompany.Text = "Firma Adı";
            LblBusDriverId.Text = "-";
            LblBusAssistantId.Text = "-";

        }
        #endregion
        #region Asistan İşlemleri
        private void BtnAssistantAdder_Click(object sender, EventArgs e)
        {
            if (TxtAssistantName.Text == "" || TxtAssistantSurname.Text == "" || TxtAssistantSalary.Text == "" || CmbAssistantCompanyName.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz","Boş Alan",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand komut;
                komut = new SqlCommand("insert into Assistant([AssistantName],[AssistantSurname],[AssistantSalary],[CompanyId]) values (@assistantname,@assistantsurname,@assistantsalary,@companyid)", connection);

                komut.Parameters.AddWithValue("@assistantname", TxtAssistantName.Text);
                komut.Parameters.AddWithValue("@assistantsurname", TxtAssistantSurname.Text);
                komut.Parameters.AddWithValue("@assistantsalary", TxtAssistantSalary.Text);
                komut.Parameters.AddWithValue("@companyid", CmbAssistantCompanyName.SelectedItem);

                komut.ExecuteNonQuery();
                MessageBox.Show("Muavin Sisteme Eklenmiştir.", "Şoför Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAsistantClear();
                AssistantDataGridViewSelection();
                connection.Close();
            }
            
        }
        private void BtnAssistantRemover_Click(object sender, EventArgs e)
        {
            if (TxtAssistantId.Text == "")
            {
                MessageBox.Show("Lütfen Silinecek Muavini Seçiniz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult message;
                message = MessageBox.Show(TxtAssistantName.Text + " isimli muavini işten çıkartmak istediğinize emin misiniz?", "İşten Çıkarma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand komut = new SqlCommand("delete from Assistant where AssistantId=@value", connection);

                    komut.Parameters.AddWithValue("@value", TxtAssistantId.Text);
                    komut.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Muavin işten çıkarılmıştır.\n(Eğer muavinin yapacağı sefer varsa sefer sonrasında seferi iptal edildiği an itibarıyla ilişkisi kesilecektir.)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AssistantDataGridViewSelection();
                    TxtAsistantClear();
                }
            }
        }
        private void BtnAssistantUpdater_Click(object sender, EventArgs e)
        {
            if (TxtAssistantId.Text == "")
            {
                MessageBox.Show("Lütfen Bilgileri Güncellenicek Olan Muavini Seçiniz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult message;
                message = MessageBox.Show("Muavin ID'si " + TxtAssistantId.Text + " olan muavinin bilgilerini güncellemek istediğinize emin misiniz?", "İşten Çıkarma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand komut;
                    komut = new SqlCommand("update Assistant set [AssistantName]=@assistantname,[AssistantSurname]=@assistantsurname,[AssistantSalary]=@assistantsalary,[CompanyId]=@companyid where AssistantId=@assistantid", connection);

                    komut.Parameters.AddWithValue("@assistantname", TxtAssistantName.Text);
                    komut.Parameters.AddWithValue("@assistantsurname", TxtAssistantSurname.Text);
                    komut.Parameters.AddWithValue("@assistantsalary", TxtAssistantSalary.Text);
                    komut.Parameters.AddWithValue("@assistantid", TxtAssistantId.Text);
                    komut.Parameters.AddWithValue("@companyid", CmbAssistantCompanyName.SelectedItem);

                    if (komut.ExecuteNonQuery() > 0)
                    {
                        AssistantDataGridViewSelection();
                        TxtAsistantClear();
                        MessageBox.Show("Muavinin Bilgileri Başarıyla Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Muavinin Bilgilerini Güncellenirken Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }

        }
        #endregion
        #region DataGridView Tıklanma İşlemleri
        private void DataGridAssistant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int seç = DataGridAssistant.CurrentRow.Index;

            TxtAssistantId.Text = DataGridAssistant.Rows[seç].Cells[0].Value.ToString();
            CmbAssistantCompanyName.Text = DataGridAssistant.Rows[seç].Cells[1].Value.ToString();
            lblAssistantBusPlate.Text = DataGridAssistant.Rows[seç].Cells[2].Value.ToString();
            TxtAssistantName.Text = DataGridAssistant.Rows[seç].Cells[3].Value.ToString();
            TxtAssistantSurname.Text = DataGridAssistant.Rows[seç].Cells[4].Value.ToString();
            TxtAssistantSalary.Text = DataGridAssistant.Rows[seç].Cells[5].Value.ToString();
        }
        private void DataGridBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BusComboBoxDriverControl();
            BusComboBoxAssistantControl();
            int seç = DataGridBus.CurrentRow.Index;
            BusDriverName.Text = DataGridBus.Rows[seç].Cells[9].Value.ToString();
            BusDriverSurname.Text = DataGridBus.Rows[seç].Cells[10].Value.ToString();

            BusAssistantName.Text = DataGridBus.Rows[seç].Cells[12].Value.ToString();
            BusAssistantSurname.Text = DataGridBus.Rows[seç].Cells[13].Value.ToString();

            string DriverNameSurname = DataGridBus.Rows[seç].Cells[9].Value.ToString() + " " + DataGridBus.Rows[seç].Cells[10].Value.ToString();
            string AssistantNameSurname = DataGridBus.Rows[seç].Cells[12].Value.ToString() + " " + DataGridBus.Rows[seç].Cells[13].Value.ToString();

            TxtBusBusPlate.Text = DataGridBus.Rows[seç].Cells[0].Value.ToString();
            TxtBusDepatureTime.Text = DataGridBus.Rows[seç].Cells[1].Value.ToString();
            DtpBusDepatureDate.Text = DataGridBus.Rows[seç].Cells[2].Value.ToString();
            CmbBusStartLocation.Text = DataGridBus.Rows[seç].Cells[3].Value.ToString();
            CmbBusFinishLocation.Text = DataGridBus.Rows[seç].Cells[4].Value.ToString();
            CmbBusCompany.Text = DataGridBus.Rows[seç].Cells[5].Value.ToString();
            CmbBusTicketPrice.Text = DataGridBus.Rows[seç].Cells[7].Value.ToString();
            LblBusDriverId.Text = DataGridBus.Rows[seç].Cells[8].Value.ToString();
            LblBusAssistantId.Text = DataGridBus.Rows[seç].Cells[11].Value.ToString();

            CmbBusDriverName.Text = DriverNameSurname;
            CmbBusAssistantName.Text = AssistantNameSurname;

        }
        private void DataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seç = DataGridCustomer.CurrentRow.Index;

            TxtCustomerTC.Text = DataGridCustomer.Rows[seç].Cells[0].Value.ToString();
            TxtCustomerName.Text = DataGridCustomer.Rows[seç].Cells[1].Value.ToString();
            TxtCustomerSurname.Text = DataGridCustomer.Rows[seç].Cells[2].Value.ToString();
            TxtCustomerPhone.Text = DataGridCustomer.Rows[seç].Cells[3].Value.ToString();
            TxtCustomerEmail.Text = DataGridCustomer.Rows[seç].Cells[4].Value.ToString();
            TxtSeatNo.Text = DataGridCustomer.Rows[seç].Cells[6].Value.ToString();
            switch (DataGridCustomer.Rows[seç].Cells[7].Value.ToString())
            {
                case "06:00":
                    BtnCustomerDepartureTime6.BackColor = Color.Red;
                    break;
                case "08:00":
                    BtnCustomerDepartureTime8.BackColor = Color.Red;
                    break;
                case "10:00":
                    BtnCustomerDepartureTime10.BackColor = Color.Red;
                    break;
                case "12:00":
                    BtnCustomerDepartureTime12.BackColor = Color.Red;
                    break;
                case "14:00":
                    BtnCustomerDepartureTime14.BackColor = Color.Red;
                    break;
                case "16:00":
                    BtnCustomerDepartureTime16.BackColor = Color.Red;
                    break;
                case "18:00":
                    BtnCustomerDepartureTime18.BackColor = Color.Red;
                    break;
                case "20:00":
                    BtnCustomerDepartureTime20.BackColor = Color.Red;
                    break;
                case "22:00":
                    BtnCustomerDepartureTime22.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
            TxtSelectedSeatCount.Text = DataGridCustomer.Rows[seç].Cells[8].Value.ToString();
            TxtCustomerTicketPrice.Text = DataGridCustomer.Rows[seç].Cells[9].Value.ToString();
            CmbCompanyName.Text = DataGridCustomer.Rows[seç].Cells[10].Value.ToString();
            CmbStratLocation.Text = DataGridCustomer.Rows[seç].Cells[11].Value.ToString();
            CmbFinishLocation.Text = DataGridCustomer.Rows[seç].Cells[12].Value.ToString();


            CustomerColorControl();
            CustomerComboBoxCompanyControl();

        }
        #endregion
        #region ComboBox SelectIndexChanged İşlemleri
        private void CmbAssistantCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssistantComboBoxCompanyControl();
        }
        private void CmbBusCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusColorChange();
            BusComboBoxCompanyControl();
            BusDepatureTimeControl();
            BusTicketPriceControl();
            BusComboBoxDriverControl();
            BusComboBoxAssistantControl();
            BusDepartureDateControl();
            CmbBusDriverName.Text = "";
            CmbBusAssistantName.Text = "";
        }
        private void CmbBusFinishLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusDepatureTimeControl();
        }
        private void DtpBusDepatureDate_ValueChanged(object sender, EventArgs e)
        {
            BusDepartureDateControl();
        }
        private void CmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerComboBoxCompanyControl();
        }
        private void CmbBusDriverName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad = CmbBusDriverName.Text.Split(' ')[0].ToString();
            BusDriverName.Text = ad;
            string soyad = CmbBusDriverName.Text.Split(' ')[1].ToString();
            BusDriverSurname.Text = soyad;
            BusDriverIdControl();
        }

        private void CmbBusAssistantName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad = CmbBusAssistantName.Text.Split(' ')[0].ToString();
            BusAssistantName.Text = ad;
            string soyad = CmbBusAssistantName.Text.Split(' ')[1].ToString();
            BusAssistantSurname.Text = soyad;
            BusAssistantIdControl();
        }
        #endregion
        #region Load İşlemleri
        private void AdminForm_Load(object sender, EventArgs e)
        {
            AssistantDataGridViewSelection();
            AssistantComboBoxCompanySelection();
            BusDataGridViewSelection();
            CustomerDataGridViewSelection();
            BusComboBoxDriverControl();
            BusComboBoxAssistantControl();
            Companylister("select *from Company");
            Driverlister("select *from Driver");
        }
        #endregion
        #region Saate Tıklama İşlemleri
        private void BtnDepartureTime6_Click(object sender, EventArgs e)
        {
            TxtBusDepatureTime.Text = BtnDepartureTime6.Text;
        }
        private void BtnDepartureTime8_Click(object sender, EventArgs e)
        {
            TxtBusDepatureTime.Text = BtnDepartureTime8.Text;
        }
        private void BtnDepartureTime10_Click(object sender, EventArgs e)
        {
            TxtBusDepatureTime.Text = BtnDepartureTime10.Text;
        }
        private void BtnDepartureTime12_Click(object sender, EventArgs e)
        {
            TxtBusDepatureTime.Text = BtnDepartureTime12.Text;
        }
        private void BtnDepartureTime14_Click(object sender, EventArgs e)
        {
            TxtBusDepatureTime.Text = BtnDepartureTime14.Text;
        }
        private void BtnDepartureTime16_Click(object sender, EventArgs e)
        {
            TxtBusDepatureTime.Text = BtnDepartureTime16.Text;
        }
        private void BtnDepartureTime18_Click(object sender, EventArgs e)
        {
            TxtBusDepatureTime.Text = BtnDepartureTime18.Text;
        }
        private void BtnDepartureTime20_Click(object sender, EventArgs e)
        {
            TxtBusDepatureTime.Text = BtnDepartureTime20.Text;
        }
        private void BtnDepartureTime22_Click(object sender, EventArgs e)
        {
            TxtBusDepatureTime.Text = BtnDepartureTime22.Text;
        }
        #endregion
        #region Müşteri İşlemleri
        private void BtnVoyageAdder_Click(object sender, EventArgs e)
        {
            if (CmbBusCompany.Text == "" || CmbBusStartLocation.Text == "" || CmbBusFinishLocation.Text == "" || TxtBusDepatureTime.Text == "" || TxtBusBusPlate.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand komut;
                komut = new SqlCommand("insert into Bus([BusPlate],[CompanyId],[DriverId],[AssistantId],[DepartureTime],[DepartureDate],[SeatNumber],[StartLocation],[FinishLocation]) values (@busplate,@companyid,@driverid,@assistantid,@departuretime,@departuredate,@seatnumber,@startlocation,@finishlocation)", connection);

                komut.Parameters.AddWithValue("@companyid", CmbBusCompany.Text);
                komut.Parameters.AddWithValue("@assistantid", LblBusAssistantId.Text);
                komut.Parameters.AddWithValue("@driverid", LblBusDriverId.Text);
                komut.Parameters.AddWithValue("@busplate", TxtBusBusPlate.Text);
                komut.Parameters.AddWithValue("@departuretime", TxtBusDepatureTime.Text);
                komut.Parameters.AddWithValue("@departuredate", Convert.ToDateTime(DtpBusDepatureDate.Text));
                komut.Parameters.AddWithValue("@seatnumber", "");
                komut.Parameters.AddWithValue("@startlocation", CmbBusStartLocation.Text);
                komut.Parameters.AddWithValue("@finishlocation", CmbBusFinishLocation.Text);

                komut.ExecuteNonQuery();
                komut = new SqlCommand("update Assistant set [BusPlate]=@busplate where AssistantName=@assistantname and AssistantSurname=@assistantsurname ", connection);

                komut.Parameters.AddWithValue("@busplate", TxtBusBusPlate.Text);
                komut.Parameters.AddWithValue("@assistantname", BusAssistantName.Text);
                komut.Parameters.AddWithValue("@assistantsurname", BusAssistantSurname.Text);


                komut.ExecuteNonQuery();

                komut = new SqlCommand("update Driver set [BusPlate]=@busplate where DriverName=@drivername and DriverSurname=@driversurname ", connection);

                komut.Parameters.AddWithValue("@busplate", TxtBusBusPlate.Text);
                komut.Parameters.AddWithValue("@drivername", BusDriverName.Text);
                komut.Parameters.AddWithValue("@driversurname", BusDriverSurname.Text);


                komut.ExecuteNonQuery();

                MessageBox.Show("İşlem Başarıyla Gerçekleşmiştir.", "Sefer Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBusClear();
                BusDataGridViewSelection();
                BusColorChange();
                connection.Close();
            }
            
        }
        private void BtnVoyageRemover_Click(object sender, EventArgs e)
        {
            if (CmbBusCompany.Text == "" || CmbBusTicketPrice.Text == "" || TxtBusDepatureTime.Text=="")
            {
                MessageBox.Show("Lütfen İptal Edilecek Seferi Seçiniz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult message;
                message = MessageBox.Show(TxtBusBusPlate.Text + " Plakalı aracın seferini iptal etmek istediğinize emin misiniz?", "Sefer İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand komut;
                    komut = new SqlCommand("delete from Bus where BusPlate=@busplate", connection);

                    komut.Parameters.AddWithValue("@busplate", TxtBusBusPlate.Text);
                    komut.ExecuteNonQuery();

                    komut = new SqlCommand("update Assistant set [BusPlate]=@busplate where AssistantName=@assistantname and AssistantSurname=@assistantsurname ", connection);
                    komut.Parameters.AddWithValue("@busplate", "");
                    komut.Parameters.AddWithValue("@assistantname", BusAssistantName.Text);
                    komut.Parameters.AddWithValue("@assistantsurname", BusAssistantSurname.Text);
                    komut.ExecuteNonQuery();

                    komut = new SqlCommand("update Driver set [BusPlate]=@busplate where DriverName=@drivername and DriverSurname=@driversurname ", connection);
                    komut.Parameters.AddWithValue("@busplate", "");
                    komut.Parameters.AddWithValue("@drivername", BusDriverName.Text);
                    komut.Parameters.AddWithValue("@driversurname", BusDriverSurname.Text);

                    komut.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Sefer iptal edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BusDataGridViewSelection();
                    TxtBusClear();
                    BusColorChange();
                }
            }
            
        }
        private void BtnVoyageUpdater_Click(object sender, EventArgs e)
        {
            if (CmbBusCompany.Text == "" || CmbBusTicketPrice.Text == "" || TxtBusDepatureTime.Text == "")
            {
                MessageBox.Show("Lütfen Güncellenicek Seferi Seçiniz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult message;
                message = MessageBox.Show("Sefer bilgilerini güncellemek istediğinize emin misiniz?", "Sefer Bilgilerini Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand komut;
                    komut = new SqlCommand("update Bus set [BusPlate]=@busplate,[CompanyId]=@companyid,[DriverId]=@driverid,[AssistantId]=@assistantid,[DepartureTime]=@departuretime,[DepartureDate]=@departuredate,[SeatNumber]=@seatnumber,[StartLocation]=@startlocation,[FinishLocation]=@finishlocation where BusPlate=@busplate", connection);

                    komut.Parameters.AddWithValue("@companyid", CmbBusCompany.Text);
                    komut.Parameters.AddWithValue("@assistantid", LblBusAssistantId.Text);
                    komut.Parameters.AddWithValue("@driverid", LblBusDriverId.Text);
                    komut.Parameters.AddWithValue("@busplate", TxtBusBusPlate.Text);
                    komut.Parameters.AddWithValue("@departuretime", TxtBusDepatureTime.Text);
                    komut.Parameters.AddWithValue("@departuredate", Convert.ToDateTime(DtpBusDepatureDate.Text));
                    komut.Parameters.AddWithValue("@seatnumber", "");
                    komut.Parameters.AddWithValue("@startlocation", CmbBusStartLocation.Text);
                    komut.Parameters.AddWithValue("@finishlocation", CmbBusFinishLocation.Text);
                    komut.ExecuteNonQuery();

                    komut = new SqlCommand("update Assistant set [BusPlate]=@busplate where AssistantName=@assistantname and AssistantSurname=@assistantsurname ", connection);
                    komut.Parameters.AddWithValue("@busplate", "");
                    komut.Parameters.AddWithValue("@assistantname", BusAssistantName.Text);
                    komut.Parameters.AddWithValue("@assistantsurname", BusAssistantSurname.Text);
                    komut.ExecuteNonQuery();

                    komut = new SqlCommand("update Driver set [BusPlate]=@busplate where DriverName=@drivername and DriverSurname=@driversurname ", connection);
                    komut.Parameters.AddWithValue("@busplate", "");
                    komut.Parameters.AddWithValue("@drivername", BusDriverName.Text);
                    komut.Parameters.AddWithValue("@driversurname", BusDriverSurname.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Sefer bilgileri başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BusDataGridViewSelection();
                    TxtBusClear();
                    BusColorChange();
                    connection.Close();
                }
            }

        }
        #endregion
        #region Yolcu İşlemleri
        private void BtnClientRemover_Click(object sender, EventArgs e)
        {
            if (CmbCompanyName.Text == "" || TxtCustomerName.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult message;
                message = MessageBox.Show(TxtCustomerName.Text + " Adlı kişinin biletini iptal etmek istediğinize emin misiniz?", "Bilet İptal İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand komut = new SqlCommand("delete from Customer where CustomerName=@customername and CustomerTcId=@customertcid", connection);
                    komut.Parameters.AddWithValue("@customername", TxtCustomerName.Text);
                    komut.Parameters.AddWithValue("@customertcid", TxtCustomerTC.Text);
                    komut.ExecuteNonQuery();
                    TxtCustomerClear();
                    CustomerColorChange();
                    CustomerDataGridViewSelection();
                    MessageBox.Show(TxtCustomerName.Text + " Adlı kişinin bileti başarılı bir şekilde iptal edilmiştir", "Bilet İptal İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();
                }
            }
        }
        #endregion

        private void cleaner()
        {
            TxtCompanyID.Clear();
            TxtCompanyNameProccessor.Clear();
            TxtBusCountProccessor.Clear();
            TxtTicketPrice.Clear();
            TxtDriverName.Clear();
            TxtDriverSurname.Clear();
            TxtDriverSalary.Clear();
            CmbDriverCompName.Text = "";
            TxtDriverBusPlate.Clear();
            TxtDriverId.Clear();
            TxtDriverCompanyId.Clear();
        }

        private void BtnCleaner2_Click(object sender, EventArgs e)
        {
            cleaner();

        }

        private void BtnCleaner_Click(object sender, EventArgs e)
        {
            cleaner();

        }
        private void Companylister(string dataCompany)
        {
            this.DataGridCompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlDataAdapter dataAdapterComp = new SqlDataAdapter(dataCompany, connection);
            DataSet dataSet = new DataSet();
            dataAdapterComp.Fill(dataSet);
            DataGridCompany.DataSource = dataSet.Tables[0];
        }
        private void Driverlister(string dataDriver)
        {
            this.DataGridDriver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlDataAdapter dataAdapterDriver = new SqlDataAdapter(dataDriver, connection);
            DataSet dataSet = new DataSet();
            dataAdapterDriver.Fill(dataSet);
            DataGridDriver.DataSource = dataSet.Tables[0];
        }

        private void BtnCompanyAdder_Click(object sender, EventArgs e)
        {
            if (TxtCompanyNameProccessor.Text == "" || TxtBusCountProccessor.Text == "" || TxtTicketPrice.Text == "")
            {
                MessageBox.Show("Eksik değer girdiniz");
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT *FROM Company WHERE CompanyName LIKE @compname", connection);
                sqlCommand.Parameters.AddWithValue("@compname", TxtCompanyNameProccessor.Text);
                connection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Bu isimde bir firma zaten var!");
                    cleaner();
                }
                else
                {
                    dataReader.Close();
                    SqlCommand command = new SqlCommand("insert into Company (CompanyName,BusCount,BusTicketPrice) values (@name,@bus,@ticketprice)", connection);
                    command.Parameters.AddWithValue("@name", TxtCompanyNameProccessor.Text);
                    command.Parameters.AddWithValue("@bus", TxtBusCountProccessor.Text);
                    command.Parameters.AddWithValue("@ticketprice", TxtTicketPrice.Text);
                    command.ExecuteNonQuery();
                    Companylister("select *from Company");

                    cleaner();
                }

                connection.Close();
            }
        }

        private void DataGridCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCompanyID.Text = DataGridCompany.CurrentRow.Cells[0].Value.ToString();
            TxtCompanyNameProccessor.Text = DataGridCompany.CurrentRow.Cells[1].Value.ToString();
            TxtBusCountProccessor.Text = DataGridCompany.CurrentRow.Cells[2].Value.ToString();
            TxtTicketPrice.Text = DataGridCompany.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnCompanyRemover_Click(object sender, EventArgs e)
        {
            if (TxtCompanyID.Text == "")
            {
                MessageBox.Show("lütfen bir firma seçiniz");
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Company WHERE CompanyId = @value", connection);
                command.Parameters.AddWithValue("@value", Convert.ToInt32(TxtCompanyID.Text));
                command.ExecuteNonQuery();
                connection.Close();
                Companylister("select *from Company");
                MessageBox.Show(TxtCompanyNameProccessor.Text + " Adlı firma silindi");
                cleaner();
            }
        }

        private void BtnCompanyUpdater_Click(object sender, EventArgs e)
        {
            if (TxtCompanyID.Text == "")
            {
                MessageBox.Show("lütfen bir firma seçiniz");
            }
            else
            {
                SqlCommand command = new SqlCommand("UPDATE Company SET CompanyName=@name,BusCount=@bus,BusTicketPrice=@ticketprice WHERE CompanyId=@CompanyIdValue", connection);
                command.Parameters.AddWithValue("@name", TxtCompanyNameProccessor.Text);
                command.Parameters.AddWithValue("@bus", TxtBusCountProccessor.Text);
                command.Parameters.AddWithValue("@ticketprice", TxtTicketPrice.Text);
                command.Parameters.AddWithValue("@CompanyIdValue", TxtCompanyID.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Firma bilgileri güncellenmiştir.");
                Companylister("select *from Company");
                cleaner();
            }
        }

        private void BtnDriverAdder_Click(object sender, EventArgs e)
        {
            if (CmbDriverCompName.Text == "")
            {
                MessageBox.Show("Eksik değer girdiniz");
            }
            else
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Driver (DriverName,DriverSurname,DriverSalary,BusPlate,CompanyId) values (@name,@surname,@salary,@plate,@Id)", connection);
                sqlCommand.Parameters.AddWithValue("@name", TxtDriverName.Text);
                sqlCommand.Parameters.AddWithValue("@surname", TxtDriverSurname.Text);
                sqlCommand.Parameters.AddWithValue("@salary", TxtDriverSalary.Text);
                sqlCommand.Parameters.AddWithValue("@plate", TxtDriverBusPlate.Text);
                sqlCommand.Parameters.AddWithValue("@Id", TxtDriverCompanyId.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Şoför başarıyla işe alındı");
                Driverlister("select *from Driver");
                connection.Close();
                cleaner();
            }
        }

        private void CmbDriverCompName_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from Company where CompanyName like @compname", connection);
            command.Parameters.AddWithValue("@compname", CmbDriverCompName.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                TxtDriverCompanyId.Text = dataReader[0].ToString();
            }
            else
            {
                MessageBox.Show("Böyle bir firma yok");
            }
            connection.Close();
        }

        private void DataGridDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDriverId.Text = DataGridDriver.CurrentRow.Cells[0].Value.ToString();
            TxtDriverCompanyId.Text = DataGridDriver.CurrentRow.Cells[1].Value.ToString();
            TxtDriverBusPlate.Text = DataGridDriver.CurrentRow.Cells[2].Value.ToString();
            TxtDriverName.Text = DataGridDriver.CurrentRow.Cells[3].Value.ToString();
            TxtDriverSurname.Text = DataGridDriver.CurrentRow.Cells[4].Value.ToString();
            TxtDriverSalary.Text = DataGridDriver.CurrentRow.Cells[5].Value.ToString();
        }

        private void BtnDriverRemover_Click(object sender, EventArgs e)
        {
            if (TxtDriverId.Text == "")
            {
                MessageBox.Show("Lütfen bir şoför seçiniz");
            }
            else
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Bus WHERE DriverId=@value2", connection);
                SqlCommand command = new SqlCommand("DELETE FROM Driver WHERE DriverId=@values", connection);
                sqlCommand.Parameters.AddWithValue("@value2", TxtDriverId.Text);
                command.Parameters.AddWithValue("@value", TxtDriverId.Text);
                sqlCommand.ExecuteNonQuery();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Şoför başarıyla işten çıkarıldı");
                Driverlister("select *from Driver");
                cleaner();
            }
        }

        private void BtnDriverUpdater_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE Driver SET CompanyId=@ıd,BusPlate=@plate,DriverName=@name,DriverSurname=@surname,DriverSalary=@salary WHERE DriverId = @DriverId", connection);
            command.Parameters.AddWithValue("@DriverId", TxtDriverId.Text);
            command.Parameters.AddWithValue("@ıd", TxtDriverCompanyId.Text);
            command.Parameters.AddWithValue("@plate", TxtDriverBusPlate.Text);
            command.Parameters.AddWithValue("@name", TxtDriverName.Text);
            command.Parameters.AddWithValue("@surname", TxtDriverSurname.Text);
            command.Parameters.AddWithValue("@salary", TxtDriverSalary.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Şoför bilgileri güncellenmiştir");
            Driverlister("select *from Driver");
            cleaner();
        }

        private void BtnDocument_Click(object sender, EventArgs e)
        {
            Form4 DocumentForm = new Form4();
            this.Hide();
            DocumentForm.Show();
        }

        private void BtnForm4_Click(object sender, EventArgs e)
        {
            Form4 DocumentForm = new Form4();
            this.Hide();
            DocumentForm.Show();
        }

        private void DataGridAssistant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAssistantId.Text = DataGridAssistant.CurrentRow.Cells[0].Value.ToString();
            CmbAssistantCompanyName.Text = DataGridAssistant.CurrentRow.Cells[1].Value.ToString();
            lblAssistantBusPlate.Text = DataGridAssistant.CurrentRow.Cells[2].Value.ToString();
            TxtAssistantName.Text = DataGridAssistant.CurrentRow.Cells[3].Value.ToString();
            TxtAssistantSurname.Text = DataGridAssistant.CurrentRow.Cells[4].Value.ToString();
            TxtAssistantSalary.Text = DataGridAssistant.CurrentRow.Cells[5].Value.ToString();
        }
        /*int seç = DataGridAssistant.CurrentRow.Index;

        TxtAssistantId.Text = DataGridAssistant.Rows[seç].Cells[0].Value.ToString();
            CmbAssistantCompanyName.Text = DataGridAssistant.Rows[seç].Cells[1].Value.ToString();
            lblAssistantBusPlate.Text = DataGridAssistant.Rows[seç].Cells[2].Value.ToString();
            TxtAssistantName.Text = DataGridAssistant.Rows[seç].Cells[3].Value.ToString();
            TxtAssistantSurname.Text = DataGridAssistant.Rows[seç].Cells[4].Value.ToString();
            TxtAssistantSalary.Text = DataGridAssistant.Rows[seç].Cells[5].Value.ToString();*/
    }
}
