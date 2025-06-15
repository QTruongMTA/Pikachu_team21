using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace Pikachu_team21
{
    class DanhSachNguoiChoi
    {
        private static string connectionString = "Data Source=zlap1100\\sqlexpress01;Initial Catalog=pikachu21;Integrated Security=True";

        public DanhSachNguoiChoi()
        {

        }
        public static List<Player> GetPlayers()
        {
            var result = new List<Player>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    SELECT Ten, Diem, ThoiGianCon
                    FROM TrangThaiGame
                ", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var player = new Player();
                        player.SetTen(reader.GetString(0));
                        player.SetDiem(reader.GetInt64(1));
                        player.SetThoigian(reader.GetInt64(2));
                        result.Add(player);
                    }
                }
            }
            return result;
        }

        public static List<Player> GetTop3(List<Player> allPlayers)
        {
            // Lấy bản ghi tốt nhất của mỗi người chơi
            var bestOfEach = allPlayers
                .GroupBy(p => p.Ten())
                .Select(g => g
                    .OrderByDescending(p => p.Diem())
                    .ThenByDescending(p => p.Thoigian()) // Thời gian còn lại nhiều hơn thì xếp trên
                    .First())
                .ToList();

            // Sắp xếp lại toàn bộ danh sách này theo điểm giảm dần, thời gian còn lại giảm dần
            var topPlayers = bestOfEach
                .OrderByDescending(p => p.Diem())
                .ThenByDescending(p => p.Thoigian())
                .Take(3)
                .ToList();

            return topPlayers;
        }
    }
}