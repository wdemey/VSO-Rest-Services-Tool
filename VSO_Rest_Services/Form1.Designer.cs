namespace VSO_Rest_Services
{
    partial class frmMain
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
            this.btnCallService = new System.Windows.Forms.Button();
            this.grpLoginDetails = new System.Windows.Forms.GroupBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.lblAssociatedBugs = new System.Windows.Forms.Label();
            this.txtAPIVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTestPlanID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpLoginDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCallService
            // 
            this.btnCallService.Location = new System.Drawing.Point(26, 141);
            this.btnCallService.Name = "btnCallService";
            this.btnCallService.Size = new System.Drawing.Size(100, 38);
            this.btnCallService.TabIndex = 0;
            this.btnCallService.Text = "Call service";
            this.btnCallService.UseVisualStyleBackColor = true;
            this.btnCallService.Click += new System.EventHandler(this.btnCallService_Click);
            // 
            // grpLoginDetails
            // 
            this.grpLoginDetails.Controls.Add(this.txtURL);
            this.grpLoginDetails.Controls.Add(this.lblURL);
            this.grpLoginDetails.Controls.Add(this.txtPassword);
            this.grpLoginDetails.Controls.Add(this.lblPassword);
            this.grpLoginDetails.Controls.Add(this.txtUser);
            this.grpLoginDetails.Controls.Add(this.lblUser);
            this.grpLoginDetails.Location = new System.Drawing.Point(31, 23);
            this.grpLoginDetails.Name = "grpLoginDetails";
            this.grpLoginDetails.Size = new System.Drawing.Size(557, 114);
            this.grpLoginDetails.TabIndex = 2;
            this.grpLoginDetails.TabStop = false;
            this.grpLoginDetails.Text = "Login Details";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(101, 81);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(253, 20);
            this.txtURL.TabIndex = 5;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(63, 84);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "URL:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(101, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(253, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(39, 52);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(101, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(253, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(63, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProject);
            this.groupBox1.Controls.Add(this.lblProject);
            this.groupBox1.Controls.Add(this.rbtYes);
            this.groupBox1.Controls.Add(this.rbtNo);
            this.groupBox1.Controls.Add(this.lblAssociatedBugs);
            this.groupBox1.Controls.Add(this.txtAPIVersion);
            this.groupBox1.Controls.Add(this.btnCallService);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTestPlanID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Details";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(212, 29);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(100, 20);
            this.txtProject.TabIndex = 10;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(163, 32);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 9;
            this.lblProject.Text = "Project:";
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.Location = new System.Drawing.Point(212, 99);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 0;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = true;
  
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(261, 99);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // lblAssociatedBugs
            // 
            this.lblAssociatedBugs.AutoSize = true;
            this.lblAssociatedBugs.Location = new System.Drawing.Point(23, 101);
            this.lblAssociatedBugs.Name = "lblAssociatedBugs";
            this.lblAssociatedBugs.Size = new System.Drawing.Size(183, 13);
            this.lblAssociatedBugs.TabIndex = 8;
            this.lblAssociatedBugs.Text = "Get test cases with associated bugs?";
            // 
            // txtAPIVersion
            // 
            this.txtAPIVersion.Location = new System.Drawing.Point(451, 64);
            this.txtAPIVersion.Name = "txtAPIVersion";
            this.txtAPIVersion.Size = new System.Drawing.Size(78, 20);
            this.txtAPIVersion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "API version:";
            // 
            // txtTestPlanID
            // 
            this.txtTestPlanID.Location = new System.Drawing.Point(212, 64);
            this.txtTestPlanID.Name = "txtTestPlanID";
            this.txtTestPlanID.Size = new System.Drawing.Size(100, 20);
            this.txtTestPlanID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Plan ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Location = new System.Drawing.Point(31, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 159);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 19);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(534, 134);
            this.txtMessage.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(36, 522);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(482, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 567);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLoginDetails);
            this.Name = "frmMain";
            this.Text = "VSO Rest Services Caller";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpLoginDetails.ResumeLayout(false);
            this.grpLoginDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCallService;
        private System.Windows.Forms.GroupBox grpLoginDetails;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAPIVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTestPlanID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAssociatedBugs;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblProject;
    }
}

