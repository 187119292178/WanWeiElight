namespace Elight.WinForm.Page.WIP
{
    partial class PackingBoxPage
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
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            uiPanel1 = new Sunny.UI.UIPanel();
            lblStatus = new System.Windows.Forms.Label();
            uiButton1 = new Sunny.UI.UIButton();
            btnReset = new Sunny.UI.UIButton();
            txtInput = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            txtOrderId = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            txtOperCode = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            txtUserId = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            lblMsg = new System.Windows.Forms.Label();
            uiPanel2 = new Sunny.UI.UIPanel();
            txtMatType = new Sunny.UI.UITextBox();
            uiLabel9 = new Sunny.UI.UILabel();
            lblUnPackQty = new Sunny.UI.UILabel();
            uiLabel12 = new Sunny.UI.UILabel();
            lblPackQty = new Sunny.UI.UILabel();
            uiLabel10 = new Sunny.UI.UILabel();
            txtOrderQty = new Sunny.UI.UITextBox();
            uiLabel8 = new Sunny.UI.UILabel();
            txtItemName = new Sunny.UI.UITextBox();
            uiLabel7 = new Sunny.UI.UILabel();
            txtItemCode = new Sunny.UI.UITextBox();
            uiLabel6 = new Sunny.UI.UILabel();
            txtOrderNo = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            uiListBox1 = new Sunny.UI.UIListBox();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(30, 0);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(-30, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(30, 0);
            panel4.TabIndex = 9;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(lblStatus);
            uiPanel1.Controls.Add(uiButton1);
            uiPanel1.Controls.Add(btnReset);
            uiPanel1.Controls.Add(txtInput);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(txtOrderId);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(txtOperCode);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(txtUserId);
            uiPanel1.Controls.Add(uiLabel5);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel1.Location = new System.Drawing.Point(30, 0);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(1, 164);
            uiPanel1.TabIndex = 10;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = System.Drawing.Color.Green;
            lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblStatus.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblStatus.Location = new System.Drawing.Point(756, 78);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(104, 55);
            lblStatus.TabIndex = 87;
            lblStatus.Text = "PASS";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            uiButton1.Location = new System.Drawing.Point(1157, 78);
            uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new System.Drawing.Size(138, 55);
            uiButton1.TabIndex = 86;
            uiButton1.Tag = "PackingPage_RePrint";
            uiButton1.Text = "补打条码";
            uiButton1.Click += uiButton1_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            btnReset.Location = new System.Drawing.Point(945, 78);
            btnReset.MinimumSize = new System.Drawing.Size(1, 1);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(138, 55);
            btnReset.TabIndex = 86;
            btnReset.Text = "重置扫描";
            btnReset.Click += btnReset_Click;
            // 
            // txtInput
            // 
            txtInput.ButtonFillColor = System.Drawing.Color.FromArgb(220, 155, 40);
            txtInput.ButtonFillHoverColor = System.Drawing.Color.FromArgb(223, 174, 86);
            txtInput.ButtonFillPressColor = System.Drawing.Color.FromArgb(192, 137, 43);
            txtInput.ButtonRectColor = System.Drawing.Color.FromArgb(220, 155, 40);
            txtInput.ButtonRectHoverColor = System.Drawing.Color.FromArgb(223, 174, 86);
            txtInput.ButtonRectPressColor = System.Drawing.Color.FromArgb(192, 137, 43);
            txtInput.ButtonSymbol = 61761;
            txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtInput.FillColor2 = System.Drawing.Color.FromArgb(251, 245, 233);
            txtInput.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            txtInput.Location = new System.Drawing.Point(203, 78);
            txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtInput.Maximum = 2147483647D;
            txtInput.MaxLength = 50;
            txtInput.Minimum = -2147483648D;
            txtInput.MinimumSize = new System.Drawing.Size(1, 16);
            txtInput.Name = "txtInput";
            txtInput.RectColor = System.Drawing.Color.FromArgb(220, 155, 40);
            txtInput.Size = new System.Drawing.Size(529, 55);
            txtInput.Style = Sunny.UI.UIStyle.Orange;
            txtInput.StyleCustomMode = true;
            txtInput.TabIndex = 1;
            txtInput.Text = "12RYTRH234RTGYH67";
            txtInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            uiLabel3.Location = new System.Drawing.Point(38, 86);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(132, 39);
            uiLabel3.TabIndex = 84;
            uiLabel3.Text = "扫描条码";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderId
            // 
            txtOrderId.ButtonSymbol = 61761;
            txtOrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOrderId.Enabled = false;
            txtOrderId.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderId.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtOrderId.Location = new System.Drawing.Point(1090, 5);
            txtOrderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderId.Maximum = 2147483647D;
            txtOrderId.MaxLength = 50;
            txtOrderId.Minimum = -2147483648D;
            txtOrderId.MinimumSize = new System.Drawing.Size(1, 16);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new System.Drawing.Size(233, 36);
            txtOrderId.Style = Sunny.UI.UIStyle.Custom;
            txtOrderId.StyleCustomMode = true;
            txtOrderId.TabIndex = 82;
            txtOrderId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel2.Location = new System.Drawing.Point(990, 9);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(93, 29);
            uiLabel2.TabIndex = 83;
            uiLabel2.Text = "工单号";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOperCode
            // 
            txtOperCode.ButtonSymbol = 61761;
            txtOperCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOperCode.Enabled = false;
            txtOperCode.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOperCode.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtOperCode.Location = new System.Drawing.Point(613, 5);
            txtOperCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOperCode.Maximum = 2147483647D;
            txtOperCode.MaxLength = 50;
            txtOperCode.Minimum = -2147483648D;
            txtOperCode.MinimumSize = new System.Drawing.Size(1, 16);
            txtOperCode.Name = "txtOperCode";
            txtOperCode.Size = new System.Drawing.Size(233, 36);
            txtOperCode.Style = Sunny.UI.UIStyle.Custom;
            txtOperCode.StyleCustomMode = true;
            txtOperCode.TabIndex = 80;
            txtOperCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel1.Location = new System.Drawing.Point(513, 9);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(93, 29);
            uiLabel1.TabIndex = 81;
            uiLabel1.Text = "当前工站";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            uiLabel1.Click += uiLabel1_Click;
            // 
            // txtUserId
            // 
            txtUserId.ButtonSymbol = 61761;
            txtUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtUserId.Enabled = false;
            txtUserId.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtUserId.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtUserId.Location = new System.Drawing.Point(139, 5);
            txtUserId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtUserId.Maximum = 2147483647D;
            txtUserId.MaxLength = 50;
            txtUserId.Minimum = -2147483648D;
            txtUserId.MinimumSize = new System.Drawing.Size(1, 16);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new System.Drawing.Size(233, 36);
            txtUserId.Style = Sunny.UI.UIStyle.Custom;
            txtUserId.StyleCustomMode = true;
            txtUserId.TabIndex = 78;
            txtUserId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel5.Location = new System.Drawing.Point(39, 9);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new System.Drawing.Size(93, 29);
            uiLabel5.TabIndex = 79;
            uiLabel5.Text = "操作人员";
            uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMsg
            // 
            lblMsg.BackColor = System.Drawing.Color.LightSkyBlue;
            lblMsg.Dock = System.Windows.Forms.DockStyle.Top;
            lblMsg.Font = new System.Drawing.Font("微软雅黑", 14F);
            lblMsg.Location = new System.Drawing.Point(30, 164);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new System.Drawing.Size(0, 70);
            lblMsg.TabIndex = 11;
            lblMsg.Text = "操作提示信息";
            lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(txtMatType);
            uiPanel2.Controls.Add(uiLabel9);
            uiPanel2.Controls.Add(lblUnPackQty);
            uiPanel2.Controls.Add(uiLabel12);
            uiPanel2.Controls.Add(lblPackQty);
            uiPanel2.Controls.Add(uiLabel10);
            uiPanel2.Controls.Add(txtOrderQty);
            uiPanel2.Controls.Add(uiLabel8);
            uiPanel2.Controls.Add(txtItemName);
            uiPanel2.Controls.Add(uiLabel7);
            uiPanel2.Controls.Add(txtItemCode);
            uiPanel2.Controls.Add(uiLabel6);
            uiPanel2.Controls.Add(txtOrderNo);
            uiPanel2.Controls.Add(uiLabel4);
            uiPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiPanel2.Location = new System.Drawing.Point(30, 234);
            uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new System.Drawing.Size(522, 1);
            uiPanel2.TabIndex = 12;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatType
            // 
            txtMatType.ButtonSymbol = 61761;
            txtMatType.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMatType.Enabled = false;
            txtMatType.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtMatType.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtMatType.Location = new System.Drawing.Point(121, 62);
            txtMatType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtMatType.Maximum = 2147483647D;
            txtMatType.MaxLength = 50;
            txtMatType.Minimum = -2147483648D;
            txtMatType.MinimumSize = new System.Drawing.Size(1, 16);
            txtMatType.Name = "txtMatType";
            txtMatType.Size = new System.Drawing.Size(348, 36);
            txtMatType.Style = Sunny.UI.UIStyle.Custom;
            txtMatType.StyleCustomMode = true;
            txtMatType.TabIndex = 98;
            txtMatType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            uiLabel9.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel9.Location = new System.Drawing.Point(9, 66);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new System.Drawing.Size(93, 29);
            uiLabel9.TabIndex = 99;
            uiLabel9.Text = "物料类型";
            uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnPackQty
            // 
            lblUnPackQty.Font = new System.Drawing.Font("微软雅黑", 28F, System.Drawing.FontStyle.Bold);
            lblUnPackQty.Location = new System.Drawing.Point(250, 361);
            lblUnPackQty.Name = "lblUnPackQty";
            lblUnPackQty.Size = new System.Drawing.Size(154, 71);
            lblUnPackQty.TabIndex = 97;
            lblUnPackQty.Text = "345";
            lblUnPackQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel12
            // 
            uiLabel12.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            uiLabel12.Location = new System.Drawing.Point(56, 377);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new System.Drawing.Size(154, 39);
            uiLabel12.TabIndex = 96;
            uiLabel12.Text = "未包装数量";
            uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPackQty
            // 
            lblPackQty.Font = new System.Drawing.Font("微软雅黑", 28F, System.Drawing.FontStyle.Bold);
            lblPackQty.Location = new System.Drawing.Point(250, 276);
            lblPackQty.Name = "lblPackQty";
            lblPackQty.Size = new System.Drawing.Size(154, 71);
            lblPackQty.TabIndex = 95;
            lblPackQty.Text = "345";
            lblPackQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel10
            // 
            uiLabel10.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            uiLabel10.Location = new System.Drawing.Point(32, 292);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new System.Drawing.Size(178, 39);
            uiLabel10.TabIndex = 87;
            uiLabel10.Text = "已包装彩盒数";
            uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderQty
            // 
            txtOrderQty.ButtonSymbol = 61761;
            txtOrderQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOrderQty.Enabled = false;
            txtOrderQty.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderQty.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtOrderQty.Location = new System.Drawing.Point(121, 201);
            txtOrderQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderQty.Maximum = 2147483647D;
            txtOrderQty.MaxLength = 50;
            txtOrderQty.Minimum = -2147483648D;
            txtOrderQty.MinimumSize = new System.Drawing.Size(1, 16);
            txtOrderQty.Name = "txtOrderQty";
            txtOrderQty.Size = new System.Drawing.Size(348, 36);
            txtOrderQty.Style = Sunny.UI.UIStyle.Custom;
            txtOrderQty.StyleCustomMode = true;
            txtOrderQty.TabIndex = 89;
            txtOrderQty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel8.Location = new System.Drawing.Point(9, 205);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new System.Drawing.Size(93, 29);
            uiLabel8.TabIndex = 90;
            uiLabel8.Text = "工单数量";
            uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemName
            // 
            txtItemName.ButtonSymbol = 61761;
            txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemName.Enabled = false;
            txtItemName.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemName.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtItemName.Location = new System.Drawing.Point(121, 155);
            txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemName.Maximum = 2147483647D;
            txtItemName.MaxLength = 50;
            txtItemName.Minimum = -2147483648D;
            txtItemName.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new System.Drawing.Size(348, 36);
            txtItemName.Style = Sunny.UI.UIStyle.Custom;
            txtItemName.StyleCustomMode = true;
            txtItemName.TabIndex = 91;
            txtItemName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel7.Location = new System.Drawing.Point(9, 159);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new System.Drawing.Size(93, 29);
            uiLabel7.TabIndex = 92;
            uiLabel7.Text = "产品名称";
            uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemCode
            // 
            txtItemCode.ButtonSymbol = 61761;
            txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtItemCode.Enabled = false;
            txtItemCode.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtItemCode.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtItemCode.Location = new System.Drawing.Point(122, 109);
            txtItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtItemCode.Maximum = 2147483647D;
            txtItemCode.MaxLength = 50;
            txtItemCode.Minimum = -2147483648D;
            txtItemCode.MinimumSize = new System.Drawing.Size(1, 16);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new System.Drawing.Size(348, 36);
            txtItemCode.Style = Sunny.UI.UIStyle.Custom;
            txtItemCode.StyleCustomMode = true;
            txtItemCode.TabIndex = 89;
            txtItemCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel6.Location = new System.Drawing.Point(10, 113);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new System.Drawing.Size(93, 29);
            uiLabel6.TabIndex = 90;
            uiLabel6.Text = "产品料号";
            uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderNo
            // 
            txtOrderNo.ButtonSymbol = 61761;
            txtOrderNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtOrderNo.Enabled = false;
            txtOrderNo.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            txtOrderNo.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtOrderNo.Location = new System.Drawing.Point(122, 16);
            txtOrderNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtOrderNo.Maximum = 2147483647D;
            txtOrderNo.MaxLength = 50;
            txtOrderNo.Minimum = -2147483648D;
            txtOrderNo.MinimumSize = new System.Drawing.Size(1, 16);
            txtOrderNo.Name = "txtOrderNo";
            txtOrderNo.Size = new System.Drawing.Size(348, 36);
            txtOrderNo.Style = Sunny.UI.UIStyle.Custom;
            txtOrderNo.StyleCustomMode = true;
            txtOrderNo.TabIndex = 87;
            txtOrderNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel4.Location = new System.Drawing.Point(10, 20);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(93, 29);
            uiLabel4.TabIndex = 88;
            uiLabel4.Text = "工单号";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiListBox1
            // 
            uiListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            uiListBox1.FillColor = System.Drawing.Color.White;
            uiListBox1.FillColor2 = System.Drawing.Color.FromArgb(235, 243, 255);
            uiListBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiListBox1.FormatString = "";
            uiListBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            uiListBox1.Location = new System.Drawing.Point(552, 234);
            uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            uiListBox1.Name = "uiListBox1";
            uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            uiListBox1.Size = new System.Drawing.Size(1, 1);
            uiListBox1.TabIndex = 13;
            uiListBox1.Text = "uiListBox1";
            // 
            // PackingBoxPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(0, 0);
            Controls.Add(uiListBox1);
            Controls.Add(uiPanel2);
            Controls.Add(lblMsg);
            Controls.Add(uiPanel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "PackingBoxPage";
            Text = "PackingPage";
            Load += PackingPage_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox txtOperCode;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtUserId;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtInput;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtOrderId;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnReset;
        private System.Windows.Forms.Label lblMsg;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolButton btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsEnabled;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel lblPackQty;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UITextBox txtOrderQty;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txtItemName;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtItemCode;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtOrderNo;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel lblUnPackQty;
        private System.Windows.Forms.Label lblStatus;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox txtMatType;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIListBox uiListBox1;
    }
}