using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_IT6NSI
{
    public partial class Form1 : Form
    {
        ApplicationsEntities context = new ApplicationsEntities();
        public Form1()
        {
            InitializeComponent();
            DrawFormElements();
            ListApplications();

        }
       private void DrawFormElements()
        {
            for (int i = 0; i < 4; i++)
            {
                CountButton cb = new CountButton();
                cb.Top=Convert.ToInt32(this.Height*0.85);
                cb.Left = Convert.ToInt32(this.Width * 0.1) + i * Convert.ToInt32(this.Width * 0.25);
                Controls.Add(cb);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image =Image.FromFile( "images/"+(i+1).ToString() + ".jpg");
                pictureBox.Height = 100;
                pictureBox.Width = pictureBox.Height;
                pictureBox.Top= Convert.ToInt32(this.Height * 0.67);
                pictureBox.Left = Convert.ToInt32(this.Width * 0.075) + i * Convert.ToInt32(this.Width * 0.25);
                pictureBox.SizeMode =PictureBoxSizeMode.StretchImage;
                Controls.Add(pictureBox);
            }
        }
        private void ListApplications()
        {
            context.Applications.Load();
            var app = from x in context.Applications
                      select new
                      {
                          Név = x.Name,
                          Hangszer = (Instruments)x.Instrument,
                          Mű = x.Piece
                      };
            dataGridView1.DataSource = app.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
