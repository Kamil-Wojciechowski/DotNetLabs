namespace Zadanie02
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
            numberOne = new TextBox();
            numberTwo = new TextBox();
            addBtn = new Button();
            result = new Label();
            subBtn = new Button();
            mulBtn = new Button();
            divBtn = new Button();
            SuspendLayout();
            // 
            // numberOne
            // 
            numberOne.Location = new Point(180, 12);
            numberOne.Name = "numberOne";
            numberOne.Size = new Size(100, 23);
            numberOne.TabIndex = 0;
            numberOne.TextChanged += numberOne_TextChanged;
            // 
            // numberTwo
            // 
            numberTwo.Location = new Point(180, 52);
            numberTwo.Name = "numberTwo";
            numberTwo.Size = new Size(100, 23);
            numberTwo.TabIndex = 1;
            numberTwo.TextChanged += numberTwo_TextChanged;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(93, 123);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 2;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(208, 204);
            result.Name = "result";
            result.Size = new Size(39, 15);
            result.TabIndex = 3;
            result.Text = "Result";
            // 
            // subBtn
            // 
            subBtn.Location = new Point(180, 123);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(75, 23);
            subBtn.TabIndex = 4;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += subBtn_Click;
            // 
            // mulBtn
            // 
            mulBtn.Location = new Point(261, 123);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(75, 23);
            mulBtn.TabIndex = 5;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = true;
            mulBtn.Click += mulBtn_Click;
            // 
            // divBtn
            // 
            divBtn.Location = new Point(342, 123);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(75, 23);
            divBtn.TabIndex = 6;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.Click += divBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 311);
            Controls.Add(divBtn);
            Controls.Add(mulBtn);
            Controls.Add(subBtn);
            Controls.Add(result);
            Controls.Add(addBtn);
            Controls.Add(numberTwo);
            Controls.Add(numberOne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberOne;
        private TextBox numberTwo;
        private Button addBtn;
        private Label result;
        private Button subBtn;
        private Button mulBtn;
        private Button divBtn;
    }
}