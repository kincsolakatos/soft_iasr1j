namespace Eletjatek
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
            panel1 = new Panel();
            startButton = new Button();
            numericUpDownEloSejtek = new NumericUpDown();
            numericUpDownOszlopok = new NumericUpDown();
            numericUpDownSorok = new NumericUpDown();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownEloSejtek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOszlopok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSorok).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(138, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1254, 582);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 99);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 1;
            startButton.Text = "button1";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // numericUpDownEloSejtek
            // 
            numericUpDownEloSejtek.Location = new Point(12, 70);
            numericUpDownEloSejtek.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownEloSejtek.Name = "numericUpDownEloSejtek";
            numericUpDownEloSejtek.Size = new Size(120, 23);
            numericUpDownEloSejtek.TabIndex = 2;
            // 
            // numericUpDownOszlopok
            // 
            numericUpDownOszlopok.Location = new Point(12, 41);
            numericUpDownOszlopok.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownOszlopok.Name = "numericUpDownOszlopok";
            numericUpDownOszlopok.Size = new Size(120, 23);
            numericUpDownOszlopok.TabIndex = 1;
            // 
            // numericUpDownSorok
            // 
            numericUpDownSorok.Location = new Point(12, 12);
            numericUpDownSorok.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSorok.Name = "numericUpDownSorok";
            numericUpDownSorok.Size = new Size(120, 23);
            numericUpDownSorok.TabIndex = 0;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 606);
            Controls.Add(startButton);
            Controls.Add(panel1);
            Controls.Add(numericUpDownEloSejtek);
            Controls.Add(numericUpDownSorok);
            Controls.Add(numericUpDownOszlopok);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownEloSejtek).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOszlopok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSorok).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown numericUpDownEloSejtek;
        private NumericUpDown numericUpDownOszlopok;
        private NumericUpDown numericUpDownSorok;
        private System.Windows.Forms.Timer timer;
        private Button startButton;
    }
}
