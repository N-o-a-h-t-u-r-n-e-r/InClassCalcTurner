namespace InClassCalcTurner
{
    partial class Calc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Sqrt;
            this.txtInputOutput = new System.Windows.Forms.TextBox();
            this.Fraction = new System.Windows.Forms.Button();
            this.SquareYButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.ChangeSign = new System.Windows.Forms.Button();
            Sqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sqrt
            // 
            Sqrt.Location = new System.Drawing.Point(12, 48);
            Sqrt.Name = "Sqrt";
            Sqrt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Sqrt.Size = new System.Drawing.Size(60, 45);
            Sqrt.TabIndex = 1;
            Sqrt.Text = "Sqrt";
            Sqrt.UseVisualStyleBackColor = true;
            Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // txtInputOutput
            // 
            this.txtInputOutput.Location = new System.Drawing.Point(12, 22);
            this.txtInputOutput.Name = "txtInputOutput";
            this.txtInputOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInputOutput.Size = new System.Drawing.Size(258, 20);
            this.txtInputOutput.TabIndex = 0;
            this.txtInputOutput.Text = "0";
            this.txtInputOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInputOutput.TextChanged += new System.EventHandler(this.txtInputOutput_TextChanged);
            // 
            // Fraction
            // 
            this.Fraction.Location = new System.Drawing.Point(210, 48);
            this.Fraction.Name = "Fraction";
            this.Fraction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Fraction.Size = new System.Drawing.Size(60, 45);
            this.Fraction.TabIndex = 2;
            this.Fraction.Text = "1/x";
            this.Fraction.UseVisualStyleBackColor = true;
            this.Fraction.Click += new System.EventHandler(this.Fraction_Click);
            // 
            // SquareYButton
            // 
            this.SquareYButton.Location = new System.Drawing.Point(144, 48);
            this.SquareYButton.Name = "SquareYButton";
            this.SquareYButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SquareYButton.Size = new System.Drawing.Size(60, 45);
            this.SquareYButton.TabIndex = 3;
            this.SquareYButton.Text = "x^y";
            this.SquareYButton.UseVisualStyleBackColor = true;
            this.SquareYButton.Click += new System.EventHandler(this.SquareYButton_Click);
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(78, 48);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SquareButton.Size = new System.Drawing.Size(60, 45);
            this.SquareButton.TabIndex = 4;
            this.SquareButton.Text = "x^2";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(78, 99);
            this.C.Name = "C";
            this.C.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C.Size = new System.Drawing.Size(60, 45);
            this.C.TabIndex = 8;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(144, 99);
            this.Del.Name = "Del";
            this.Del.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Del.Size = new System.Drawing.Size(60, 45);
            this.Del.TabIndex = 7;
            this.Del.Text = "Del.";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(210, 99);
            this.Divide.Name = "Divide";
            this.Divide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Divide.Size = new System.Drawing.Size(60, 45);
            this.Divide.TabIndex = 6;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(12, 99);
            this.CE.Name = "CE";
            this.CE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CE.Size = new System.Drawing.Size(60, 45);
            this.CE.TabIndex = 5;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(78, 150);
            this.Eight.Name = "Eight";
            this.Eight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Eight.Size = new System.Drawing.Size(60, 45);
            this.Eight.TabIndex = 12;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(144, 150);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button9.Size = new System.Drawing.Size(60, 45);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(210, 150);
            this.Multiply.Name = "Multiply";
            this.Multiply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Multiply.Size = new System.Drawing.Size(60, 45);
            this.Multiply.TabIndex = 10;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(12, 150);
            this.Seven.Name = "Seven";
            this.Seven.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Seven.Size = new System.Drawing.Size(60, 45);
            this.Seven.TabIndex = 9;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(78, 201);
            this.Five.Name = "Five";
            this.Five.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Five.Size = new System.Drawing.Size(60, 45);
            this.Five.TabIndex = 16;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(144, 201);
            this.Six.Name = "Six";
            this.Six.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Six.Size = new System.Drawing.Size(60, 45);
            this.Six.TabIndex = 15;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(210, 201);
            this.Subtract.Name = "Subtract";
            this.Subtract.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Subtract.Size = new System.Drawing.Size(60, 45);
            this.Subtract.TabIndex = 14;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(12, 201);
            this.Four.Name = "Four";
            this.Four.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Four.Size = new System.Drawing.Size(60, 45);
            this.Four.TabIndex = 13;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(78, 252);
            this.Two.Name = "Two";
            this.Two.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Two.Size = new System.Drawing.Size(60, 45);
            this.Two.TabIndex = 20;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(144, 252);
            this.Three.Name = "Three";
            this.Three.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Three.Size = new System.Drawing.Size(60, 45);
            this.Three.TabIndex = 19;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(210, 252);
            this.Plus.Name = "Plus";
            this.Plus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Plus.Size = new System.Drawing.Size(60, 45);
            this.Plus.TabIndex = 18;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(12, 252);
            this.One.Name = "One";
            this.One.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.One.Size = new System.Drawing.Size(60, 45);
            this.One.TabIndex = 17;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(78, 303);
            this.Zero.Name = "Zero";
            this.Zero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Zero.Size = new System.Drawing.Size(60, 45);
            this.Zero.TabIndex = 24;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Decimal
            // 
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.Location = new System.Drawing.Point(144, 303);
            this.Decimal.Name = "Decimal";
            this.Decimal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Decimal.Size = new System.Drawing.Size(60, 45);
            this.Decimal.TabIndex = 23;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(210, 303);
            this.Equals.Name = "Equals";
            this.Equals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Equals.Size = new System.Drawing.Size(60, 45);
            this.Equals.TabIndex = 22;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // ChangeSign
            // 
            this.ChangeSign.Location = new System.Drawing.Point(12, 303);
            this.ChangeSign.Name = "ChangeSign";
            this.ChangeSign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChangeSign.Size = new System.Drawing.Size(60, 45);
            this.ChangeSign.TabIndex = 21;
            this.ChangeSign.Text = "+/-";
            this.ChangeSign.UseVisualStyleBackColor = true;
            this.ChangeSign.Click += new System.EventHandler(this.ChangeSign_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 368);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.ChangeSign);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.SquareYButton);
            this.Controls.Add(this.Fraction);
            this.Controls.Add(Sqrt);
            this.Controls.Add(this.txtInputOutput);
            this.KeyPreview = true;
            this.Name = "Calc";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputOutput;
        private System.Windows.Forms.Button Fraction;
        private System.Windows.Forms.Button SquareYButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button ChangeSign;
    }
}

