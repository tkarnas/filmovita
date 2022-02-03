namespace Filmovita
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.godinaIzdanja = new System.Windows.Forms.NumericUpDown();
            this.fiilmoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmovitaDataSet = new Filmovita.FilmovitaDataSet();
            this.textBoxLokacija = new System.Windows.Forms.TextBox();
            this.radioButtonMedij = new System.Windows.Forms.RadioButton();
            this.radioButtonRacunalo = new System.Windows.Forms.RadioButton();
            this.lokacijalbl = new System.Windows.Forms.Label();
            this.redatelj = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.redateljtxt = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.ocjena = new System.Windows.Forms.NumericUpDown();
            this.addbtn = new System.Windows.Forms.Button();
            this.trajanje = new System.Windows.Forms.TextBox();
            this.comboBoxZanr = new System.Windows.Forms.ComboBox();
            this.naziv = new System.Windows.Forms.TextBox();
            this.ocjenatxt = new System.Windows.Forms.Label();
            this.trajanjetxt = new System.Windows.Forms.Label();
            this.zanrrtxt = new System.Windows.Forms.Label();
            this.izdanjetxt = new System.Windows.Forms.Label();
            this.nazivtxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultgrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaIzdanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redateljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmovitaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmovitaDataSet1 = new Filmovita.FilmovitaDataSet1();
            this.button_refresh = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fiilmoviTableAdapter = new Filmovita.FilmovitaDataSetTableAdapters.fiilmoviTableAdapter();
            this.fiilmoviTableAdapter1 = new Filmovita.FilmovitaDataSetTableAdapters.fiilmoviTableAdapter();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.godinaIzdanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiilmoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmovitaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocjena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmovitaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmovitaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.CadetBlue;
            this.panel.Controls.Add(this.godinaIzdanja);
            this.panel.Controls.Add(this.textBoxLokacija);
            this.panel.Controls.Add(this.radioButtonMedij);
            this.panel.Controls.Add(this.radioButtonRacunalo);
            this.panel.Controls.Add(this.lokacijalbl);
            this.panel.Controls.Add(this.redatelj);
            this.panel.Controls.Add(this.deletebtn);
            this.panel.Controls.Add(this.redateljtxt);
            this.panel.Controls.Add(this.updatebtn);
            this.panel.Controls.Add(this.ocjena);
            this.panel.Controls.Add(this.addbtn);
            this.panel.Controls.Add(this.trajanje);
            this.panel.Controls.Add(this.comboBoxZanr);
            this.panel.Controls.Add(this.naziv);
            this.panel.Controls.Add(this.ocjenatxt);
            this.panel.Controls.Add(this.trajanjetxt);
            this.panel.Controls.Add(this.zanrrtxt);
            this.panel.Controls.Add(this.izdanjetxt);
            this.panel.Controls.Add(this.nazivtxt);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(-1, -4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1009, 467);
            this.panel.TabIndex = 0;
            // 
            // godinaIzdanja
            // 
            this.godinaIzdanja.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fiilmoviBindingSource, "GodinaIzdanja", true));
            this.godinaIzdanja.Location = new System.Drawing.Point(307, 81);
            this.godinaIzdanja.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.godinaIzdanja.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.godinaIzdanja.Name = "godinaIzdanja";
            this.godinaIzdanja.Size = new System.Drawing.Size(198, 20);
            this.godinaIzdanja.TabIndex = 21;
            this.godinaIzdanja.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // fiilmoviBindingSource
            // 
            this.fiilmoviBindingSource.DataMember = "fiilmovi";
            this.fiilmoviBindingSource.DataSource = this.filmovitaDataSet;
            // 
            // filmovitaDataSet
            // 
            this.filmovitaDataSet.DataSetName = "FilmovitaDataSet";
            this.filmovitaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxLokacija
            // 
            this.textBoxLokacija.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiilmoviBindingSource, "Lokacija", true));
            this.textBoxLokacija.Enabled = false;
            this.textBoxLokacija.Location = new System.Drawing.Point(305, 361);
            this.textBoxLokacija.Name = "textBoxLokacija";
            this.textBoxLokacija.Size = new System.Drawing.Size(200, 20);
            this.textBoxLokacija.TabIndex = 20;
            // 
            // radioButtonMedij
            // 
            this.radioButtonMedij.AutoSize = true;
            this.radioButtonMedij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMedij.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonMedij.Location = new System.Drawing.Point(408, 315);
            this.radioButtonMedij.Name = "radioButtonMedij";
            this.radioButtonMedij.Size = new System.Drawing.Size(97, 21);
            this.radioButtonMedij.TabIndex = 19;
            this.radioButtonMedij.TabStop = true;
            this.radioButtonMedij.Text = "Drugi medij";
            this.radioButtonMedij.UseVisualStyleBackColor = true;
            this.radioButtonMedij.CheckedChanged += new System.EventHandler(this.radioButtonMedij_CheckedChanged);
            // 
            // radioButtonRacunalo
            // 
            this.radioButtonRacunalo.AutoSize = true;
            this.radioButtonRacunalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRacunalo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonRacunalo.Location = new System.Drawing.Point(307, 315);
            this.radioButtonRacunalo.Name = "radioButtonRacunalo";
            this.radioButtonRacunalo.Size = new System.Drawing.Size(86, 21);
            this.radioButtonRacunalo.TabIndex = 18;
            this.radioButtonRacunalo.TabStop = true;
            this.radioButtonRacunalo.Text = "Računalo";
            this.radioButtonRacunalo.UseVisualStyleBackColor = true;
            this.radioButtonRacunalo.CheckedChanged += new System.EventHandler(this.radioButtonRacunalo_CheckedChanged);
            // 
            // lokacijalbl
            // 
            this.lokacijalbl.AutoSize = true;
            this.lokacijalbl.BackColor = System.Drawing.Color.CadetBlue;
            this.lokacijalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lokacijalbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lokacijalbl.Location = new System.Drawing.Point(55, 313);
            this.lokacijalbl.Name = "lokacijalbl";
            this.lokacijalbl.Size = new System.Drawing.Size(80, 20);
            this.lokacijalbl.TabIndex = 17;
            this.lokacijalbl.Text = "Lokacija:";
            // 
            // redatelj
            // 
            this.redatelj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiilmoviBindingSource, "Redatelj", true));
            this.redatelj.Location = new System.Drawing.Point(307, 268);
            this.redatelj.Name = "redatelj";
            this.redatelj.Size = new System.Drawing.Size(198, 20);
            this.redatelj.TabIndex = 6;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletebtn.Location = new System.Drawing.Point(767, 260);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(107, 39);
            this.deletebtn.TabIndex = 10;
            this.deletebtn.Text = "Izbriši";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // redateljtxt
            // 
            this.redateljtxt.AutoSize = true;
            this.redateljtxt.BackColor = System.Drawing.Color.CadetBlue;
            this.redateljtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redateljtxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.redateljtxt.Location = new System.Drawing.Point(55, 268);
            this.redateljtxt.Name = "redateljtxt";
            this.redateljtxt.Size = new System.Drawing.Size(81, 20);
            this.redateljtxt.TabIndex = 12;
            this.redateljtxt.Text = "Redatelj:";
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updatebtn.Location = new System.Drawing.Point(767, 173);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(107, 39);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.Text = "Ažuriraj";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // ocjena
            // 
            this.ocjena.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fiilmoviBindingSource, "Ocjena", true));
            this.ocjena.DecimalPlaces = 1;
            this.ocjena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ocjena.Location = new System.Drawing.Point(307, 218);
            this.ocjena.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ocjena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ocjena.Name = "ocjena";
            this.ocjena.Size = new System.Drawing.Size(198, 20);
            this.ocjena.TabIndex = 5;
            this.ocjena.ThousandsSeparator = true;
            this.ocjena.Value = new decimal(new int[] {
            81,
            0,
            0,
            65536});
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Teal;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addbtn.Location = new System.Drawing.Point(767, 89);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(107, 39);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "Dodaj";
            this.addbtn.UseMnemonic = false;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // trajanje
            // 
            this.trajanje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiilmoviBindingSource, "Trajanje", true));
            this.trajanje.Location = new System.Drawing.Point(307, 173);
            this.trajanje.Name = "trajanje";
            this.trajanje.Size = new System.Drawing.Size(198, 20);
            this.trajanje.TabIndex = 4;
            this.trajanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trajanje_KeyPress);
            // 
            // comboBoxZanr
            // 
            this.comboBoxZanr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiilmoviBindingSource, "Zanr", true));
            this.comboBoxZanr.FormattingEnabled = true;
            this.comboBoxZanr.Items.AddRange(new object[] {
            "Akcija",
            "Komediija",
            "Triler",
            "Horor",
            "Drama",
            "Akcijska komedija",
            "Avantura",
            "Fantazija",
            "Dokumentarni",
            "Kriminalistički",
            "Sportski"});
            this.comboBoxZanr.Location = new System.Drawing.Point(307, 127);
            this.comboBoxZanr.Name = "comboBoxZanr";
            this.comboBoxZanr.Size = new System.Drawing.Size(198, 21);
            this.comboBoxZanr.TabIndex = 3;
            // 
            // naziv
            // 
            this.naziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiilmoviBindingSource, "Naziv", true));
            this.naziv.Location = new System.Drawing.Point(305, 36);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(200, 20);
            this.naziv.TabIndex = 1;
            // 
            // ocjenatxt
            // 
            this.ocjenatxt.AutoSize = true;
            this.ocjenatxt.BackColor = System.Drawing.Color.CadetBlue;
            this.ocjenatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocjenatxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ocjenatxt.Location = new System.Drawing.Point(55, 218);
            this.ocjenatxt.Name = "ocjenatxt";
            this.ocjenatxt.Size = new System.Drawing.Size(115, 20);
            this.ocjenatxt.TabIndex = 6;
            this.ocjenatxt.Text = "IMDb ocjena:";
            // 
            // trajanjetxt
            // 
            this.trajanjetxt.AutoSize = true;
            this.trajanjetxt.BackColor = System.Drawing.Color.CadetBlue;
            this.trajanjetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trajanjetxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trajanjetxt.Location = new System.Drawing.Point(55, 173);
            this.trajanjetxt.Name = "trajanjetxt";
            this.trajanjetxt.Size = new System.Drawing.Size(123, 20);
            this.trajanjetxt.TabIndex = 5;
            this.trajanjetxt.Text = "Trajanje (min):";
            // 
            // zanrrtxt
            // 
            this.zanrrtxt.AutoSize = true;
            this.zanrrtxt.BackColor = System.Drawing.Color.CadetBlue;
            this.zanrrtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zanrrtxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zanrrtxt.Location = new System.Drawing.Point(55, 128);
            this.zanrrtxt.Name = "zanrrtxt";
            this.zanrrtxt.Size = new System.Drawing.Size(109, 20);
            this.zanrrtxt.TabIndex = 4;
            this.zanrrtxt.Text = "Filmski žanr:";
            // 
            // izdanjetxt
            // 
            this.izdanjetxt.AutoSize = true;
            this.izdanjetxt.BackColor = System.Drawing.Color.CadetBlue;
            this.izdanjetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izdanjetxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.izdanjetxt.Location = new System.Drawing.Point(55, 81);
            this.izdanjetxt.Name = "izdanjetxt";
            this.izdanjetxt.Size = new System.Drawing.Size(134, 20);
            this.izdanjetxt.TabIndex = 3;
            this.izdanjetxt.Text = "Godina izdanja:";
            // 
            // nazivtxt
            // 
            this.nazivtxt.AutoSize = true;
            this.nazivtxt.BackColor = System.Drawing.Color.CadetBlue;
            this.nazivtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivtxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nazivtxt.Location = new System.Drawing.Point(55, 36);
            this.nazivtxt.Name = "nazivtxt";
            this.nazivtxt.Size = new System.Drawing.Size(57, 20);
            this.nazivtxt.TabIndex = 2;
            this.nazivtxt.Text = "Naziv:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(615, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 461);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // resultgrid
            // 
            this.resultgrid.AllowUserToAddRows = false;
            this.resultgrid.AutoGenerateColumns = false;
            this.resultgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultgrid.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.resultgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nazivDataGridViewTextBoxColumn,
            this.godinaIzdanjaDataGridViewTextBoxColumn,
            this.zanrDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn,
            this.ocjenaDataGridViewTextBoxColumn,
            this.redateljDataGridViewTextBoxColumn,
            this.lokacijaDataGridViewTextBoxColumn});
            this.resultgrid.DataSource = this.fiilmoviBindingSource;
            this.resultgrid.Location = new System.Drawing.Point(-1, 454);
            this.resultgrid.Name = "resultgrid";
            this.resultgrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultgrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.resultgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultgrid.Size = new System.Drawing.Size(1009, 300);
            this.resultgrid.TabIndex = 15;
            this.resultgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultgrid_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // godinaIzdanjaDataGridViewTextBoxColumn
            // 
            this.godinaIzdanjaDataGridViewTextBoxColumn.DataPropertyName = "GodinaIzdanja";
            this.godinaIzdanjaDataGridViewTextBoxColumn.HeaderText = "GodinaIzdanja";
            this.godinaIzdanjaDataGridViewTextBoxColumn.Name = "godinaIzdanjaDataGridViewTextBoxColumn";
            // 
            // zanrDataGridViewTextBoxColumn
            // 
            this.zanrDataGridViewTextBoxColumn.DataPropertyName = "Zanr";
            this.zanrDataGridViewTextBoxColumn.HeaderText = "Zanr";
            this.zanrDataGridViewTextBoxColumn.Name = "zanrDataGridViewTextBoxColumn";
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            // 
            // ocjenaDataGridViewTextBoxColumn
            // 
            this.ocjenaDataGridViewTextBoxColumn.DataPropertyName = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.Name = "ocjenaDataGridViewTextBoxColumn";
            // 
            // redateljDataGridViewTextBoxColumn
            // 
            this.redateljDataGridViewTextBoxColumn.DataPropertyName = "Redatelj";
            this.redateljDataGridViewTextBoxColumn.HeaderText = "Redatelj";
            this.redateljDataGridViewTextBoxColumn.Name = "redateljDataGridViewTextBoxColumn";
            // 
            // lokacijaDataGridViewTextBoxColumn
            // 
            this.lokacijaDataGridViewTextBoxColumn.DataPropertyName = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.HeaderText = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.Name = "lokacijaDataGridViewTextBoxColumn";
            // 
            // filmovitaDataSet1BindingSource
            // 
            this.filmovitaDataSet1BindingSource.DataSource = this.filmovitaDataSet1;
            this.filmovitaDataSet1BindingSource.Position = 0;
            // 
            // filmovitaDataSet1
            // 
            this.filmovitaDataSet1.DataSetName = "FilmovitaDataSet1";
            this.filmovitaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_refresh.Location = new System.Drawing.Point(445, 409);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(107, 39);
            this.button_refresh.TabIndex = 18;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseMnemonic = false;
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Visible = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // fiilmoviTableAdapter
            // 
            this.fiilmoviTableAdapter.ClearBeforeFill = true;
            // 
            // fiilmoviTableAdapter1
            // 
            this.fiilmoviTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1007, 754);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.resultgrid);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Filmovita";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.godinaIzdanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiilmoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmovitaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocjena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmovitaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmovitaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label ocjenatxt;
        private System.Windows.Forms.Label trajanjetxt;
        private System.Windows.Forms.Label zanrrtxt;
        private System.Windows.Forms.Label izdanjetxt;
        private System.Windows.Forms.Label nazivtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox trajanje;
        private System.Windows.Forms.ComboBox comboBoxZanr;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.NumericUpDown ocjena;
        private System.Windows.Forms.TextBox redatelj;
        private System.Windows.Forms.Label redateljtxt;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView resultgrid;
        private System.Windows.Forms.Label lokacijalbl;
        private FilmovitaDataSet filmovitaDataSet;
        private System.Windows.Forms.BindingSource fiilmoviBindingSource;
        private FilmovitaDataSetTableAdapters.fiilmoviTableAdapter fiilmoviTableAdapter;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.RadioButton radioButtonMedij;
        private System.Windows.Forms.RadioButton radioButtonRacunalo;
        private System.Windows.Forms.TextBox textBoxLokacija;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource filmovitaDataSet1BindingSource;
        private FilmovitaDataSet1 filmovitaDataSet1;
        private FilmovitaDataSetTableAdapters.fiilmoviTableAdapter fiilmoviTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaIzdanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redateljDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown godinaIzdanja;
    }
}

