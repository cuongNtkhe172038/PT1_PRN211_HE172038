namespace AutomobileWinform
{
    partial class frmCarDetails
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
            lbCarID = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbReleaseYear = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            txtPirce = new System.Windows.Forms.MaskedTextBox();
            cboManufacturer = new System.Windows.Forms.ComboBox();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(370, 53);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(50, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(123, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(73, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 20);
            label4.TabIndex = 3;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(357, 110);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(75, 20);
            lbCarName.TabIndex = 4;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(352, 160);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(97, 20);
            lbManufacturer.TabIndex = 5;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(370, 216);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Price";
            lbPrice.Click += lbPrice_Click;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(340, 278);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(92, 20);
            lbReleaseYear.TabIndex = 7;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(594, 50);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(125, 27);
            txtCarID.TabIndex = 8;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(594, 103);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(125, 27);
            txtCarName.TabIndex = 9;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(594, 271);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(125, 27);
            txtReleaseYear.TabIndex = 10;
            txtReleaseYear.Text = "0";
            // 
            // txtPirce
            // 
            txtPirce.Location = new System.Drawing.Point(594, 209);
            txtPirce.Mask = "000000000";
            txtPirce.Name = "txtPirce";
            txtPirce.Size = new System.Drawing.Size(125, 27);
            txtPirce.TabIndex = 10;
            txtPirce.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Items:", "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new System.Drawing.Point(594, 152);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new System.Drawing.Size(125, 28);
            cboManufacturer.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(697, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(435, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1073, 563);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(cboManufacturer);
            Controls.Add(txtPirce);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbCarID);
            Name = "frmCarDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.MaskedTextBox txtPirce;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
