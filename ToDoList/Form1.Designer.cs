namespace ToDoList
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
            DevComponents.DotNetBar.Controls.ClockStyleData clockStyleData1 = new DevComponents.DotNetBar.Controls.ClockStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData1 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData2 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData3 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData1 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData4 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData5 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData2 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData6 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ClockHandStyleData clockHandStyleData3 = new DevComponents.DotNetBar.Controls.ClockHandStyleData();
            DevComponents.DotNetBar.Controls.ColorData colorData7 = new DevComponents.DotNetBar.Controls.ColorData();
            DevComponents.DotNetBar.Controls.ColorData colorData8 = new DevComponents.DotNetBar.Controls.ColorData();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AllLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToDayLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Clock = new DevComponents.DotNetBar.Controls.AnalogClockControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExitButt = new System.Windows.Forms.Button();
            this.AddButt = new System.Windows.Forms.Button();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.EditButt = new System.Windows.Forms.Button();
            this.DoneButt = new System.Windows.Forms.Button();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AllLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ToDayLabel);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.Clock);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(360, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(227, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "کل فعالیت های باز";
            // 
            // AllLabel
            // 
            this.AllLabel.AutoSize = true;
            this.AllLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllLabel.Location = new System.Drawing.Point(155, 74);
            this.AllLabel.Name = "AllLabel";
            this.AllLabel.Size = new System.Drawing.Size(28, 24);
            this.AllLabel.TabIndex = 3;
            this.AllLabel.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(246, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "کار های امروز";
            // 
            // ToDayLabel
            // 
            this.ToDayLabel.AutoSize = true;
            this.ToDayLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDayLabel.Location = new System.Drawing.Point(155, 25);
            this.ToDayLabel.Name = "ToDayLabel";
            this.ToDayLabel.Size = new System.Drawing.Size(28, 24);
            this.ToDayLabel.TabIndex = 2;
            this.ToDayLabel.Text = "10";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DateLabel.Location = new System.Drawing.Point(155, 132);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(182, 24);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "امروز سه شنبه 25 دی 1400";
            // 
            // Clock
            // 
            this.Clock.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            colorData1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            colorData1.BorderWidth = 0.01F;
            colorData1.BrushSBSScale = 1F;
            colorData1.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            colorData1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            clockStyleData1.BezelColor = colorData1;
            colorData2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData2.BorderWidth = 0.01F;
            colorData2.BrushSBSScale = 1F;
            colorData2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            clockStyleData1.CapColor = colorData2;
            colorData3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(161)))));
            colorData3.BorderWidth = 0.01F;
            colorData3.BrushAngle = 45F;
            colorData3.BrushSBSScale = 1F;
            colorData3.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            colorData3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            clockStyleData1.FaceColor = colorData3;
            clockStyleData1.GlassAngle = -20;
            colorData4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData4.BorderWidth = 0.01F;
            colorData4.BrushSBSScale = 1F;
            colorData4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            clockHandStyleData1.HandColor = colorData4;
            clockHandStyleData1.Length = 0.55F;
            clockHandStyleData1.Width = 0.015F;
            clockStyleData1.HourHandStyle = clockHandStyleData1;
            colorData5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            colorData5.BorderWidth = 0.01F;
            colorData5.BrushSBSScale = 1F;
            colorData5.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData5.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            colorData5.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            clockStyleData1.LargeTickColor = colorData5;
            colorData6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData6.BorderWidth = 0.01F;
            colorData6.BrushSBSScale = 1F;
            colorData6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData6.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            clockHandStyleData2.HandColor = colorData6;
            clockHandStyleData2.Length = 0.8F;
            clockHandStyleData2.Width = 0.01F;
            clockStyleData1.MinuteHandStyle = clockHandStyleData2;
            clockStyleData1.NumberFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            colorData7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData7.BorderWidth = 0.01F;
            colorData7.BrushSBSScale = 1F;
            colorData7.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            colorData7.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(127)))), ((int)(((byte)(138)))));
            clockHandStyleData3.HandColor = colorData7;
            clockHandStyleData3.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style2;
            clockHandStyleData3.Length = 0.8F;
            clockHandStyleData3.Width = 0.005F;
            clockStyleData1.SecondHandStyle = clockHandStyleData3;
            colorData8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            colorData8.BorderWidth = 0.01F;
            colorData8.BrushSBSScale = 1F;
            colorData8.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear;
            colorData8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            colorData8.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(142)))), ((int)(((byte)(154)))));
            clockStyleData1.SmallTickColor = colorData8;
            clockStyleData1.Style = DevComponents.DotNetBar.Controls.eClockStyles.Custom;
            this.Clock.ClockStyleData = clockStyleData1;
            this.Clock.Location = new System.Drawing.Point(6, 25);
            this.Clock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clock.MinimumSize = new System.Drawing.Size(100, 131);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(131, 131);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "analogClockControl1";
            this.Clock.Value = new System.DateTime(2022, 1, 9, 10, 30, 12, 136);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(360, 511);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.GridColor = System.Drawing.Color.DarkGray;
            this.DGV.Location = new System.Drawing.Point(3, 21);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.ShowCellErrors = false;
            this.DGV.ShowCellToolTips = false;
            this.DGV.ShowRowErrors = false;
            this.DGV.Size = new System.Drawing.Size(354, 486);
            this.DGV.TabIndex = 0;
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ExitButt);
            this.groupBox3.Controls.Add(this.AddButt);
            this.groupBox3.Controls.Add(this.DeleteButt);
            this.groupBox3.Controls.Add(this.EditButt);
            this.groupBox3.Controls.Add(this.DoneButt);
            this.groupBox3.Location = new System.Drawing.Point(12, 713);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(360, 77);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // ExitButt
            // 
            this.ExitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButt.ForeColor = System.Drawing.Color.White;
            this.ExitButt.Image = global::ToDoList.Properties.Resources.exit;
            this.ExitButt.Location = new System.Drawing.Point(6, 24);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(75, 46);
            this.ExitButt.TabIndex = 0;
            this.ExitButt.UseVisualStyleBackColor = true;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // AddButt
            // 
            this.AddButt.BackColor = System.Drawing.Color.White;
            this.AddButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButt.ForeColor = System.Drawing.Color.White;
            this.AddButt.Image = global::ToDoList.Properties.Resources.add;
            this.AddButt.Location = new System.Drawing.Point(116, 22);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(53, 46);
            this.AddButt.TabIndex = 0;
            this.AddButt.UseVisualStyleBackColor = false;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // DeleteButt
            // 
            this.DeleteButt.BackColor = System.Drawing.Color.White;
            this.DeleteButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButt.ForeColor = System.Drawing.Color.White;
            this.DeleteButt.Image = global::ToDoList.Properties.Resources.waste;
            this.DeleteButt.Location = new System.Drawing.Point(175, 22);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(53, 46);
            this.DeleteButt.TabIndex = 0;
            this.DeleteButt.UseVisualStyleBackColor = false;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // EditButt
            // 
            this.EditButt.BackColor = System.Drawing.Color.White;
            this.EditButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButt.ForeColor = System.Drawing.Color.White;
            this.EditButt.Image = global::ToDoList.Properties.Resources.edit_property;
            this.EditButt.Location = new System.Drawing.Point(234, 24);
            this.EditButt.Name = "EditButt";
            this.EditButt.Size = new System.Drawing.Size(53, 46);
            this.EditButt.TabIndex = 0;
            this.EditButt.UseVisualStyleBackColor = false;
            this.EditButt.Click += new System.EventHandler(this.EditButt_Click);
            // 
            // DoneButt
            // 
            this.DoneButt.BackColor = System.Drawing.Color.White;
            this.DoneButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButt.ForeColor = System.Drawing.Color.White;
            this.DoneButt.Image = global::ToDoList.Properties.Resources._checked;
            this.DoneButt.Location = new System.Drawing.Point(293, 24);
            this.DoneButt.Name = "DoneButt";
            this.DoneButt.Size = new System.Drawing.Size(53, 46);
            this.DoneButt.TabIndex = 0;
            this.DoneButt.UseVisualStyleBackColor = false;
            this.DoneButt.Click += new System.EventHandler(this.DoneButt_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 796D;
            this.reSize1.InitialHostContainerWidth = 384D;
            this.reSize1.Tag = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 796);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "لیست کارها";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AllLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ToDayLabel;
        private System.Windows.Forms.Label DateLabel;
        private DevComponents.DotNetBar.Controls.AnalogClockControl Clock;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button EditButt;
        private System.Windows.Forms.Button DoneButt;
        private System.Windows.Forms.Timer ClockTimer;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Button AddButt;
    }
}

