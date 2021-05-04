using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._1_generator
{
    public partial class Form1 : Form
    {
        private const double yes_or_no = 0.5;
        private Random random = new Random();
        private string[] phrases = {"It is certain", "It is decidedly so",
            "As I see it, yes", "Most likely",
            "Reply hazy, try again", "Ask again later",
            " Don’t count on it", "My reply is no" };
        private void YesOrNo()
        {
            if (random.NextDouble() < yes_or_no)
            {
                label1.Text = "No";
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.Text = "Yes";
                label1.ForeColor = Color.Green;

            }
        }
        private int ArrayNumber(double k)
        {
            double last_position = 1;
            double period = last_position / phrases.Length;
            int counter = 0;
            while (true)
            {
                k -= period;
                if (k < 0)
                    break;
                counter++;
            }
            return counter;
        }

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YesOrNo();
            var array_position = ArrayNumber(random.NextDouble());
            label2.Text = phrases[array_position];
        }
    }
}
