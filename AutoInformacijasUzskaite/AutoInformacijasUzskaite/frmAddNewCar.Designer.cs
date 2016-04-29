namespace AutoInformacijasUzskaite
{
    partial class frmAddNewCar
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
            this.lblTitleFrmAddNewCar = new System.Windows.Forms.Label();
            this.lblNewCarManufacture = new System.Windows.Forms.Label();
            this.tbCarManufacture = new System.Windows.Forms.TextBox();
            this.tbCarModel = new System.Windows.Forms.TextBox();
            this.lblNewCarModel = new System.Windows.Forms.Label();
            this.tbCarYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnBackFrmAddNewCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleFrmAddNewCar
            // 
            this.lblTitleFrmAddNewCar.AutoSize = true;
            this.lblTitleFrmAddNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFrmAddNewCar.Location = new System.Drawing.Point(46, 9);
            this.lblTitleFrmAddNewCar.Name = "lblTitleFrmAddNewCar";
            this.lblTitleFrmAddNewCar.Size = new System.Drawing.Size(328, 24);
            this.lblTitleFrmAddNewCar.TabIndex = 0;
            this.lblTitleFrmAddNewCar.Text = "Jaunas automašīnas pievienošana";
            // 
            // lblNewCarManufacture
            // 
            this.lblNewCarManufacture.AutoSize = true;
            this.lblNewCarManufacture.Location = new System.Drawing.Point(15, 62);
            this.lblNewCarManufacture.Name = "lblNewCarManufacture";
            this.lblNewCarManufacture.Size = new System.Drawing.Size(136, 17);
            this.lblNewCarManufacture.TabIndex = 1;
            this.lblNewCarManufacture.Text = "Automašīnas marka:";
            // 
            // tbCarManufacture
            // 
            this.tbCarManufacture.Location = new System.Drawing.Point(172, 59);
            this.tbCarManufacture.Name = "tbCarManufacture";
            this.tbCarManufacture.Size = new System.Drawing.Size(163, 22);
            this.tbCarManufacture.TabIndex = 2;
            // 
            // tbCarModel
            // 
            this.tbCarModel.Location = new System.Drawing.Point(172, 111);
            this.tbCarModel.Name = "tbCarModel";
            this.tbCarModel.Size = new System.Drawing.Size(163, 22);
            this.tbCarModel.TabIndex = 4;
            // 
            // lblNewCarModel
            // 
            this.lblNewCarModel.AutoSize = true;
            this.lblNewCarModel.Location = new System.Drawing.Point(15, 116);
            this.lblNewCarModel.Name = "lblNewCarModel";
            this.lblNewCarModel.Size = new System.Drawing.Size(145, 17);
            this.lblNewCarModel.TabIndex = 3;
            this.lblNewCarModel.Text = "Automašīnas modelis:";
            // 
            // tbCarYear
            // 
            this.tbCarYear.Location = new System.Drawing.Point(172, 168);
            this.tbCarYear.Name = "tbCarYear";
            this.tbCarYear.Size = new System.Drawing.Size(163, 22);
            this.tbCarYear.TabIndex = 6;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(15, 173);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(118, 17);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Ražošanas gads:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(253, 215);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(82, 36);
            this.btnAddCar.TabIndex = 7;
            this.btnAddCar.Text = "Pievienot";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnBackFrmAddNewCar
            // 
            this.btnBackFrmAddNewCar.Location = new System.Drawing.Point(12, 242);
            this.btnBackFrmAddNewCar.Name = "btnBackFrmAddNewCar";
            this.btnBackFrmAddNewCar.Size = new System.Drawing.Size(82, 36);
            this.btnBackFrmAddNewCar.TabIndex = 8;
            this.btnBackFrmAddNewCar.Text = "Atpakaļ";
            this.btnBackFrmAddNewCar.UseVisualStyleBackColor = true;
            this.btnBackFrmAddNewCar.Click += new System.EventHandler(this.btnBackFrmAddNewCar_Click);
            // 
            // frmAddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 290);
            this.Controls.Add(this.btnBackFrmAddNewCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.tbCarYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.tbCarModel);
            this.Controls.Add(this.lblNewCarModel);
            this.Controls.Add(this.tbCarManufacture);
            this.Controls.Add(this.lblNewCarManufacture);
            this.Controls.Add(this.lblTitleFrmAddNewCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddNewCar";
            this.Text = "Jaunas automašīnas pievienošana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleFrmAddNewCar;
        private System.Windows.Forms.Label lblNewCarManufacture;
        private System.Windows.Forms.TextBox tbCarManufacture;
        private System.Windows.Forms.TextBox tbCarModel;
        private System.Windows.Forms.Label lblNewCarModel;
        private System.Windows.Forms.TextBox tbCarYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnBackFrmAddNewCar;
    }
}