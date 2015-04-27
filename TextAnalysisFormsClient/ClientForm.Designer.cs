namespace TextAnalysisFormsClient
{
    partial class ClientForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblSentPackages = new System.Windows.Forms.Label();
            this.txtSent = new System.Windows.Forms.TextBox();
            this.lblSending = new System.Windows.Forms.Label();
            this.txtSolved = new System.Windows.Forms.TextBox();
            this.lblResolved = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(30, 105);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(27, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(79, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(107, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 58);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(107, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(111, 105);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblSentPackages
            // 
            this.lblSentPackages.AutoSize = true;
            this.lblSentPackages.Location = new System.Drawing.Point(27, 169);
            this.lblSentPackages.Name = "lblSentPackages";
            this.lblSentPackages.Size = new System.Drawing.Size(55, 13);
            this.lblSentPackages.TabIndex = 6;
            this.lblSentPackages.Text = "Sent Rate";
            // 
            // txtSent
            // 
            this.txtSent.Location = new System.Drawing.Point(86, 169);
            this.txtSent.Name = "txtSent";
            this.txtSent.ReadOnly = true;
            this.txtSent.Size = new System.Drawing.Size(100, 20);
            this.txtSent.TabIndex = 7;
            // 
            // lblSending
            // 
            this.lblSending.AutoSize = true;
            this.lblSending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSending.ForeColor = System.Drawing.Color.Lime;
            this.lblSending.Location = new System.Drawing.Point(76, 144);
            this.lblSending.Name = "lblSending";
            this.lblSending.Size = new System.Drawing.Size(65, 13);
            this.lblSending.TabIndex = 8;
            this.lblSending.Text = "Sending...";
            this.lblSending.Visible = false;
            // 
            // txtSolved
            // 
            this.txtSolved.Location = new System.Drawing.Point(99, 195);
            this.txtSolved.Name = "txtSolved";
            this.txtSolved.ReadOnly = true;
            this.txtSolved.Size = new System.Drawing.Size(87, 20);
            this.txtSolved.TabIndex = 10;
            // 
            // lblResolved
            // 
            this.lblResolved.AutoSize = true;
            this.lblResolved.Location = new System.Drawing.Point(27, 198);
            this.lblResolved.Name = "lblResolved";
            this.lblResolved.Size = new System.Drawing.Size(66, 13);
            this.lblResolved.TabIndex = 9;
            this.lblResolved.Text = "Solved Rate";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 236);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(106, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "An error has ocurred.";
            this.lblError.Visible = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 261);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtSolved);
            this.Controls.Add(this.lblResolved);
            this.Controls.Add(this.lblSending);
            this.Controls.Add(this.txtSent);
            this.Controls.Add(this.lblSentPackages);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSend);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblSentPackages;
        private System.Windows.Forms.TextBox txtSent;
        private System.Windows.Forms.Label lblSending;
        private System.Windows.Forms.TextBox txtSolved;
        private System.Windows.Forms.Label lblResolved;
        private System.Windows.Forms.Label lblError;

    }
}

