namespace Igraionica
{
    partial class frmSony
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipSonyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igraionicaDataSet = new Igraionica.IgraionicaDataSet();
            this.accSonyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accSonyTableAdapter = new Igraionica.IgraionicaDataSetTableAdapters.AccSonyTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sonyAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipSonyTableAdapter = new Igraionica.IgraionicaDataSetTableAdapters.TipSonyTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipSonyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraionicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accSonyBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.tipSDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.accSonyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "Sifra";
            this.sifraDataGridViewTextBoxColumn.HeaderText = "Sifra";
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // tipSDataGridViewTextBoxColumn
            // 
            this.tipSDataGridViewTextBoxColumn.DataPropertyName = "TipS";
            this.tipSDataGridViewTextBoxColumn.DataSource = this.tipSonyBindingSource;
            this.tipSDataGridViewTextBoxColumn.DisplayMember = "Opis";
            this.tipSDataGridViewTextBoxColumn.HeaderText = "TipS";
            this.tipSDataGridViewTextBoxColumn.Name = "tipSDataGridViewTextBoxColumn";
            this.tipSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipSDataGridViewTextBoxColumn.ValueMember = "TipS";
            // 
            // tipSonyBindingSource
            // 
            this.tipSonyBindingSource.DataMember = "TipSony";
            this.tipSonyBindingSource.DataSource = this.igraionicaDataSet;
            // 
            // igraionicaDataSet
            // 
            this.igraionicaDataSet.DataSetName = "IgraionicaDataSet";
            this.igraionicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accSonyBindingSource
            // 
            this.accSonyBindingSource.DataMember = "AccSony";
            this.accSonyBindingSource.DataSource = this.igraionicaDataSet;
            // 
            // accSonyTableAdapter
            // 
            this.accSonyTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(147, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortiraj po tipu";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 95);
            this.listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tipSonyBindingSource;
            this.comboBox1.DisplayMember = "Opis";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "TipS";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sonyAccToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sonyAccToolStripMenuItem
            // 
            this.sonyAccToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviToolStripMenuItem,
            this.pretraziToolStripMenuItem,
            this.stampajToolStripMenuItem});
            this.sonyAccToolStripMenuItem.Name = "sonyAccToolStripMenuItem";
            this.sonyAccToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.sonyAccToolStripMenuItem.Text = "Sony acc";
            // 
            // noviToolStripMenuItem
            // 
            this.noviToolStripMenuItem.Name = "noviToolStripMenuItem";
            this.noviToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.noviToolStripMenuItem.Text = "Novi";
            this.noviToolStripMenuItem.Click += new System.EventHandler(this.noviToolStripMenuItem_Click);
            // 
            // pretraziToolStripMenuItem
            // 
            this.pretraziToolStripMenuItem.Name = "pretraziToolStripMenuItem";
            this.pretraziToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.pretraziToolStripMenuItem.Text = "Pretrazi";
            this.pretraziToolStripMenuItem.Click += new System.EventHandler(this.pretraziToolStripMenuItem_Click);
            // 
            // stampajToolStripMenuItem
            // 
            this.stampajToolStripMenuItem.Name = "stampajToolStripMenuItem";
            this.stampajToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stampajToolStripMenuItem.Text = "Stampaj";
            this.stampajToolStripMenuItem.Click += new System.EventHandler(this.stampajToolStripMenuItem_Click);
            // 
            // tipSonyTableAdapter
            // 
            this.tipSonyTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrisiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // obrisiToolStripMenuItem
            // 
            this.obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
            this.obrisiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.obrisiToolStripMenuItem.Text = "Obrisi";
            this.obrisiToolStripMenuItem.Click += new System.EventHandler(this.obrisiToolStripMenuItem_Click);
            // 
            // frmSony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSony";
            this.Text = "Sony";
            this.Load += new System.EventHandler(this.frmSony_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipSonyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraionicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accSonyBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private IgraionicaDataSet igraionicaDataSet;
        private System.Windows.Forms.BindingSource accSonyBindingSource;
        private IgraionicaDataSetTableAdapters.AccSonyTableAdapter accSonyTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sonyAccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziToolStripMenuItem;
        private System.Windows.Forms.BindingSource tipSonyBindingSource;
        private IgraionicaDataSetTableAdapters.TipSonyTableAdapter tipSonyTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem stampajToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
    }
}