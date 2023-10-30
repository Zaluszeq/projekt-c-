namespace AiSD_io4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Generuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SB = new System.Windows.Forms.Button();
            this.SS = new System.Windows.Forms.Button();
            this.SI = new System.Windows.Forms.Button();
            this.SM = new System.Windows.Forms.Button();
            this.SQ = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(292, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(417, 50);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 2;
            // 
            // Generuj
            // 
            this.Generuj.Location = new System.Drawing.Point(456, 149);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(75, 23);
            this.Generuj.TabIndex = 3;
            this.Generuj.Text = "Generuj";
            this.Generuj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Czas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SB
            // 
            this.SB.Location = new System.Drawing.Point(138, 334);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(75, 23);
            this.SB.TabIndex = 6;
            this.SB.Text = "SB";
            this.SB.UseVisualStyleBackColor = true;
            // 
            // SS
            // 
            this.SS.Location = new System.Drawing.Point(219, 334);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(75, 23);
            this.SS.TabIndex = 7;
            this.SS.Text = "SS";
            this.SS.UseVisualStyleBackColor = true;
            // 
            // SI
            // 
            this.SI.Location = new System.Drawing.Point(300, 334);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(75, 23);
            this.SI.TabIndex = 8;
            this.SI.Text = "SI";
            this.SI.UseVisualStyleBackColor = true;
            // 
            // SM
            // 
            this.SM.Location = new System.Drawing.Point(381, 334);
            this.SM.Name = "SM";
            this.SM.Size = new System.Drawing.Size(75, 23);
            this.SM.TabIndex = 9;
            this.SM.Text = "SM";
            this.SM.UseVisualStyleBackColor = true;
            this.SM.Click += new System.EventHandler(this.button4_Click);
            // 
            // SQ
            // 
            this.SQ.Location = new System.Drawing.Point(462, 334);
            this.SQ.Name = "SQ";
            this.SQ.Size = new System.Drawing.Size(75, 23);
            this.SQ.TabIndex = 10;
            this.SQ.Text = "SQ";
            this.SQ.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 456);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SQ);
            this.Controls.Add(this.SM);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.SB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Button Generuj;
        private Label label1;
        private Label label2;
        private Button SB;
        private Button SS;
        private Button SI;
        private Button SM;
        private Button SQ;
        private TextBox textBox2;
    }
}