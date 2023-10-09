using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVEDRI_MIDTERM_ACT_3_SOFTWARE_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an array of integers.
            int[] numbers = new int[] { 3, 9, 2, 8, 6, 5 };

            // Use LINQ query syntax to find the number and the square of each number which is more than 20.
            var sqNo = from number in numbers let sqrNo = number * number where sqrNo > 20 select new { Number = number, SqrNo = sqrNo };

            // Display the output
            listBox1.Items.Clear();
            foreach (var item in sqNo)
            {
                listBox1.Items.Add(item);
            }
        }


    }
    }

