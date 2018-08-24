namespace Igraionica
{
    partial class frmSonyNovi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.igraionicaDataSet = new Igraionica.IgraionicaDataSet();
            this.tipSonyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipSonyTableAdapter = new Igraionica.IgraionicaDataSetTableAdapters.TipSonyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igraionicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipSonyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip sonia";
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(89, 39);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(43, 20);
            this.tbSifra.TabIndex = 4;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(89, 76);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(121, 20);
            this.tbUsername.TabIndex = 5;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(89, 113);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(121, 20);
            this.tbPass.TabIndex = 6;
            // 
            // cbTip
            // 
            this.cbTip.DataSource = this.tipSonyBindingSource;
            this.cbTip.DisplayMember = "Opis";
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(89, 150);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(121, 21);
            this.cbTip.TabIndex = 7;
            this.cbTip.ValueMember = "TipS";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(89, 214);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 8;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // igraionicaDataSet
            // 
            this.igraionicaDataSet.DataSetName = "IgraionicaDataSet";
            this.igraionicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipSonyBindingSource
            // 
            this.tipSonyBindingSource.DataMember = "TipSony";
            this.tipSonyBindingSource.DataSource = this.igraionicaDataSet;
            // 
            // tipSonyTableAdapter
            // 
            this.tipSonyTableAdapter.ClearBeforeFill = true;
            // 
            // frmSonyNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 258);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSonyNovi";
            this.Text = "frmSonyNovi";
            this.Load += new System.EventHandler(this.frmSonyNovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igraionicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipSonyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Button btnUnesi;
        private IgraionicaDataSet igraionicaDataSet;
        private System.Windows.Forms.BindingSource tipSonyBindingSource;
        private IgraionicaDataSetTableAdapters.TipSonyTableAdapter tipSonyTableAdapter;
    }
}