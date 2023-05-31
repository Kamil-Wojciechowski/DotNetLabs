namespace Zadanie07
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
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            readFile = new Button();
            filename = new Label();
            clearFile = new Button();
            treeView1 = new TreeView();
            import = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // readFile
            // 
            readFile.Location = new Point(12, 336);
            readFile.Name = "readFile";
            readFile.Size = new Size(112, 34);
            readFile.TabIndex = 0;
            readFile.Text = "Read File";
            readFile.UseVisualStyleBackColor = true;
            // 
            // filename
            // 
            filename.AutoSize = true;
            filename.Location = new Point(12, 382);
            filename.Name = "filename";
            filename.Size = new Size(79, 25);
            filename.TabIndex = 1;
            filename.Text = "filename";
            // 
            // clearFile
            // 
            clearFile.Location = new Point(130, 336);
            clearFile.Name = "clearFile";
            clearFile.Size = new Size(112, 34);
            clearFile.TabIndex = 2;
            clearFile.Text = "Clear File";
            clearFile.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(776, 308);
            treeView1.TabIndex = 3;
            // 
            // import
            // 
            import.Location = new Point(248, 336);
            import.Name = "import";
            import.Size = new Size(112, 34);
            import.TabIndex = 4;
            import.Text = "Import";
            import.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(import);
            Controls.Add(treeView1);
            Controls.Add(clearFile);
            Controls.Add(filename);
            Controls.Add(readFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button readFile;
        private Label filename;
        private Button clearFile;
        private TreeView treeView1;
        private Button import;
    }
}