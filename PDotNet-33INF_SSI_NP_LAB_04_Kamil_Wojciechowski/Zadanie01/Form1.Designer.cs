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
            components = new System.ComponentModel.Container();
            redPanel = new Panel();
            yellowPanel = new Panel();
            greenPanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // redPanel
            // 
            redPanel.BackColor = Color.Red;
            redPanel.Location = new Point(49, 23);
            redPanel.Name = "redPanel";
            redPanel.Size = new Size(93, 79);
            redPanel.TabIndex = 0;
            // 
            // yellowPanel
            // 
            yellowPanel.BackColor = Color.Yellow;
            yellowPanel.Location = new Point(49, 108);
            yellowPanel.Name = "yellowPanel";
            yellowPanel.Size = new Size(93, 79);
            yellowPanel.TabIndex = 1;
            // 
            // greenPanel
            // 
            greenPanel.BackColor = Color.Green;
            greenPanel.Location = new Point(49, 193);
            greenPanel.Name = "greenPanel";
            greenPanel.Size = new Size(93, 79);
            greenPanel.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(187, 308);
            Controls.Add(greenPanel);
            Controls.Add(yellowPanel);
            Controls.Add(redPanel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel redPanel;
        private Panel yellowPanel;
        private Panel greenPanel;
        private System.Windows.Forms.Timer timer1;
    }
}