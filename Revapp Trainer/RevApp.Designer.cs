
namespace Revapp_Trainer
{
    partial class RevApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevApp));
            this.topPanel = new Guna.UI.WinForms.GunaPanel();
            this.thisMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.thisClose = new Guna.UI.WinForms.GunaControlBox();
            this.logoPicBox = new Guna.UI.WinForms.GunaPictureBox();
            this.mainPanel = new Guna.UI.WinForms.GunaPanel();
            this.lblUnlimitedMoney = new Guna.UI.WinForms.GunaLabel();
            this.checkMoney = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.lblUnlimitedHealth = new Guna.UI.WinForms.GunaLabel();
            this.checkHealth = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.mainSeperator = new Guna.UI.WinForms.GunaSeparator();
            this.lblGameName = new Guna.UI.WinForms.GunaLabel();
            this.topDrag = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.mainDrag = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.lblAmmo = new Guna.UI.WinForms.GunaLabel();
            this.checkAmmo = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(34)))));
            this.topPanel.Controls.Add(this.thisMinimize);
            this.topPanel.Controls.Add(this.thisClose);
            this.topPanel.Controls.Add(this.logoPicBox);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 40);
            this.topPanel.TabIndex = 0;
            // 
            // thisMinimize
            // 
            this.thisMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thisMinimize.AnimationHoverSpeed = 0.07F;
            this.thisMinimize.AnimationSpeed = 0.03F;
            this.thisMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.thisMinimize.IconColor = System.Drawing.Color.White;
            this.thisMinimize.IconSize = 15F;
            this.thisMinimize.Location = new System.Drawing.Point(712, 0);
            this.thisMinimize.Name = "thisMinimize";
            this.thisMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.thisMinimize.OnHoverIconColor = System.Drawing.Color.Red;
            this.thisMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.thisMinimize.Size = new System.Drawing.Size(40, 40);
            this.thisMinimize.TabIndex = 1;
            // 
            // thisClose
            // 
            this.thisClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thisClose.AnimationHoverSpeed = 0.07F;
            this.thisClose.AnimationSpeed = 0.03F;
            this.thisClose.IconColor = System.Drawing.Color.White;
            this.thisClose.IconSize = 15F;
            this.thisClose.Location = new System.Drawing.Point(760, 0);
            this.thisClose.Name = "thisClose";
            this.thisClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.thisClose.OnHoverIconColor = System.Drawing.Color.Red;
            this.thisClose.OnPressedColor = System.Drawing.Color.Black;
            this.thisClose.Size = new System.Drawing.Size(40, 40);
            this.thisClose.TabIndex = 0;
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPicBox.BackgroundImage")));
            this.logoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPicBox.BaseColor = System.Drawing.Color.White;
            this.logoPicBox.Location = new System.Drawing.Point(-4, 7);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(120, 25);
            this.logoPicBox.TabIndex = 0;
            this.logoPicBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.lblAmmo);
            this.mainPanel.Controls.Add(this.checkAmmo);
            this.mainPanel.Controls.Add(this.lblUnlimitedMoney);
            this.mainPanel.Controls.Add(this.checkMoney);
            this.mainPanel.Controls.Add(this.lblUnlimitedHealth);
            this.mainPanel.Controls.Add(this.checkHealth);
            this.mainPanel.Controls.Add(this.mainSeperator);
            this.mainPanel.Controls.Add(this.lblGameName);
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 460);
            this.mainPanel.TabIndex = 1;
            // 
            // lblUnlimitedMoney
            // 
            this.lblUnlimitedMoney.AutoSize = true;
            this.lblUnlimitedMoney.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnlimitedMoney.ForeColor = System.Drawing.Color.White;
            this.lblUnlimitedMoney.Location = new System.Drawing.Point(24, 147);
            this.lblUnlimitedMoney.Name = "lblUnlimitedMoney";
            this.lblUnlimitedMoney.Size = new System.Drawing.Size(133, 19);
            this.lblUnlimitedMoney.TabIndex = 5;
            this.lblUnlimitedMoney.Text = "Unlimited Money";
            // 
            // checkMoney
            // 
            this.checkMoney.BaseColor = System.Drawing.SystemColors.Control;
            this.checkMoney.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.checkMoney.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkMoney.FillColor = System.Drawing.Color.White;
            this.checkMoney.Location = new System.Drawing.Point(254, 147);
            this.checkMoney.Name = "checkMoney";
            this.checkMoney.Size = new System.Drawing.Size(38, 19);
            this.checkMoney.TabIndex = 4;
            // 
            // lblUnlimitedHealth
            // 
            this.lblUnlimitedHealth.AutoSize = true;
            this.lblUnlimitedHealth.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnlimitedHealth.ForeColor = System.Drawing.Color.White;
            this.lblUnlimitedHealth.Location = new System.Drawing.Point(24, 108);
            this.lblUnlimitedHealth.Name = "lblUnlimitedHealth";
            this.lblUnlimitedHealth.Size = new System.Drawing.Size(126, 19);
            this.lblUnlimitedHealth.TabIndex = 3;
            this.lblUnlimitedHealth.Text = "Unlimited Heath";
            // 
            // checkHealth
            // 
            this.checkHealth.BaseColor = System.Drawing.SystemColors.Control;
            this.checkHealth.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.checkHealth.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkHealth.FillColor = System.Drawing.Color.White;
            this.checkHealth.Location = new System.Drawing.Point(254, 108);
            this.checkHealth.Name = "checkHealth";
            this.checkHealth.Size = new System.Drawing.Size(38, 19);
            this.checkHealth.TabIndex = 2;
            // 
            // mainSeperator
            // 
            this.mainSeperator.LineColor = System.Drawing.Color.DimGray;
            this.mainSeperator.Location = new System.Drawing.Point(28, 58);
            this.mainSeperator.Name = "mainSeperator";
            this.mainSeperator.Size = new System.Drawing.Size(199, 10);
            this.mainSeperator.TabIndex = 1;
            this.mainSeperator.Thickness = 2;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Roboto Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(22, 23);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(206, 33);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "ASSAULT CUBE";
            // 
            // topDrag
            // 
            this.topDrag.TargetControl = this.topPanel;
            // 
            // mainDrag
            // 
            this.mainDrag.TargetControl = this.mainPanel;
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.ForeColor = System.Drawing.Color.White;
            this.lblAmmo.Location = new System.Drawing.Point(24, 189);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(128, 19);
            this.lblAmmo.TabIndex = 7;
            this.lblAmmo.Text = "Unlimited Ammo";
            // 
            // checkAmmo
            // 
            this.checkAmmo.BaseColor = System.Drawing.SystemColors.Control;
            this.checkAmmo.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.checkAmmo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkAmmo.FillColor = System.Drawing.Color.White;
            this.checkAmmo.Location = new System.Drawing.Point(254, 189);
            this.checkAmmo.Name = "checkAmmo";
            this.checkAmmo.Size = new System.Drawing.Size(38, 19);
            this.checkAmmo.TabIndex = 6;
            this.checkAmmo.CheckedChanged += new System.EventHandler(this.checkAmmo_CheckedChanged);
            // 
            // RevApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RevApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevApp";
            this.Load += new System.EventHandler(this.RevApp_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel topPanel;
        private Guna.UI.WinForms.GunaPanel mainPanel;
        private Guna.UI.WinForms.GunaPictureBox logoPicBox;
        private Guna.UI.WinForms.GunaControlBox thisClose;
        private Guna.UI.WinForms.GunaDragControl topDrag;
        private Guna.UI.WinForms.GunaDragControl mainDrag;
        private Guna.UI.WinForms.GunaControlBox thisMinimize;
        private Guna.UI.WinForms.GunaLabel lblGameName;
        private Guna.UI.WinForms.GunaSeparator mainSeperator;
        private Guna.UI.WinForms.GunaGoogleSwitch checkHealth;
        private Guna.UI.WinForms.GunaLabel lblUnlimitedHealth;
        private Guna.UI.WinForms.GunaLabel lblUnlimitedMoney;
        private Guna.UI.WinForms.GunaGoogleSwitch checkMoney;
        private Guna.UI.WinForms.GunaLabel lblAmmo;
        private Guna.UI.WinForms.GunaGoogleSwitch checkAmmo;
    }
}

