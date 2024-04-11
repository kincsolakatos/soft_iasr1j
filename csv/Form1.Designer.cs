namespace csv
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
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            populationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaInSquareKmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataBindingSource = new BindingSource(components);
            megnyitas = new Button();
            szerkesztes = new Button();
            torles = new Button();
            save = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, populationDataGridViewTextBoxColumn, areaInSquareKmDataGridViewTextBoxColumn });
            dataGridView1.DataSource = countryDataBindingSource;
            dataGridView1.Location = new Point(24, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(341, 286);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn.HeaderText = "Population";
            populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // megnyitas
            // 
            megnyitas.Location = new Point(24, 23);
            megnyitas.Name = "megnyitas";
            megnyitas.Size = new Size(75, 23);
            megnyitas.TabIndex = 1;
            megnyitas.Text = "megnyitas";
            megnyitas.UseVisualStyleBackColor = true;
            megnyitas.Click += megnyitas_Click;
            // 
            // szerkesztes
            // 
            szerkesztes.Location = new Point(24, 378);
            szerkesztes.Name = "szerkesztes";
            szerkesztes.Size = new Size(75, 23);
            szerkesztes.TabIndex = 2;
            szerkesztes.Text = "szerkesztes";
            szerkesztes.UseVisualStyleBackColor = true;
            szerkesztes.Click += szerkesztes_Click;
            // 
            // torles
            // 
            torles.Location = new Point(123, 378);
            torles.Name = "torles";
            torles.Size = new Size(75, 23);
            torles.TabIndex = 3;
            torles.Text = "torles";
            torles.UseVisualStyleBackColor = true;
            torles.Click += torles_Click;
            // 
            // save
            // 
            save.Location = new Point(221, 378);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 4;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 450);
            Controls.Add(save);
            Controls.Add(torles);
            Controls.Add(szerkesztes);
            Controls.Add(megnyitas);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button megnyitas;
        private Button szerkesztes;
        private Button torles;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private BindingSource countryDataBindingSource;
        private Button save;
    }
}