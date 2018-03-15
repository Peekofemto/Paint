using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class formPrincipal : Form
    {


        public formPrincipal()
        {
            InitializeComponent();
        }

        Bitmap imagen;

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            imagen = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
        }


        Color ColorBorde;
        private void btnColorDeBorde_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            DialogResult result = colorDeBorde.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                ColorBorde = colorDeBorde.Color;
            }
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = rtbTexto.Font;
            fontDialog1.Color = rtbTexto.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                rtbTexto.Font = fontDialog1.Font;
                rtbTexto.ForeColor = fontDialog1.Color;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imagen, 0, 0, imagen.Width, imagen.Height);
           
 
        }



        private void btnTexto_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            tbCoordenadas.Text = string.Format("punto 1: {0} ,punto 2: {1}", point1, point2);
            tbCoordenadas1.Text = string.Format("X: {0} ,Y: {1}", Cursor.Position.X, Cursor.Position.Y);
            label5.Text = "Color: " + colorDeBorde.Color;
        }




        //DIBUJO DE LINEA
        //Puntos necesarios para la linea, cada uno registrado cada vez que se hace click 
        //en el panel

        private void btnLinea_Click(object sender, EventArgs e)
        {
            
            //Por alguna razón hay un desfase en los puntos y lo tuve que compensar, wth?
            point1.X = point1.X - 100;
            point1.Y = point1.Y - 25;
            point2.X = point2.X - 100;
            point2.Y = point2.Y - 25;
            Graphics g = Graphics.FromImage(imagen);
            
            g.DrawLine(new Pen(ColorBorde, 3), point1, point2);
            panel1.Invalidate();
            
            
        }

        Point point1;
        Point point2;
        int noPuntos = 0;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (noPuntos == 0)
            {
                point1 = new Point(Cursor.Position.X, Cursor.Position.Y);
                noPuntos++;

            }
            else
            {
                point2 = new Point(Cursor.Position.X, Cursor.Position.Y);
                noPuntos++;
            }
            if (noPuntos >= 2)
            {
                noPuntos = 0;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
