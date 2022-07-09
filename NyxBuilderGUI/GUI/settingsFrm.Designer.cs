
namespace NyxBuilderGUI.GUI
{
    partial class settingsFrm
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
            this.srcTextBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frmElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.txtBoxElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.saveBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.closeBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.closebtnElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.saveBtnElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.invisTxtBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.SuspendLayout();
            // 
            // srcTextBox
            // 
            this.srcTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.srcTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.srcTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.srcTextBox.DefaultText = "";
            this.srcTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.srcTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.srcTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.srcTextBox.DisabledState.Parent = this.srcTextBox;
            this.srcTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.srcTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.srcTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.srcTextBox.FocusedState.Parent = this.srcTextBox;
            this.srcTextBox.ForeColor = System.Drawing.Color.White;
            this.srcTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.srcTextBox.HoveredState.Parent = this.srcTextBox;
            this.srcTextBox.Location = new System.Drawing.Point(108, 87);
            this.srcTextBox.Name = "srcTextBox";
            this.srcTextBox.PasswordChar = '\0';
            this.srcTextBox.PlaceholderText = "";
            this.srcTextBox.SelectedText = "";
            this.srcTextBox.ShadowDecoration.Parent = this.srcTextBox;
            this.srcTextBox.Size = new System.Drawing.Size(200, 36);
            this.srcTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source directory";
            // 
            // frmElipse
            // 
            this.frmElipse.TargetControl = this;
            // 
            // txtBoxElipse
            // 
            this.txtBoxElipse.TargetControl = this.srcTextBox;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoveredState.Parent = this.saveBtn;
            this.saveBtn.Location = new System.Drawing.Point(225, 185);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PressedColor = System.Drawing.Color.White;
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(89, 41);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.closeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.closeBtn.CheckedState.Parent = this.closeBtn;
            this.closeBtn.CustomImages.Parent = this.closeBtn;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.HoveredState.Parent = this.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(320, 185);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedColor = System.Drawing.Color.White;
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(89, 41);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // closebtnElipse
            // 
            this.closebtnElipse.TargetControl = this.closeBtn;
            // 
            // saveBtnElipse
            // 
            this.saveBtnElipse.TargetControl = this.saveBtn;
            // 
            // invisTxtBox
            // 
            this.invisTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.invisTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.invisTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invisTxtBox.DefaultText = "";
            this.invisTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.invisTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.invisTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.invisTxtBox.DisabledState.Parent = this.invisTxtBox;
            this.invisTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.invisTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.invisTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.invisTxtBox.FocusedState.Parent = this.invisTxtBox;
            this.invisTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.invisTxtBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.invisTxtBox.HoveredState.Parent = this.invisTxtBox;
            this.invisTxtBox.Location = new System.Drawing.Point(399, 2);
            this.invisTxtBox.Name = "invisTxtBox";
            this.invisTxtBox.PasswordChar = '\0';
            this.invisTxtBox.PlaceholderText = "";
            this.invisTxtBox.SelectedText = "";
            this.invisTxtBox.ShadowDecoration.Parent = this.invisTxtBox;
            this.invisTxtBox.Size = new System.Drawing.Size(10, 10);
            this.invisTxtBox.TabIndex = 7;
            // 
            // settingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(409, 227);
            this.Controls.Add(this.invisTxtBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srcTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settingsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settingsFrm";
            this.Load += new System.EventHandler(this.settingsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneMaterialTextBox srcTextBox;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneElipse frmElipse;
        private Siticone.UI.WinForms.SiticoneElipse txtBoxElipse;
        private Siticone.UI.WinForms.SiticoneButton saveBtn;
        private Siticone.UI.WinForms.SiticoneButton closeBtn;
        private Siticone.UI.WinForms.SiticoneElipse closebtnElipse;
        private Siticone.UI.WinForms.SiticoneElipse saveBtnElipse;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox invisTxtBox;
    }
}