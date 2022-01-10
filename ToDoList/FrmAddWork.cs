using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DateLayer;
namespace ToDoList
{
    public partial class FrmAddWork : Form
    {
        IWorkRepository rp = new WorkRepository();
        public FrmAddWork()
        {
            InitializeComponent();
            Cls();
        }
        public FrmAddWork(int id)
        {
            InitializeComponent();
            Cls(id);
        }

        public void Cls()
        {
            TBWorkID.Text = string.Empty;
            TBFinishDate.Text = string.Empty;
            TBCaption.Text = string.Empty;
            TBInfo.Text = string.Empty;
            TBHour.Text = string.Empty;
            TBMin.Text = string.Empty;
            CBIsDone.Checked = false;
            EditButt.Enabled = false;
            DoneButt.Enabled = true;
            DeleteButt.Enabled = false;
            TBWorkID.Enabled = true;
            SearchButt.Enabled = true;
        }
        public void Cls(int id)
        {
            Work src = rp.GetByID(id);
            TBWorkID.Text = src.WorkID.ToString();
            TBFinishDate.Text = src.Finish.ToShamsi();
            TBCaption.Text = src.Caption.ToString();
            TBInfo.Text = src.Info.ToString();
            TBHour.Text = src.Finish.Hour.ToString();
            TBMin.Text = src.Finish.Minute.ToString();
            CBIsDone.Checked = src.IsDone;
            EditButt.Enabled = true;
            DoneButt.Enabled = false;
            DeleteButt.Enabled = true;
            TBWorkID.Enabled = false;
            SearchButt.Enabled = false;
        }

        private void DoneButt_Click(object sender, EventArgs e)
        {

            Work src = new Work();
            src.Finish = ExtensionMethods.ToMiladi(TBFinishDate.Text,TBHour.Text,TBMin.Text);
            src.Caption = TBCaption.Text;
            src.Info = TBInfo.Text;
            src.IsDone = CBIsDone.Checked;
            rp.Insert(src);
            Cls();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Cls();
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            Work src = new Work();
            src.WorkID = Convert.ToInt32(TBWorkID.Text);
            src.Finish = ExtensionMethods.ToMiladi(TBFinishDate.Text, TBHour.Text, TBMin.Text);
            src.Caption = TBCaption.Text;
            src.Info = TBInfo.Text;
            src.IsDone = CBIsDone.Checked;
            if (!rp.Update(src)) MessageBox.Show("متاسفانه عملیات انجام نشد");
            Cls();
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            rp.Delete(Convert.ToInt32(TBWorkID.Text));
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButt_Click(object sender, EventArgs e)
        {
            try
            {
                Cls(rp.GetByID(Convert.ToInt32(TBWorkID.Text)).WorkID);
            }
            catch { MessageBox.Show("این کد فعالیت موجود نیست"); }
        }
    }
}
