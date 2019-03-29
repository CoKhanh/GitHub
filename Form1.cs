using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using DevExpress.XtraEditors;
namespace QuanLyBanHang
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        bool add;
        public Form1()
        {
            InitializeComponent();
        }
        
        void LoadData()
        {
            txtMaThanhPho.ResetText();
            txtTenThanhPho.ResetText();

            sbtnSave.Enabled = false;
            sbtnDeny.Enabled = false;
            panelMain.Enabled = false;
            try
            {
                DataClasses1DataContext qlBH = new DataClasses1DataContext();
                dataGridViewThanhPho.DataSource = qlBH.ThanhPhos;
            }
            catch
            {
                XtraMessageBox.Show("Error Load Data");
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void sbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(XtraMessageBox.Show("Do you want to exit App?","Exit",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Edit by GitKraken");
            add = true;
            txtMaThanhPho.Enabled = true;

            txtMaThanhPho.ResetText();
            txtTenThanhPho.ResetText();

            sbtnSave.Enabled = true;
            sbtnDeny.Enabled = true;
            panelMain.Enabled = true;

           
            //sbtnExit.Enabled = false;

            txtMaThanhPho.Focus();
        }

        private void dataGridViewThanhPho_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            //thứ tự dòng
            int r = dataGridViewThanhPho.CurrentCell.RowIndex;
            //Chuyển đổi thông tin
            txtMaThanhPho.Text = dataGridViewThanhPho.Rows[r].Cells[0].Value.ToString();
            txtTenThanhPho.Text = dataGridViewThanhPho.Rows[r].Cells[1].Value.ToString();
        }
        private void sbtnEdit_Click(object sender, EventArgs e)
        {

            add = false;
            dataGridViewThanhPho_CellClick(null, null);
            panelMain.Enabled = true;

            sbtnSave.Enabled = true;
            sbtnDeny.Enabled = true;

            sbtnAdd.Enabled = false;
            sbtnDel.Enabled = false;
            sbtnEdit.Enabled = false;
            //sbtnExit.Enabled = false;

            txtMaThanhPho.Enabled = false;
            txtTenThanhPho.Focus();
        }

        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if(!txtMaThanhPho.Text.Trim().Equals(""))
            {
                if(add)
                {
                    try
                    {
                        DataClasses1DataContext qlBH = new DataClasses1DataContext();
                        ThanhPho tp = new ThanhPho();
                        tp.ThanhPho1 = txtMaThanhPho.Text;
                        tp.TenThanhPho = txtTenThanhPho.Text;

                        qlBH.ThanhPhos.InsertOnSubmit(tp);
                        qlBH.ThanhPhos.Context.SubmitChanges();

                        LoadData();
                        XtraMessageBox.Show("Done");
                    }
                    catch
                    {
                        XtraMessageBox.Show("ErrorSave");
                    }
                }
                else
                {
                    try
                    {
                        int r = dataGridViewThanhPho.CurrentCell.RowIndex;

                        string strThanhpho = dataGridViewThanhPho.Rows[r].Cells[0].Value.ToString();

                        //SQL
                        DataClasses1DataContext qlBH = new DataClasses1DataContext();
                        var tpQuery = (from tp in qlBH.ThanhPhos where tp.ThanhPho1 == strThanhpho select tp).SingleOrDefault();
                        if(tpQuery!=null)
                        {
                            tpQuery.TenThanhPho = txtTenThanhPho.Text;
                            qlBH.SubmitChanges();
                            LoadData();
                        }

                        LoadData();
                        XtraMessageBox.Show("Edit DONE");
                    }
                    catch
                    {
                        XtraMessageBox.Show("Edit error");
                    }

                }
            }
            else
            {
                XtraMessageBox.Show("Invalid ThanhPho");
                txtMaThanhPho.Focus();
            }
        }

        private void sbtnDel_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = XtraMessageBox.Show("Make sure to delete", "Delete Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(traloi==DialogResult.OK)
            {
                try
                {
                    DataClasses1DataContext qlBH = new DataClasses1DataContext();
                    var tpQuery = from tp in qlBH.ThanhPhos where tp.ThanhPho1 == txtMaThanhPho.Text select tp;

                    qlBH.ThanhPhos.DeleteAllOnSubmit(tpQuery);
                    qlBH.SubmitChanges();
                    LoadData();
                }
                catch
                {
                    XtraMessageBox.Show("Del Error");
                }
            }
        }

        private void sbtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
           //Application.Restart();
        }

        private void sbtnskin_Click(object sender, EventArgs e)
        {
            LookAndFeel.SetSkinStyle("Stardust");
        }
    }
}
