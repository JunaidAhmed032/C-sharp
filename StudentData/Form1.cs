using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentData
{
    public partial class SMS : Form
    {
        SqlConnection sqlConnect = null;

        public SMS()
        {
            InitializeComponent();
            showStudent.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void clkAddStudent(object sender, EventArgs e)
        {
            StudentRegister stdReg = new StudentRegister();
            stdReg.ShowDialog();
            fetchData();
        }

        private void OpenConnection()
        {
            string ConnectionStrings = "Data Source=WAJAHAT;Initial Catalog=SMS;Integrated Security=True";
            sqlConnect = new SqlConnection(ConnectionStrings);
            sqlConnect.Open();
        }

        private void LoadScreen(object sender, EventArgs e)
        {
            OpenConnection();
            fetchData();
        }

        private void fetchData()
        {
            SqlDataAdapter ShowData = new SqlDataAdapter("SELECT * FROM tbStdRegister", sqlConnect);
            DataSet dt = new DataSet();
            ShowData.Fill(dt, "tbStdRegister");
            showStudent.DataSource = dt.Tables["tbStdRegister"].DefaultView;
            sqlConnect.Close();
        }

        private void CRUD(object sender, DataGridViewCellEventArgs e)
        {
            if (showStudent.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult res = MessageBox.Show("Are you sure to delete?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == res)
                {
                    int id = Convert.ToInt32(showStudent.Rows[e.RowIndex].Cells["sr"].Value);
                    OpenConnection();

                    string deleteQuery = "DELETE FROM tbStdRegister WHERE sId=@id";
                    SqlCommand cmd = new SqlCommand(deleteQuery, sqlConnect);
                    cmd.Parameters.AddWithValue("@id", id);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        fetchData();
                        MessageBox.Show("Data Deleted Succesfully!", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Deleted", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }

            if (showStudent.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int Id = Convert.ToInt32(showStudent.Rows[e.RowIndex].Cells["sr"].Value);
                string Name = Convert.ToString(showStudent.Rows[e.RowIndex].Cells["name"].Value);
                string Email = Convert.ToString(showStudent.Rows[e.RowIndex].Cells["email"].Value);
                string Program = Convert.ToString(showStudent.Rows[e.RowIndex].Cells["program"].Value);
                string Gender = Convert.ToString(showStudent.Rows[e.RowIndex].Cells["gender"].Value);

                UpdateStudent us = new UpdateStudent(Id, Name, Email, Program, Gender);
                us.ShowDialog();
                fetchData();
            }

        }
    }
}
