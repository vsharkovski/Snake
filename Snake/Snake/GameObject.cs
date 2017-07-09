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
    abstract class GameObject
    {
        public GameObject(string name, Point position)
        {
            Position = position;
            Name = name;
            switch (Name)
            {
                case "SnakePart": BoardSymbol = (int)BoardValue.SnakePart; break;
                case "SnakeHead": BoardSymbol = (int)BoardValue.SnakeHead; break;
                case "Wall": BoardSymbol = (int)BoardValue.Wall; break;
                case "Apple": BoardSymbol = (int)BoardValue.Apple; break;
                case "Orange": BoardSymbol = (int)BoardValue.Orange; break;
                case "Berry": BoardSymbol = (int)BoardValue.Berry; break;
            }
        }

        public Point Position;
        public string Name;
        public int BoardSymbol;
    }
}
