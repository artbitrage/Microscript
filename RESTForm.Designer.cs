
namespace Microscript
{
    partial class RESTForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RESTForm));
            this.lv_Result = new System.Windows.Forms.ListView();
            this.pnl_Conf = new System.Windows.Forms.Panel();
            this.btn_CustomSOAP = new System.Windows.Forms.Button();
            this.cbx_Debug = new System.Windows.Forms.CheckBox();
            this.cbx_XMLReport = new System.Windows.Forms.CheckBox();
            this.cbx_InfoDisclo = new System.Windows.Forms.CheckBox();
            this.cbx_DynamicScan = new System.Windows.Forms.CheckBox();
            this.lbl_Config = new System.Windows.Forms.Label();
            this.cbx_StaticScan = new System.Windows.Forms.CheckBox();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.btn_JSON = new System.Windows.Forms.Button();
            this.grpBox_Auth = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_ContentType = new System.Windows.Forms.Label();
            this.lbl_PostData = new System.Windows.Forms.Label();
            this.cmbContentType = new System.Windows.Forms.ComboBox();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.cmbMethods = new System.Windows.Forms.ComboBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lbl_Method = new System.Windows.Forms.Label();
            this.lbl_URL = new System.Windows.Forms.Label();
            this.pnl_Conf.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.grpBox_Auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Result
            // 
            this.lv_Result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_Result.HideSelection = false;
            this.lv_Result.LabelWrap = false;
            this.lv_Result.Location = new System.Drawing.Point(12, 193);
            this.lv_Result.Name = "lv_Result";
            this.lv_Result.Size = new System.Drawing.Size(425, 245);
            this.lv_Result.TabIndex = 0;
            this.lv_Result.UseCompatibleStateImageBehavior = false;
            this.lv_Result.View = System.Windows.Forms.View.Details;
            // 
            // pnl_Conf
            // 
            this.pnl_Conf.Controls.Add(this.btn_CustomSOAP);
            this.pnl_Conf.Controls.Add(this.cbx_Debug);
            this.pnl_Conf.Controls.Add(this.cbx_XMLReport);
            this.pnl_Conf.Controls.Add(this.cbx_InfoDisclo);
            this.pnl_Conf.Controls.Add(this.cbx_DynamicScan);
            this.pnl_Conf.Controls.Add(this.lbl_Config);
            this.pnl_Conf.Controls.Add(this.cbx_StaticScan);
            this.pnl_Conf.Location = new System.Drawing.Point(443, 221);
            this.pnl_Conf.Name = "pnl_Conf";
            this.pnl_Conf.Size = new System.Drawing.Size(162, 217);
            this.pnl_Conf.TabIndex = 0;
            // 
            // btn_CustomSOAP
            // 
            this.btn_CustomSOAP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CustomSOAP.Location = new System.Drawing.Point(19, 166);
            this.btn_CustomSOAP.Name = "btn_CustomSOAP";
            this.btn_CustomSOAP.Size = new System.Drawing.Size(121, 35);
            this.btn_CustomSOAP.TabIndex = 13;
            this.btn_CustomSOAP.Text = "Custom SOAP Tags";
            this.btn_CustomSOAP.UseVisualStyleBackColor = true;
            // 
            // cbx_Debug
            // 
            this.cbx_Debug.AutoSize = true;
            this.cbx_Debug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Debug.Location = new System.Drawing.Point(19, 134);
            this.cbx_Debug.Name = "cbx_Debug";
            this.cbx_Debug.Size = new System.Drawing.Size(58, 17);
            this.cbx_Debug.TabIndex = 12;
            this.cbx_Debug.Text = "Debug";
            this.cbx_Debug.UseVisualStyleBackColor = true;
            // 
            // cbx_XMLReport
            // 
            this.cbx_XMLReport.AutoSize = true;
            this.cbx_XMLReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_XMLReport.Location = new System.Drawing.Point(19, 111);
            this.cbx_XMLReport.Name = "cbx_XMLReport";
            this.cbx_XMLReport.Size = new System.Drawing.Size(83, 17);
            this.cbx_XMLReport.TabIndex = 11;
            this.cbx_XMLReport.Text = "XML Report";
            this.cbx_XMLReport.UseVisualStyleBackColor = true;
            // 
            // cbx_InfoDisclo
            // 
            this.cbx_InfoDisclo.AutoSize = true;
            this.cbx_InfoDisclo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_InfoDisclo.Location = new System.Drawing.Point(19, 88);
            this.cbx_InfoDisclo.Name = "cbx_InfoDisclo";
            this.cbx_InfoDisclo.Size = new System.Drawing.Size(99, 17);
            this.cbx_InfoDisclo.TabIndex = 11;
            this.cbx_InfoDisclo.Text = "Info. Disclosure";
            this.cbx_InfoDisclo.UseVisualStyleBackColor = true;
            // 
            // cbx_DynamicScan
            // 
            this.cbx_DynamicScan.AutoSize = true;
            this.cbx_DynamicScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_DynamicScan.Location = new System.Drawing.Point(19, 65);
            this.cbx_DynamicScan.Name = "cbx_DynamicScan";
            this.cbx_DynamicScan.Size = new System.Drawing.Size(95, 17);
            this.cbx_DynamicScan.TabIndex = 10;
            this.cbx_DynamicScan.Text = "Dynamic Scan";
            this.cbx_DynamicScan.UseVisualStyleBackColor = true;
            // 
            // lbl_Config
            // 
            this.lbl_Config.AutoSize = true;
            this.lbl_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Config.Location = new System.Drawing.Point(16, 14);
            this.lbl_Config.Name = "lbl_Config";
            this.lbl_Config.Size = new System.Drawing.Size(88, 13);
            this.lbl_Config.TabIndex = 0;
            this.lbl_Config.Text = "Configurations";
            // 
            // cbx_StaticScan
            // 
            this.cbx_StaticScan.AutoSize = true;
            this.cbx_StaticScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_StaticScan.Location = new System.Drawing.Point(19, 42);
            this.cbx_StaticScan.Name = "cbx_StaticScan";
            this.cbx_StaticScan.Size = new System.Drawing.Size(81, 17);
            this.cbx_StaticScan.TabIndex = 9;
            this.cbx_StaticScan.Text = "Static Scan";
            this.cbx_StaticScan.UseVisualStyleBackColor = true;
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.btn_Scan);
            this.pnl_Dashboard.Controls.Add(this.btn_JSON);
            this.pnl_Dashboard.Controls.Add(this.grpBox_Auth);
            this.pnl_Dashboard.Controls.Add(this.lbl_ContentType);
            this.pnl_Dashboard.Controls.Add(this.lbl_PostData);
            this.pnl_Dashboard.Controls.Add(this.cmbContentType);
            this.pnl_Dashboard.Controls.Add(this.txtPostData);
            this.pnl_Dashboard.Controls.Add(this.cmbMethods);
            this.pnl_Dashboard.Controls.Add(this.txtURL);
            this.pnl_Dashboard.Controls.Add(this.lbl_Method);
            this.pnl_Dashboard.Controls.Add(this.lbl_URL);
            this.pnl_Dashboard.Location = new System.Drawing.Point(12, 12);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(593, 175);
            this.pnl_Dashboard.TabIndex = 0;
            // 
            // btn_Scan
            // 
            this.btn_Scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Scan.Location = new System.Drawing.Point(316, 133);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(75, 23);
            this.btn_Scan.TabIndex = 6;
            this.btn_Scan.Text = "Scan";
            this.btn_Scan.UseVisualStyleBackColor = true;
            // 
            // btn_JSON
            // 
            this.btn_JSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JSON.Location = new System.Drawing.Point(316, 37);
            this.btn_JSON.Name = "btn_JSON";
            this.btn_JSON.Size = new System.Drawing.Size(75, 23);
            this.btn_JSON.TabIndex = 3;
            this.btn_JSON.Text = "JSON";
            this.btn_JSON.UseVisualStyleBackColor = true;
            // 
            // grpBox_Auth
            // 
            this.grpBox_Auth.Controls.Add(this.txtPassword);
            this.grpBox_Auth.Controls.Add(this.txtUsername);
            this.grpBox_Auth.Controls.Add(this.lbl_Password);
            this.grpBox_Auth.Controls.Add(this.lbl_Username);
            this.grpBox_Auth.Location = new System.Drawing.Point(397, 10);
            this.grpBox_Auth.Name = "grpBox_Auth";
            this.grpBox_Auth.Size = new System.Drawing.Size(193, 146);
            this.grpBox_Auth.TabIndex = 0;
            this.grpBox_Auth.TabStop = false;
            this.grpBox_Auth.Text = "Basic Authentication";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(18, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(18, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(17, 83);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(15, 29);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_ContentType
            // 
            this.lbl_ContentType.AutoSize = true;
            this.lbl_ContentType.Location = new System.Drawing.Point(7, 138);
            this.lbl_ContentType.Name = "lbl_ContentType";
            this.lbl_ContentType.Size = new System.Drawing.Size(71, 13);
            this.lbl_ContentType.TabIndex = 0;
            this.lbl_ContentType.Text = "Content Type";
            // 
            // lbl_PostData
            // 
            this.lbl_PostData.AutoSize = true;
            this.lbl_PostData.Location = new System.Drawing.Point(24, 72);
            this.lbl_PostData.Name = "lbl_PostData";
            this.lbl_PostData.Size = new System.Drawing.Size(54, 13);
            this.lbl_PostData.TabIndex = 0;
            this.lbl_PostData.Text = "Post Data";
            // 
            // cmbContentType
            // 
            this.cmbContentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbContentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContentType.FormattingEnabled = true;
            this.cmbContentType.Location = new System.Drawing.Point(84, 135);
            this.cmbContentType.Name = "cmbContentType";
            this.cmbContentType.Size = new System.Drawing.Size(209, 21);
            this.cmbContentType.TabIndex = 5;
            // 
            // txtPostData
            // 
            this.txtPostData.Location = new System.Drawing.Point(84, 69);
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPostData.Size = new System.Drawing.Size(307, 60);
            this.txtPostData.TabIndex = 4;
            // 
            // cmbMethods
            // 
            this.cmbMethods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethods.FormattingEnabled = true;
            this.cmbMethods.Location = new System.Drawing.Point(84, 39);
            this.cmbMethods.Name = "cmbMethods";
            this.cmbMethods.Size = new System.Drawing.Size(209, 21);
            this.cmbMethods.TabIndex = 2;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(84, 10);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(307, 20);
            this.txtURL.TabIndex = 1;
            // 
            // lbl_Method
            // 
            this.lbl_Method.AutoSize = true;
            this.lbl_Method.Location = new System.Drawing.Point(35, 42);
            this.lbl_Method.Name = "lbl_Method";
            this.lbl_Method.Size = new System.Drawing.Size(43, 13);
            this.lbl_Method.TabIndex = 0;
            this.lbl_Method.Text = "Method";
            // 
            // lbl_URL
            // 
            this.lbl_URL.AutoSize = true;
            this.lbl_URL.Location = new System.Drawing.Point(49, 13);
            this.lbl_URL.Name = "lbl_URL";
            this.lbl_URL.Size = new System.Drawing.Size(29, 13);
            this.lbl_URL.TabIndex = 0;
            this.lbl_URL.Text = "URL";
            // 
            // RESTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pnl_Conf);
            this.Controls.Add(this.lv_Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RESTForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RESTForm";
            this.pnl_Conf.ResumeLayout(false);
            this.pnl_Conf.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.grpBox_Auth.ResumeLayout(false);
            this.grpBox_Auth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Result;
        private System.Windows.Forms.Panel pnl_Conf;
        private System.Windows.Forms.CheckBox cbx_Debug;
        private System.Windows.Forms.CheckBox cbx_XMLReport;
        private System.Windows.Forms.CheckBox cbx_InfoDisclo;
        private System.Windows.Forms.CheckBox cbx_DynamicScan;
        private System.Windows.Forms.Label lbl_Config;
        private System.Windows.Forms.CheckBox cbx_StaticScan;
        private System.Windows.Forms.Button btn_CustomSOAP;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_ContentType;
        private System.Windows.Forms.Label lbl_PostData;
        private System.Windows.Forms.ComboBox cmbContentType;
        private System.Windows.Forms.TextBox txtPostData;
        private System.Windows.Forms.ComboBox cmbMethods;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lbl_Method;
        private System.Windows.Forms.Label lbl_URL;
        private System.Windows.Forms.GroupBox grpBox_Auth;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btn_JSON;
        private System.Windows.Forms.Button btn_Scan;
    }
}