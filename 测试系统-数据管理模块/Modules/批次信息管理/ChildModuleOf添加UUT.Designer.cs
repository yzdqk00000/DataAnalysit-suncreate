﻿namespace 数据管理模块.Modules
{
    partial class ChildModuleOf添加UUT
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_退出 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_确认添加 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit_UUT编号 = new DevExpress.XtraEditors.LookUpEdit();
            this.imageComboBoxEdit_生产状态 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.comboBoxEdit_UUT类型 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_UUT编号.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit_生产状态.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_UUT类型.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton_退出);
            this.groupControl1.Controls.Add(this.simpleButton_确认添加);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 275);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(479, 87);
            this.groupControl1.TabIndex = 2;
            // 
            // simpleButton_退出
            // 
            this.simpleButton_退出.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_退出.Appearance.Options.UseFont = true;
            this.simpleButton_退出.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton_退出.ImageOptions.Image = global::数据管理模块.Properties.Resources.cancel_32x32;
            this.simpleButton_退出.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton_退出.Location = new System.Drawing.Point(261, 25);
            this.simpleButton_退出.Name = "simpleButton_退出";
            this.simpleButton_退出.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton_退出.Size = new System.Drawing.Size(153, 47);
            this.simpleButton_退出.TabIndex = 1;
            this.simpleButton_退出.Text = "退出";
            this.simpleButton_退出.Click += new System.EventHandler(this.simpleButton_退出_Click);
            // 
            // simpleButton_确认添加
            // 
            this.simpleButton_确认添加.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_确认添加.Appearance.Options.UseFont = true;
            this.simpleButton_确认添加.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton_确认添加.ImageOptions.Image = global::数据管理模块.Properties.Resources.apply_32x32;
            this.simpleButton_确认添加.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton_确认添加.Location = new System.Drawing.Point(51, 25);
            this.simpleButton_确认添加.Name = "simpleButton_确认添加";
            this.simpleButton_确认添加.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton_确认添加.Size = new System.Drawing.Size(153, 47);
            this.simpleButton_确认添加.TabIndex = 1;
            this.simpleButton_确认添加.Text = "确认添加";
            this.simpleButton_确认添加.Click += new System.EventHandler(this.simpleButton_确认添加_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.SvgImage = global::数据管理模块.Properties.Resources.m_pm;
            this.groupControl2.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.groupControl2.Controls.Add(this.lookUpEdit_UUT编号);
            this.groupControl2.Controls.Add(this.imageComboBoxEdit_生产状态);
            this.groupControl2.Controls.Add(this.comboBoxEdit_UUT类型);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(479, 275);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "UUT信息（The UUT View）";
            // 
            // lookUpEdit_UUT编号
            // 
            this.lookUpEdit_UUT编号.Location = new System.Drawing.Point(192, 200);
            this.lookUpEdit_UUT编号.Name = "lookUpEdit_UUT编号";
            this.lookUpEdit_UUT编号.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_UUT编号.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit_UUT编号.Size = new System.Drawing.Size(184, 20);
            this.lookUpEdit_UUT编号.TabIndex = 12;
            // 
            // imageComboBoxEdit_生产状态
            // 
            this.imageComboBoxEdit_生产状态.Location = new System.Drawing.Point(192, 62);
            this.imageComboBoxEdit_生产状态.Name = "imageComboBoxEdit_生产状态";
            this.imageComboBoxEdit_生产状态.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit_生产状态.Size = new System.Drawing.Size(184, 20);
            this.imageComboBoxEdit_生产状态.TabIndex = 3;
            // 
            // comboBoxEdit_UUT类型
            // 
            this.comboBoxEdit_UUT类型.EditValue = "DAM-T";
            this.comboBoxEdit_UUT类型.Location = new System.Drawing.Point(192, 139);
            this.comboBoxEdit_UUT类型.Name = "comboBoxEdit_UUT类型";
            this.comboBoxEdit_UUT类型.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_UUT类型.Size = new System.Drawing.Size(184, 20);
            this.comboBoxEdit_UUT类型.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(72, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "UUT生产状态：";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(96, 203);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "UUT编号：";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(96, 141);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "UUT类型：";
            // 
            // ChildModuleOf添加UUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 362);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChildModuleOf添加UUT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加批次信息";
            this.Load += new System.EventHandler(this.ChildModuleOf添加UUT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_UUT编号.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit_生产状态.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_UUT类型.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_UUT类型;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_确认添加;
        private DevExpress.XtraEditors.SimpleButton simpleButton_退出;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit_生产状态;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_UUT编号;
    }
}