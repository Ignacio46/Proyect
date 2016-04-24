using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Dibujarecta
{
    public partial class Form1 : Form
    {
        enum TipoFigura { Rectangulo, Circulo };

       
        private TipoFigura figura_actual;
        private List<Figuron> rectangulos;
        
        public Form1()
        {
            figura_actual = TipoFigura.Circulo;

            rectangulos = new List<Figuron>();
            InitializeComponent();
            circuloToolStripMenuItem.Checked = true;

         }   

        

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {

                contextMenuStrip1.Show(this, e.X, e.Y);
            }
            else if (MouseButtons.Left == e.Button)
            {
                if (figura_actual == TipoFigura.Circulo)
                {
                    circulo c = new circulo(e.X, e.Y);
                    c.Dibuja(this);
                    rectangulos.Add(c);
                }
                else if (figura_actual == TipoFigura.Rectangulo)
                {
                    rectangulo r = new rectangulo(e.X, e.Y);
                    r.Dibuja(this);
                    rectangulos.Add(r);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figuron r in rectangulos)
                r.Dibuja(this);
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.circuloToolStripMenuItem.Checked = true;
            this.rectanguloToolStripMenuItem.Checked = false;
            figura_actual = TipoFigura.Circulo;
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rectanguloToolStripMenuItem.Checked = true;
            this.circuloToolStripMenuItem.Checked = false;
            figura_actual = TipoFigura.Rectangulo;
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
