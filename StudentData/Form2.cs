using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentData
{
    public partial class StudentRegister : Form
    {
        SqlConnection sqlConnect = null;

        public StudentRegister()
        {
            InitializeComponent();
        }

        private void OpenConnection()
        {
            string ConnectionStrings = "Data Source=WAJAHAT;Initial Catalog=SMS;Integrated Security=True";
            sqlConnect = new SqlConnection(ConnectionStrings);
            sqlConnect.Open();
        }

        private void clkSave(object sender, EventArgs e)
        {
            OpenConnection();
            string insert = "INSERT INTO tbStdRegister (sName, sEmail, sProgram, sGender) values ('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtProgram.Text + "', '" + cbGender.SelectedItem + "')";
            SqlCommand cmd = new SqlCommand(insert, sqlConnect);
            int row = cmd.ExecuteNonQuery();

            if (row > 0)
            {
                MessageBox.Show("Student Information Saved!", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student Information Saved!", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            sqlConnect.Close();
            this.Close();
        }
    }
}
