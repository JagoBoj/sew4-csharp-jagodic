namespace _20201112_CalcWithLambda
{
    partial class Form1
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoConnectSum = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCompute = new System.Windows.Forms.Button();
            this.rdoConnectDiff = new System.Windows.Forms.RadioButton();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtY);
            this.grpInput.Controls.Add(this.txtX);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Location = new System.Drawing.Point(11, 11);
            this.grpInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInput.Size = new System.Drawing.Size(173, 86);
            this.grpInput.TabIndex = 11;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Eingabe";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(57, 52);
            this.txtY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(113, 22);
            this.txtY.TabIndex = 3;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(57, 20);
            this.txtX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(113, 22);
            this.txtX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zahl 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zahl 1";
            // 
            // rdoConnectSum
            // 
            this.rdoConnectSum.AutoSize = true;
            this.rdoConnectSum.Location = new System.Drawing.Point(8, 19);
            this.rdoConnectSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoConnectSum.Name = "rdoConnectSum";
            this.rdoConnectSum.Size = new System.Drawing.Size(37, 21);
            this.rdoConnectSum.TabIndex = 1;
            this.rdoConnectSum.TabStop = true;
            this.rdoConnectSum.Text = "+";
            this.rdoConnectSum.UseVisualStyleBackColor = true;
            this.rdoConnectSum.CheckedChanged += new System.EventHandler(this.rdoConnectSum_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCompute);
            this.groupBox1.Controls.Add(this.rdoConnectDiff);
            this.groupBox1.Controls.Add(this.rdoConnectSum);
            this.groupBox1.Location = new System.Drawing.Point(11, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(173, 74);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // cmdCompute
            // 
            this.cmdCompute.Location = new System.Drawing.Point(65, 20);
            this.cmdCompute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCompute.Name = "cmdCompute";
            this.cmdCompute.Size = new System.Drawing.Size(104, 40);
            this.cmdCompute.TabIndex = 3;
            this.cmdCompute.Text = "Berechne";
            this.cmdCompute.UseVisualStyleBackColor = true;
            this.cmdCompute.Click += new System.EventHandler(this.cmdCompute_Click);
            // 
            // rdoConnectDiff
            // 
            this.rdoConnectDiff.AutoSize = true;
            this.rdoConnectDiff.Location = new System.Drawing.Point(8, 42);
            this.rdoConnectDiff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoConnectDiff.Name = "rdoConnectDiff";
            this.rdoConnectDiff.Size = new System.Drawing.Size(34, 21);
            this.rdoConnectDiff.TabIndex = 2;
            this.rdoConnectDiff.TabStop = true;
            this.rdoConnectDiff.Text = "-";
            this.rdoConnectDiff.UseVisualStyleBackColor = true;
            this.rdoConnectDiff.CheckedChanged += new System.EventHandler(this.rdoConnectDiff_CheckedChanged);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(19, 226);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(161, 35);
            this.cmdDelete.TabIndex = 15;
            this.cmdDelete.Text = "Löschen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resultat";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(80, 192);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(101, 22);
            this.txtResult.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 288);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoConnectSum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCompute;
        private System.Windows.Forms.RadioButton rdoConnectDiff;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
    }
}

