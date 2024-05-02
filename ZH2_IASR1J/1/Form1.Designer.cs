namespace _1
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
            dataGridView1 = new DataGridView();
            italIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alkoholtartalomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egysegArDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nepszeruDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bindingSource1 = new BindingSource(components);
            buttonBetoltes = new Button();
            buttonMentes = new Button();
            buttonTorles = new Button();
            buttonUjSor = new Button();
            buttonErdekessegek = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { italIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, alkoholtartalomDataGridViewTextBoxColumn, egysegArDataGridViewTextBoxColumn, nepszeruDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(13, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(496, 368);
            dataGridView1.TabIndex = 0;
            // 
            // italIDDataGridViewTextBoxColumn
            // 
            italIDDataGridViewTextBoxColumn.DataPropertyName = "ItalID";
            italIDDataGridViewTextBoxColumn.HeaderText = "ItalID";
            italIDDataGridViewTextBoxColumn.Name = "italIDDataGridViewTextBoxColumn";
            italIDDataGridViewTextBoxColumn.Width = 59;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.Width = 53;
            // 
            // alkoholtartalomDataGridViewTextBoxColumn
            // 
            alkoholtartalomDataGridViewTextBoxColumn.DataPropertyName = "Alkoholtartalom";
            alkoholtartalomDataGridViewTextBoxColumn.HeaderText = "Alkoholtartalom";
            alkoholtartalomDataGridViewTextBoxColumn.Name = "alkoholtartalomDataGridViewTextBoxColumn";
            alkoholtartalomDataGridViewTextBoxColumn.Width = 118;
            // 
            // egysegArDataGridViewTextBoxColumn
            // 
            egysegArDataGridViewTextBoxColumn.DataPropertyName = "EgysegAr";
            egysegArDataGridViewTextBoxColumn.HeaderText = "EgysegAr";
            egysegArDataGridViewTextBoxColumn.Name = "egysegArDataGridViewTextBoxColumn";
            egysegArDataGridViewTextBoxColumn.Width = 81;
            // 
            // nepszeruDataGridViewCheckBoxColumn
            // 
            nepszeruDataGridViewCheckBoxColumn.DataPropertyName = "Nepszeru";
            nepszeruDataGridViewCheckBoxColumn.HeaderText = "Nepszeru";
            nepszeruDataGridViewCheckBoxColumn.Name = "nepszeruDataGridViewCheckBoxColumn";
            nepszeruDataGridViewCheckBoxColumn.Width = 62;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Ital);
            // 
            // buttonBetoltes
            // 
            buttonBetoltes.Location = new Point(434, 12);
            buttonBetoltes.Name = "buttonBetoltes";
            buttonBetoltes.Size = new Size(75, 23);
            buttonBetoltes.TabIndex = 1;
            buttonBetoltes.Text = "Betoltes";
            buttonBetoltes.UseVisualStyleBackColor = true;
            buttonBetoltes.Click += buttonBetoltes_Click;
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(353, 12);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(75, 23);
            buttonMentes.TabIndex = 2;
            buttonMentes.Text = "Mentes";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // buttonTorles
            // 
            buttonTorles.Location = new Point(353, 415);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(75, 23);
            buttonTorles.TabIndex = 3;
            buttonTorles.Text = "Torles";
            buttonTorles.UseVisualStyleBackColor = true;
            buttonTorles.Click += buttonTorles_Click;
            // 
            // buttonUjSor
            // 
            buttonUjSor.Location = new Point(434, 415);
            buttonUjSor.Name = "buttonUjSor";
            buttonUjSor.Size = new Size(75, 23);
            buttonUjSor.TabIndex = 4;
            buttonUjSor.Text = "Uj Sor";
            buttonUjSor.UseVisualStyleBackColor = true;
            buttonUjSor.Click += buttonUjSor_Click;
            // 
            // buttonErdekessegek
            // 
            buttonErdekessegek.Location = new Point(13, 12);
            buttonErdekessegek.Name = "buttonErdekessegek";
            buttonErdekessegek.Size = new Size(89, 23);
            buttonErdekessegek.TabIndex = 5;
            buttonErdekessegek.Text = "Erdekessegek";
            buttonErdekessegek.UseVisualStyleBackColor = true;
            buttonErdekessegek.Click += buttonErdekessegek_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(buttonErdekessegek);
            Controls.Add(buttonUjSor);
            Controls.Add(buttonTorles);
            Controls.Add(buttonMentes);
            Controls.Add(buttonBetoltes);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonBetoltes;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn italIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alkoholtartalomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegArDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn nepszeruDataGridViewCheckBoxColumn;
        private Button buttonMentes;
        private Button buttonTorles;
        private Button buttonUjSor;
        private Button buttonErdekessegek;
    }
}