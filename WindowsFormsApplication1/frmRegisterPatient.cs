using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmRegisterPatient : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=E:\\Klinik\\db.accdb");
        public frmRegisterPatient()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string str = "select* from HastaKayit";
            OleDbCommand komut = new OleDbCommand(str, baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
        }

        private void btnShowPatientByDate_Click(object sender, EventArgs e)
        {
            frmListPatients form = new frmListPatients();
            form.ShowDialog(this);
        }

        private void frmRegisterPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            SqlConnection connection = dbConnection.baglanti;
            using (connection)
            {
                connection.Open();
                string insertPatientQuery = "insert into [Patient]([patient_name],[patient_surname],[phone_number],[note])values(@name,@surname,@phone,@note)";


                using (SqlCommand command = new SqlCommand(insertPatientQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", txtPatientName.Text);  // Replace with actual values
                    command.Parameters.AddWithValue("@surname", txtPatientSurname.Text);  // Replace with actual values
                    command.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);  // Replace with actual values
                    command.Parameters.AddWithValue("@note", txtNote.Text);  // Replace with actual values

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            MessageBox.Show("A new patient was added", "Adding new patient",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);
        }

        private void btnCutomerDetails_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnection dbConnection = new DbConnection();
                using (SqlConnection connection = dbConnection.baglanti)
                {
                    using (SqlCommand cmd = new SqlCommand("GetPatientByPhone", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters if needed
                        SqlParameter parameter = new SqlParameter("@phoneNumber", SqlDbType.Text);
                        parameter.Value = (object)txtSearchByPhoneNumber.Text ?? DBNull.Value;
                        cmd.Parameters.Add(parameter);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable != null && dataTable.Rows.Count > 0)
                        {
                            // Instead of creating a DataTable, you can bind the data directly to the DevExpress GridControl
                            grdPatientByPhone.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Appointments are empty");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
