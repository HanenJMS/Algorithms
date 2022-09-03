using Algorithms.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Form1 : Form
    {
        Client client;
        ProblemController solution;
        Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Client();
            solution = new ProblemController();
            stopwatch = new Stopwatch();
            client.currentSolution = solution;
            solution.SetFibonacci();
            LabelTextUpdate();
            button1.Text = "Enter";
            button2.Text = "Fibonacci";
            button4.Text = "GridTravler";
            button3.Text = "Memoization solution";
            textBox1.Text = "Enter value here";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            LabelTextUpdate();
            stopwatch.Start();
            textBox2.Text = client.Run(textBox1.Text) + "";
            stopwatch.Stop();
            LabelTextUpdate();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            solution.SetFibonacci();
            LabelTextUpdate();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            solution.SetGridTraveler();
            LabelTextUpdate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            solution.ToggleMemo();
            LabelTextUpdate();
        }
        private void LabelTextUpdate()
        {
            label1.Text = $"Current: {solution.GetCurrentSolution()}";
            label2.Text = $"TimeComplexity: {solution.TimeComplexity()}";
            label3.Text = $"SpaceComplexity: {solution.SpaceComplexity()}";
            label4.Text = $"Memoized Solution: {solution.IsMemo}";
            label5.Text = $"Time: {stopwatch.Elapsed.ToString()}";
            label6.Text = $"Instructions: {solution.Instructions()}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


    }
}
