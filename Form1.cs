using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAluclator
{
    public partial class Form1 : Form
    {

        Panel p1 = new Panel();
        Panel p2 = new Panel();
        Panel p3 = new Panel();
        Button x1 = new Button();
        Button x2 = new Button();
        Button x3 = new Button();
        Button x4 = new Button();
        Button x5 = new Button();
        Button x6 = new Button();
        Button x7 = new Button();
        Button x8 = new Button();
        Button x9 = new Button();
        Button x0 = new Button();
        Button xnot = new Button();
        Button mult = new Button();
        Button sum = new Button();
        Button sub = new Button();
        Button div = new Button();
        Button mod = new Button();
        Button equal = new Button();
        Button clear = new Button();
        TextBox dis = new TextBox();
        Label labelCurrentOperation = new Label();


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Enable key preview to capture key events at the form level
            this.KeyDown += new KeyEventHandler(Form1_KeyDown); // Attach KeyDown event handler


           
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            // Set the form border style to FixedDialog to make the form non-resizable.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.Size = new Size(410, 630);

            this.Text = "Calculator";
            this.Controls.Add(p1);
            this.Controls.Add(p2);
            this.Controls.Add(p3);
            this.Controls.Add(dis);
            this.Controls.Add(labelCurrentOperation);

            //create upper
            p1.Controls.Add(equal);
            p1.Controls.Add(clear);
            p1.Controls.Add(mod);
            p1.Size = new Size(340, 70);

            p1.Location = new Point(30, 180);
            //create upper operation
            equal.Size = new Size(80, 70);
            equal.Text = "=";
            equal.Font = new Font("Arial", 15, FontStyle.Bold);
            equal.BackColor = Color.LightGray;
            equal.FlatStyle = FlatStyle.Flat;
            equal.FlatAppearance.BorderSize = 0;
            equal.Click += new EventHandler(EqualsButtonClick);

            mod.Size = new Size(80, 70);
            mod.Text = "%";
            mod.Location = new Point(85, 0);
            mod.BackColor = Color.LightGray;
            mod.Font = new Font("Arial", 15, FontStyle.Bold);
            mod.Click += new EventHandler(OperationButtonClick);
            mod.FlatStyle = FlatStyle.Flat;
            mod.FlatAppearance.BorderSize = 0;
            clear.Size = new Size(165, 70);
            clear.Text = "AC";
            clear.Location = new Point(170, 0);
            clear.Font = new Font("Arial", 15, FontStyle.Bold);
            clear.BackColor = Color.LightGray;
            clear.FlatStyle = FlatStyle.Flat;
            clear.FlatAppearance.BorderSize = 0;
            clear.Click += new EventHandler(ClearButtonClick);
            //clear.Click += new EventHandler(button5_Click);
            //create text
            dis.Location = new Point(30, 50);
            dis.BackColor = Color.Black;
            dis.Size = new Size(340, 300);
            dis.BorderStyle = BorderStyle.None;
            dis.BringToFront();
            dis.ForeColor = Color.White;
            Font currentFont = dis.Font;
            dis.ReadOnly = true;
            this.dis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // Create a new font with bold style and an increased size
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size + 25, FontStyle.Bold);
            // Set the control's font to the new font
            dis.Font = newFont;
            //create p2
            p2.Controls.Add(x1);
            p2.Controls.Add(x2);
            p2.Controls.Add(x3);
            p2.Controls.Add(x4);
            p2.Controls.Add(x5);
            p2.Controls.Add(x6);
            p2.Controls.Add(x7);
            p2.Controls.Add(x8);
            p2.Controls.Add(x9);
            p2.Controls.Add(x0);
            p2.Controls.Add(xnot);

            p2.Size = new Size(250, 300);

            p2.Location = new Point(30, 260);
            x1.Size = new Size(80, 70);
            x1.Text = "1";
            x1.BackColor = Color.DimGray;
            x1.ForeColor = Color.White;
            x1.Click += new EventHandler(btn);
            x1.Font = new Font("Arial", 15, FontStyle.Bold);
            x1.FlatStyle = FlatStyle.Flat;
            x1.FlatAppearance.BorderSize = 0;
            x2.Size = new Size(80, 70);
            x2.Text = "2";
            x2.Location = new Point(85, 0);
            x2.BackColor = Color.DimGray;
            x2.ForeColor = Color.White;
            x2.Click += new EventHandler(btn);
            x2.Font = new Font("Arial", 15, FontStyle.Bold);
            x2.FlatStyle = FlatStyle.Flat;
            x2.FlatAppearance.BorderSize = 0;
            x3.Size = new Size(80, 70);
            x3.Text = "3";
            x3.Location = new Point(170, 0);
            x3.BackColor = Color.DimGray;
            x3.ForeColor = Color.White;
            x3.Click += new EventHandler(btn);
            x3.Font = new Font("Arial", 15, FontStyle.Bold);
            x3.FlatStyle = FlatStyle.Flat;
            x3.FlatAppearance.BorderSize = 0;
            x4.Size = new Size(80, 70);
            x4.Text = "4";
            x4.BackColor = Color.DimGray;
            x4.Location = new Point(0, 75);
            x4.ForeColor = Color.White;
            x4.Font = new Font("Arial", 15, FontStyle.Bold);
            x4.Click += new EventHandler(btn);
            x4.FlatStyle = FlatStyle.Flat;
            x4.FlatAppearance.BorderSize = 0;
            x5.Size = new Size(80, 70);
            x5.Text = "5";
            x5.Font = new Font("Arial", 15, FontStyle.Bold);
            x5.Location = new Point(85, 75);
            x5.BackColor = Color.DimGray;
            x5.ForeColor = Color.White;
            x5.FlatStyle = FlatStyle.Flat;
            x5.FlatAppearance.BorderSize = 0;
            x5.Click += new EventHandler(btn);
            x6.Size = new Size(80, 70);
            x6.Font = new Font("Arial", 15, FontStyle.Bold);
            x6.Text = "6";
            x6.Location = new Point(170, 75);
            x6.BackColor = Color.DimGray;
            x6.ForeColor = Color.White;
            x6.FlatStyle = FlatStyle.Flat;
            x6.FlatAppearance.BorderSize = 0;
            x6.Click += new EventHandler(btn);
            x7.Size = new Size(80, 70);
            x7.Font = new Font("Arial", 15, FontStyle.Bold);
            x7.Text = "7";
            x7.BackColor = Color.DimGray;
            x7.Location = new Point(0, 150);
            x7.ForeColor = Color.White;
            x7.FlatStyle = FlatStyle.Flat;
            x7.FlatAppearance.BorderSize = 0;
            x7.Click += new EventHandler(btn);
            x8.Size = new Size(80, 70);
            x8.Text = "8";
            x8.Location = new Point(85, 150);
            x8.BackColor = Color.DimGray;
            x8.Font = new Font("Arial", 15, FontStyle.Bold);
            x8.ForeColor = Color.White;
            x8.FlatStyle = FlatStyle.Flat;
            x8.FlatAppearance.BorderSize = 0;
            x8.Click += new EventHandler(btn);
            x9.Size = new Size(80, 70);
            x9.Text = "9";
            x9.Location = new Point(170, 150);
            x9.BackColor = Color.DimGray;
            x9.ForeColor = Color.White;
            x9.Click += new EventHandler(btn);
            x9.Font = new Font("Arial", 15, FontStyle.Bold);
            x9.FlatStyle = FlatStyle.Flat;
            x9.FlatAppearance.BorderSize = 0; ;
            x0.Size = new Size(165, 70);
            x0.Text = "0";
            x0.Location = new Point(0, 225);
            x0.BackColor = Color.DimGray;
            x0.ForeColor = Color.White;
            x0.FlatStyle = FlatStyle.Flat;
            x0.FlatAppearance.BorderSize = 0;
            x0.Click += new EventHandler(btn);
            x0.Font = new Font("Arial", 15, FontStyle.Bold);
            xnot.Size = new Size(80, 70);
            xnot.Text = ".";
            xnot.Font = new Font("Arial", 15, FontStyle.Bold);
            xnot.Location = new Point(170, 225);
            xnot.BackColor = Color.DimGray;
            xnot.ForeColor = Color.White;
            xnot.FlatStyle = FlatStyle.Flat;
            xnot.FlatAppearance.BorderSize = 0;
            xnot.Click += new EventHandler(btn);
            //create p3
            p3.Location = new Point(285, 260);

            p3.Size = new Size(80, 300);
            p3.Controls.Add(mult);
            p3.Controls.Add(div);
            p3.Controls.Add(sub);
            p3.Controls.Add(sum);
            sum.Size = new Size(80, 70);
            sum.Text = "+";
            sum.BackColor = Color.Orange;
            sum.Location = new Point(0, 0);
            sum.Font = new Font("Arial", 15, FontStyle.Bold);
            sum.ForeColor = Color.White;
            sum.FlatStyle = FlatStyle.Flat;
            sum.FlatAppearance.BorderSize = 0;
            sum.Click += new EventHandler(OperationButtonClick);
            sub.Size = new Size(80, 70);
            sub.Font = new Font("Arial", 15, FontStyle.Bold);
            sub.Text = "-";
            sub.BackColor = Color.Orange;
            sub.Location = new Point(0, 75);
            sub.ForeColor = Color.White;
            sub.FlatStyle = FlatStyle.Flat;
            sub.FlatAppearance.BorderSize = 0;
            sub.Click += new EventHandler(OperationButtonClick);
            mult.Size = new Size(80, 70);
            mult.Text = "*";
            mult.Font = new Font("Arial", 15, FontStyle.Bold);
            mult.BackColor = Color.Orange;
            mult.Location = new Point(0, 150);
            mult.ForeColor = Color.White;
            mult.FlatStyle = FlatStyle.Flat;
            mult.FlatAppearance.BorderSize = 0;
            mult.Click += new EventHandler(OperationButtonClick);
            div.Size = new Size(80, 70);
            div.Text = "/";
            div.Font = new Font("Arial", 15, FontStyle.Bold);
            div.BackColor = Color.Orange;
            div.Location = new Point(0, 225);
            div.ForeColor = Color.White;
            div.FlatStyle = FlatStyle.Flat;
            div.FlatAppearance.BorderSize = 0;
            div.Click += new EventHandler(OperationButtonClick);
            //////////////////
            ///
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = Color.Black;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F,
           System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentOperation.Location = new System.Drawing.Point(330, 30);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 24);
            this.labelCurrentOperation.TabIndex = 21;
            labelCurrentOperation.BringToFront();
        }
       

       
        

       


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    x0.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    x1.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    x2.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    x3.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    x4.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    x5.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    x6.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    x7.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    x8.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    x9.PerformClick();
                    break;
                case Keys.Decimal:
                    xnot.PerformClick();
                    break;
                case Keys.Add:
                    sum.PerformClick();
                    break;
                case Keys.Subtract:
                    sub.PerformClick();
                    break;
                case Keys.Multiply:
                    mult.PerformClick();
                    break;
                case Keys.Divide:
                    div.PerformClick();
                    break;
                case Keys.Enter:
                    equal.PerformClick();
                    break;
                case Keys.Back:
                    ClearButtonClick(sender, e);
                    break;
            }
            }





        private string currentInput = "";
            private double currentValue = 0;
            private string currentOperation = "";
            private bool isNewInput = true;
            bool d = false;
            private void btn(object sender, EventArgs e)
            {
                Button button = (Button)sender;



            if (isNewInput)
            {
                currentInput = "";
                isNewInput = false;
            }



            if (button.Text == ".")
                {
                    if (!dis.Text.Contains("."))
                    {
                        currentInput += button.Text;
                    }
                }
                else
                {
                  
                    if (currentInput == "0")
                    {
                        currentInput = button.Text;
                    }
                    else
                    {
                        currentInput += button.Text;
                    }

                }
                UpdateDisplay();
            }
            private void OperationButtonClick(object sender, EventArgs e)
            {
                Button button = (Button)sender;

                if (!string.IsNullOrEmpty(dis.Text))
                {
                    if (d == true)
                    {
                        equal.PerformClick();
                    }
                


                }
            else
            {
                return;
            }

                isNewInput = true;
                currentValue = double.Parse(currentInput);
                currentOperation = button.Text;
                labelCurrentOperation.Text = currentValue + " " + currentOperation;

            }
            private void EqualsButtonClick(object sender, EventArgs e)
            {
                d = true;
                if (!string.IsNullOrEmpty(currentInput))
                {
                    double secondValue = double.Parse(currentInput);
                    switch (currentOperation)
                    {
                        case "+":
                            currentValue += secondValue;
                            break;
                        case "-":
                            currentValue -= secondValue;
                            break;
                        case "*":
                            currentValue *= secondValue;
                            break;
                        case "%":
                            currentValue %= secondValue;
                            break;
                        case "/":
                            if (secondValue != 0)
                                currentValue /= secondValue;
                            else
                                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                            break;
                    }
                    d = true;
                    currentInput = currentValue.ToString();
                    currentOperation = "";
                    isNewInput = true;
                    UpdateDisplay();
                }
            }
            private void ClearButtonClick(object sender, EventArgs e)
            {
                // Clear the input and reset values
              
                currentInput = "";
                currentValue = 0;
                currentOperation = "";
                isNewInput = true;
                d = false;
                UpdateDisplay();
                labelCurrentOperation.Text = "";
            }
            private void UpdateDisplay()
            {
                dis.Text = currentInput;
            }
    }
    }

