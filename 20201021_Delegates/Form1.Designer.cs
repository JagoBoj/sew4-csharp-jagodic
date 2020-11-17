namespace _20201021_Delegates
{
    partial class Delegates_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPushBtn = new System.Windows.Forms.Label();
            this.btnCallMethod = new System.Windows.Forms.Button();
            this.cbxConnection = new System.Windows.Forms.CheckBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPushBtn
            // 
            this.lblPushBtn.AutoSize = true;
            this.lblPushBtn.Location = new System.Drawing.Point(13, 13);
            this.lblPushBtn.Name = "lblPushBtn";
            this.lblPushBtn.Size = new System.Drawing.Size(179, 17);
            this.lblPushBtn.TabIndex = 0;
            this.lblPushBtn.Text = "Push button to call method!";
            // 
            // btnCallMethod
            // 
            this.btnCallMethod.Location = new System.Drawing.Point(12, 33);
            this.btnCallMethod.Name = "btnCallMethod";
            this.btnCallMethod.Size = new System.Drawing.Size(99, 30);
            this.btnCallMethod.TabIndex = 1;
            this.btnCallMethod.Text = "Call Method";
            this.btnCallMethod.UseVisualStyleBackColor = true;
            this.btnCallMethod.Click += new System.EventHandler(this.BtnCallMethod_Click);
            // 
            // cbxConnection
            // 
            this.cbxConnection.AutoSize = true;
            this.cbxConnection.Location = new System.Drawing.Point(16, 110);
            this.cbxConnection.Name = "cbxConnection";
            this.cbxConnection.Size = new System.Drawing.Size(253, 21);
            this.cbxConnection.TabIndex = 2;
            this.cbxConnection.Text = "Connect / Disconnect with Delegate";
            this.cbxConnection.UseVisualStyleBackColor = true;
            this.cbxConnection.CheckedChanged += new System.EventHandler(this.CbxConnection_CheckedChanged);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(12, 70);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(104, 17);
            this.lblOut.TabIndex = 3;
            this.lblOut.Text = "____________";
            // 
            // Delegates_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 156);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.cbxConnection);
            this.Controls.Add(this.btnCallMethod);
            this.Controls.Add(this.lblPushBtn);
            this.Name = "Delegates_Form";
            this.Text = "Delegates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPushBtn;
        private System.Windows.Forms.Button btnCallMethod;
        private System.Windows.Forms.CheckBox cbxConnection;
        private System.Windows.Forms.Label lblOut;
    }
}

