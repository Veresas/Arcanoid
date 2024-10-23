using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid.Contrats.Models
{
    public static class Constants
    {
        public static int LenghtBlocks { get; private set; } = 70;
        public static int HeightBlocks { get; private set; } = 30;
        public static int HeightPlayer { get; private set; } = 80;
        public static int LenghtPlayer { get; private set; } = 90;
        public static int SpeedPlyer { get; private set; } = 1;
        public static int SpeedBall { get; private set; } = 1;
        public static int SizeBall { get; private set; } = 30;
        public static int BlockIndentation { get; private set; } = 10;
        public static int WidowsHeight { get; private set; } = 600;
        public static int WidowsWidht { get; private set; } = 400;
    }
}
