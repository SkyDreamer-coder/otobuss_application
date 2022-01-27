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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-034MF6P;Initial Catalog=BusProgram;Integrated Security=True");
        private void company_list(string dataroad)
        {
            this.DatagridCompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlDataAdapter dataAdapterCOMP = new SqlDataAdapter(dataroad, connection);
            DataSet dataSet = new DataSet();
            dataAdapterCOMP.Fill(dataSet);
            DatagridCompany.DataSource = dataSet.Tables[0];
        }
        private void driver_list(string dataroad)
        {
            this.DatagridDriver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlDataAdapter dataAdapterDRIVER = new SqlDataAdapter(dataroad, connection);
            DataSet dataSet = new DataSet();
            dataAdapterDRIVER.Fill(dataSet);
            DatagridDriver.DataSource = dataSet.Tables[0];
        }
        private void assistant_list(string dataroad)
        {
            this.DatagridAssistant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlDataAdapter dataAdapterASSISTANT = new SqlDataAdapter(dataroad, connection);
            DataSet dataSet = new DataSet();
            dataAdapterASSISTANT.Fill(dataSet);
            DatagridAssistant.DataSource = dataSet.Tables[0];
        }
        private void company_text(string dataroad)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(dataroad, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                TxtSumComp.Text = dataReader[0].ToString();
                TxtAVGComp.Text = dataReader[1].ToString();
                TxtCountComp.Text = dataReader[2].ToString();
            }
            connection.Close();
        }
        private void driver_text(string dataroad)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(dataroad, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                TxtSumDriver.Text = dataReader[0].ToString();
                TxtAVGDriver.Text = dataReader[1].ToString();
                TxtCountDriver.Text = dataReader[2].ToString();
            }
            connection.Close();
        }
        private void assitant_text(string dataroad)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(dataroad, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                TxtSumAssistant.Text = dataReader[0].ToString();
                TxtAVGAssistant.Text = dataReader[1].ToString();
                TxtCountAssistant.Text = dataReader[2].ToString();
            }
            connection.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            company_list("exec COMP_REPORT_LIST");
            company_text("exec COMP_REPORT");
            driver_list("exec DRIVER_REPORT_LIST");
            driver_text("exec DRIVER_REPORT");
            assistant_list("exec ASSIST_REPORT_LIST");
            assitant_text("exec ASSIST_REPORT");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.Show();
        }
    }
}
