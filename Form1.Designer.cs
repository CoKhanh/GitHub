namespace QuanLyBanHang
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaThanhPho = new System.Windows.Forms.TextBox();
            this.txtTenThanhPho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewThanhPho = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.sbtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnDeny = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnDel = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnReload = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnExit = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnskin = new DevExpress.XtraEditors.SimpleButton();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanhPho)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtTenThanhPho);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtMaThanhPho);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(374, 104);
            this.panelMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thành phố:";
            // 
            // txtMaThanhPho
            // 
            this.txtMaThanhPho.Location = new System.Drawing.Point(114, 16);
            this.txtMaThanhPho.Name = "txtMaThanhPho";
            this.txtMaThanhPho.Size = new System.Drawing.Size(249, 21);
            this.txtMaThanhPho.TabIndex = 2;
            // 
            // txtTenThanhPho
            // 
            this.txtTenThanhPho.Location = new System.Drawing.Point(114, 55);
            this.txtTenThanhPho.Name = "txtTenThanhPho";
            this.txtTenThanhPho.Size = new System.Drawing.Size(249, 21);
            this.txtTenThanhPho.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thành phố:";
            // 
            // dataGridViewThanhPho
            // 
            this.dataGridViewThanhPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThanhPho.Location = new System.Drawing.Point(12, 122);
            this.dataGridViewThanhPho.Name = "dataGridViewThanhPho";
            this.dataGridViewThanhPho.Size = new System.Drawing.Size(374, 233);
            this.dataGridViewThanhPho.TabIndex = 5;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.sbtnskin);
            this.panelButton.Controls.Add(this.sbtnExit);
            this.panelButton.Controls.Add(this.sbtnReload);
            this.panelButton.Controls.Add(this.sbtnSave);
            this.panelButton.Controls.Add(this.sbtnDel);
            this.panelButton.Controls.Add(this.sbtnEdit);
            this.panelButton.Controls.Add(this.sbtnDeny);
            this.panelButton.Controls.Add(this.sbtnAdd);
            this.panelButton.Location = new System.Drawing.Point(12, 361);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(374, 88);
            this.panelButton.TabIndex = 5;
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.Location = new System.Drawing.Point(20, 13);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new System.Drawing.Size(75, 23);
            this.sbtnAdd.TabIndex = 0;
            this.sbtnAdd.Text = "Add";
            this.sbtnAdd.Click += new System.EventHandler(this.sbtnAdd_Click);
            // 
            // sbtnDeny
            // 
            this.sbtnDeny.Location = new System.Drawing.Point(20, 42);
            this.sbtnDeny.Name = "sbtnDeny";
            this.sbtnDeny.Size = new System.Drawing.Size(75, 23);
            this.sbtnDeny.TabIndex = 1;
            this.sbtnDeny.Text = "Deny";
            // 
            // sbtnEdit
            // 
            this.sbtnEdit.Location = new System.Drawing.Point(114, 13);
            this.sbtnEdit.Name = "sbtnEdit";
            this.sbtnEdit.Size = new System.Drawing.Size(75, 23);
            this.sbtnEdit.TabIndex = 2;
            this.sbtnEdit.Text = "Edit";
            this.sbtnEdit.Click += new System.EventHandler(this.sbtnEdit_Click);
            // 
            // sbtnDel
            // 
            this.sbtnDel.Location = new System.Drawing.Point(114, 42);
            this.sbtnDel.Name = "sbtnDel";
            this.sbtnDel.Size = new System.Drawing.Size(75, 23);
            this.sbtnDel.TabIndex = 3;
            this.sbtnDel.Text = "Delete";
            this.sbtnDel.Click += new System.EventHandler(this.sbtnDel_Click);
            // 
            // sbtnSave
            // 
            this.sbtnSave.Location = new System.Drawing.Point(207, 13);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new System.Drawing.Size(75, 23);
            this.sbtnSave.TabIndex = 4;
            this.sbtnSave.Text = "Save";
            this.sbtnSave.Click += new System.EventHandler(this.sbtnSave_Click);
            // 
            // sbtnReload
            // 
            this.sbtnReload.Location = new System.Drawing.Point(207, 42);
            this.sbtnReload.Name = "sbtnReload";
            this.sbtnReload.Size = new System.Drawing.Size(75, 23);
            this.sbtnReload.TabIndex = 5;
            this.sbtnReload.Text = "Reload";
            this.sbtnReload.Click += new System.EventHandler(this.sbtnReload_Click);
            // 
            // sbtnExit
            // 
            this.sbtnExit.Location = new System.Drawing.Point(288, 42);
            this.sbtnExit.Name = "sbtnExit";
            this.sbtnExit.Size = new System.Drawing.Size(75, 23);
            this.sbtnExit.TabIndex = 6;
            this.sbtnExit.Text = "Exit";
            this.sbtnExit.Click += new System.EventHandler(this.sbtnExit_Click);
            // 
            // sbtnskin
            // 
            this.sbtnskin.Location = new System.Drawing.Point(288, 13);
            this.sbtnskin.Name = "sbtnskin";
            this.sbtnskin.Size = new System.Drawing.Size(75, 23);
            this.sbtnskin.TabIndex = 7;
            this.sbtnskin.Text = "Skin";
            this.sbtnskin.Click += new System.EventHandler(this.sbtnskin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 461);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.dataGridViewThanhPho);
            this.Controls.Add(this.panelMain);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanhPho)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtTenThanhPho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaThanhPho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewThanhPho;
        private System.Windows.Forms.Panel panelButton;
        private DevExpress.XtraEditors.SimpleButton sbtnExit;
        private DevExpress.XtraEditors.SimpleButton sbtnReload;
        private DevExpress.XtraEditors.SimpleButton sbtnSave;
        private DevExpress.XtraEditors.SimpleButton sbtnDel;
        private DevExpress.XtraEditors.SimpleButton sbtnEdit;
        private DevExpress.XtraEditors.SimpleButton sbtnDeny;
        private DevExpress.XtraEditors.SimpleButton sbtnAdd;
        private DevExpress.XtraEditors.SimpleButton sbtnskin;
    }
}

