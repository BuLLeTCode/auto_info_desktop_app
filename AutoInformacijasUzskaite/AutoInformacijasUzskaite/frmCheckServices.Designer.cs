namespace AutoInformacijasUzskaite
{
    partial class frmCheckServices
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
            this.lblTitleFrmCheckService = new System.Windows.Forms.Label();
            this.lblChooseCar = new System.Windows.Forms.Label();
            this.cbChooseCar = new System.Windows.Forms.ComboBox();
            this.lblChoosenCarServices = new System.Windows.Forms.Label();
            this.lvCarServices = new System.Windows.Forms.ListView();
            this.chServiceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServiceDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServiceCosts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServiceComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.lblDeleteInfo = new System.Windows.Forms.Label();
            this.btnCheckServicesBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleFrmCheckService
            // 
            this.lblTitleFrmCheckService.AutoSize = true;
            this.lblTitleFrmCheckService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFrmCheckService.Location = new System.Drawing.Point(266, 9);
            this.lblTitleFrmCheckService.Name = "lblTitleFrmCheckService";
            this.lblTitleFrmCheckService.Size = new System.Drawing.Size(92, 24);
            this.lblTitleFrmCheckService.TabIndex = 0;
            this.lblTitleFrmCheckService.Text = "Apkopes";
            // 
            // lblChooseCar
            // 
            this.lblChooseCar.AutoSize = true;
            this.lblChooseCar.Location = new System.Drawing.Point(12, 85);
            this.lblChooseCar.Name = "lblChooseCar";
            this.lblChooseCar.Size = new System.Drawing.Size(135, 17);
            this.lblChooseCar.TabIndex = 1;
            this.lblChooseCar.Text = "Izvēlies automašīnu:";
            // 
            // cbChooseCar
            // 
            this.cbChooseCar.FormattingEnabled = true;
            this.cbChooseCar.Location = new System.Drawing.Point(173, 82);
            this.cbChooseCar.Name = "cbChooseCar";
            this.cbChooseCar.Size = new System.Drawing.Size(142, 24);
            this.cbChooseCar.TabIndex = 2;
            this.cbChooseCar.SelectedIndexChanged += new System.EventHandler(this.cbChooseCar_SelectedIndexChanged);
            // 
            // lblChoosenCarServices
            // 
            this.lblChoosenCarServices.AutoSize = true;
            this.lblChoosenCarServices.Location = new System.Drawing.Point(12, 157);
            this.lblChoosenCarServices.Name = "lblChoosenCarServices";
            this.lblChoosenCarServices.Size = new System.Drawing.Size(209, 17);
            this.lblChoosenCarServices.TabIndex = 3;
            this.lblChoosenCarServices.Text = "Izvēlētās automašīnas apkopes:";
            // 
            // lvCarServices
            // 
            this.lvCarServices.CheckBoxes = true;
            this.lvCarServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chServiceType,
            this.chServiceDate,
            this.chServiceCosts,
            this.chServiceComments});
            this.lvCarServices.GridLines = true;
            this.lvCarServices.Location = new System.Drawing.Point(15, 192);
            this.lvCarServices.Name = "lvCarServices";
            this.lvCarServices.Size = new System.Drawing.Size(615, 206);
            this.lvCarServices.TabIndex = 4;
            this.lvCarServices.UseCompatibleStateImageBehavior = false;
            this.lvCarServices.View = System.Windows.Forms.View.Details;
            // 
            // chServiceType
            // 
            this.chServiceType.Text = "Apkopes veids";
            this.chServiceType.Width = 112;
            // 
            // chServiceDate
            // 
            this.chServiceDate.Text = "Apkopes datums";
            this.chServiceDate.Width = 123;
            // 
            // chServiceCosts
            // 
            this.chServiceCosts.Text = "Izmaksas";
            this.chServiceCosts.Width = 77;
            // 
            // chServiceComments
            // 
            this.chServiceComments.Text = "Komentāri";
            this.chServiceComments.Width = 302;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(555, 425);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteService.TabIndex = 6;
            this.btnDeleteService.Text = "Dzēst";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // lblDeleteInfo
            // 
            this.lblDeleteInfo.AutoSize = true;
            this.lblDeleteInfo.Location = new System.Drawing.Point(322, 436);
            this.lblDeleteInfo.Name = "lblDeleteInfo";
            this.lblDeleteInfo.Size = new System.Drawing.Size(227, 17);
            this.lblDeleteInfo.TabIndex = 7;
            this.lblDeleteInfo.Text = "Iezīmē apkopes, kuras vēlies dzēst";
            // 
            // btnCheckServicesBack
            // 
            this.btnCheckServicesBack.Location = new System.Drawing.Point(15, 425);
            this.btnCheckServicesBack.Name = "btnCheckServicesBack";
            this.btnCheckServicesBack.Size = new System.Drawing.Size(75, 39);
            this.btnCheckServicesBack.TabIndex = 8;
            this.btnCheckServicesBack.Text = "Atpakaļ";
            this.btnCheckServicesBack.UseVisualStyleBackColor = true;
            this.btnCheckServicesBack.Click += new System.EventHandler(this.btnCheckServicesBack_Click);
            // 
            // frmCheckServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 476);
            this.Controls.Add(this.btnCheckServicesBack);
            this.Controls.Add(this.lblDeleteInfo);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.lvCarServices);
            this.Controls.Add(this.lblChoosenCarServices);
            this.Controls.Add(this.cbChooseCar);
            this.Controls.Add(this.lblChooseCar);
            this.Controls.Add(this.lblTitleFrmCheckService);
            this.Name = "frmCheckServices";
            this.Text = "Apkopes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleFrmCheckService;
        private System.Windows.Forms.Label lblChooseCar;
        private System.Windows.Forms.ComboBox cbChooseCar;
        private System.Windows.Forms.Label lblChoosenCarServices;
        private System.Windows.Forms.ListView lvCarServices;
        private System.Windows.Forms.ColumnHeader chServiceType;
        private System.Windows.Forms.ColumnHeader chServiceDate;
        private System.Windows.Forms.ColumnHeader chServiceCosts;
        private System.Windows.Forms.ColumnHeader chServiceComments;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Label lblDeleteInfo;
        private System.Windows.Forms.Button btnCheckServicesBack;
    }
}