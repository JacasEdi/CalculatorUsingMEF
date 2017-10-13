using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompositionHelper;

namespace CalculatorUsingMEF
{
    public partial class Form1 : Form
    {
        CalculatorCompositionHelper helper;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DoOperation("Add");
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            DoOperation("Multiply");
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            DoOperation("Subtract");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            DoOperation("Divide");
        }

        private void DoOperation(string operationType)
        {
            helper = new CalculatorCompositionHelper();
            helper.AssembleCalculatorComponents();

            var result = helper.Execute(Convert.ToDouble(textBoxFirstNum.Text),
                Convert.ToDouble(textBoxSecNum.Text), operationType);

            textBoxResult.Text = result.ToString();
        }

    }
}
