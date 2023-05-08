using System.Text;
using System.Collections.Generic;

namespace VSDemo
{
    public partial class Form1 : Form
    {

        public string prevTextBox = "";
        public Form1()
        {
            InitializeComponent();
        }

        private string[] _operators = { "-", "+", "/", "*", "^" };

        private Func<double, double, double>[] _operations = {
            (a1, a2) => a1 - a2,
            (a1, a2) => a1 + a2,
            (a1, a2) => a1 / a2,
            (a1, a2) => a1 * a2,
            (a1, a2) => Math.Pow(a1, a2)
        };

        public List<string> GetTokens(string input)
        {
            string operators = "()^*/+-";
            List<string> tokens = new List<string>();
            StringBuilder sb = new StringBuilder();

            foreach (char c in input.Replace(" ", string.Empty))
            {
                if (operators.IndexOf(c) >= 0)
                {
                    if ((sb.Length > 0))
                    {
                        tokens.Add(sb.ToString());
                        sb.Length = 0;
                    }
                    tokens.Add(c.ToString());
                }
                else
                {
                    sb.Append(c);
                }
            }

            if ((sb.Length > 0))
            {
                tokens.Add(sb.ToString());
            }

            return tokens;
        }

        private string getSubExpression(List<string> tokens, ref int index)
        {
            StringBuilder subExpr = new StringBuilder();
            int parenlevels = 1;
            index += 1;
            while (index < tokens.Count && parenlevels > 0)
            {
                string token = tokens[index];
                if (tokens[index] == "(")
                {
                    parenlevels += 1;
                }

                if (tokens[index] == ")")
                {
                    parenlevels -= 1;
                }

                if (parenlevels > 0)
                {
                    subExpr.Append(token);
                }

                index += 1;
            }

            if ((parenlevels > 0))
            {
                throw new ArgumentException();
            }
            return subExpr.ToString();
        }

        public double Calculate(string input)
        {
            try
            {
                List<string> tokens = GetTokens(input);
                Stack<double> operandStack = new Stack<double>();
                Stack<string> operatorStack = new Stack<string>();
                int tokenIndex = 0;

                while (tokenIndex < tokens.Count)
                {
                    string token = tokens[tokenIndex];
                    if (token == "(")
                    {
                        string subExpr = getSubExpression(tokens, ref tokenIndex);
                        operandStack.Push(Calculate(subExpr));
                        continue;
                    }
                    if (token == ")")
                    {
                        throw new ArgumentException();
                    }
                    if (Array.IndexOf(_operators, token) >= 0)
                    {
                        while (operatorStack.Count > 0 && Array.IndexOf(_operators, token) < Array.IndexOf(_operators, operatorStack.Peek()))
                        {
                            string op = operatorStack.Pop();
                            double arg2 = operandStack.Pop();
                            double arg1 = operandStack.Pop();
                            operandStack.Push(_operations[Array.IndexOf(_operators, op)](arg1, arg2));
                        }
                        operatorStack.Push(token);
                    }
                    else
                    {
                        operandStack.Push(double.Parse(token));
                    }
                    tokenIndex += 1;
                }

                while (operatorStack.Count > 0)
                {
                    string op = operatorStack.Pop();
                    double arg2 = operandStack.Pop();
                    double arg1 = operandStack.Pop();
                    operandStack.Push(_operations[Array.IndexOf(_operators, op)](arg1, arg2));
                }
                return operandStack.Pop();
            }
            catch
            {
                return 8361375334787046697;
            }
        }


        private void btn_equals_Click(object sender, EventArgs e)
        {
            double calc = Calculate(input_display.Text);
            if (calc == 8361375334787046697)
            {
                input_display.Text = "Error";
                return;
            }
            input_display.Text = Calculate(input_display.Text).ToString();
        }

        private void input_display_TextChanged(object sender, EventArgs e)
        {
            if(prevTextBox == "Error")
            {
                input_display.Text = "";
            }
            prevTextBox = input_display.Text;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            input_display.Text += "+";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            input_display.Text += "-";
        }

        private void btn_ob_Click(object sender, EventArgs e)
        {
            input_display.Text += "(";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            input_display.Text = input_display.Text.Remove(input_display.Text.Length - 1, 1);
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            input_display.Text += "*";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            input_display.Text += "/";
        }

        private void btn_cb_Click(object sender, EventArgs e)
        {
            input_display.Text += ")";
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            input_display.Text = "";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            input_display.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            input_display.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            input_display.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            input_display.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            input_display.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            input_display.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            input_display.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            input_display.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            input_display.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            input_display.Text += "0";
        }

        private void btn_rty_Click(object sender, EventArgs e)
        {
            input_display.Text = "(" + input_display.Text + ")" + "^";
        }

        private void btn_rt_Click(object sender, EventArgs e)
        {
            input_display.Text += "^";
        }
    }
}