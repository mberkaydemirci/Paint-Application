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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ciz, boyama;
        int baslax, baslay;
        int kalınlık=3;
        ColorDialog renksec = new ColorDialog();
        


        private void button1_Click(object sender, EventArgs e)
        {
            renksec.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog renkler = new ColorDialog();
            renkler.Color = richTextBox1.SelectionColor;
            if(renkler.ShowDialog()==System.Windows.Forms.DialogResult.OK && renkler.Color != richTextBox1.SelectionColor)
            {
                richTextBox1.SelectionColor = renkler.Color;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        ciz = true;
                baslax = e.X;
                baslay = e.Y;
           
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(renksec.Color, kalınlık);
            Point point1 = new Point(baslax,baslay);
            Point point2 = new Point(e.X, e.Y);
            
                if (ciz == true)
                {
                    g.DrawLine(p, point1, point2);
                    baslax = e.X;
                    baslay = e.Y;
                }
                if(boyama == true)
            {
                Brush firca = new SolidBrush(renksec.Color);
                g.FillEllipse(firca,20,30,20,30);
            }
            }
           


        

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalınlık = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            
        }

        private void renkSeçmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renksec.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void şekilÇizmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yuvarlakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Purple, 5);
            Graphics g = this.CreateGraphics();
            Rectangle dikdortgen = new Rectangle(154, 164, 300, 300);
            g.DrawEllipse(p, 154, 164, 300, 300);
        }

        private void sürprizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Graphics g;
            g = this.CreateGraphics();
            Color[] renkler = new Color[3];
            renkler[0] = Color.Red;
            renkler[1] = Color.Blue;
            renkler[2] = Color.Green;
            Brush firca = new SolidBrush(renkler[r.Next(3)]);
            int h = r.Next(20, 51);
            int w = r.Next(20, 51);
            int pw = this.Width;
            int ph = this.Height;
            g.FillEllipse(firca, r.Next(0, pw - w), r.Next(0, ph - h), w, h);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boyasızRasgeleYuvarlakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            Pen firca1 = new Pen(System.Drawing.Color.Blue, 5);
            g.DrawRectangle(firca1, 20, 100, 100, 100);
        }

        private void arkaPlanDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult renkler;
            renkler = colorDialog1.ShowDialog();
            if (renkler == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
       
    }
}
