namespace E
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
            nUDS = new NumericUpDown();
            nUDO = new NumericUpDown();
            nUDES = new NumericUpDown();
            sB = new Button();
            p1 = new Panel();
            t = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nUDS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDES).BeginInit();
            SuspendLayout();
            // 
            // nUDS
            // 
            nUDS.Location = new Point(12, 12);
            nUDS.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nUDS.Name = "nUDS";
            nUDS.Size = new Size(120, 23);
            nUDS.TabIndex = 0;
            // 
            // nUDO
            // 
            nUDO.Location = new Point(12, 41);
            nUDO.Name = "nUDO";
            nUDO.Size = new Size(120, 23);
            nUDO.TabIndex = 1;
            // 
            // nUDES
            // 
            nUDES.Location = new Point(12, 70);
            nUDES.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nUDES.Name = "nUDES";
            nUDES.Size = new Size(120, 23);
            nUDES.TabIndex = 2;
            // 
            // sB
            // 
            sB.Location = new Point(12, 99);
            sB.Name = "sB";
            sB.Size = new Size(75, 23);
            sB.TabIndex = 3;
            sB.Text = "button1";
            sB.UseVisualStyleBackColor = true;
            sB.Click += sB_Click;
            // 
            // p1
            // 
            p1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p1.Location = new Point(138, 12);
            p1.Name = "p1";
            p1.Size = new Size(650, 426);
            p1.TabIndex = 4;
            p1.Paint += p1_Paint;
            // 
            // t
            // 
            t.Tick += t_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(p1);
            Controls.Add(sB);
            Controls.Add(nUDES);
            Controls.Add(nUDO);
            Controls.Add(nUDS);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nUDS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDO).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nUDS;
        private NumericUpDown nUDO;
        private NumericUpDown nUDES;
        private Button sB;
        private Panel p1;
        private System.Windows.Forms.Timer t;
    }
}
