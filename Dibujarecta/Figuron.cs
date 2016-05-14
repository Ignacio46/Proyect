using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dibujarecta
{
   abstract class Figuron: IComparable
    {
        protected int X, Y;
        protected Pen pluma;
        protected int ancho, largo;
        protected Color color;
        public SolidBrush brocha;

        public Figuron(int x, int y)
        {
            X = x;
            Y = y;

            brocha = new SolidBrush(Color.White);
            pluma = new Pen(Color.Black);

            Random rnd = new Random();
            ancho = rnd.Next(5, 70);
            largo = ancho;
        }
        public abstract void Dibuja(Form f);

        public int CompareTo(object obj)
        {

            return this.largo.CompareTo(((Figuron)obj).largo);
        }

    }


   class rectangulo : Figuron
   {
       public rectangulo(int x, int y)
           : base(x, y)
       {
       }
       public override void Dibuja(Form f)
       {
           Graphics g = f.CreateGraphics();
           g.DrawRectangle(pluma, this.X, this.Y, ancho, largo);
           g.FillRectangle(brocha, this.X, this.Y, ancho, largo);
       }
   }


   class circulo : Figuron
   {
       public circulo(int x, int y)
           : base(x, y)
       {
       }
       public override void Dibuja(Form f)
       {
           Graphics g = f.CreateGraphics();
           g.DrawEllipse(pluma, this.X, this.Y, ancho, largo);
           g.FillEllipse(brocha, this.X, this.Y, ancho, largo);
       }
   }

}
