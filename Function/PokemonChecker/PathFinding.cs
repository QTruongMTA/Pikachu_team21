using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class PathFinding
    {
        private readonly Dictionary<Point, PictureBox> cellMap;

        public PathFinding(List<PictureBox> pic)
        {
            cellMap = pic
                .Where(cell => cell != null)
                .GroupBy(cell => cell.Location)
                .ToDictionary(g => g.Key, g => g.First());
        }

        public List<List<Point>> FindPaths(Point start, Point end, int maxTurns = 3)
        {
            var result = new List<List<Point>>();
            var queue = new Queue<(Point point, List<Point> path, int turns, int lastDx, int lastDy)>();
            var visited = new HashSet<string>();

            queue.Enqueue((start, new List<Point> { start }, 0, 0, 0));

            while (queue.Count > 0)
            {
                var (current, path, turns, lastDx, lastDy) = queue.Dequeue();

                if (current == end)
                {
                    if (turns <= maxTurns)
                        result.Add(new List<Point>(path));
                    continue;
                }

                foreach (var (dRow, dCol) in new (int, int)[] { (-48, 0), (48, 0), (0, -48), (0, 48) })
                {
                    Point neighbor = new Point(current.X + dRow, current.Y + dCol);
                    if (!cellMap.ContainsKey(neighbor)) continue;
                    if (neighbor != end && Convert.ToInt32(cellMap[neighbor].Tag) != 0) continue;
                    if (path.Contains(neighbor)) continue;

                    int dx = dRow, dy = dCol;
                    int newTurns = (lastDx == 0 && lastDy == 0) || (dx == lastDx && dy == lastDy) ? turns : turns + 1;
                    if (newTurns > maxTurns) continue;

                    string visitKey = $"{neighbor.X},{neighbor.Y},{newTurns},{dx},{dy}";
                    if (visited.Contains(visitKey)) continue;
                    visited.Add(visitKey);

                    var newPath = new List<Point>(path) { neighbor };
                    queue.Enqueue((neighbor, newPath, newTurns, dx, dy));
                }
            }
            return result;
        }
    }
}
