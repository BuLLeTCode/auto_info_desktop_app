namespace AutoInformacijasUzskaite
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewCarFrmMain = new System.Windows.Forms.Button();
            this.btnShowServicesFrmMain = new System.Windows.Forms.Button();
            this.btnAddNewServiceFrmMain = new System.Windows.Forms.Button();
            this.lblDateTimeFrmMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto informācijas uzskaite";
            // 
            // btnNewCarFrmMain
            // 
            this.btnNewCarFrmMain.Location = new System.Drawing.Point(164, 60);
            this.btnNewCarFrmMain.Name = "btnNewCarFrmMain";
            this.btnNewCarFrmMain.Size = new System.Drawing.Size(126, 45);
            this.btnNewCarFrmMain.TabIndex = 1;
            this.btnNewCarFrmMain.Text = "Pievienot jaunu automašīnu";
            this.btnNewCarFrmMain.UseVisualStyleBackColor = true;
            this.btnNewCarFrmMain.Click += new System.EventHandler(this.btnNewCarFrmMain_Click);
            // 
            // btnShowServicesFrmMain
            // 
            this.btnShowServicesFrmMain.Location = new System.Drawing.Point(163, 137);
            this.btnShowServicesFrmMain.Name = "btnShowServicesFrmMain";
            this.btnShowServicesFrmMain.Size = new System.Drawing.Size(126, 45);
            this.btnShowServicesFrmMain.TabIndex = 2;
            this.btnShowServicesFrmMain.Text = "Apskatīties apkopes";
            this.btnShowServicesFrmMain.UseVisualStyleBackColor = true;
            this.btnShowServicesFrmMain.Click += new System.EventHandler(this.btnShowServicesFrmMain_Click);
            // 
            // btnAddNewServiceFrmMain
            // 
            this.btnAddNewServiceFrmMain.Location = new System.Drawing.Point(163, 221);
            this.btnAddNewServiceFrmMain.Name = "btnAddNewServiceFrmMain";
            this.btnAddNewServiceFrmMain.Size = new System.Drawing.Size(126, 45);
            this.btnAddNewServiceFrmMain.TabIndex = 3;
            this.btnAddNewServiceFrmMain.Text = "Pievienot jaunu apkopi";
            this.btnAddNewServiceFrmMain.UseVisualStyleBackColor = true;
            this.btnAddNewServiceFrmMain.Click += new System.EventHandler(this.btnAddNewServiceFrmMain_Click);
            // 
            // lblDateTimeFrmMain
            // 
            this.lblDateTimeFrmMain.AutoSize = true;
            this.lblDateTimeFrmMain.Location = new System.Drawing.Point(354, 293);
            this.lblDateTimeFrmMain.Name = "lblDateTimeFrmMain";
            this.lblDateTimeFrmMain.Size = new System.Drawing.Size(46, 17);
            this.lblDateTimeFrmMain.TabIndex = 4;
            this.lblDateTimeFrmMain.Text = "label2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 319);
            this.Controls.Add(this.lblDateTimeFrmMain);
            this.Controls.Add(this.btnAddNewServiceFrmMain);
            this.Controls.Add(this.btnShowServicesFrmMain);
            this.Controls.Add(this.btnNewCarFrmMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Auto informacijas uzskaite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewCarFrmMain;
        private System.Windows.Forms.Button btnShowServicesFrmMain;
        private System.Windows.Forms.Button btnAddNewServiceFrmMain;
        private System.Windows.Forms.Label lblDateTimeFrmMain;
    }
}

