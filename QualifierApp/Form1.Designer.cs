namespace QualifierApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.pPictureBox = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pPictureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(26, 28);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(121, 13);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Seleccionar carpeta";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(193, 22);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(450, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnFolder
            // 
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Location = new System.Drawing.Point(657, 22);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(26, 71);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(118, 13);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "Seleccionar alumno";
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(193, 63);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(451, 21);
            this.cbStudent.TabIndex = 4;
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.CbStudent_SelectedIndexChanged);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(920, 681);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseDown);
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseMove);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseUp);
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(115, 129);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(60, 23);
            this.btnColor.TabIndex = 7;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.Blue;
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Enabled = false;
            this.txtColor.ForeColor = System.Drawing.SystemColors.Window;
            this.txtColor.Location = new System.Drawing.Point(29, 130);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(83, 20);
            this.txtColor.TabIndex = 8;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Green;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComplete.Location = new System.Drawing.Point(1144, 772);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(171, 44);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "Completar";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // pPictureBox
            // 
            this.pPictureBox.AutoScroll = true;
            this.pPictureBox.Controls.Add(this.pbImage);
            this.pPictureBox.Location = new System.Drawing.Point(190, 129);
            this.pPictureBox.Name = "pPictureBox";
            this.pPictureBox.Size = new System.Drawing.Size(926, 687);
            this.pPictureBox.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(1144, 24);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(171, 44);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Crear Carpetas";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.IndianRed;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClean.Location = new System.Drawing.Point(29, 156);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(146, 23);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Borrar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1338, 841);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pPictureBox);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Calificador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pPictureBox.ResumeLayout(false);
            this.pPictureBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Panel pPictureBox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClean;
    }
}

