using System.Globalization;
using System.Collections.Generic;

namespace lesson1
{
    public partial class frmCalculator : Form
    {
        private MyMath clsMath = new MyMath();
        private double firstArgument;
        private string selectedAction;
        private double secondArgument;
        private double outputCount;
        private bool hasFirstArgument;
        private bool executed = false;
        private readonly Queue<PendingOperation> operationQueue = new();

        private sealed record PendingOperation(string Action, double SecondArgument);

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKeypadClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (executed == true)
            {
                ResetCalculator();
            }

            switch (btn.Name)
            {
                case "btnDot":
                    if (txtDisplay.Text.IndexOf(".") > 0)
                        return;
                    break;
            }
            txtDisplay.Text += btn.Text;
        }

        private void btnKeypadOperationClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Name == "btnReset")
            {
                ResetCalculator();
                return;
            }
            if (btn.Name == "btnExec")
            {
                if (!hasFirstArgument || selectedAction == null || txtDisplay.Text == "")
                    return;

                secondArgument = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
                operationQueue.Enqueue(new PendingOperation(selectedAction, secondArgument));
                txtDisplay.Text = "";

                outputCount = firstArgument;
                while (operationQueue.Count > 0)
                {
                    var operation = operationQueue.Dequeue();
                    outputCount = ApplyOperation(operation.Action, outputCount, operation.SecondArgument);
                }

                labelStatus.Text += $" {secondArgument} = {outputCount}";
                executed = true;
                return;
            }

            switch (btn.Name)
            {
                case "btnPercent":
                    if (executed == true) return;
                    var inputCount = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
                    labelStatus.Text = $"{inputCount / 100}";
                    return;
                case "btnMinus":
                case "btnPlus":
                case "btnDiv":
                case "btnMul":
                    if (executed == true || txtDisplay.Text == "")
                        return;
                    break;
            }

            if (executed == false)
            {
                if (!hasFirstArgument)
                {
                    firstArgument = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
                    hasFirstArgument = true;
                    labelStatus.Text = $"{firstArgument} {btn.Text}";
                }
                else
                {
                    secondArgument = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
                    operationQueue.Enqueue(new PendingOperation(selectedAction, secondArgument));
                    labelStatus.Text += $" {secondArgument} {btn.Text}";
                }

                selectedAction = btn.Name;
                txtDisplay.Text = "";
            }
        }

        private double ApplyOperation(string action, double leftArgument, double rightArgument)
        {
            return action switch
            {
                "btnMinus" => clsMath.Minus(leftArgument, rightArgument),
                "btnPlus" => clsMath.Plus(leftArgument, rightArgument),
                "btnDiv" => clsMath.Div(leftArgument, rightArgument),
                "btnMul" => clsMath.Mul(leftArgument, rightArgument),
                _ => throw new InvalidOperationException($"Unknown operation: {action}")
            };
        }

        private void ResetCalculator()
        {
            txtDisplay.Text = "";
            labelStatus.Text = "";
            firstArgument = 0;
            secondArgument = 0;
            outputCount = 0;
            selectedAction = null;
            hasFirstArgument = false;
            executed = false;
            operationQueue.Clear();
        }
    }
}
