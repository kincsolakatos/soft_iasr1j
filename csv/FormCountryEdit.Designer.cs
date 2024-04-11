namespace csv
{
    partial class FormCountryEdit
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
            countryname = new TextBox();
            bindingSource1 = new BindingSource(components);
            population = new TextBox();
            label2 = new Label();
            areainkm2 = new TextBox();
            label3 = new Label();
            ok = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "country name";
            // 
            // countryname
            // 
            countryname.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            countryname.Location = new Point(25, 43);
            countryname.Name = "countryname";
            countryname.Size = new Size(192, 23);
            countryname.TabIndex = 1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // population
            // 
            population.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            population.Location = new Point(25, 99);
            population.Name = "population";
            population.Size = new Size(192, 23);
            population.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "population";
            // 
            // areainkm2
            // 
            areainkm2.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            areainkm2.Location = new Point(25, 153);
            areainkm2.Name = "areainkm2";
            areainkm2.Size = new Size(192, 23);
            areainkm2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 135);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "area in km2";
            // 
            // ok
            // 
            ok.Location = new Point(139, 193);
            ok.Name = "ok";
            ok.Size = new Size(75, 23);
            ok.TabIndex = 6;
            ok.Text = "ok";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // FormCountryEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 232);
            Controls.Add(ok);
            Controls.Add(areainkm2);
            Controls.Add(label3);
            Controls.Add(population);
            Controls.Add(label2);
            Controls.Add(countryname);
            Controls.Add(label1);
            Name = "FormCountryEdit";
            Text = "FormCountryEdit";
            Load += FormCountryEdit_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox countryname;
        private TextBox population;
        private Label label2;
        private TextBox areainkm2;
        private Label label3;
        private BindingSource bindingSource1;
        private Button ok;
    }
}