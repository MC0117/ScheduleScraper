namespace ScheduleScraper
{
    partial class ScheduleForm
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
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.Label();
            this.cargoLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.imagePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(715, 418);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(80, 55);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Enabled = false;
            this.previousBtn.Location = new System.Drawing.Point(12, 418);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(84, 55);
            this.previousBtn.TabIndex = 1;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(48, 31);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(48, 20);
            this.dateLbl.TabIndex = 2;
            this.dateLbl.Text = "Date";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.Location = new System.Drawing.Point(49, 72);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(41, 15);
            this.locationLbl.TabIndex = 3;
            this.locationLbl.Text = "label2";
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLbl.Location = new System.Drawing.Point(49, 98);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(41, 15);
            this.modelLbl.TabIndex = 4;
            this.modelLbl.Text = "label3";
            // 
            // cargoLbl
            // 
            this.cargoLbl.AutoSize = true;
            this.cargoLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoLbl.Location = new System.Drawing.Point(49, 123);
            this.cargoLbl.Name = "cargoLbl";
            this.cargoLbl.Size = new System.Drawing.Size(41, 15);
            this.cargoLbl.TabIndex = 5;
            this.cargoLbl.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description:";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(52, 166);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(288, 141);
            this.descriptionTxt.TabIndex = 8;
            this.descriptionTxt.Text = "";
            // 
            // imagePic
            // 
            this.imagePic.Location = new System.Drawing.Point(403, 31);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(362, 381);
            this.imagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagePic.TabIndex = 10;
            this.imagePic.TabStop = false;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 485);
            this.Controls.Add(this.imagePic);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cargoLbl);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Name = "ScheduleForm";
            this.Text = "Upcoming Launches";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Label cargoLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.PictureBox imagePic;
    }
}

