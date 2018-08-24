namespace Igraionica
{
    partial class frmIgraionica
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
            this.btnUnesiSony = new System.Windows.Forms.Button();
            this.btnUnesiPc = new System.Windows.Forms.Button();
            this.brAccZaSonyIPcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igraionicaDataSet = new Igraionica.IgraionicaDataSet();
            this.brAccZaSonyIPcTableAdapter = new Igraionica.IgraionicaDataSetTableAdapters.BrAccZaSonyIPcTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.brAccZaSonyIPcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraionicaDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnesiSony
            // 
            this.btnUnesiSony.Location = new System.Drawing.Point(22, 119);
            this.btnUnesiSony.Name = "btnUnesiSony";
            this.btnUnesiSony.Size = new System.Drawing.Size(132, 23);
            this.btnUnesiSony.TabIndex = 0;
            this.btnUnesiSony.Text = "Unesi novi acc za Sony";
            this.btnUnesiSony.UseVisualStyleBackColor = true;
            this.btnUnesiSony.Click += new System.EventHandler(this.btnUnesiSony_Click);
            // 
            // btnUnesiPc
            // 
            this.btnUnesiPc.Location = new System.Drawing.Point(232, 119);
            this.btnUnesiPc.Name = "btnUnesiPc";
            this.btnUnesiPc.Size = new System.Drawing.Size(128, 23);
            this.btnUnesiPc.TabIndex = 1;
            this.btnUnesiPc.Text = "Unesi novi acc za Pc";
            this.btnUnesiPc.UseVisualStyleBackColor = true;
            this.btnUnesiPc.Click += new System.EventHandler(this.btnUnesiPc_Click);
            // 
            // brAccZaSonyIPcBindingSource
            // 
            this.brAccZaSonyIPcBindingSource.DataMember = "BrAccZaSonyIPc";
            this.brAccZaSonyIPcBindingSource.DataSource = this.igraionicaDataSet;
            // 
            // igraionicaDataSet
            // 
            this.igraionicaDataSet.DataSetName = "IgraionicaDataSet";
            this.igraionicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brAccZaSonyIPcTableAdapter
            // 
            this.brAccZaSonyIPcTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.logInToolStripMenuItem.Text = "LogIn";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.logOffToolStripMenuItem.Text = "LogOff";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // frmIgraionica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 167);
            this.Controls.Add(this.btnUnesiPc);
            this.Controls.Add(this.btnUnesiSony);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmIgraionica";
            this.Text = "Igraionica";
            this.Load += new System.EventHandler(this.frmIgraionica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brAccZaSonyIPcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraionicaDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesiSony;
        private System.Windows.Forms.Button btnUnesiPc;
        private IgraionicaDataSet igraionicaDataSet;
        private System.Windows.Forms.BindingSource brAccZaSonyIPcBindingSource;
        private IgraionicaDataSetTableAdapters.BrAccZaSonyIPcTableAdapter brAccZaSonyIPcTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
    }
}

