namespace QualifierApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyQualifierForm));
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.pPictureBox = new System.Windows.Forms.Panel();
            this.nudPincel = new System.Windows.Forms.NumericUpDown();
            this.lblPincel = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.nudFont = new System.Windows.Forms.NumericUpDown();
            this.btnNote = new System.Windows.Forms.Button();
            this.tcTools = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tpFolder = new System.Windows.Forms.TabPage();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblHelpNotes = new System.Windows.Forms.Label();
            this.lblCleanHelp = new System.Windows.Forms.Label();
            this.lblHelpStudent = new System.Windows.Forms.Label();
            this.lblHelpColor = new System.Windows.Forms.Label();
            this.lblHelpFont = new System.Windows.Forms.Label();
            this.lblHelpPincel = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnHomeworkBefore = new System.Windows.Forms.Button();
            this.btnNextStudent = new System.Windows.Forms.Button();
            this.pPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPincel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFont)).BeginInit();
            this.tcTools.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFolder
            // 
            this.txtFolder.Enabled = false;
            this.txtFolder.Location = new System.Drawing.Point(1373, 2);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(10, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(362, 11);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(143, 16);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "Carpeta del alumno";
            // 
            // cbStudent
            // 
            this.cbStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(365, 42);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(451, 21);
            this.cbStudent.TabIndex = 4;
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.CbStudent_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Blue;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColor.Location = new System.Drawing.Point(246, 66);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(72, 27);
            this.btnColor.TabIndex = 7;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Green;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComplete.Location = new System.Drawing.Point(528, 866);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(184, 44);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "Siguiente Tarea";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // pPictureBox
            // 
            this.pPictureBox.AutoScroll = true;
            this.pPictureBox.Controls.Add(this.pbImage);
            this.pPictureBox.Location = new System.Drawing.Point(12, 171);
            this.pPictureBox.Name = "pPictureBox";
            this.pPictureBox.Size = new System.Drawing.Size(1097, 689);
            this.pPictureBox.TabIndex = 10;
            // 
            // nudPincel
            // 
            this.nudPincel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPincel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPincel.Location = new System.Drawing.Point(246, 6);
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
            this.lblPincel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPincel.Location = new System.Drawing.Point(128, 6);
            this.lblPincel.Name = "lblPincel";
            this.lblPincel.Size = new System.Drawing.Size(112, 16);
            this.lblPincel.TabIndex = 14;
            this.lblPincel.Text = "Tamaño Pincel";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(1132, 174);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(95, 16);
            this.lblStudents.TabIndex = 15;
            this.lblStudents.Text = "Mis Alumnos";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(1115, 193);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(268, 667);
            this.dgvStudents.TabIndex = 0;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(835, 38);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(269, 52);
            this.txtNote.TabIndex = 17;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(128, 39);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(104, 16);
            this.lblFont.TabIndex = 18;
            this.lblFont.Text = "Tamaño Letra";
            // 
            // nudFont
            // 
            this.nudFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFont.Location = new System.Drawing.Point(246, 38);
            this.nudFont.Name = "nudFont";
            this.nudFont.Size = new System.Drawing.Size(72, 20);
            this.nudFont.TabIndex = 19;
            this.nudFont.Value = new decimal(new int[] {
            50,
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
            this.btnNote.Location = new System.Drawing.Point(835, 96);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(269, 36);
            this.btnNote.TabIndex = 20;
            this.btnNote.Text = "Agregar Nota";
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.BtnNote_Click);
            // 
            // tcTools
            // 
            this.tcTools.Controls.Add(this.tpHome);
            this.tcTools.Controls.Add(this.tpFolder);
            this.tcTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTools.Location = new System.Drawing.Point(0, 0);
            this.tcTools.Name = "tcTools";
            this.tcTools.SelectedIndex = 0;
            this.tcTools.Size = new System.Drawing.Size(1395, 165);
            this.tcTools.TabIndex = 21;
            // 
            // tpHome
            // 
            this.tpHome.BackColor = System.Drawing.SystemColors.Control;
            this.tpHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpHome.Controls.Add(this.lblHelpNotes);
            this.tpHome.Controls.Add(this.btnNote);
            this.tpHome.Controls.Add(this.lblNotes);
            this.tpHome.Controls.Add(this.lblCleanHelp);
            this.tpHome.Controls.Add(this.lblHelpStudent);
            this.tpHome.Controls.Add(this.txtNote);
            this.tpHome.Controls.Add(this.lblHelpColor);
            this.tpHome.Controls.Add(this.lblColor);
            this.tpHome.Controls.Add(this.lblHelpFont);
            this.tpHome.Controls.Add(this.lblHelpPincel);
            this.tpHome.Controls.Add(this.btnClean);
            this.tpHome.Controls.Add(this.btnFolder);
            this.tpHome.Controls.Add(this.lblPincel);
            this.tpHome.Controls.Add(this.nudFont);
            this.tpHome.Controls.Add(this.nudPincel);
            this.tpHome.Controls.Add(this.lblFont);
            this.tpHome.Controls.Add(this.cbStudent);
            this.tpHome.Controls.Add(this.btnColor);
            this.tpHome.Controls.Add(this.lblStudent);
            this.tpHome.Controls.Add(this.txtFolder);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1387, 139);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Inicio";
            // 
            // tpFolder
            // 
            this.tpFolder.BackColor = System.Drawing.SystemColors.Control;
            this.tpFolder.Controls.Add(this.btnCreate);
            this.tpFolder.Location = new System.Drawing.Point(4, 22);
            this.tpFolder.Name = "tpFolder";
            this.tpFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tpFolder.Size = new System.Drawing.Size(1387, 139);
            this.tpFolder.TabIndex = 1;
            this.tpFolder.Text = "Carpetas";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(128, 71);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 16);
            this.lblColor.TabIndex = 22;
            this.lblColor.Text = "Color";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(832, 10);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 16);
            this.lblNotes.TabIndex = 26;
            this.lblNotes.Text = "Notas";
            // 
            // lblHelpNotes
            // 
            this.lblHelpNotes.AutoSize = true;
            this.lblHelpNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpNotes.Image = global::QualifierApp.Properties.Resources.help;
            this.lblHelpNotes.Location = new System.Drawing.Point(919, 11);
            this.lblHelpNotes.Name = "lblHelpNotes";
            this.lblHelpNotes.Size = new System.Drawing.Size(32, 16);
            this.lblHelpNotes.TabIndex = 27;
            this.lblHelpNotes.Text = "      ";
            this.ttHelp.SetToolTip(this.lblHelpNotes, "Escribe una nota y esta sera agregada en la parte superior de la imagen");
            // 
            // lblCleanHelp
            // 
            this.lblCleanHelp.AutoSize = true;
            this.lblCleanHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleanHelp.Image = global::QualifierApp.Properties.Resources.help;
            this.lblCleanHelp.Location = new System.Drawing.Point(324, 106);
            this.lblCleanHelp.Name = "lblCleanHelp";
            this.lblCleanHelp.Size = new System.Drawing.Size(32, 16);
            this.lblCleanHelp.TabIndex = 25;
            this.lblCleanHelp.Text = "      ";
            this.ttHelp.SetToolTip(this.lblCleanHelp, "Borra todo lo agregado en la imagen");
            // 
            // lblHelpStudent
            // 
            this.lblHelpStudent.AutoSize = true;
            this.lblHelpStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpStudent.Image = global::QualifierApp.Properties.Resources.help;
            this.lblHelpStudent.Location = new System.Drawing.Point(520, 11);
            this.lblHelpStudent.Name = "lblHelpStudent";
            this.lblHelpStudent.Size = new System.Drawing.Size(32, 16);
            this.lblHelpStudent.TabIndex = 24;
            this.lblHelpStudent.Text = "      ";
            this.ttHelp.SetToolTip(this.lblHelpStudent, "Es el Selecciona la carpeta del alumno que quieras calificar");
            // 
            // lblHelpColor
            // 
            this.lblHelpColor.AutoSize = true;
            this.lblHelpColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpColor.Image = global::QualifierApp.Properties.Resources.help;
            this.lblHelpColor.Location = new System.Drawing.Point(324, 73);
            this.lblHelpColor.Name = "lblHelpColor";
            this.lblHelpColor.Size = new System.Drawing.Size(32, 16);
            this.lblHelpColor.TabIndex = 23;
            this.lblHelpColor.Text = "      ";
            this.ttHelp.SetToolTip(this.lblHelpColor, "Es el color del pincel y de las notas");
            // 
            // lblHelpFont
            // 
            this.lblHelpFont.AutoSize = true;
            this.lblHelpFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpFont.Image = global::QualifierApp.Properties.Resources.help;
            this.lblHelpFont.Location = new System.Drawing.Point(324, 41);
            this.lblHelpFont.Name = "lblHelpFont";
            this.lblHelpFont.Size = new System.Drawing.Size(32, 16);
            this.lblHelpFont.TabIndex = 21;
            this.lblHelpFont.Text = "      ";
            this.ttHelp.SetToolTip(this.lblHelpFont, "Es el tamaño de la letra para agregar notas");
            // 
            // lblHelpPincel
            // 
            this.lblHelpPincel.AutoSize = true;
            this.lblHelpPincel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpPincel.Image = global::QualifierApp.Properties.Resources.help;
            this.lblHelpPincel.Location = new System.Drawing.Point(324, 9);
            this.lblHelpPincel.Name = "lblHelpPincel";
            this.lblHelpPincel.Size = new System.Drawing.Size(32, 16);
            this.lblHelpPincel.TabIndex = 20;
            this.lblHelpPincel.Text = "      ";
            this.ttHelp.SetToolTip(this.lblHelpPincel, "Es el tamaño que se usa para dibujar");
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClean.Image = global::QualifierApp.Properties.Resources.eraser;
            this.btnClean.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnClean.Location = new System.Drawing.Point(270, 96);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(48, 36);
            this.btnClean.TabIndex = 12;
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnFolder.Image")));
            this.btnFolder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFolder.Location = new System.Drawing.Point(7, 6);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(93, 125);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "Seleccionar carpeta de tareas";
            this.btnFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = global::QualifierApp.Properties.Resources.folders;
            this.btnCreate.Location = new System.Drawing.Point(6, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 125);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Crear Carpetas";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(1091, 681);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseDown);
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseMove);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseUp);
            // 
            // btnHomeworkBefore
            // 
            this.btnHomeworkBefore.BackColor = System.Drawing.Color.Red;
            this.btnHomeworkBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeworkBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeworkBefore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomeworkBefore.Location = new System.Drawing.Point(326, 866);
            this.btnHomeworkBefore.Name = "btnHomeworkBefore";
            this.btnHomeworkBefore.Size = new System.Drawing.Size(184, 44);
            this.btnHomeworkBefore.TabIndex = 22;
            this.btnHomeworkBefore.Text = "Tarea Anterior";
            this.btnHomeworkBefore.UseVisualStyleBackColor = false;
            this.btnHomeworkBefore.Click += new System.EventHandler(this.BtnHomeworkBefore_Click);
            // 
            // btnNextStudent
            // 
            this.btnNextStudent.BackColor = System.Drawing.Color.Green;
            this.btnNextStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextStudent.Location = new System.Drawing.Point(1115, 866);
            this.btnNextStudent.Name = "btnNextStudent";
            this.btnNextStudent.Size = new System.Drawing.Size(268, 44);
            this.btnNextStudent.TabIndex = 23;
            this.btnNextStudent.Text = "Siguiente Alumno";
            this.btnNextStudent.UseVisualStyleBackColor = false;
            this.btnNextStudent.Click += new System.EventHandler(this.BtnNextStudent_Click);
            // 
            // MyQualifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 913);
            this.Controls.Add(this.btnNextStudent);
            this.Controls.Add(this.btnHomeworkBefore);
            this.Controls.Add(this.tcTools);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.pPictureBox);
            this.Controls.Add(this.btnComplete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyQualifierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.pPictureBox.ResumeLayout(false);
            this.pPictureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPincel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFont)).EndInit();
            this.tcTools.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            this.tpFolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TabControl tcTools;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.Label lblHelpStudent;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.Label lblHelpColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblHelpFont;
        private System.Windows.Forms.Label lblHelpPincel;
        private System.Windows.Forms.TabPage tpFolder;
        private System.Windows.Forms.Label lblHelpNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblCleanHelp;
        private System.Windows.Forms.Button btnHomeworkBefore;
        private System.Windows.Forms.Button btnNextStudent;
    }
}

