using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SQLConnection
{
    public partial class LoginForm: Form
    {
        string connectstring = @"Data Source=ThinkPad-QT\SQLEXPRESS;Integrated Security = True";
        SQLConnection con;
        SQLConnection cmd;
        SQLConnection adt;
        DataTable data;
        private void TestConnection()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                MessageBox.Show("Kết nối thành công đến SQL Server!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message);
            }
        }
    }
    public class PlayerData
    {
        string connectionString = @"Data Source=ThinkPad-QT\SQLEXPRESS;Initial Catalog=GameDB;Integrated Security=True";

        public void SavePlayer(string name, int score, int level)
        {
            string query = "INSERT INTO Players(UserName, TotalScore, Level) VALUES (@name, @score, @level)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@score", score);
                    cmd.Parameters.AddWithValue("@level", level);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}