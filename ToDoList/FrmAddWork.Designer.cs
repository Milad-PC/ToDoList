namespace ToDoList
{
    partial class FrmAddWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddWork));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBFinishDate = new Atf.UI.DateTimeSelector();
            this.CBIsDone = new System.Windows.Forms.CheckBox();
            this.TBInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBHour = new System.Windows.Forms.TextBox();
            this.TBMin = new System.Windows.Forms.TextBox();
            this.TBCaption = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBWorkID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.ExitButt = new System.Windows.Forms.Button();
            this.EditButt = new System.Windows.Forms.Button();
            this.DoneButt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBFinishDate);
            this.groupBox1.Controls.Add(this.CBIsDone);
            this.groupBox1.Controls.Add(this.TBInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBHour);
            this.groupBox1.Controls.Add(this.TBMin);
            this.groupBox1.Controls.Add(this.TBCaption);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBWorkID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchButt);
            this.groupBox1.Location = new System.Drawing.Point(119, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(279, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TBFinishDate
            // 
            this.TBFinishDate.Location = new System.Drawing.Point(8, 72);
            this.TBFinishDate.Name = "TBFinishDate";
            this.TBFinishDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBFinishDate.Size = new System.Drawing.Size(156, 33);
            this.TBFinishDate.TabIndex = 4;
            this.TBFinishDate.UsePersianFormat = true;
            // 
            // CBIsDone
            // 
            this.CBIsDone.AutoSize = true;
            this.CBIsDone.Location = new System.Drawing.Point(44, 345);
            this.CBIsDone.Name = "CBIsDone";
            this.CBIsDone.Size = new System.Drawing.Size(196, 28);
            this.CBIsDone.TabIndex = 13;
            this.CBIsDone.Text = "این کار به اتمام رسیده است";
            this.CBIsDone.UseVisualStyleBackColor = true;
            // 
            // TBInfo
            // 
            this.TBInfo.Location = new System.Drawing.Point(8, 212);
            this.TBInfo.Multiline = true;
            this.TBInfo.Name = "TBInfo";
            this.TBInfo.Size = new System.Drawing.Size(263, 118);
            this.TBInfo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "توضیحات :";
            // 
            // TBHour
            // 
            this.TBHour.Location = new System.Drawing.Point(8, 111);
            this.TBHour.Name = "TBHour";
            this.TBHour.Size = new System.Drawing.Size(60, 32);
            this.TBHour.TabIndex = 8;
            this.TBHour.Text = "00";
            // 
            // TBMin
            // 
            this.TBMin.Location = new System.Drawing.Point(104, 111);
            this.TBMin.Name = "TBMin";
            this.TBMin.Size = new System.Drawing.Size(60, 32);
            this.TBMin.TabIndex = 6;
            this.TBMin.Text = "00";
            // 
            // TBCaption
            // 
            this.TBCaption.Location = new System.Drawing.Point(8, 151);
            this.TBCaption.Name = "TBCaption";
            this.TBCaption.Size = new System.Drawing.Size(156, 32);
            this.TBCaption.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "ساعت :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "عنوان :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاریخ اتمام :";
            // 
            // TBWorkID
            // 
            this.TBWorkID.Location = new System.Drawing.Point(64, 34);
            this.TBWorkID.Name = "TBWorkID";
            this.TBWorkID.Size = new System.Drawing.Size(100, 32);
            this.TBWorkID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد فعالیت :";
            // 
            // SearchButt
            // 
            this.SearchButt.BackColor = System.Drawing.Color.White;
            this.SearchButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButt.ForeColor = System.Drawing.Color.White;
            this.SearchButt.Image = global::ToDoList.Properties.Resources.search;
            this.SearchButt.Location = new System.Drawing.Point(8, 34);
            this.SearchButt.Name = "SearchButt";
            this.SearchButt.Size = new System.Drawing.Size(50, 32);
            this.SearchButt.TabIndex = 2;
            this.SearchButt.UseVisualStyleBackColor = false;
            this.SearchButt.Click += new System.EventHandler(this.SearchButt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRefresh);
            this.groupBox2.Controls.Add(this.DeleteButt);
            this.groupBox2.Controls.Add(this.ExitButt);
            this.groupBox2.Controls.Add(this.EditButt);
            this.groupBox2.Controls.Add(this.DoneButt);
            this.groupBox2.Location = new System.Drawing.Point(14, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(95, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.White;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = global::ToDoList.Properties.Resources.refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(8, 248);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(79, 33);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // DeleteButt
            // 
            this.DeleteButt.BackColor = System.Drawing.Color.White;
            this.DeleteButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButt.ForeColor = System.Drawing.Color.White;
            this.DeleteButt.Image = global::ToDoList.Properties.Resources.waste;
            this.DeleteButt.Location = new System.Drawing.Point(8, 174);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(79, 64);
            this.DeleteButt.TabIndex = 2;
            this.DeleteButt.UseVisualStyleBackColor = false;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // ExitButt
            // 
            this.ExitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButt.ForeColor = System.Drawing.Color.White;
            this.ExitButt.Image = global::ToDoList.Properties.Resources.exit;
            this.ExitButt.Location = new System.Drawing.Point(8, 311);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(79, 62);
            this.ExitButt.TabIndex = 4;
            this.ExitButt.UseVisualStyleBackColor = true;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // EditButt
            // 
            this.EditButt.BackColor = System.Drawing.Color.White;
            this.EditButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButt.ForeColor = System.Drawing.Color.White;
            this.EditButt.Image = global::ToDoList.Properties.Resources.edit_property;
            this.EditButt.Location = new System.Drawing.Point(8, 104);
            this.EditButt.Name = "EditButt";
            this.EditButt.Size = new System.Drawing.Size(79, 64);
            this.EditButt.TabIndex = 1;
            this.EditButt.UseVisualStyleBackColor = false;
            this.EditButt.Click += new System.EventHandler(this.EditButt_Click);
            // 
            // DoneButt
            // 
            this.DoneButt.BackColor = System.Drawing.Color.White;
            this.DoneButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButt.ForeColor = System.Drawing.Color.White;
            this.DoneButt.Image = global::ToDoList.Properties.Resources._checked;
            this.DoneButt.Location = new System.Drawing.Point(8, 34);
            this.DoneButt.Name = "DoneButt";
            this.DoneButt.Size = new System.Drawing.Size(79, 64);
            this.DoneButt.TabIndex = 0;
            this.DoneButt.UseVisualStyleBackColor = false;
            this.DoneButt.Click += new System.EventHandler(this.DoneButt_Click);
            // 
            // FrmAddWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmAddWork";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddWork";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBWorkID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButt;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Button EditButt;
        private System.Windows.Forms.Button DoneButt;
        private System.Windows.Forms.CheckBox CBIsDone;
        private System.Windows.Forms.TextBox TBInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBCaption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRefresh;
        private Atf.UI.DateTimeSelector TBFinishDate;
        private System.Windows.Forms.TextBox TBHour;
        private System.Windows.Forms.TextBox TBMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}