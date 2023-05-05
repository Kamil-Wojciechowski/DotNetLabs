namespace Zadanie01
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
            firstDate = new DateTimePicker();
            secondDate = new DateTimePicker();
            result = new Label();
            SuspendLayout();
            // 
            // firstDate
            // 
            firstDate.Format = DateTimePickerFormat.Custom;
            firstDate.Location = new Point(255, 48);
            firstDate.Name = "firstDate";
            firstDate.Size = new Size(312, 31);
            firstDate.TabIndex = 0;
            firstDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // secondDate
            // 
            secondDate.Format = DateTimePickerFormat.Custom;
            secondDate.Location = new Point(255, 112);
            secondDate.Name = "secondDate";
            secondDate.Size = new Size(312, 31);
            secondDate.TabIndex = 1;
            secondDate.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(362, 178);
            result.Name = "result";
            result.Size = new Size(155, 25);
            result.TabIndex = 2;
            result.Text = "D: 0 H: 0 M: 0 S: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(secondDate);
            Controls.Add(firstDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker firstDate;
        private DateTimePicker secondDate;
        private Label result;
    }
}