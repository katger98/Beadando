﻿using System;
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
        int SelectedRow1 = 0;
        int SelectedColumn = 0;
        int SelectedRow2 = 0;
        int[] ShowApp = new int[41];
        int[] ShowAcc = new int[41];
        public Form1()
        {
            InitializeComponent();
            DrawFormElements();
            context.Applications.Load();
            for (int i = 0; i < ShowApp.Length; i++)
            {
                ShowApp[i] = i;
            }
            ListApplications();
        }
        private void DrawFormElements()
        {
            for (int i = 0; i < 4; i++)
            {
                CountButton cb = new CountButton();
                cb.Top = Convert.ToInt32(this.Height * 0.85);
                cb.Left = Convert.ToInt32(this.Width * 0.1) + i * Convert.ToInt32(this.Width * 0.25);
                Controls.Add(cb);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile("images/" + (i + 1).ToString() + ".jpg");
                pictureBox.Height = 100;
                pictureBox.Width = pictureBox.Height;
                pictureBox.Top = Convert.ToInt32(this.Height * 0.67);
                pictureBox.Left = Convert.ToInt32(this.Width * 0.075) + i * Convert.ToInt32(this.Width * 0.25);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(pictureBox);
            }
        }
        private void ListApplications()
        {

            var app = from x in context.Applications
                      where (ShowApp.Contains(x.Id))
                      select new
                      {
                          Sorszám = x.Id,
                          Név = x.Name,
                          Hangszer = (Instruments)x.Instrument,
                          Mű = x.Piece
                      };
            dataGridView1.DataSource = app.ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void ListAccepted()
        {
            var acc = from x in context.Applications
                      where (ShowAcc.Contains(x.Id))
                      select new
                      {
                          Sorszám = x.Id,
                          Név = x.Name,
                          Hangszer = (Instruments)x.Instrument,
                          Mű = x.Piece
                      };
            dataGridView2.DataSource = acc.ToList();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ShowApp[(int)dataGridView1.Rows[SelectedRow1].Cells[0].Value] = 0;
                ShowAcc[(int)dataGridView1.Rows[SelectedRow1].Cells[0].Value] = (int)dataGridView1.Rows[SelectedRow1].Cells[0].Value;
                ListApplications();
                ListAccepted();
                SelectedRow1 = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Üres a jelentkezők táblázata.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedColumn = e.ColumnIndex;
                SelectedRow1 = e.RowIndex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ShowApp[(int)dataGridView2.Rows[SelectedRow2].Cells[0].Value] = (int)dataGridView2.Rows[SelectedRow2].Cells[0].Value;
                ShowAcc[(int)dataGridView2.Rows[SelectedRow2].Cells[0].Value] = 0;
                ListApplications();
                ListAccepted();
                SelectedRow2 = 0;
            }
            catch (Exception)
            {

                MessageBox.Show("Üres a kiválasztottak táblázáta.");
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRow2 = e.RowIndex;
            }
        }
    }
}
