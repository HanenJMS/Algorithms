using Algorithms.Controls;
using Algorithms.Problems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Form1 : Form
    {
        Client client;
        ProblemSetter solution;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Client();
            solution = new ProblemSetter();
            solution.SetFibonacci();
            LabelTextUpdate();
            button1.Text = "Enter";
            button2.Text = "Fibonacci";
            textBox1.Text = "Enter value here";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            client.SolutionChange(solution.GetCurrentSolution());
            textBox2.Text = client.Run(textBox1.Text) + "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            solution.SetFibonacci();
            LabelTextUpdate();
        }

        private void LabelTextUpdate()
        {
            label1.Text = $"Current: {solution.GetCurrentSolution()}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
