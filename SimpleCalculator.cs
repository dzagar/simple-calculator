using System;
using System.Windows.Forms;

namespace dzagar_SE3353_SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        //Global vars
        enum State
        {
            INFIX = 1,
            RPN = 2
        };
        State currentMode = State.INFIX;
        char opr = ' ';
        bool equalsPressed = false, decValue = false;
        double ans = 0, num = 0;
        int d = 1;

        public SimpleCalculator()
        {
            InitializeComponent();
            ResetCalc();
        }

        private void ResetCalc()
        {
            ans = 0;
            num = 0;
            opr = ' ';
            MainTextBox.Text = "0";
        }

        private void OnModeButtonClick(State mode)
        {
            if (mode == State.INFIX)
            {
                currentMode = State.INFIX;
                equalsBtn.Text = "=";
            } else
            {
                currentMode = State.RPN;
                equalsBtn.Text = "Enter";
            }
            ResetCalc();
        }

        private void OnNumberClick(int n)
        {
            if (equalsPressed)
            {
                ResetCalc();
                equalsPressed = false;
            }
            if (decValue)
            {
                num = num + n * (Math.Pow(10, -(d)));
                d++;
            } else
            {
                num = num * 10 + n;
            }
            MainTextBox.Text = num.ToString();
        }

        private double CalculateVal(double number, char operand, double currentAns)
        {
            switch (operand)
            {
                case '+':
                    return currentAns + number;
                case '-':
                    return currentAns - number;
                case '/':
                    return currentAns / number;
                case 'X':
                    return currentAns * number;
                default:
                    return 0;
            }
        }

        private void OnOperatorClick(char operand)
        {
            if (currentMode == State.INFIX)
            {
                if (equalsPressed)
                {
                    equalsPressed = false;
                }
                d = 1;
                decValue = false;
                if (!(opr == ' '))
                {
                    ans = CalculateVal(num, opr, ans);
                } else
                {
                    ans = num;
                }
                opr = operand;
                num = 0;
                MainTextBox.Text = ans.ToString();
            } else
            {
                ans = CalculateVal(num, operand, ans);
                MainTextBox.Text = ans.ToString();
                decValue = false;
                num = 0;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            OnOperatorClick('+');
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            OnOperatorClick('-');
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            OnOperatorClick('X');
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            OnOperatorClick('/');
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (currentMode == State.INFIX)
            {
                equalsPressed = true;
                double temp = CalculateVal(num, opr, ans);
                MainTextBox.Text = temp.ToString();
            } else
            {
                ans = num;
                MainTextBox.Text = ans.ToString();
                num = 0;
            }
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(0);
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(1);
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(2);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(3);
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(4);
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(5);
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(6);
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(7);
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(8);
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            OnNumberClick(9);
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            decValue = true;
        }

        private void RPN_Click(object sender, EventArgs e)
        {
            OnModeButtonClick(State.RPN);
        }

        private void INFIX_Click(object sender, EventArgs e)
        {
            OnModeButtonClick(State.INFIX);
        }

    }
}
