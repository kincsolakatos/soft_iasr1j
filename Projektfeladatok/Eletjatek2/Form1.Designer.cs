namespace Eletjatek2
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
            numericUpDownSorok = new NumericUpDown();
            numericUpDownOszlopok = new NumericUpDown();
            numericUpDownEloSejtek = new NumericUpDown();
            button = new Button();
            panel = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownSorok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOszlopok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEloSejtek).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownSorok
            // 
            numericUpDownSorok.Location = new Point(12, 12);
            numericUpDownSorok.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownSorok.Name = "numericUpDownSorok";
            numericUpDownSorok.Size = new Size(120, 23);
            numericUpDownSorok.TabIndex = 0;
            numericUpDownSorok.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numericUpDownOszlopok
            // 
            numericUpDownOszlopok.Location = new Point(138, 12);
            numericUpDownOszlopok.Name = "numericUpDownOszlopok";
            numericUpDownOszlopok.Size = new Size(120, 23);
            numericUpDownOszlopok.TabIndex = 1;
            numericUpDownOszlopok.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDownEloSejtek
            // 
            numericUpDownEloSejtek.Location = new Point(264, 12);
            numericUpDownEloSejtek.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownEloSejtek.Name = "numericUpDownEloSejtek";
            numericUpDownEloSejtek.Size = new Size(120, 23);
            numericUpDownEloSejtek.TabIndex = 2;
            numericUpDownEloSejtek.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // button
            // 
            button.Location = new Point(394, 12);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 3;
            button.Text = "mentes";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.Location = new Point(12, 41);
            panel.Name = "panel";
            panel.Size = new Size(776, 397);
            panel.TabIndex = 4;
            panel.Paint += panel_Paint;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(button);
            Controls.Add(numericUpDownEloSejtek);
            Controls.Add(numericUpDownOszlopok);
            Controls.Add(numericUpDownSorok);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSorok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOszlopok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEloSejtek).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDownSorok;
        private NumericUpDown numericUpDownOszlopok;
        private NumericUpDown numericUpDownEloSejtek;
        private Button button;
        private Panel panel;
        private System.Windows.Forms.Timer timer;
    }
}
