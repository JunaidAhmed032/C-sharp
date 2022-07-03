using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentData
{
    public partial class UpdateStudent : Form
    {
        int oId;
        string oName;
        string oEmail;
        string oProgram;
        string oGender;

        SqlConnection sqlConnect = null;

        public UpdateStudent(int Id, string Name, string Email, string Program, string Gender)
        {
            InitializeComponent();
            oId = Id;
            oName = Name;
            oEmail = Email;
            oProgram = Program;
            oGender = Gender;
        }

        private void OpenConnection()
        {
            string ConnectionStrings = "Data Source=WAJAHAT;Initial Catalog=SMS;Integrated Security=True";
            sqlConnect = new SqlConnection(ConnectionStrings);
            sqlConnect.Open();
        }

        private void clkUpdate(object sender, EventArgs e)
        {
            oName = txtName.Text;
            oEmail = txtEmail.Text;
            oProgram = txtProgram.Text;
            oGender = cbGender.SelectedItem.ToString();

            OpenConnection();
            string updateQuery = "UPDATE tbStdRegister SET sName=@name, sEmail=@email, sProgram=@program, sGender=@gender WHERE sId=@id";
            SqlCommand cmd = new SqlCommand(updateQuery, sqlConnect);
            cmd.Parameters.AddWithValue("@id", oId);
            cmd.Parameters.AddWithValue("@name", oName);
            cmd.Parameters.AddWithValue("@email", oEmail);
            cmd.Parameters.AddWithValue("@program", oProgram);
            cmd.Parameters.AddWithValue("@gender", oGender);

            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Data Updated Succesfully!", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Data Not Updated", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnect.Close();
            this.Close();
        }

        private void LoadScreen(object sender, EventArgs e)
        {
            txtName.Text = oName.ToString();
            txtEmail.Text = oEmail.ToString();
            txtProgram.Text = oProgram.ToString();
            cbGender.SelectedItem = oGender;
        }
    }
}
