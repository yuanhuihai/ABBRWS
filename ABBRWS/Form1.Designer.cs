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
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
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
            this.axisOneValue = new System.Windows.Forms.TextBox();
            this.axisTwoValue = new System.Windows.Forms.TextBox();
            this.axisThreeValue = new System.Windows.Forms.TextBox();
            this.axisFourValue = new System.Windows.Forms.TextBox();
            this.axisFiveValue = new System.Windows.Forms.TextBox();
            this.axisSixValue = new System.Windows.Forms.TextBox();
            this.getAxisValue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalRegist
            // 
            this.LocalRegist.Location = new System.Drawing.Point(110, 48);
            this.LocalRegist.Name = "LocalRegist";
            this.LocalRegist.Size = new System.Drawing.Size(116, 23);
            this.LocalRegist.TabIndex = 0;
            this.LocalRegist.Text = "注册本地用户";
            this.LocalRegist.UseVisualStyleBackColor = true;
            this.LocalRegist.Click += new System.EventHandler(this.LocalRegist_Click);
            // 
            // mShipGet
            // 
            this.mShipGet.Location = new System.Drawing.Point(110, 97);
            this.mShipGet.Name = "mShipGet";
            this.mShipGet.Size = new System.Drawing.Size(116, 23);
            this.mShipGet.TabIndex = 1;
            this.mShipGet.Text = "请求Motion权限";
            this.mShipGet.UseVisualStyleBackColor = true;
            this.mShipGet.Click += new System.EventHandler(this.mShipGet_Click);
            // 
            // jogAxisModeSet
            // 
            this.jogAxisModeSet.Location = new System.Drawing.Point(110, 145);
            this.jogAxisModeSet.Name = "jogAxisModeSet";
            this.jogAxisModeSet.Size = new System.Drawing.Size(116, 23);
            this.jogAxisModeSet.TabIndex = 2;
            this.jogAxisModeSet.Text = "设置单轴模式";
            this.jogAxisModeSet.UseVisualStyleBackColor = true;
            this.jogAxisModeSet.Click += new System.EventHandler(this.jogAxisModeSet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button11);
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
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(123, 174);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 5;
            this.button14.Text = "6轴 -";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(29, 174);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 4;
            this.button15.Text = "6轴 +";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(123, 145);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 9;
            this.button12.Text = "5轴 -";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(29, 145);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 8;
            this.button13.Text = "5轴 +";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(123, 116);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "4轴 -";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(29, 116);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 6;
            this.button11.Text = "4轴 +";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // axisThreeMinus
            // 
            this.axisThreeMinus.Location = new System.Drawing.Point(123, 87);
            this.axisThreeMinus.Name = "axisThreeMinus";
            this.axisThreeMinus.Size = new System.Drawing.Size(75, 23);
            this.axisThreeMinus.TabIndex = 5;
            this.axisThreeMinus.Text = "3轴 -";
            this.axisThreeMinus.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "步骤1：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "步骤2：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 150);
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
            // axisOneValue
            // 
            this.axisOneValue.Location = new System.Drawing.Point(6, 31);
            this.axisOneValue.Name = "axisOneValue";
            this.axisOneValue.Size = new System.Drawing.Size(74, 21);
            this.axisOneValue.TabIndex = 0;
            // 
            // axisTwoValue
            // 
            this.axisTwoValue.Location = new System.Drawing.Point(6, 60);
            this.axisTwoValue.Name = "axisTwoValue";
            this.axisTwoValue.Size = new System.Drawing.Size(74, 21);
            this.axisTwoValue.TabIndex = 1;
            // 
            // axisThreeValue
            // 
            this.axisThreeValue.Location = new System.Drawing.Point(6, 89);
            this.axisThreeValue.Name = "axisThreeValue";
            this.axisThreeValue.Size = new System.Drawing.Size(74, 21);
            this.axisThreeValue.TabIndex = 2;
            // 
            // axisFourValue
            // 
            this.axisFourValue.Location = new System.Drawing.Point(6, 118);
            this.axisFourValue.Name = "axisFourValue";
            this.axisFourValue.Size = new System.Drawing.Size(74, 21);
            this.axisFourValue.TabIndex = 3;
            // 
            // axisFiveValue
            // 
            this.axisFiveValue.Location = new System.Drawing.Point(6, 147);
            this.axisFiveValue.Name = "axisFiveValue";
            this.axisFiveValue.Size = new System.Drawing.Size(74, 21);
            this.axisFiveValue.TabIndex = 9;
            // 
            // axisSixValue
            // 
            this.axisSixValue.Location = new System.Drawing.Point(6, 176);
            this.axisSixValue.Name = "axisSixValue";
            this.axisSixValue.Size = new System.Drawing.Size(74, 21);
            this.axisSixValue.TabIndex = 9;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 508);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LocalRegist;
        private System.Windows.Forms.Button mShipGet;
        private System.Windows.Forms.Button jogAxisModeSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
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
    }
}

