using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool isDarkTheme = true; 

        public Form1()
        {
            InitializeComponent();
            
            ApplyTheme();
        }

        //  (0-9) 
        private void button_click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (isOperationPerformed))
                txtDisplay.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == "." && txtDisplay.Text.Contains("."))
                return;

            txtDisplay.Text = txtDisplay.Text + button.Text;
        }

        //  (+, -, X, /)
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                lblOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txtDisplay.Text);
                lblOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        //  CE (Очистить поле)
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        // C (Полный сброс)
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
            lblOperation.Text = "";
        }

        //  (<) - Backspace
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        // (=)
        private void btnEqual_Click(object sender, EventArgs e)
        {
            Double secondNum = Double.Parse(txtDisplay.Text);
            Double finalResult = 0;

            switch (operationPerformed)
            {
                case "+":
                    finalResult = resultValue + secondNum;
                    break;
                case "-":
                    finalResult = resultValue - secondNum;
                    break;
                case "X": 
                    finalResult = resultValue * secondNum;
                    break;
                case "/":
                    if (secondNum == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    finalResult = resultValue / secondNum;
                    break;
                default:
                    break;
            }

            txtDisplay.Text = finalResult.ToString();

            
            if (lstHistory != null)
            {
                lstHistory.Items.Insert(0, $"{resultValue} {operationPerformed} {secondNum} = {finalResult}");
            }

            resultValue = finalResult;
            lblOperation.Text = "";
        }

        
        private void btnTheme_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (isDarkTheme)
            {
                // ТЕМНАЯ ТЕМА
                this.BackColor = Color.FromArgb(32, 32, 32);
                txtDisplay.BackColor = Color.FromArgb(32, 32, 32);
                txtDisplay.ForeColor = Color.White;
                if (lstHistory != null) lstHistory.BackColor = Color.FromArgb(50, 50, 50);
                if (lstHistory != null) lstHistory.ForeColor = Color.White;

                foreach (Control c in this.Controls)
                {
                    if (c is Button btn)
                    {
                        
                        btn.BackColor = Color.FromArgb(50, 50, 50);
                        btn.ForeColor = Color.White;

                        
                        if (btn.Name == "btnPlus" || btn.Name == "btnMinus" || btn.Name == "btnMult" || btn.Name == "btnDiv")
                        {
                            btn.ForeColor = Color.DarkOrange;
                            btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        }
                        if (btn.Name == "btnEqual")
                        {
                            btn.BackColor = Color.DarkOrange;
                            btn.ForeColor = Color.White;
                        }
                        if (btn.Name == "btnTheme")
                        {
                            btn.ForeColor = Color.Gold;
                        }
                    }
                }
            }
            else
            {
                // СВЕТЛАЯ ТЕМА
                this.BackColor = Color.WhiteSmoke;
                txtDisplay.BackColor = Color.WhiteSmoke;
                txtDisplay.ForeColor = Color.Black;
                if (lstHistory != null) lstHistory.BackColor = Color.White;
                if (lstHistory != null) lstHistory.ForeColor = Color.Black;

                foreach (Control c in this.Controls)
                {
                    if (c is Button btn)
                    {
                        btn.BackColor = Color.Gainsboro;
                        btn.ForeColor = Color.Black;
                       
                        if (btn.Name == "btnEqual")
                        {
                            btn.BackColor = Color.Orange;
                            btn.ForeColor = Color.White;
                        }
                    }
                }
            }
        }
    }
}