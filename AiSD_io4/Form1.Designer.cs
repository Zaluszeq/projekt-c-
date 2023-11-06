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
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            Generuj = new Button();
            label1 = new Label();
            label2 = new Label();
            SB = new Button();
            SS = new Button();
            SI = new Button();
            SM = new Button();
            SQ = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 65);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(334, 72);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(477, 67);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(137, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Generuj
            // 
            Generuj.Location = new Point(521, 199);
            Generuj.Margin = new Padding(3, 4, 3, 4);
            Generuj.Name = "Generuj";
            Generuj.Size = new Size(86, 31);
            Generuj.TabIndex = 3;
            Generuj.Text = "Generuj";
            Generuj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 252);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "Czas:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 252);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 5;
            label2.Text = "...";
            label2.Click += label2_Click;
            // 
            // SB
            // 
            SB.Location = new Point(158, 445);
            SB.Margin = new Padding(3, 4, 3, 4);
            SB.Name = "SB";
            SB.Size = new Size(86, 31);
            SB.TabIndex = 6;
            SB.Text = "SB";
            SB.UseVisualStyleBackColor = true;
            SB.Click += SB_Click_1;
            // 
            // SS
            // 
            SS.Location = new Point(250, 445);
            SS.Margin = new Padding(3, 4, 3, 4);
            SS.Name = "SS";
            SS.Size = new Size(86, 31);
            SS.TabIndex = 7;
            SS.Text = "SS";
            SS.UseVisualStyleBackColor = true;
            SS.Click += SS_Click;
            // 
            // SI
            // 
            SI.Location = new Point(343, 445);
            SI.Margin = new Padding(3, 4, 3, 4);
            SI.Name = "SI";
            SI.Size = new Size(86, 31);
            SI.TabIndex = 8;
            SI.Text = "SI";
            SI.UseVisualStyleBackColor = true;
            SI.Click += SI_Click;
            // 
            // SM
            // 
            SM.Location = new Point(435, 445);
            SM.Margin = new Padding(3, 4, 3, 4);
            SM.Name = "SM";
            SM.Size = new Size(86, 31);
            SM.TabIndex = 9;
            SM.Text = "SM";
            SM.UseVisualStyleBackColor = true;
            SM.Click += button4_Click;
            // 
            // SQ
            // 
            SQ.Location = new Point(528, 445);
            SQ.Margin = new Padding(3, 4, 3, 4);
            SQ.Name = "SQ";
            SQ.Size = new Size(86, 31);
            SQ.TabIndex = 10;
            SQ.Text = "SQ";
            SQ.UseVisualStyleBackColor = true;
            SQ.Click += SQ_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 252);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 608);
            Controls.Add(textBox2);
            Controls.Add(SQ);
            Controls.Add(SM);
            Controls.Add(SI);
            Controls.Add(SS);
            Controls.Add(SB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Generuj);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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