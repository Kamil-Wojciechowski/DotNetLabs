namespace Zadanie03
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
            textEncDec = new TextBox();
            publicKey = new TextBox();
            privateKey = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            text = new Label();
            label1 = new Label();
            label2 = new Label();
            resultTextBox = new TextBox();
            // 
            // textEncDec
            // 
            textEncDec.Location = new Point(96, 139);
            textEncDec.Name = "textEncDec";
            textEncDec.Size = new Size(671, 31);
            textEncDec.TabIndex = 0;
            // 
            // publicKey
            // 
            publicKey.Location = new Point(96, 12);
            publicKey.Name = "publicKey";
            publicKey.Size = new Size(671, 31);
            publicKey.TabIndex = 1;
            // 
            // privateKey
            // 
            privateKey.Location = new Point(96, 49);
            privateKey.Name = "privateKey";
            privateKey.Size = new Size(671, 31);
            privateKey.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(297, 86);
            button1.Name = "button1";
            button1.Size = new Size(244, 34);
            button1.TabIndex = 3;
            button1.Text = "Wygeneruj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += generateKeys;
            // 
            // button2
            // 
            button2.Location = new Point(96, 176);
            button2.Name = "button2";
            button2.Size = new Size(245, 34);
            button2.TabIndex = 4;
            button2.Text = "Enkryptuj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += encryptText;
            // 
            // button3
            // 
            button3.Location = new Point(531, 176);
            button3.Name = "button3";
            button3.Size = new Size(236, 34);
            button3.TabIndex = 5;
            button3.Text = "Dekryptuj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += decryptText;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(36, 142);
            text.Name = "text";
            text.Size = new Size(60, 25);
            text.TabIndex = 6;
            text.Text = "Tekst: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 7;
            label1.Text = "Public:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 52);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 8;
            label2.Text = "Private:";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(96, 216);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(671, 31);
            resultTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(privateKey);
            Controls.Add(publicKey);
            Controls.Add(textEncDec);
            Name = "Form1";
            Text = "Form1";
     
        }

        #endregion

        private TextBox textEncDec;
        private TextBox publicKey;
        private TextBox privateKey;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label text;
        private Label label1;
        private Label label2;
        private TextBox resultTextBox;
    }
}