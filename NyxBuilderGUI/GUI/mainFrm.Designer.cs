
namespace NyxBuilderGUI.GUI
{
    partial class mainFrm
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
            this.topPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.miniBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.exitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.topPnlElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.dragCtrl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.windowsBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.windowsBtnElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.macBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.macBtnElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.linuxBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.linuxBtnElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.darwinBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.darwinBtnElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.settingsBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.settingsBtnElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.frmElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.topPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.topPnl.Controls.Add(this.label1);
            this.topPnl.Controls.Add(this.miniBtn);
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(550, 33);
            this.topPnl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nyx Builder";
            // 
            // miniBtn
            // 
            this.miniBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.miniBtn.CheckedState.Parent = this.miniBtn;
            this.miniBtn.CustomImages.Parent = this.miniBtn;
            this.miniBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.miniBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.miniBtn.ForeColor = System.Drawing.Color.White;
            this.miniBtn.HoveredState.Parent = this.miniBtn;
            this.miniBtn.Location = new System.Drawing.Point(459, 3);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.PressedColor = System.Drawing.Color.White;
            this.miniBtn.ShadowDecoration.Parent = this.miniBtn;
            this.miniBtn.Size = new System.Drawing.Size(41, 27);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.Text = "-";
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.exitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoveredState.Parent = this.exitBtn;
            this.exitBtn.Location = new System.Drawing.Point(506, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.PressedColor = System.Drawing.Color.White;
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(41, 27);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // topPnlElipse
            // 
            this.topPnlElipse.TargetControl = this.topPnl;
            // 
            // dragCtrl
            // 
            this.dragCtrl.TargetControl = this.topPnl;
            // 
            // windowsBtn
            // 
            this.windowsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.windowsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.windowsBtn.CheckedState.Parent = this.windowsBtn;
            this.windowsBtn.CustomImages.Parent = this.windowsBtn;
            this.windowsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.windowsBtn.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowsBtn.ForeColor = System.Drawing.Color.White;
            this.windowsBtn.HoveredState.Parent = this.windowsBtn;
            this.windowsBtn.Location = new System.Drawing.Point(16, 3);
            this.windowsBtn.Name = "windowsBtn";
            this.windowsBtn.PressedColor = System.Drawing.Color.White;
            this.windowsBtn.ShadowDecoration.Parent = this.windowsBtn;
            this.windowsBtn.Size = new System.Drawing.Size(112, 41);
            this.windowsBtn.TabIndex = 2;
            this.windowsBtn.Text = "Windows";
            this.windowsBtn.Click += new System.EventHandler(this.windowsBtn_Click);
            // 
            // windowsBtnElipse
            // 
            this.windowsBtnElipse.TargetControl = this.windowsBtn;
            // 
            // macBtn
            // 
            this.macBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.macBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.macBtn.CheckedState.Parent = this.macBtn;
            this.macBtn.CustomImages.Parent = this.macBtn;
            this.macBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.macBtn.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macBtn.ForeColor = System.Drawing.Color.White;
            this.macBtn.HoveredState.Parent = this.macBtn;
            this.macBtn.Location = new System.Drawing.Point(245, 3);
            this.macBtn.Name = "macBtn";
            this.macBtn.PressedColor = System.Drawing.Color.White;
            this.macBtn.ShadowDecoration.Parent = this.macBtn;
            this.macBtn.Size = new System.Drawing.Size(112, 41);
            this.macBtn.TabIndex = 3;
            this.macBtn.Text = "Mac";
            this.macBtn.Click += new System.EventHandler(this.macBtn_Click);
            // 
            // macBtnElipse
            // 
            this.macBtnElipse.TargetControl = this.macBtn;
            // 
            // linuxBtn
            // 
            this.linuxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.linuxBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.linuxBtn.CheckedState.Parent = this.linuxBtn;
            this.linuxBtn.CustomImages.Parent = this.linuxBtn;
            this.linuxBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.linuxBtn.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linuxBtn.ForeColor = System.Drawing.Color.White;
            this.linuxBtn.HoveredState.Parent = this.linuxBtn;
            this.linuxBtn.Location = new System.Drawing.Point(16, 190);
            this.linuxBtn.Name = "linuxBtn";
            this.linuxBtn.PressedColor = System.Drawing.Color.White;
            this.linuxBtn.ShadowDecoration.Parent = this.linuxBtn;
            this.linuxBtn.Size = new System.Drawing.Size(112, 41);
            this.linuxBtn.TabIndex = 4;
            this.linuxBtn.Text = "Linux";
            this.linuxBtn.Click += new System.EventHandler(this.linuxBtn_Click);
            // 
            // linuxBtnElipse
            // 
            this.linuxBtnElipse.TargetControl = this.linuxBtn;
            // 
            // darwinBtn
            // 
            this.darwinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.darwinBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.darwinBtn.CheckedState.Parent = this.darwinBtn;
            this.darwinBtn.CustomImages.Parent = this.darwinBtn;
            this.darwinBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.darwinBtn.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darwinBtn.ForeColor = System.Drawing.Color.White;
            this.darwinBtn.HoveredState.Parent = this.darwinBtn;
            this.darwinBtn.Location = new System.Drawing.Point(245, 190);
            this.darwinBtn.Name = "darwinBtn";
            this.darwinBtn.PressedColor = System.Drawing.Color.White;
            this.darwinBtn.ShadowDecoration.Parent = this.darwinBtn;
            this.darwinBtn.Size = new System.Drawing.Size(112, 41);
            this.darwinBtn.TabIndex = 5;
            this.darwinBtn.Text = "Darwin";
            this.darwinBtn.Click += new System.EventHandler(this.darwinBtn_Click);
            // 
            // darwinBtnElipse
            // 
            this.darwinBtnElipse.TargetControl = this.darwinBtn;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.windowsBtn);
            this.panel1.Controls.Add(this.darwinBtn);
            this.panel1.Controls.Add(this.linuxBtn);
            this.panel1.Controls.Add(this.macBtn);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.panel1.Location = new System.Drawing.Point(97, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 234);
            this.panel1.TabIndex = 6;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this.panel1;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.settingsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.settingsBtn.CheckedState.Parent = this.settingsBtn;
            this.settingsBtn.CustomImages.Parent = this.settingsBtn;
            this.settingsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.settingsBtn.Font = new System.Drawing.Font("badcache", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.HoveredState.Parent = this.settingsBtn;
            this.settingsBtn.Location = new System.Drawing.Point(491, 316);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.PressedColor = System.Drawing.Color.White;
            this.settingsBtn.ShadowDecoration.Parent = this.settingsBtn;
            this.settingsBtn.Size = new System.Drawing.Size(59, 38);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.Text = "G";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // settingsBtnElipse
            // 
            this.settingsBtnElipse.TargetControl = this.settingsBtn;
            // 
            // frmElipse
            // 
            this.frmElipse.TargetControl = this;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(550, 354);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainFrm";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private Siticone.UI.WinForms.SiticoneButton exitBtn;
        private Siticone.UI.WinForms.SiticoneButton miniBtn;
        private Siticone.UI.WinForms.SiticoneElipse topPnlElipse;
        private Siticone.UI.WinForms.SiticoneDragControl dragCtrl;
        private Siticone.UI.WinForms.SiticoneButton windowsBtn;
        private Siticone.UI.WinForms.SiticoneElipse windowsBtnElipse;
        private Siticone.UI.WinForms.SiticoneButton macBtn;
        private Siticone.UI.WinForms.SiticoneElipse macBtnElipse;
        private Siticone.UI.WinForms.SiticoneButton linuxBtn;
        private Siticone.UI.WinForms.SiticoneElipse linuxBtnElipse;
        private Siticone.UI.WinForms.SiticoneButton darwinBtn;
        private Siticone.UI.WinForms.SiticoneElipse darwinBtnElipse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneButton settingsBtn;
        private Siticone.UI.WinForms.SiticoneElipse settingsBtnElipse;
        private Siticone.UI.WinForms.SiticoneElipse frmElipse;
    }
}