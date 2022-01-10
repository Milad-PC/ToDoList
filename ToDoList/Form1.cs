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
    public partial class Form1 : Form
    {
        IWorkRepository rp = new WorkRepository();
        public Form1()
        {
            InitializeComponent();
            Location = new Point(Screen.FromControl(this).Bounds.Width - 400, 0);
            Size = new Size(400,(int) (Screen.FromControl(this).Bounds.Height * 0.96));
            DateLabel.Text = DateTime.Now.ToDateString();
            DoneButt.Enabled = false;
            EditButt.Enabled = false;
            DeleteButt.Enabled = false;
            FillDGV();
        }
        public void FillDGV()
        {
            List<Work> input = rp.GetWorks();

            int TodayWorkCount = 0;

            DGV.Rows.Clear();
            DGV.Columns.Clear();
            DGV.Columns.Add("WorkID", "کد");
            DGV.Columns.Add("Caption", "عنوان");
            DGV.Columns.Add("Finish", "روز");
            DGV.Columns["WorkID"].Width = 35;
            DGV.Columns["Finish"].Width = 50;

            foreach (var item in input)
            {
                int totalDay = (int)(item.Finish - DateTime.Now).TotalDays;
                int rowID = DGV.Rows.Add(item.WorkID,item.Caption, totalDay);

                if(totalDay < 1)
                {
                    DGV.Rows[rowID].DefaultCellStyle.BackColor = Color.IndianRed;
                }
                else if(totalDay == 1)
                {
                    TodayWorkCount++;
                    DGV.Rows[rowID].DefaultCellStyle.BackColor = Color.LightYellow;
                }
            }

            ToDayLabel.Text = TodayWorkCount.ToString();
            AllLabel.Text = input.Count().ToString();
            DGV.Refresh();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            Clock.Value = DateTime.Now;
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            DialogResult rslt = MessageBox.Show("آیا از حذف مطمئن هستید؟","اخطار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (rslt == DialogResult.Yes)
            {
                rp.Delete((int)DGV.SelectedRows[0].Cells["WorkID"].Value);
            }
            FillDGV();
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            FrmAddWork frm = new FrmAddWork();
            frm.FormClosed += (s,args) => { this.FillDGV(); };
            frm.ShowDialog();
        }

        private void DoneButt_Click(object sender, EventArgs e)
        {
            bool x = rp.IsDone((int)DGV.SelectedRows[0].Cells["WorkID"].Value);
            FillDGV();
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            FrmAddWork frm = new FrmAddWork((int)DGV.SelectedRows[0].Cells["WorkID"].Value);
            frm.FormClosed += (s, args) => { this.FillDGV(); };
            frm.ShowDialog();
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV.SelectedCells.Count > 0)
            {
                DoneButt.Enabled = true;
                EditButt.Enabled = true;
                DeleteButt.Enabled = true;
            }
            else
            {
                DoneButt.Enabled = false;
                EditButt.Enabled = false;
                DeleteButt.Enabled = false;
            }
        }
    }
}
