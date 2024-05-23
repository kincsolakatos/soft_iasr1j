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
            labelSorok = new Label();
            labelOszlopok = new Label();
            labelEloSejtek = new Label();
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
            // labelSorok
            // 
            labelSorok.AutoSize = true;
            labelSorok.Location = new Point(12, 9);
            labelSorok.Name = "labelSorok";
            labelSorok.Size = new Size(37, 15);
            labelSorok.TabIndex = 0;
            labelSorok.Text = "Sorok";
            // 
            // labelOszlopok
            // 
            labelOszlopok.AutoSize = true;
            labelOszlopok.Location = new Point(138, 9);
            labelOszlopok.Name = "labelOszlopok";
            labelOszlopok.Size = new Size(56, 15);
            labelOszlopok.TabIndex = 1;
            labelOszlopok.Text = "Oszlopok";
            // 
            // labelEloSejtek
            // 
            labelEloSejtek.AutoSize = true;
            labelEloSejtek.Location = new Point(264, 9);
            labelEloSejtek.Name = "labelEloSejtek";
            labelEloSejtek.Size = new Size(57, 15);
            labelEloSejtek.TabIndex = 2;
            labelEloSejtek.Text = "Elo Sejtek";
            // 
            // numericUpDownSorok
            // 
            numericUpDownSorok.Location = new Point(12, 27);
            numericUpDownSorok.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownSorok.Name = "numericUpDownSorok";
            numericUpDownSorok.Size = new Size(120, 23);
            numericUpDownSorok.TabIndex = 3;
            numericUpDownSorok.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numericUpDownOszlopok
            // 
            numericUpDownOszlopok.Location = new Point(138, 27);
            numericUpDownOszlopok.Name = "numericUpDownOszlopok";
            numericUpDownOszlopok.Size = new Size(120, 23);
            numericUpDownOszlopok.TabIndex = 4;
            numericUpDownOszlopok.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDownEloSejtek
            // 
            numericUpDownEloSejtek.Location = new Point(264, 27);
            numericUpDownEloSejtek.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownEloSejtek.Name = "numericUpDownEloSejtek";
            numericUpDownEloSejtek.Size = new Size(120, 23);
            numericUpDownEloSejtek.TabIndex = 5;
            numericUpDownEloSejtek.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // button
            // 
            button.Location = new Point(390, 27);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 6;
            button.Text = "Start";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.Location = new Point(12, 56);
            panel.Name = "panel";
            panel.Size = new Size(776, 382);
            panel.TabIndex = 7;
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
            Controls.Add(labelEloSejtek);
            Controls.Add(labelOszlopok);
            Controls.Add(labelSorok);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSorok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOszlopok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEloSejtek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSorok;
        private Label labelOszlopok;
        private Label labelEloSejtek;
        private NumericUpDown numericUpDownSorok;
        private NumericUpDown numericUpDownOszlopok;
        private NumericUpDown numericUpDownEloSejtek;
        private Button button;
        private Panel panel;
        private System.Windows.Forms.Timer timer;
    }
}