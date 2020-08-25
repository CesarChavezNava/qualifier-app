﻿namespace QualifierApp
{
    partial class MyQualifierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyQualifierForm));
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.pPictureBox = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.nudPincel = new System.Windows.Forms.NumericUpDown();
            this.lblPincel = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.nudFont = new System.Windows.Forms.NumericUpDown();
            this.btnNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPincel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFont)).BeginInit();
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
            this.btnColor.BackColor = System.Drawing.Color.Blue;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColor.Location = new System.Drawing.Point(97, 158);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(146, 23);
            this.btnColor.TabIndex = 7;
            this.btnColor.Text = "Cambiar Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Green;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComplete.Location = new System.Drawing.Point(1199, 769);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(184, 44);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "Completar";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // pPictureBox
            // 
            this.pPictureBox.AutoScroll = true;
            this.pPictureBox.Controls.Add(this.pbImage);
            this.pPictureBox.Location = new System.Drawing.Point(263, 129);
            this.pPictureBox.Name = "pPictureBox";
            this.pPictureBox.Size = new System.Drawing.Size(926, 687);
            this.pPictureBox.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(1199, 22);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(184, 44);
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
            this.btnClean.Location = new System.Drawing.Point(97, 187);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(146, 23);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Borrar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // nudPincel
            // 
            this.nudPincel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPincel.Location = new System.Drawing.Point(171, 129);
            this.nudPincel.Name = "nudPincel";
            this.nudPincel.Size = new System.Drawing.Size(72, 20);
            this.nudPincel.TabIndex = 13;
            this.nudPincel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPincel.ValueChanged += new System.EventHandler(this.NudPincel_ValueChanged);
            // 
            // lblPincel
            // 
            this.lblPincel.AutoSize = true;
            this.lblPincel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPincel.Location = new System.Drawing.Point(26, 132);
            this.lblPincel.Name = "lblPincel";
            this.lblPincel.Size = new System.Drawing.Size(91, 13);
            this.lblPincel.TabIndex = 14;
            this.lblPincel.Text = "Tamaño Pincel";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(26, 322);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(77, 13);
            this.lblStudents.TabIndex = 15;
            this.lblStudents.Text = "Mis Alumnos";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(4, 349);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(253, 464);
            this.dgvStudents.TabIndex = 0;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(29, 248);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(214, 37);
            this.txtNote.TabIndex = 17;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(26, 224);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(85, 13);
            this.lblFont.TabIndex = 18;
            this.lblFont.Text = "Tamaño Letra";
            // 
            // nudFont
            // 
            this.nudFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFont.Location = new System.Drawing.Point(171, 222);
            this.nudFont.Name = "nudFont";
            this.nudFont.Size = new System.Drawing.Size(72, 20);
            this.nudFont.TabIndex = 19;
            this.nudFont.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.Color.Green;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNote.Location = new System.Drawing.Point(97, 291);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(146, 23);
            this.btnNote.TabIndex = 20;
            this.btnNote.Text = "Agregar Nota";
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.BtnNote_Click);
            // 
            // MyQualifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 841);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.nudFont);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblPincel);
            this.Controls.Add(this.nudPincel);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pPictureBox);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyQualifierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Calificador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pPictureBox.ResumeLayout(false);
            this.pPictureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPincel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFont)).EndInit();
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
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Panel pPictureBox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.NumericUpDown nudPincel;
        private System.Windows.Forms.Label lblPincel;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.NumericUpDown nudFont;
        private System.Windows.Forms.Button btnNote;
    }
}

