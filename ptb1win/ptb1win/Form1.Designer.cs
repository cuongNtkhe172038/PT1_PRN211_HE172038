namespace ptb1win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblResult = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            txtA = new System.Windows.Forms.TextBox();
            txtB = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(45, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(19, 20);
            label1.TabIndex = 0;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(45, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(18, 20);
            label2.TabIndex = 1;
            label2.Text = "B";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new System.Drawing.Point(45, 347);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(49, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            lblResult.Click += label3_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(164, 248);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(66, 25);
            btnSave.TabIndex = 3;
            btnSave.Text = "submit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(398, 248);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(66, 25);
            btnClear.TabIndex = 3;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtA
            // 
            txtA.Location = new System.Drawing.Point(319, 54);
            txtA.Name = "txtA";
            txtA.Size = new System.Drawing.Size(125, 27);
            txtA.TabIndex = 4;
            // 
            // txtB
            // 
            txtB.Location = new System.Drawing.Point(319, 118);
            txtB.Name = "txtB";
            txtB.Size = new System.Drawing.Size(125, 27);
            txtB.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
    }
}
