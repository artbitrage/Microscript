
namespace Microscript
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnl_MainForm = new System.Windows.Forms.Panel();
            this.pnl_Version = new System.Windows.Forms.Panel();
            this.lbl_Update = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.btn_REST = new System.Windows.Forms.Button();
            this.btn_SOAP = new System.Windows.Forms.Button();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.btn_WDSL = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanRESTServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomSOAPTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomRequestHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pnl_MainForm.SuspendLayout();
            this.pnl_Version.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MainForm
            // 
            this.pnl_MainForm.Controls.Add(this.pnl_Version);
            this.pnl_MainForm.Controls.Add(this.btn_REST);
            this.pnl_MainForm.Controls.Add(this.btn_SOAP);
            this.pnl_MainForm.Controls.Add(this.pnl_Logo);
            this.pnl_MainForm.Controls.Add(this.btn_WDSL);
            this.pnl_MainForm.Controls.Add(this.menuStrip);
            this.pnl_MainForm.Location = new System.Drawing.Point(0, 0);
            this.pnl_MainForm.Name = "pnl_MainForm";
            this.pnl_MainForm.Size = new System.Drawing.Size(179, 450);
            this.pnl_MainForm.TabIndex = 0;
            // 
            // pnl_Version
            // 
            this.pnl_Version.Controls.Add(this.lbl_Update);
            this.pnl_Version.Controls.Add(this.lbl_ProductName);
            this.pnl_Version.Controls.Add(this.lbl_Version);
            this.pnl_Version.Location = new System.Drawing.Point(0, 350);
            this.pnl_Version.Name = "pnl_Version";
            this.pnl_Version.Size = new System.Drawing.Size(179, 100);
            this.pnl_Version.TabIndex = 5;
            // 
            // lbl_Update
            // 
            this.lbl_Update.AutoSize = true;
            this.lbl_Update.Location = new System.Drawing.Point(12, 30);
            this.lbl_Update.Name = "lbl_Update";
            this.lbl_Update.Size = new System.Drawing.Size(113, 13);
            this.lbl_Update.TabIndex = 3;
            this.lbl_Update.Text = "Software is up-to-date!";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(12, 65);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(94, 13);
            this.lbl_ProductName.TabIndex = 2;
            this.lbl_ProductName.Text = "Microscript (Alpha)";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(12, 78);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(140, 13);
            this.lbl_Version.TabIndex = 1;
            this.lbl_Version.Text = "Version: 0.1a (Build 201124)";
            // 
            // btn_REST
            // 
            this.btn_REST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_REST.Location = new System.Drawing.Point(12, 244);
            this.btn_REST.Name = "btn_REST";
            this.btn_REST.Size = new System.Drawing.Size(152, 45);
            this.btn_REST.TabIndex = 4;
            this.btn_REST.Text = "REST";
            this.btn_REST.UseVisualStyleBackColor = true;
            // 
            // btn_SOAP
            // 
            this.btn_SOAP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SOAP.Location = new System.Drawing.Point(12, 193);
            this.btn_SOAP.Name = "btn_SOAP";
            this.btn_SOAP.Size = new System.Drawing.Size(152, 45);
            this.btn_SOAP.TabIndex = 3;
            this.btn_SOAP.Text = "SOAP";
            this.btn_SOAP.UseVisualStyleBackColor = true;
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Logo.BackgroundImage")));
            this.pnl_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Logo.Location = new System.Drawing.Point(3, 27);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(173, 100);
            this.pnl_Logo.TabIndex = 2;
            // 
            // btn_WDSL
            // 
            this.btn_WDSL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WDSL.Location = new System.Drawing.Point(12, 142);
            this.btn_WDSL.Name = "btn_WDSL";
            this.btn_WDSL.Size = new System.Drawing.Size(152, 45);
            this.btn_WDSL.TabIndex = 1;
            this.btn_WDSL.Text = "WSDL";
            this.btn_WDSL.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.scanToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(179, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanRESTServiceToolStripMenuItem,
            this.addCustomSOAPTagsToolStripMenuItem,
            this.addCustomRequestHeaderToolStripMenuItem});
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.scanToolStripMenuItem.Text = "Scan";
            // 
            // scanRESTServiceToolStripMenuItem
            // 
            this.scanRESTServiceToolStripMenuItem.Name = "scanRESTServiceToolStripMenuItem";
            this.scanRESTServiceToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.scanRESTServiceToolStripMenuItem.Text = "Scan REST Service";
            this.scanRESTServiceToolStripMenuItem.Click += new System.EventHandler(this.scanRESTServiceToolStripMenuItem_Click);
            // 
            // addCustomSOAPTagsToolStripMenuItem
            // 
            this.addCustomSOAPTagsToolStripMenuItem.Name = "addCustomSOAPTagsToolStripMenuItem";
            this.addCustomSOAPTagsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.addCustomSOAPTagsToolStripMenuItem.Text = "Add Custom SOAP Tags";
            // 
            // addCustomRequestHeaderToolStripMenuItem
            // 
            this.addCustomRequestHeaderToolStripMenuItem.Name = "addCustomRequestHeaderToolStripMenuItem";
            this.addCustomRequestHeaderToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.addCustomRequestHeaderToolStripMenuItem.Text = "Add Custom Request Header";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(182, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(617, 450);
            this.panelChildForm.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.pnl_MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Microscript (Alpha)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_MainForm.ResumeLayout(false);
            this.pnl_MainForm.PerformLayout();
            this.pnl_Version.ResumeLayout(false);
            this.pnl_Version.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MainForm;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Button btn_WDSL;
        private System.Windows.Forms.Button btn_REST;
        private System.Windows.Forms.Button btn_SOAP;
        private System.Windows.Forms.Panel pnl_Version;
        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.ToolStripMenuItem scanRESTServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomSOAPTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomRequestHeaderToolStripMenuItem;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

