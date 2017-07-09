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
    class Food : GameObject
    {
        public Food(int id, Point position, int nutrition, int lifespan) : base(FoodService.GetName(id), position)
        {
            Id_real = id;
            Nutrition_real = nutrition;
            LifeSpan_real = lifespan;
        }

        private int Id_real;
        private int Nutrition_real;
        private int LifeSpan_real;

        public int Id { get => Id_real; }
        public int Nutrition { get => Nutrition_real; }
        public int LifeSpan { get => LifeSpan_real; }
    }
}
