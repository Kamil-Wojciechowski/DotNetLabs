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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            digitalText = new Label();
            AnalogPanel = new Panel();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // digitalText
            // 
            digitalText.AutoSize = true;
            digitalText.Location = new Point(64, 193);
            digitalText.Name = "digitalText";
            digitalText.Size = new Size(80, 25);
            digitalText.TabIndex = 0;
            digitalText.Text = "00:00:00";
            // 
            // AnalogPanel
            // 
            AnalogPanel.Location = new Point(10, 10);
            AnalogPanel.Name = "AnalogPanel";
            AnalogPanel.Size = new Size(180, 180);
            AnalogPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 266);
            Controls.Add(AnalogPanel);
            Controls.Add(digitalText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label digitalText;
        private Panel AnalogPanel;
    }
}