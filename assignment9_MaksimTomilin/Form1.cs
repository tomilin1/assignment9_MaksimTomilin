using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment9_MaksimTomilin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.ToString();
            int[] letter = new int[256];
            for (int i = 0; i < input.Length; i++)
            {
                letter[input[i]]++;
            }
            int max = -1;
            char result = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                if (max < letter[input[i]])
                {
                    max = letter[input[i]]; 
                    result = input[i];
                }
            }

            output.Text = result + "\r" + "\n";



        }

        
        }
    }
