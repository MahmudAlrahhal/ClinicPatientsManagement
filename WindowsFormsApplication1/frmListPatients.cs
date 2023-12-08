using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmListPatients : Form
    {


        DataTable tblAppointments = new DataTable();
        //string connectionString = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password;";
        public frmListPatients()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the Edit button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };

            // Create the Delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadAppointmentData();
        }
        private void LoadAppointmentData()
        {
            try
            {
                DbConnection dbConnection = new DbConnection();
                using (SqlConnection connection = dbConnection.baglanti)
                {

                    using (SqlCommand cmd = new SqlCommand("FetchAppointment", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters if needed
                        SqlParameter parameter = new SqlParameter("@AppointmentDate", SqlDbType.DateTime);
                        parameter.Value = (object)DateforAppointments.Text ?? DBNull.Value;
                        cmd.Parameters.Add(parameter);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DataTable tblAppointments = new DataTable();
                        if (dataTable != null && dataTable.Rows.Count > 0)
                        {
                            // Create columns for mergedTable based on existing columns in dataTable
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                tblAppointments.Columns.Add(new DataColumn(column.ColumnName, column.DataType));
                            }
                            // Merge existing appointments with the DataTable containing empty time slots
                            foreach (DataRow appointment in dataTable.Rows)
                            {
                                tblAppointments.ImportRow(appointment);
                            }
                            grdAppointments.DataSource = tblAppointments;
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
        public string appointmentId;
        private void grdAppointments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdAppointments.SelectedRows.Count > 0)
            {
                // Get the first selected row (assuming you have a single selection mode)
                DataGridViewRow selectedRow = grdAppointments.SelectedRows[0];

                // Access data from cells
                appointmentId = selectedRow.Cells["appointment_id"].Value.ToString();
                string appointmentDate = selectedRow.Cells["appointment_date"].Value.ToString();
                string appointmentTime = selectedRow.Cells["appointment_time"].Value.ToString();
                // ... access other columns as needed

                // Now you can use the data as needed
                // For example, display in textboxes or perform some other actions
                txtDate.Text = appointmentDate;
                txtTime.Text = appointmentTime;
                //txtDate.Text = patientName;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int Amount = (Convert.ToInt32(txtTotalPrice.Text))- (Convert.ToInt32(txtPaidAmount.Text));
            
            try
            {
                DbConnection dbConnection = new DbConnection();
                using (SqlConnection connection = dbConnection.baglanti)
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("UpdateAppointment", connection))
                    {
                        if (appointmentId != null)
                        {
                            int doctorID = Convert.ToInt32(txtDrName.Text);
                            string phoneNumber = txtPhoneNumber.Text.ToString();
                            string remainingAmount = Amount.ToString();
                            string paidAmount = txtPaidAmount.Text.ToString();
                            string totalPrice = txtTotalPrice.Text.ToString();
                            int appointmentID = Convert.ToInt32(appointmentId);
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Replace these values with the actual values you want to update
                            cmd.Parameters.AddWithValue("@appointment_id", appointmentID); // Replace with the actual appointment_id
                            cmd.Parameters.AddWithValue("@appointment_date", DateTime.Parse(txtDate.Text));
                            cmd.Parameters.AddWithValue("@appointment_time", TimeSpan.Parse(txtTime.Text));
                            cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                            cmd.Parameters.AddWithValue("@paidAmount", paidAmount);
                            cmd.Parameters.AddWithValue("@remainingAmount", remainingAmount);
                            cmd.Parameters.AddWithValue("@patient_id", phoneNumber); // Replace with the actual patient_id
                            cmd.Parameters.AddWithValue("@doctor_id", doctorID); // Replace with the actual doctor_id

                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Appointment updated successfully!");
                            LoadAppointmentData();
                        }
                        else
                        {
                            MessageBox.Show("Please select an empty appointment from the list");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}

