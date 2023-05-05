namespace Zadanie06
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
            Attachment = new Label();
            topic = new TextBox();
            attachmentPwd = new TextBox();
            message = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            To = new Label();
            toText = new TextBox();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // Attachment
            // 
            Attachment.AutoSize = true;
            Attachment.Location = new Point(12, 109);
            Attachment.Name = "Attachment";
            Attachment.Size = new Size(104, 25);
            Attachment.TabIndex = 2;
            Attachment.Text = "Attachment";
            // 
            // topic
            // 
            topic.Location = new Point(122, 63);
            topic.Name = "topic";
            topic.Size = new Size(455, 31);
            topic.TabIndex = 4;
            // 
            // attachmentPwd
            // 
            attachmentPwd.Location = new Point(122, 109);
            attachmentPwd.Name = "attachmentPwd";
            attachmentPwd.Size = new Size(455, 31);
            attachmentPwd.TabIndex = 5;
            // 
            // message
            // 
            message.Location = new Point(12, 209);
            message.Name = "message";
            message.Size = new Size(565, 318);
            message.TabIndex = 6;
            message.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(465, 533);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 146);
            button2.Name = "button2";
            button2.Size = new Size(156, 34);
            button2.TabIndex = 8;
            button2.Text = "Add Attachment";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // To
            // 
            To.AutoSize = true;
            To.Location = new Point(12, 20);
            To.Name = "To";
            To.Size = new Size(34, 25);
            To.TabIndex = 0;
            To.Text = "To:";
            // 
            // toText
            // 
            toText.Location = new Point(122, 20);
            toText.Name = "toText";
            toText.Size = new Size(455, 31);
            toText.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(174, 146);
            button3.Name = "button3";
            button3.Size = new Size(166, 34);
            button3.TabIndex = 9;
            button3.Text = "Clear Attachment";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 11;
            label3.Text = "Subject";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 579);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(message);
            Controls.Add(attachmentPwd);
            Controls.Add(topic);
            Controls.Add(toText);
            Controls.Add(Attachment);
            Controls.Add(To);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label F;
        private Label label2;
        private Label Attachment;
        private TextBox textBox1;
        private TextBox topic;
        private TextBox attachmentPwd;
        private RichTextBox message;
        private Button button1;
        private Button button2;
        private Label To;
        private TextBox toText;
        private Button button3;
        private Label label3;
    }
}