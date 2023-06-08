namespace ABBRWS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LocalRegist = new System.Windows.Forms.Button();
            this.mShipGet = new System.Windows.Forms.Button();
            this.jogAxisModeSet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axisSixMinus = new System.Windows.Forms.Button();
            this.axisSixAdd = new System.Windows.Forms.Button();
            this.axisFiveMinus = new System.Windows.Forms.Button();
            this.axisFiveAdd = new System.Windows.Forms.Button();
            this.axisFourMinus = new System.Windows.Forms.Button();
            this.axisFourAdd = new System.Windows.Forms.Button();
            this.axisThreeMinus = new System.Windows.Forms.Button();
            this.axisThreeAdd = new System.Windows.Forms.Button();
            this.axisTwoMinus = new System.Windows.Forms.Button();
            this.axisTwoAdd = new System.Windows.Forms.Button();
            this.jogOneMinus = new System.Windows.Forms.Button();
            this.jogOneAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.axisSixValue = new System.Windows.Forms.TextBox();
            this.axisFiveValue = new System.Windows.Forms.TextBox();
            this.axisFourValue = new System.Windows.Forms.TextBox();
            this.axisThreeValue = new System.Windows.Forms.TextBox();
            this.axisTwoValue = new System.Windows.Forms.TextBox();
            this.axisOneValue = new System.Windows.Forms.TextBox();
            this.getAxisValue = new System.Windows.Forms.Button();
            this.robotIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listInfo = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.motorStatus = new System.Windows.Forms.Button();
            this.opMode = new System.Windows.Forms.Button();
            this.speedRatio = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalRegist
            // 
            this.LocalRegist.Location = new System.Drawing.Point(113, 125);
            this.LocalRegist.Name = "LocalRegist";
            this.LocalRegist.Size = new System.Drawing.Size(116, 23);
            this.LocalRegist.TabIndex = 0;
            this.LocalRegist.Text = "注册本地用户";
            this.LocalRegist.UseVisualStyleBackColor = true;
            this.LocalRegist.Click += new System.EventHandler(this.LocalRegist_Click);
            // 
            // mShipGet
            // 
            this.mShipGet.Location = new System.Drawing.Point(113, 174);
            this.mShipGet.Name = "mShipGet";
            this.mShipGet.Size = new System.Drawing.Size(116, 23);
            this.mShipGet.TabIndex = 1;
            this.mShipGet.Text = "请求Motion权限";
            this.mShipGet.UseVisualStyleBackColor = true;
            this.mShipGet.Click += new System.EventHandler(this.mShipGet_Click);
            // 
            // jogAxisModeSet
            // 
            this.jogAxisModeSet.Location = new System.Drawing.Point(113, 222);
            this.jogAxisModeSet.Name = "jogAxisModeSet";
            this.jogAxisModeSet.Size = new System.Drawing.Size(116, 23);
            this.jogAxisModeSet.TabIndex = 2;
            this.jogAxisModeSet.Text = "设置单轴模式";
            this.jogAxisModeSet.UseVisualStyleBackColor = true;
            this.jogAxisModeSet.Click += new System.EventHandler(this.jogAxisModeSet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axisSixMinus);
            this.groupBox1.Controls.Add(this.axisSixAdd);
            this.groupBox1.Controls.Add(this.axisFiveMinus);
            this.groupBox1.Controls.Add(this.axisFiveAdd);
            this.groupBox1.Controls.Add(this.axisFourMinus);
            this.groupBox1.Controls.Add(this.axisFourAdd);
            this.groupBox1.Controls.Add(this.axisThreeMinus);
            this.groupBox1.Controls.Add(this.axisThreeAdd);
            this.groupBox1.Controls.Add(this.axisTwoMinus);
            this.groupBox1.Controls.Add(this.axisTwoAdd);
            this.groupBox1.Controls.Add(this.jogOneMinus);
            this.groupBox1.Controls.Add(this.jogOneAdd);
            this.groupBox1.Location = new System.Drawing.Point(269, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单轴运动";
            // 
            // axisSixMinus
            // 
            this.axisSixMinus.Location = new System.Drawing.Point(123, 174);
            this.axisSixMinus.Name = "axisSixMinus";
            this.axisSixMinus.Size = new System.Drawing.Size(75, 23);
            this.axisSixMinus.TabIndex = 5;
            this.axisSixMinus.Text = "6轴 -";
            this.axisSixMinus.UseVisualStyleBackColor = true;
            this.axisSixMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisSixMinus_MouseDown);
            this.axisSixMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisSixMinus_MouseUp);
            // 
            // axisSixAdd
            // 
            this.axisSixAdd.Location = new System.Drawing.Point(29, 174);
            this.axisSixAdd.Name = "axisSixAdd";
            this.axisSixAdd.Size = new System.Drawing.Size(75, 23);
            this.axisSixAdd.TabIndex = 4;
            this.axisSixAdd.Text = "6轴 +";
            this.axisSixAdd.UseVisualStyleBackColor = true;
            this.axisSixAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisSixAdd_MouseDown);
            this.axisSixAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisSixAdd_MouseUp);
            // 
            // axisFiveMinus
            // 
            this.axisFiveMinus.Location = new System.Drawing.Point(123, 145);
            this.axisFiveMinus.Name = "axisFiveMinus";
            this.axisFiveMinus.Size = new System.Drawing.Size(75, 23);
            this.axisFiveMinus.TabIndex = 9;
            this.axisFiveMinus.Text = "5轴 -";
            this.axisFiveMinus.UseVisualStyleBackColor = true;
            this.axisFiveMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisFiveMinus_MouseDown);
            this.axisFiveMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisFiveMinus_MouseUp);
            // 
            // axisFiveAdd
            // 
            this.axisFiveAdd.Location = new System.Drawing.Point(29, 145);
            this.axisFiveAdd.Name = "axisFiveAdd";
            this.axisFiveAdd.Size = new System.Drawing.Size(75, 23);
            this.axisFiveAdd.TabIndex = 8;
            this.axisFiveAdd.Text = "5轴 +";
            this.axisFiveAdd.UseVisualStyleBackColor = true;
            this.axisFiveAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisFiveAdd_MouseDown);
            this.axisFiveAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisFiveAdd_MouseUp);
            // 
            // axisFourMinus
            // 
            this.axisFourMinus.Location = new System.Drawing.Point(123, 116);
            this.axisFourMinus.Name = "axisFourMinus";
            this.axisFourMinus.Size = new System.Drawing.Size(75, 23);
            this.axisFourMinus.TabIndex = 7;
            this.axisFourMinus.Text = "4轴 -";
            this.axisFourMinus.UseVisualStyleBackColor = true;
            this.axisFourMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisFourMinus_MouseDown);
            this.axisFourMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisFourMinus_MouseUp);
            // 
            // axisFourAdd
            // 
            this.axisFourAdd.Location = new System.Drawing.Point(29, 116);
            this.axisFourAdd.Name = "axisFourAdd";
            this.axisFourAdd.Size = new System.Drawing.Size(75, 23);
            this.axisFourAdd.TabIndex = 6;
            this.axisFourAdd.Text = "4轴 +";
            this.axisFourAdd.UseVisualStyleBackColor = true;
            this.axisFourAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisFourAdd_MouseDown);
            this.axisFourAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisFourAdd_MouseUp);
            // 
            // axisThreeMinus
            // 
            this.axisThreeMinus.Location = new System.Drawing.Point(123, 87);
            this.axisThreeMinus.Name = "axisThreeMinus";
            this.axisThreeMinus.Size = new System.Drawing.Size(75, 23);
            this.axisThreeMinus.TabIndex = 5;
            this.axisThreeMinus.Text = "3轴 -";
            this.axisThreeMinus.UseVisualStyleBackColor = true;
            this.axisThreeMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisThreeMinus_MouseDown);
            this.axisThreeMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisThreeMinus_MouseUp);
            // 
            // axisThreeAdd
            // 
            this.axisThreeAdd.Location = new System.Drawing.Point(29, 87);
            this.axisThreeAdd.Name = "axisThreeAdd";
            this.axisThreeAdd.Size = new System.Drawing.Size(75, 23);
            this.axisThreeAdd.TabIndex = 4;
            this.axisThreeAdd.Text = "3轴 +";
            this.axisThreeAdd.UseVisualStyleBackColor = true;
            this.axisThreeAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisThreeAdd_MouseDown);
            this.axisThreeAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisThreeAdd_MouseUp);
            // 
            // axisTwoMinus
            // 
            this.axisTwoMinus.Location = new System.Drawing.Point(123, 58);
            this.axisTwoMinus.Name = "axisTwoMinus";
            this.axisTwoMinus.Size = new System.Drawing.Size(75, 23);
            this.axisTwoMinus.TabIndex = 3;
            this.axisTwoMinus.Text = "2轴 -";
            this.axisTwoMinus.UseVisualStyleBackColor = true;
            this.axisTwoMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisTwoMinus_MouseDown);
            this.axisTwoMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisTwoMinus_MouseUp);
            // 
            // axisTwoAdd
            // 
            this.axisTwoAdd.Location = new System.Drawing.Point(29, 58);
            this.axisTwoAdd.Name = "axisTwoAdd";
            this.axisTwoAdd.Size = new System.Drawing.Size(75, 23);
            this.axisTwoAdd.TabIndex = 2;
            this.axisTwoAdd.Text = "2轴 +";
            this.axisTwoAdd.UseVisualStyleBackColor = true;
            this.axisTwoAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisTwoAdd_MouseDown);
            this.axisTwoAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.axisTwoAdd_MouseUp);
            // 
            // jogOneMinus
            // 
            this.jogOneMinus.Location = new System.Drawing.Point(123, 29);
            this.jogOneMinus.Name = "jogOneMinus";
            this.jogOneMinus.Size = new System.Drawing.Size(75, 23);
            this.jogOneMinus.TabIndex = 1;
            this.jogOneMinus.Text = "1轴 -";
            this.jogOneMinus.UseVisualStyleBackColor = true;
            this.jogOneMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogOneMinus_MouseDown);
            this.jogOneMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogOneMinus_MouseUp);
            // 
            // jogOneAdd
            // 
            this.jogOneAdd.Location = new System.Drawing.Point(29, 29);
            this.jogOneAdd.Name = "jogOneAdd";
            this.jogOneAdd.Size = new System.Drawing.Size(75, 23);
            this.jogOneAdd.TabIndex = 0;
            this.jogOneAdd.Text = "1轴 +";
            this.jogOneAdd.UseVisualStyleBackColor = true;
            this.jogOneAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogOneAdd_MouseDown);
            this.jogOneAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogOneAdd_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "步骤1：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "步骤2：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "步骤3：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.axisSixValue);
            this.groupBox2.Controls.Add(this.axisFiveValue);
            this.groupBox2.Controls.Add(this.axisFourValue);
            this.groupBox2.Controls.Add(this.axisThreeValue);
            this.groupBox2.Controls.Add(this.axisTwoValue);
            this.groupBox2.Controls.Add(this.axisOneValue);
            this.groupBox2.Location = new System.Drawing.Point(512, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 208);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "轴角度";
            // 
            // axisSixValue
            // 
            this.axisSixValue.Location = new System.Drawing.Point(6, 176);
            this.axisSixValue.Name = "axisSixValue";
            this.axisSixValue.Size = new System.Drawing.Size(74, 21);
            this.axisSixValue.TabIndex = 9;
            // 
            // axisFiveValue
            // 
            this.axisFiveValue.Location = new System.Drawing.Point(6, 147);
            this.axisFiveValue.Name = "axisFiveValue";
            this.axisFiveValue.Size = new System.Drawing.Size(74, 21);
            this.axisFiveValue.TabIndex = 9;
            // 
            // axisFourValue
            // 
            this.axisFourValue.Location = new System.Drawing.Point(6, 118);
            this.axisFourValue.Name = "axisFourValue";
            this.axisFourValue.Size = new System.Drawing.Size(74, 21);
            this.axisFourValue.TabIndex = 3;
            // 
            // axisThreeValue
            // 
            this.axisThreeValue.Location = new System.Drawing.Point(6, 89);
            this.axisThreeValue.Name = "axisThreeValue";
            this.axisThreeValue.Size = new System.Drawing.Size(74, 21);
            this.axisThreeValue.TabIndex = 2;
            // 
            // axisTwoValue
            // 
            this.axisTwoValue.Location = new System.Drawing.Point(6, 60);
            this.axisTwoValue.Name = "axisTwoValue";
            this.axisTwoValue.Size = new System.Drawing.Size(74, 21);
            this.axisTwoValue.TabIndex = 1;
            // 
            // axisOneValue
            // 
            this.axisOneValue.Location = new System.Drawing.Point(6, 31);
            this.axisOneValue.Name = "axisOneValue";
            this.axisOneValue.Size = new System.Drawing.Size(74, 21);
            this.axisOneValue.TabIndex = 0;
            // 
            // getAxisValue
            // 
            this.getAxisValue.Location = new System.Drawing.Point(517, 262);
            this.getAxisValue.Name = "getAxisValue";
            this.getAxisValue.Size = new System.Drawing.Size(75, 23);
            this.getAxisValue.TabIndex = 9;
            this.getAxisValue.Text = "获取";
            this.getAxisValue.UseVisualStyleBackColor = true;
            this.getAxisValue.Click += new System.EventHandler(this.getAxisValue_Click);
            // 
            // robotIp
            // 
            this.robotIp.Location = new System.Drawing.Point(113, 58);
            this.robotIp.Name = "robotIp";
            this.robotIp.Size = new System.Drawing.Size(116, 21);
            this.robotIp.TabIndex = 10;
            this.robotIp.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "机器人IP：";
            // 
            // listInfo
            // 
            this.listInfo.FormattingEnabled = true;
            this.listInfo.ItemHeight = 12;
            this.listInfo.Location = new System.Drawing.Point(660, 48);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(290, 208);
            this.listInfo.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.motorStatus);
            this.groupBox3.Controls.Add(this.opMode);
            this.groupBox3.Controls.Add(this.speedRatio);
            this.groupBox3.Location = new System.Drawing.Point(50, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 129);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "机器人状态";
            // 
            // motorStatus
            // 
            this.motorStatus.Location = new System.Drawing.Point(6, 89);
            this.motorStatus.Name = "motorStatus";
            this.motorStatus.Size = new System.Drawing.Size(75, 23);
            this.motorStatus.TabIndex = 16;
            this.motorStatus.Text = "电机状态";
            this.motorStatus.UseVisualStyleBackColor = true;
            this.motorStatus.Click += new System.EventHandler(this.motorStatus_Click);
            // 
            // opMode
            // 
            this.opMode.Location = new System.Drawing.Point(6, 60);
            this.opMode.Name = "opMode";
            this.opMode.Size = new System.Drawing.Size(75, 23);
            this.opMode.TabIndex = 15;
            this.opMode.Text = "操作模式";
            this.opMode.UseVisualStyleBackColor = true;
            this.opMode.Click += new System.EventHandler(this.opMode_Click);
            // 
            // speedRatio
            // 
            this.speedRatio.Location = new System.Drawing.Point(6, 31);
            this.speedRatio.Name = "speedRatio";
            this.speedRatio.Size = new System.Drawing.Size(75, 23);
            this.speedRatio.TabIndex = 14;
            this.speedRatio.Text = "速度百分比";
            this.speedRatio.UseVisualStyleBackColor = true;
            this.speedRatio.Click += new System.EventHandler(this.speedRatio_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(269, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 129);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "直线运动";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 558);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.robotIp);
            this.Controls.Add(this.getAxisValue);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jogAxisModeSet);
            this.Controls.Add(this.mShipGet);
            this.Controls.Add(this.LocalRegist);
            this.Name = "Form1";
            this.Text = "  C#基于robot web servcie和ABB机器人通讯";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LocalRegist;
        private System.Windows.Forms.Button mShipGet;
        private System.Windows.Forms.Button jogAxisModeSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button axisSixMinus;
        private System.Windows.Forms.Button axisSixAdd;
        private System.Windows.Forms.Button axisFiveMinus;
        private System.Windows.Forms.Button axisFiveAdd;
        private System.Windows.Forms.Button axisFourMinus;
        private System.Windows.Forms.Button axisFourAdd;
        private System.Windows.Forms.Button axisThreeMinus;
        private System.Windows.Forms.Button axisThreeAdd;
        private System.Windows.Forms.Button axisTwoMinus;
        private System.Windows.Forms.Button axisTwoAdd;
        private System.Windows.Forms.Button jogOneMinus;
        private System.Windows.Forms.Button jogOneAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox axisSixValue;
        private System.Windows.Forms.TextBox axisFiveValue;
        private System.Windows.Forms.TextBox axisFourValue;
        private System.Windows.Forms.TextBox axisThreeValue;
        private System.Windows.Forms.TextBox axisTwoValue;
        private System.Windows.Forms.TextBox axisOneValue;
        private System.Windows.Forms.Button getAxisValue;
        private System.Windows.Forms.TextBox robotIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button motorStatus;
        private System.Windows.Forms.Button opMode;
        private System.Windows.Forms.Button speedRatio;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

