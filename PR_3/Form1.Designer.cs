namespace PR_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationGeometricMean = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Reference = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.Task = new System.Windows.Forms.GroupBox();
            this.TaskPNG = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ValueMatrix = new System.Windows.Forms.GroupBox();
            this.GeometricMeanMatrix = new System.Windows.Forms.GroupBox();
            this.GeometricMeanMatrixExit = new System.Windows.Forms.TextBox();
            this.GeometricMeanMatrixButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CreateMatrix = new System.Windows.Forms.Button();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.textBoxLines = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPNG)).BeginInit();
            this.GeometricMeanMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.Reference});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(828, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Applications,
            this.ClearMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "файл";
            // 
            // Applications
            // 
            this.Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationGeometricMean});
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(146, 22);
            this.Applications.Text = "Приложения";
            // 
            // ApplicationGeometricMean
            // 
            this.ApplicationGeometricMean.Name = "ApplicationGeometricMean";
            this.ApplicationGeometricMean.Size = new System.Drawing.Size(261, 22);
            this.ApplicationGeometricMean.Text = "Программа \"ср. геометрическое\"";
            this.ApplicationGeometricMean.Click += new System.EventHandler(this.ApplicationGeometricMean_Click);
            // 
            // ClearMenu
            // 
            this.ClearMenu.Name = "ClearMenu";
            this.ClearMenu.Size = new System.Drawing.Size(146, 22);
            this.ClearMenu.Text = "Очистить";
            this.ClearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(146, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Reference
            // 
            this.Reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(63, 20);
            this.Reference.Text = "справка";
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(149, 22);
            this.AboutProgram.Text = "О программе";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Task.Controls.Add(this.TaskPNG);
            this.Task.Location = new System.Drawing.Point(12, 27);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(808, 80);
            this.Task.TabIndex = 3;
            this.Task.TabStop = false;
            this.Task.Text = "Задание:";
            // 
            // TaskPNG
            // 
            this.TaskPNG.Image = global::PR_3.Properties.Resources._213442;
            this.TaskPNG.Location = new System.Drawing.Point(63, 19);
            this.TaskPNG.Name = "TaskPNG";
            this.TaskPNG.Size = new System.Drawing.Size(682, 50);
            this.TaskPNG.TabIndex = 0;
            this.TaskPNG.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Exit.Location = new System.Drawing.Point(703, 208);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(117, 39);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear.Location = new System.Drawing.Point(531, 208);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(117, 39);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ValueMatrix
            // 
            this.ValueMatrix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ValueMatrix.Location = new System.Drawing.Point(12, 113);
            this.ValueMatrix.Name = "ValueMatrix";
            this.ValueMatrix.Size = new System.Drawing.Size(281, 150);
            this.ValueMatrix.TabIndex = 8;
            this.ValueMatrix.TabStop = false;
            this.ValueMatrix.Text = "Матрица:";
            // 
            // GeometricMeanMatrix
            // 
            this.GeometricMeanMatrix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GeometricMeanMatrix.Controls.Add(this.GeometricMeanMatrixExit);
            this.GeometricMeanMatrix.Location = new System.Drawing.Point(531, 113);
            this.GeometricMeanMatrix.Name = "GeometricMeanMatrix";
            this.GeometricMeanMatrix.Size = new System.Drawing.Size(289, 47);
            this.GeometricMeanMatrix.TabIndex = 11;
            this.GeometricMeanMatrix.TabStop = false;
            this.GeometricMeanMatrix.Text = "Среднее геометрическое значение матрицы:";
            // 
            // GeometricMeanMatrixExit
            // 
            this.GeometricMeanMatrixExit.Location = new System.Drawing.Point(6, 19);
            this.GeometricMeanMatrixExit.Name = "GeometricMeanMatrixExit";
            this.GeometricMeanMatrixExit.ReadOnly = true;
            this.GeometricMeanMatrixExit.Size = new System.Drawing.Size(277, 20);
            this.GeometricMeanMatrixExit.TabIndex = 11;
            // 
            // GeometricMeanMatrixButton
            // 
            this.GeometricMeanMatrixButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GeometricMeanMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GeometricMeanMatrixButton.Location = new System.Drawing.Point(531, 166);
            this.GeometricMeanMatrixButton.Name = "GeometricMeanMatrixButton";
            this.GeometricMeanMatrixButton.Size = new System.Drawing.Size(289, 34);
            this.GeometricMeanMatrixButton.TabIndex = 12;
            this.GeometricMeanMatrixButton.Text = "Вычислить ср. геометрическое значение";
            this.GeometricMeanMatrixButton.UseVisualStyleBackColor = false;
            this.GeometricMeanMatrixButton.Click += new System.EventHandler(this.GeometricMeanMatrixButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateMatrix
            // 
            this.CreateMatrix.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CreateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CreateMatrix.Location = new System.Drawing.Point(123, 85);
            this.CreateMatrix.Name = "CreateMatrix";
            this.CreateMatrix.Size = new System.Drawing.Size(77, 34);
            this.CreateMatrix.TabIndex = 13;
            this.CreateMatrix.Text = "Создать";
            this.CreateMatrix.UseVisualStyleBackColor = false;
            this.CreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click);
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(103, 19);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(117, 20);
            this.textBoxColumns.TabIndex = 12;
            // 
            // textBoxLines
            // 
            this.textBoxLines.Location = new System.Drawing.Point(103, 50);
            this.textBoxLines.Name = "textBoxLines";
            this.textBoxLines.Size = new System.Drawing.Size(117, 20);
            this.textBoxLines.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CreateMatrix);
            this.groupBox1.Controls.Add(this.textBoxLines);
            this.groupBox1.Controls.Add(this.textBoxColumns);
            this.groupBox1.Location = new System.Drawing.Point(299, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель управления создания матрицы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Кол-во столбцов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Кол-во строк:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GeometricMeanMatrixButton);
            this.Controls.Add(this.GeometricMeanMatrix);
            this.Controls.Add(this.ValueMatrix);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Menu);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Практическая работа №3";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskPNG)).EndInit();
            this.GeometricMeanMatrix.ResumeLayout(false);
            this.GeometricMeanMatrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem Applications;
        private System.Windows.Forms.ToolStripMenuItem ClearMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem Reference;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.PictureBox TaskPNG;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox ValueMatrix;
        private System.Windows.Forms.GroupBox GeometricMeanMatrix;
        private System.Windows.Forms.TextBox GeometricMeanMatrixExit;
        private System.Windows.Forms.Button GeometricMeanMatrixButton;
        private System.Windows.Forms.ToolStripMenuItem ApplicationGeometricMean;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateMatrix;
        private System.Windows.Forms.TextBox textBoxLines;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

