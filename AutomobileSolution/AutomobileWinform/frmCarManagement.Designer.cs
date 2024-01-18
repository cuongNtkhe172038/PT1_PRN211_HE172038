namespace AutomobileWinform
{
    partial class frmCarManagement
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
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            lbReleaseYear = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtManufacturer = new System.Windows.Forms.TextBox();
            txtReleaseYear = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            dgvCarList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(26, 36);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(50, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(26, 103);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(71, 20);
            lbCarName.TabIndex = 0;
            lbCarName.Text = "CarName";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(26, 180);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(97, 20);
            lbManufacturer.TabIndex = 0;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(366, 110);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(101, 20);
            lbReleaseYear.TabIndex = 0;
            lbReleaseYear.Text = "Released Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(366, 36);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price";
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(126, 33);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(125, 27);
            txtCarID.TabIndex = 1;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(126, 100);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(125, 27);
            txtCarName.TabIndex = 1;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new System.Drawing.Point(126, 177);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(125, 27);
            txtManufacturer.TabIndex = 1;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(486, 103);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(125, 27);
            txtReleaseYear.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(486, 33);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(125, 27);
            txtPrice.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(584, 251);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(390, 251);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(176, 251);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(12, 286);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.Size = new System.Drawing.Size(776, 160);
            dgvCarList.TabIndex = 3;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvCarList);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(txtPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbPrice);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvCarList;
    }
}