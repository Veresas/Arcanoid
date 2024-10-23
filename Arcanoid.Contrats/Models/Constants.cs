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
        public static int HeightPlayer { get; private set; } = 20;
        public static int LenghtPlayer { get; private set; } = 90;
        public static int SpeedPlyer { get; private set; } = 3;
        public static int SpeedBall { get; private set; } = 5;
        public static int SizeBall { get; private set; } = 20;
        public static int BlockIndentation { get; private set; } = 10;
        public static int WidowsHeight { get; private set; } = 600;
        public static int WidowsWidht { get; private set; } = 400;
        public static int CountBlokcInColumn { get; private set; } = 3;
        public static int CountBlokcInRow { get; private set; } = 5;

    }
    
}
