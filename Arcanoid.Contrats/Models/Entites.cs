﻿using Arcanoid.Contrats.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Arcanoid.Contrats.Models
{
    public abstract class Entites
    {
        public Vector Position { get; set; }
        public Rectangle Bounds { get; set; }
    }
}
