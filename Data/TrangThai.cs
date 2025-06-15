using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Pikachu_team21
{
    class TrangThai
    {
        private static TrangThai _instance;
        public static TrangThai Instance => _instance ?? (_instance = new TrangThai());

        private readonly string connectionString = @"Data Source=zlap1100\sqlexpress01;Initial Catalog=pikachu21;Integrated Security=True";

        public void SaveGame(string ten, long diem, int capDo, long thoiGianCon, List<PictureBox> picBoxes)
        {
            var stateList = picBoxes.Select(pb => pb.Visible ? 1 : 0).ToList();
            string stateJson = JsonConvert.SerializeObject(stateList);

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO TrangThaiGame (Ten, Diem, CapDo, ThoiGianCon, TrangThaiPicbox) VALUES (@Ten, @Diem, @CapDo, @ThoiGianCon, @TrangThaiPicbox)", conn);
                cmd.Parameters.AddWithValue("@Ten", ten);
                cmd.Parameters.AddWithValue("@Diem", diem);
                cmd.Parameters.AddWithValue("@CapDo", capDo);
                cmd.Parameters.AddWithValue("@ThoiGianCon", thoiGianCon);
                cmd.Parameters.AddWithValue("@TrangThaiPicbox", stateJson);
                cmd.ExecuteNonQuery();
            }
        }

        public (long diem, int capDo, long thoiGianCon, List<dynamic> stateList, string ten) LoadGame(string ten)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT TOP 1 Diem, CapDo, ThoiGianCon, TrangThaiPicbox FROM TrangThaiGame WHERE Ten = @Ten ORDER BY SaveTime DESC", conn);
                cmd.Parameters.AddWithValue("@Ten", ten);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        long diem = reader.GetInt64(0);
                        int capDo = reader.GetInt32(1);
                        long thoiGianCon = reader.GetInt64(2);
                        string stateJson = reader.GetString(3);
                        var stateList = JsonConvert.DeserializeObject<List<dynamic>>(stateJson);
                        return (diem, capDo, thoiGianCon, stateList, ten);
                    }
                }
            }
            return (0, 0, 0, null, null);
        }
    }
}
