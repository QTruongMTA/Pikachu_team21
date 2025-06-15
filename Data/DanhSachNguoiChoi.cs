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
            var topPlayers = allPlayers
                .GroupBy(p => p.Ten())
                .Select(g =>
                {
                    var best = g
                        .OrderByDescending(p => p.Diem())
                        .ThenBy(p => p.Thoigian())
                        .First();
                    return best;
                })
                .OrderByDescending(p => p.Diem())
                .ThenBy(p => p.Thoigian())
                .Take(3)
                .ToList();

            return topPlayers;
        }
    }
}