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
    class GameStates
    {
        private static GameStates _instance;
        public static GameStates Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameStates();
                }
                return _instance;
            }
        }

        public void SaveGame(string playerName, long score, int level, long timeRemain, int[,] matrix, List<PictureBox> gameCells)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            var cellStates = new List<object>();
            int playableCols = cols - 2;
            for (int i = 0; i < gameCells.Count; i++)
            {
                var pb = gameCells[i];
                int row = (i / playableCols) + 1;
                int col = (i % playableCols) + 1;
                bool visible = pb.Visible;
                int imageIndex = GameMatrix.Instance.GetImageIndex(pb.Image);
                cellStates.Add(new { row, col, visible, imageIndex });
            }

            var saveData = new
            {
                rows,
                cols,
                cellStates
            };
            string matrixJson = Newtonsoft.Json.JsonConvert.SerializeObject(saveData);

            using (var conn = new System.Data.SqlClient.SqlConnection("Data Source=zlap1100\\sqlexpress01;Initial Catalog=pikachu21;Integrated Security=True"))
            {
                conn.Open();
                var cmd = new System.Data.SqlClient.SqlCommand(
                    "INSERT INTO GameState (PlayerName, Score, Level, TimeRemain, MatrixData, SaveTime) VALUES (@PlayerName, @Score, @Level, @TimeRemain, @MatrixData, GETDATE())", conn);
                cmd.Parameters.AddWithValue("@PlayerName", playerName);
                cmd.Parameters.AddWithValue("@Score", score);
                cmd.Parameters.AddWithValue("@Level", level);
                cmd.Parameters.AddWithValue("@TimeRemain", timeRemain);
                cmd.Parameters.AddWithValue("@MatrixData", matrixJson);
                cmd.ExecuteNonQuery();
            }
        }

        public (int score, int level, long timeRemain, int rows, int cols, List<(int row, int col, bool visible, int imageIndex)> cellStates, string name) LoadGame(string playerName)
        {
            using (var conn = new System.Data.SqlClient.SqlConnection("Data Source=zlap1100\\sqlexpress01;Initial Catalog=pikachu21;Integrated Security=True"))
            {
                conn.Open();
                var cmd = new System.Data.SqlClient.SqlCommand(
                    "SELECT TOP 1 Score, Level, TimeRemain, MatrixData FROM GameState WHERE PlayerName = @PlayerName ORDER BY SaveTime DESC", conn);
                cmd.Parameters.AddWithValue("@PlayerName", playerName);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int score = reader.GetInt32(0);
                        int level = reader.GetInt32(1);
                        long timeRemain = reader.GetInt64(2);
                        string matrixJson = reader.GetString(3);

                        dynamic saveData = Newtonsoft.Json.JsonConvert.DeserializeObject(matrixJson);
                        int rows = Convert.ToInt32(saveData.rows);
                        int cols = Convert.ToInt32(saveData.cols);
                        var cellStates = new List<(int row, int col, bool visible, int imageIndex)>();
                        if (saveData.cellStates != null)
                        {
                            foreach (var cell in saveData.cellStates)
                            {
                                int r = Convert.ToInt32(cell.row);
                                int c = Convert.ToInt32(cell.col);
                                bool visible = Convert.ToBoolean(cell.visible);
                                int imageIndex = Convert.ToInt32(cell.imageIndex);
                                cellStates.Add((r, c, visible, imageIndex));
                            }
                        }
                        return (score, level, timeRemain, rows, cols, cellStates, playerName);
                    }
                }
            }
            return (0, 0, 0, 0, 0, new List<(int, int, bool, int)>(), null);
        }
    }
}
