using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItUniver.Calc.Core;
using ConsoleCalc;
using System.Text.RegularExpressions;
using ItUniver.Calc.Core.Interfaces;
using ItUniver.Calc.DB.Models;

namespace ItUniver.Calc.WinFormApp
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();

        public Form1()
        {
            InitializeComponent();

            var operations = calc.GetOperations();

            cbOperations.DataSource = operations;
            cbOperations.DisplayMember = "Name";

            CheckForm();

            // TODO: актуализировать таблицу операций

            lbHistory.Items.AddRange(MyHelper.GetAllHistoryItems().Select(h => $"{h.Operation}({h.Args}) = {h.Result} [ {h.ExecDate} ]").ToArray());

            /*foreach (var item in MyHelper.GetAllOperationItems())
            {
                lbHistory.Items.Add(item.Name);
            }*/
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalculateForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbArgs.Clear();
            tbResult.Clear();
        }

        private double[] ParseArguments(string text)
        {
            bool argsAreValid = ValidateArgs(tbArgs.Text);

            if (!argsAreValid)
                return new double[]{};

            var result = new double[]{};

            result = text.Trim().Split(' ')
                .Select(str => Convert.ToDouble(str))
                .ToArray();

            return result;
        }

        /// <summary>
        /// Считает результат и вносит его в Оутпут
        /// </summary>
        private void CalculateForm()
        {
            bool argsAreValid = ValidateArgs(tbArgs.Text);

            if (!argsAreValid)
                return;

            var operation = cbOperations.SelectedItem as IOperation;
            var args = ParseArguments(tbArgs.Text);

            if (operation == null)
                return;

            var result = operation.Exec(args);

            tbResult.Text = $"{result}";
            MyHelper.AddToHistory(operation.Name, args, result);
            lbHistory.Items.Add($"{result}");
        }

        private void btnLucky_Click(object sender, EventArgs e)
        {
            var random = new Random();
            cbOperations.SelectedIndex = random.Next(cbOperations.Items.Count);
            tbArgs.Text = $"{Math.Round(random.NextDouble(), 3)} {Math.Round(random.NextDouble(), 3)}";
            CalculateForm();
        }

        /// <summary>
        /// Проверяет какие элементы формы должны быть скрыты или покрашены, затем скрывает их или красит
        /// </summary>
        private void CheckForm()
        {
            bool operationIsSelected = cbOperations.SelectedIndex != -1;
            bool argsAreGiven = tbArgs.Text.Trim() != "";
            bool argsAreValid = ValidateArgs(tbArgs.Text);
            bool resultIsWritten = tbResult.Text != "";

            // по умолчанию
            btnLucky.Enabled = true;
            btnReset.Enabled = false;
            btnCalc.Enabled = false;
            tbArgs.ForeColor = Color.Black;
            tbResult.BackColor = SystemColors.Control;

            if (operationIsSelected && argsAreGiven && argsAreValid)
                btnCalc.Enabled = true;

            if (argsAreGiven || resultIsWritten)
                btnReset.Enabled = true;

            if (!argsAreValid)
                tbArgs.ForeColor = Color.Tomato;

            if (resultIsWritten)
                tbResult.BackColor = Color.YellowGreen;
        }

        private bool ValidateArgs(string text)
        {
            if (text.Trim() == "")
                return false;

            Regex regex = new Regex(@"[^\d ,.]");

            return (!regex.IsMatch(text));
        }

        private void cbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void tbArgs_TextChanged(object sender, EventArgs e)
        {
            ArgsChangedTimer.Start();

            CheckForm();
            ArgsChangedTimer.Stop();
            ArgsChangedTimer.Start();
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void ArgsChangedTimer_Tick(object sender, EventArgs e)
        {
            ArgsChangedTimer.Stop();
            CheckForm();
            CalculateForm();
        }
    }
}
