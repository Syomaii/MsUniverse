using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsUniverse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNextT10_Click(object sender, EventArgs e)
        {
            string item = lbTop20.SelectedItem.ToString();
            if (lbTop10.Items.Count < 10 && !lbTop10.Items.Contains(item))
                lbTop10.Items.Add(item);
            else if (lbTop10.Items.Contains(item))
            {

                MessageBox.Show("Error! you already have this country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextT1_Click(object sender, EventArgs e)
        {
            string item = lbTop3.SelectedItem.ToString();
            if (lbTop1.Items.Count < 1 && !lbTop1.Items.Contains(item))
            {
                lbTop1.Items.Add(item);
                lblRes.Visible = true;
                lblRes.Text = "Ms. Universe is Ms. " + item;
            }
            else if (lbTop1.Items.Contains(item))
            {
                MessageBox.Show("Error! you already have this country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextT3_Click(object sender, EventArgs e)
        {
            string item = lbTop10.SelectedItem.ToString();
            if (lbTop3.Items.Count < 3 && !lbTop3.Items.Contains(item))
                lbTop3.Items.Add(item);
            else if (lbTop3.Items.Contains(item))
            {

                MessageBox.Show("Error! you already have this country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbTop20_MouseDoubleClick(object sender, MouseEventArgs e) 
        { 
            string item = lbTop20.SelectedItem.ToString();
            if (lbTop10.Items.Count < 10 && !lbTop10.Items.Contains(item))
                lbTop10.Items.Add(item);
            else if (lbTop10.Items.Contains(item))
            {
                
                MessageBox.Show("Error! you already have this country", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }

        private void lbTop10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string item = lbTop10.SelectedItem.ToString();
            if (lbTop3.Items.Count < 3 && !lbTop3.Items.Contains(item))
                lbTop3.Items.Add(item);
            else if (lbTop3.Items.Contains(item))
            {

                MessageBox.Show("Error! you already have this country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbTop3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string item = lbTop3.SelectedItem.ToString();
            if (lbTop1.Items.Count < 1 && !lbTop1.Items.Contains(item))
            {
                lbTop1.Items.Add(item);
                lblRes.Visible = true;
                lblRes.Text = "Ms. Universe is " + item;
            }
            else if (lbTop1.Items.Contains(item))
            {
                MessageBox.Show("Error! you already have this country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] top20 = File.ReadAllLines(@"top20.txt");
            foreach (string line in top20)
            { 
                lbTop20.Items.Add(line);
            }
        }

        private void btnPrintT10_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"top10.txt", "");
            using (StreamWriter writer = new StreamWriter(@"top10.txt"))
            {
                foreach (string lines in lbTop10.Items)
                {
                    writer.WriteLine(lines);
                }
            }
        }

        private void btnPrintT3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"top3.txt", "");
            using (StreamWriter writer = new StreamWriter(@"top3.txt"))
            {
                foreach (string lines in lbTop3.Items)
                {
                    writer.WriteLine(lines);
                }
            }
        }

        private void btnPrintT1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"MsUniverse.txt", "");
            using (StreamWriter writer = new StreamWriter(@"MsUniverse.txt"))
            {
                foreach (string lines in lbTop1.Items)
                {
                    writer.WriteLine(lines);
                }
            }
        }
    }
}
