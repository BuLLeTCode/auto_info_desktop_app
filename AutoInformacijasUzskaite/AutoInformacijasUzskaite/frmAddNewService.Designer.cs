namespace AutoInformacijasUzskaite
{
    partial class frmAddNewService
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
            this.lblServiceType = new System.Windows.Forms.Label();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblServiceCosts = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblServiceComments = new System.Windows.Forms.Label();
            this.tbServiceComments = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnNewServiceBack = new System.Windows.Forms.Button();
            this.cbUserCar = new System.Windows.Forms.ComboBox();
            this.lblUserCar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(12, 65);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(104, 17);
            this.lblServiceType.TabIndex = 0;
            this.lblServiceType.Text = "Apkopes veids:";
            // 
            // cbServiceType
            // 
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(122, 62);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(121, 24);
            this.cbServiceType.TabIndex = 1;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(12, 112);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(60, 17);
            this.lblServiceDate.TabIndex = 2;
            this.lblServiceDate.Text = "Datums:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2016, 6, 27, 0, 0, 0, 0);
            // 
            // lblServiceCosts
            // 
            this.lblServiceCosts.AutoSize = true;
            this.lblServiceCosts.Location = new System.Drawing.Point(12, 155);
            this.lblServiceCosts.Name = "lblServiceCosts";
            this.lblServiceCosts.Size = new System.Drawing.Size(70, 17);
            this.lblServiceCosts.TabIndex = 4;
            this.lblServiceCosts.Text = "Izmaksas:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(123, 153);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // lblServiceComments
            // 
            this.lblServiceComments.AutoSize = true;
            this.lblServiceComments.Location = new System.Drawing.Point(12, 196);
            this.lblServiceComments.Name = "lblServiceComments";
            this.lblServiceComments.Size = new System.Drawing.Size(80, 17);
            this.lblServiceComments.TabIndex = 6;
            this.lblServiceComments.Text = "Komentāri: ";
            // 
            // tbServiceComments
            // 
            this.tbServiceComments.Location = new System.Drawing.Point(123, 196);
            this.tbServiceComments.Multiline = true;
            this.tbServiceComments.Name = "tbServiceComments";
            this.tbServiceComments.Size = new System.Drawing.Size(405, 194);
            this.tbServiceComments.TabIndex = 7;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(444, 405);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(84, 40);
            this.btnAddService.TabIndex = 8;
            this.btnAddService.Text = "Pievienot";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnNewServiceBack
            // 
            this.btnNewServiceBack.Location = new System.Drawing.Point(332, 405);
            this.btnNewServiceBack.Name = "btnNewServiceBack";
            this.btnNewServiceBack.Size = new System.Drawing.Size(90, 40);
            this.btnNewServiceBack.TabIndex = 9;
            this.btnNewServiceBack.Text = "Atpakaļ";
            this.btnNewServiceBack.UseVisualStyleBackColor = true;
            this.btnNewServiceBack.Click += new System.EventHandler(this.btnNewServiceBack_Click);
            // 
            // cbUserCar
            // 
            this.cbUserCar.FormattingEnabled = true;
            this.cbUserCar.Location = new System.Drawing.Point(122, 21);
            this.cbUserCar.Name = "cbUserCar";
            this.cbUserCar.Size = new System.Drawing.Size(121, 24);
            this.cbUserCar.TabIndex = 11;
            // 
            // lblUserCar
            // 
            this.lblUserCar.AutoSize = true;
            this.lblUserCar.Location = new System.Drawing.Point(12, 24);
            this.lblUserCar.Name = "lblUserCar";
            this.lblUserCar.Size = new System.Drawing.Size(86, 17);
            this.lblUserCar.TabIndex = 10;
            this.lblUserCar.Text = "Automašīna:";
            // 
            // frmAddNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 498);
            this.Controls.Add(this.cbUserCar);
            this.Controls.Add(this.lblUserCar);
            this.Controls.Add(this.btnNewServiceBack);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.tbServiceComments);
            this.Controls.Add(this.lblServiceComments);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblServiceCosts);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblServiceDate);
            this.Controls.Add(this.cbServiceType);
            this.Controls.Add(this.lblServiceType);
            this.Name = "frmAddNewService";
            this.Text = "Jaunas apkopes pievienošana";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblServiceCosts;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblServiceComments;
        private System.Windows.Forms.TextBox tbServiceComments;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnNewServiceBack;
        private System.Windows.Forms.ComboBox cbUserCar;
        private System.Windows.Forms.Label lblUserCar;
    }
}