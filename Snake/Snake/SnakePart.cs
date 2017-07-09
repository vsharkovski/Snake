using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class SnakePart : GameObject
    {
        public SnakePart(string name, Point position) : base(name, position) { }
    }
}
