namespace Zadanie04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            result = new Label();
            perBt = new Button();
            ceBt = new Button();
            cBt = new Button();
            backBt = new Button();
            divByXBt = new Button();
            xToSquareBt = new Button();
            sqrtBt = new Button();
            divBt = new Button();
            sevenBt = new Button();
            eightBt = new Button();
            nineBt = new Button();
            mulBt = new Button();
            fourBt = new Button();
            fiveBt = new Button();
            sixBt = new Button();
            minBt = new Button();
            oneBt = new Button();
            twoBt = new Button();
            threeBt = new Button();
            plusBt = new Button();
            changeMinusBt = new Button();
            zeroBt = new Button();
            dotBt = new Button();
            resultBt = new Button();
            SuspendLayout();
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            result.Location = new Point(12, 9);
            result.Name = "result";
            result.Size = new Size(331, 54);
            result.TabIndex = 0;
            result.Text = "00000000000000";
            // 
            // perBt
            // 
            perBt.Location = new Point(12, 66);
            perBt.Name = "perBt";
            perBt.Size = new Size(75, 23);
            perBt.TabIndex = 1;
            perBt.Text = "%";
            perBt.UseVisualStyleBackColor = true;
            // 
            // ceBt
            // 
            ceBt.Location = new Point(93, 66);
            ceBt.Name = "ceBt";
            ceBt.Size = new Size(75, 23);
            ceBt.TabIndex = 2;
            ceBt.Text = "CE";
            ceBt.UseVisualStyleBackColor = true;
            ceBt.Click += ceBt_Click;
            // 
            // cBt
            // 
            cBt.Location = new Point(180, 66);
            cBt.Name = "cBt";
            cBt.Size = new Size(75, 23);
            cBt.TabIndex = 3;
            cBt.Text = "C";
            cBt.UseVisualStyleBackColor = true;
            cBt.Click += cBt_Click;
            // 
            // backBt
            // 
            backBt.Location = new Point(268, 66);
            backBt.Name = "backBt";
            backBt.Size = new Size(75, 23);
            backBt.TabIndex = 4;
            backBt.Text = "Back";
            backBt.UseVisualStyleBackColor = true;
            backBt.Click += backBt_Click;
            // 
            // divByXBt
            // 
            divByXBt.Location = new Point(12, 95);
            divByXBt.Name = "divByXBt";
            divByXBt.Size = new Size(75, 70);
            divByXBt.TabIndex = 5;
            divByXBt.Text = "1/x";
            divByXBt.UseVisualStyleBackColor = true;
            divByXBt.Click += divByXBt_Click;
            // 
            // xToSquareBt
            // 
            xToSquareBt.Location = new Point(93, 95);
            xToSquareBt.Name = "xToSquareBt";
            xToSquareBt.Size = new Size(75, 70);
            xToSquareBt.TabIndex = 6;
            xToSquareBt.Text = "x^2";
            xToSquareBt.UseVisualStyleBackColor = true;
            xToSquareBt.Click += xToSquareBt_Click;
            // 
            // sqrtBt
            // 
            sqrtBt.Location = new Point(180, 95);
            sqrtBt.Name = "sqrtBt";
            sqrtBt.Size = new Size(75, 70);
            sqrtBt.TabIndex = 7;
            sqrtBt.Text = "sqrt(2)";
            sqrtBt.UseVisualStyleBackColor = true;
            sqrtBt.Click += sqrtBt_Click;
            // 
            // divBt
            // 
            divBt.Location = new Point(268, 95);
            divBt.Name = "divBt";
            divBt.Size = new Size(75, 70);
            divBt.TabIndex = 8;
            divBt.Text = "/";
            divBt.UseVisualStyleBackColor = true;
            divBt.Click += divBt_Click;
            // 
            // sevenBt
            // 
            sevenBt.Location = new Point(12, 171);
            sevenBt.Name = "sevenBt";
            sevenBt.Size = new Size(75, 70);
            sevenBt.TabIndex = 9;
            sevenBt.Text = "7";
            sevenBt.UseVisualStyleBackColor = true;
            sevenBt.Click += sevenBt_Click;
            // 
            // eightBt
            // 
            eightBt.Location = new Point(93, 171);
            eightBt.Name = "eightBt";
            eightBt.Size = new Size(75, 70);
            eightBt.TabIndex = 10;
            eightBt.Text = "8";
            eightBt.UseVisualStyleBackColor = true;
            eightBt.Click += eightBt_Click;
            // 
            // nineBt
            // 
            nineBt.Location = new Point(180, 171);
            nineBt.Name = "nineBt";
            nineBt.Size = new Size(75, 70);
            nineBt.TabIndex = 11;
            nineBt.Text = "9";
            nineBt.UseVisualStyleBackColor = true;
            nineBt.Click += nineBt_Click;
            // 
            // mulBt
            // 
            mulBt.Location = new Point(268, 171);
            mulBt.Name = "mulBt";
            mulBt.Size = new Size(75, 70);
            mulBt.TabIndex = 12;
            mulBt.Text = "*";
            mulBt.UseVisualStyleBackColor = true;
            mulBt.Click += mulBt_Click;
            // 
            // fourBt
            // 
            fourBt.Location = new Point(12, 247);
            fourBt.Name = "fourBt";
            fourBt.Size = new Size(75, 70);
            fourBt.TabIndex = 13;
            fourBt.Text = "4";
            fourBt.UseVisualStyleBackColor = true;
            fourBt.Click += fourBt_Click;
            // 
            // fiveBt
            // 
            fiveBt.Location = new Point(93, 247);
            fiveBt.Name = "fiveBt";
            fiveBt.Size = new Size(75, 70);
            fiveBt.TabIndex = 14;
            fiveBt.Text = "5";
            fiveBt.UseVisualStyleBackColor = true;
            fiveBt.Click += fiveBt_Click;
            // 
            // sixBt
            // 
            sixBt.Location = new Point(180, 247);
            sixBt.Name = "sixBt";
            sixBt.Size = new Size(75, 70);
            sixBt.TabIndex = 15;
            sixBt.Text = "6";
            sixBt.UseVisualStyleBackColor = true;
            sixBt.Click += sixBt_Click;
            // 
            // minBt
            // 
            minBt.Location = new Point(268, 247);
            minBt.Name = "minBt";
            minBt.Size = new Size(75, 70);
            minBt.TabIndex = 16;
            minBt.Text = "-";
            minBt.UseVisualStyleBackColor = true;
            minBt.Click += minBt_Click;
            // 
            // oneBt
            // 
            oneBt.Location = new Point(12, 323);
            oneBt.Name = "oneBt";
            oneBt.Size = new Size(75, 70);
            oneBt.TabIndex = 17;
            oneBt.Text = "1";
            oneBt.UseVisualStyleBackColor = true;
            oneBt.Click += oneBt_Click;
            // 
            // twoBt
            // 
            twoBt.Location = new Point(93, 323);
            twoBt.Name = "twoBt";
            twoBt.Size = new Size(75, 70);
            twoBt.TabIndex = 18;
            twoBt.Text = "2";
            twoBt.UseVisualStyleBackColor = true;
            twoBt.Click += twoBt_Click;
            // 
            // threeBt
            // 
            threeBt.Location = new Point(180, 323);
            threeBt.Name = "threeBt";
            threeBt.Size = new Size(75, 70);
            threeBt.TabIndex = 19;
            threeBt.Text = "3";
            threeBt.UseVisualStyleBackColor = true;
            threeBt.Click += threeBt_Click;
            // 
            // plusBt
            // 
            plusBt.Location = new Point(268, 324);
            plusBt.Name = "plusBt";
            plusBt.Size = new Size(75, 70);
            plusBt.TabIndex = 20;
            plusBt.Text = "+";
            plusBt.UseVisualStyleBackColor = true;
            plusBt.Click += plusBt_Click;
            // 
            // changeMinusBt
            // 
            changeMinusBt.Location = new Point(12, 399);
            changeMinusBt.Name = "changeMinusBt";
            changeMinusBt.Size = new Size(75, 70);
            changeMinusBt.TabIndex = 21;
            changeMinusBt.Text = "+/-";
            changeMinusBt.UseVisualStyleBackColor = true;
            changeMinusBt.Click += changeMinusBt_Click;
            // 
            // zeroBt
            // 
            zeroBt.Location = new Point(93, 400);
            zeroBt.Name = "zeroBt";
            zeroBt.Size = new Size(75, 70);
            zeroBt.TabIndex = 22;
            zeroBt.Text = "0";
            zeroBt.UseVisualStyleBackColor = true;
            zeroBt.Click += zeroBt_Click;
            // 
            // dotBt
            // 
            dotBt.Location = new Point(180, 400);
            dotBt.Name = "dotBt";
            dotBt.Size = new Size(75, 70);
            dotBt.TabIndex = 23;
            dotBt.Text = ",";
            dotBt.UseVisualStyleBackColor = true;
            dotBt.Click += dotBt_Click;
            // 
            // resultBt
            // 
            resultBt.Location = new Point(268, 400);
            resultBt.Name = "resultBt";
            resultBt.Size = new Size(75, 70);
            resultBt.TabIndex = 24;
            resultBt.Text = "=";
            resultBt.UseVisualStyleBackColor = true;
            resultBt.Click += resultBt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 482);
            Controls.Add(resultBt);
            Controls.Add(dotBt);
            Controls.Add(zeroBt);
            Controls.Add(changeMinusBt);
            Controls.Add(plusBt);
            Controls.Add(threeBt);
            Controls.Add(twoBt);
            Controls.Add(oneBt);
            Controls.Add(minBt);
            Controls.Add(sixBt);
            Controls.Add(fiveBt);
            Controls.Add(fourBt);
            Controls.Add(mulBt);
            Controls.Add(nineBt);
            Controls.Add(eightBt);
            Controls.Add(sevenBt);
            Controls.Add(divBt);
            Controls.Add(sqrtBt);
            Controls.Add(xToSquareBt);
            Controls.Add(divByXBt);
            Controls.Add(backBt);
            Controls.Add(cBt);
            Controls.Add(ceBt);
            Controls.Add(perBt);
            Controls.Add(result);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label result;
        private Button perBt;
        private Button ceBt;
        private Button cBt;
        private Button backBt;
        private Button divByXBt;
        private Button xToSquareBt;
        private Button sqrtBt;
        private Button divBt;
        private Button sevenBt;
        private Button eightBt;
        private Button nineBt;
        private Button mulBt;
        private Button fourBt;
        private Button fiveBt;
        private Button sixBt;
        private Button minBt;
        private Button oneBt;
        private Button twoBt;
        private Button threeBt;
        private Button plusBt;
        private Button changeMinusBt;
        private Button zeroBt;
        private Button dotBt;
        private Button resultBt;
    }
}