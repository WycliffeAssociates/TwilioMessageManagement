namespace TwilioMessageManagement
{
    partial class MainForm
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
            this.grdMessages = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMessages
            // 
            this.grdMessages.AllowUserToAddRows = false;
            this.grdMessages.AllowUserToDeleteRows = false;
            this.grdMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMessages.Location = new System.Drawing.Point(6, 58);
            this.grdMessages.Margin = new System.Windows.Forms.Padding(2);
            this.grdMessages.Name = "grdMessages";
            this.grdMessages.ReadOnly = true;
            this.grdMessages.RowTemplate.Height = 33;
            this.grdMessages.Size = new System.Drawing.Size(756, 494);
            this.grdMessages.TabIndex = 0;
            this.grdMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMessages_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account SID";
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(87, 10);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(207, 20);
            this.txtSid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Auth Token";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(385, 10);
            this.txtToken.Name = "txtToken";
            this.txtToken.PasswordChar = '*';
            this.txtToken.Size = new System.Drawing.Size(240, 20);
            this.txtToken.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(642, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.ForeColor = System.Drawing.Color.Red;
            this.lblProgress.Location = new System.Drawing.Point(263, 33);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(152, 13);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "Getting Messages Please Wait";
            this.lblProgress.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 552);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdMessages);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Twilio Message Management";
            ((System.ComponentModel.ISupportInitialize)(this.grdMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblProgress;
    }
}

