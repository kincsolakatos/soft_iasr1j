namespace hajoskviz
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            valaszGomb1 = new ValaszGomb();
            valaszGomb2 = new ValaszGomb();
            valaszGomb3 = new ValaszGomb();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 176);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(511, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 246);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // valaszGomb1
            // 
            valaszGomb1.BackColor = Color.Gray;
            valaszGomb1.BorderStyle = BorderStyle.None;
            valaszGomb1.Location = new Point(16, 63);
            valaszGomb1.Multiline = true;
            valaszGomb1.Name = "valaszGomb1";
            valaszGomb1.ReadOnly = true;
            valaszGomb1.Size = new Size(468, 61);
            valaszGomb1.TabIndex = 3;
            // 
            // valaszGomb2
            // 
            valaszGomb2.BackColor = Color.Gray;
            valaszGomb2.BorderStyle = BorderStyle.None;
            valaszGomb2.Location = new Point(16, 130);
            valaszGomb2.Multiline = true;
            valaszGomb2.Name = "valaszGomb2";
            valaszGomb2.ReadOnly = true;
            valaszGomb2.Size = new Size(468, 61);
            valaszGomb2.TabIndex = 4;
            // 
            // valaszGomb3
            // 
            valaszGomb3.BackColor = Color.Gray;
            valaszGomb3.BorderStyle = BorderStyle.None;
            valaszGomb3.Location = new Point(16, 197);
            valaszGomb3.Multiline = true;
            valaszGomb3.Name = "valaszGomb3";
            valaszGomb3.ReadOnly = true;
            valaszGomb3.Size = new Size(468, 61);
            valaszGomb3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(valaszGomb3);
            Controls.Add(valaszGomb2);
            Controls.Add(valaszGomb1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private ValaszGomb valaszGomb1;
        private ValaszGomb valaszGomb2;
        private ValaszGomb valaszGomb3;
        private Label label1;
    }
}