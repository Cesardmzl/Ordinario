using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_ORD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            //para delimitar y decir en dónde se va a dibujar//
            papel = pictureBox1.CreateGraphics();
            //para decir con qué se va a dibujar y cómo se va a rellenar//
            SolidBrush rojo = new SolidBrush(Color.DarkRed);
            //para las coordenadas que se van a usar//
            papel.FillRectangle(rojo, 30, 100, 270, 100);
        }
    }
}
