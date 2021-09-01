using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DesenheAlgo();

        }
        private void DesenheAlgo()
        {
            using (var pincelAzul = new SolidBrush(Color.Blue))
            {
                using (var grafico = CreateGraphics())
                {
                    grafico.FillRectangle(pincelAzul, new Rectangle(10, 10, 100, 100));
                }
            }
        }
    }
}
