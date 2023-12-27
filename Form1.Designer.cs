namespace Amc_BinaryReader
{
    partial class BinaryReader
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
            readFile_btn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            save_btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // readFile_btn
            // 
            readFile_btn.Location = new Point(532, 55);
            readFile_btn.Name = "readFile_btn";
            readFile_btn.Size = new Size(180, 29);
            readFile_btn.TabIndex = 0;
            readFile_btn.Text = "Read Binary file";
            readFile_btn.UseVisualStyleBackColor = true;
            readFile_btn.Click += readFile_btn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 55);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "contenuto in byte";
            textBox1.Size = new Size(295, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 2;
            label1.Text = "contenuto in byte";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 151);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "contenuto in lettere";
            textBox2.Size = new Size(295, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 130);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 4;
            label2.Text = "contenuto in lettere";
            // 
            // save_btn
            // 
            save_btn.Location = new Point(39, 253);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(147, 50);
            save_btn.TabIndex = 5;
            save_btn.Text = "Salva il contenuto in csv";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Visible = false;
            save_btn.Click += save_btn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(316, 253);
            button1.Name = "button1";
            button1.Size = new Size(147, 50);
            button1.TabIndex = 6;
            button1.Text = "Salva il contenuto in xml";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // BinaryReader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(save_btn);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(readFile_btn);
            Name = "BinaryReader";
            Text = "Binary File Reader";
            Load += BinaryReader_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button readFile_btn;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button save_btn;
        private Button button1;
    }
}
