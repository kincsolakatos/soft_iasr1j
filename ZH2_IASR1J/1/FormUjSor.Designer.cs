namespace _1
{
    partial class FormUjSor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBoxItalID = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBoxNev = new TextBox();
            label2 = new Label();
            textBoxAlkoholtartalom = new TextBox();
            label3 = new Label();
            textBoxEgysegAr = new TextBox();
            label4 = new Label();
            checkBoxNepszeru = new CheckBox();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Ital azonositoja";
            // 
            // textBoxItalID
            // 
            textBoxItalID.DataBindings.Add(new Binding("Text", bindingSource1, "ItalID", true));
            textBoxItalID.Location = new Point(12, 27);
            textBoxItalID.Name = "textBoxItalID";
            textBoxItalID.Size = new Size(253, 23);
            textBoxItalID.TabIndex = 1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Ital);
            // 
            // textBoxNev
            // 
            textBoxNev.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBoxNev.Location = new Point(12, 71);
            textBoxNev.Name = "textBoxNev";
            textBoxNev.Size = new Size(253, 23);
            textBoxNev.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Nev";
            // 
            // textBoxAlkoholtartalom
            // 
            textBoxAlkoholtartalom.DataBindings.Add(new Binding("Text", bindingSource1, "Alkoholtartalom", true));
            textBoxAlkoholtartalom.Location = new Point(12, 115);
            textBoxAlkoholtartalom.Name = "textBoxAlkoholtartalom";
            textBoxAlkoholtartalom.Size = new Size(253, 23);
            textBoxAlkoholtartalom.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Alkoholtartalom";
            // 
            // textBoxEgysegAr
            // 
            textBoxEgysegAr.DataBindings.Add(new Binding("Text", bindingSource1, "EgysegAr", true));
            textBoxEgysegAr.Location = new Point(12, 159);
            textBoxEgysegAr.Name = "textBoxEgysegAr";
            textBoxEgysegAr.Size = new Size(253, 23);
            textBoxEgysegAr.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Egysegar";
            // 
            // checkBoxNepszeru
            // 
            checkBoxNepszeru.AutoSize = true;
            checkBoxNepszeru.DataBindings.Add(new Binding("Text", bindingSource1, "Nepszeru", true));
            checkBoxNepszeru.Location = new Point(12, 188);
            checkBoxNepszeru.Name = "checkBoxNepszeru";
            checkBoxNepszeru.Size = new Size(80, 19);
            checkBoxNepszeru.TabIndex = 8;
            checkBoxNepszeru.Text = "Nepszeru?";
            checkBoxNepszeru.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(89, 213);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 9;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormUjSor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 247);
            Controls.Add(buttonOk);
            Controls.Add(checkBoxNepszeru);
            Controls.Add(textBoxEgysegAr);
            Controls.Add(label4);
            Controls.Add(textBoxAlkoholtartalom);
            Controls.Add(label3);
            Controls.Add(textBoxNev);
            Controls.Add(label2);
            Controls.Add(textBoxItalID);
            Controls.Add(label1);
            Name = "FormUjSor";
            Text = "FormUjSor";
            Load += FormUjSor_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxItalID;
        private TextBox textBoxNev;
        private Label label2;
        private TextBox textBoxAlkoholtartalom;
        private Label label3;
        private TextBox textBoxEgysegAr;
        private Label label4;
        private CheckBox checkBoxNepszeru;
        private Button buttonOk;
        private BindingSource bindingSource1;
    }
}