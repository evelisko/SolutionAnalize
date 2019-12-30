namespace SolutionAnalize
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
            this.tbSolutionFolder = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWorkFolder = new System.Windows.Forms.TextBox();
            this.tbCompillngFolder = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFolderCopmpare = new System.Windows.Forms.Button();
            this.btnProjTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSolutionFolder
            // 
            this.tbSolutionFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSolutionFolder.Location = new System.Drawing.Point(120, 90);
            this.tbSolutionFolder.Margin = new System.Windows.Forms.Padding(2);
            this.tbSolutionFolder.Name = "tbSolutionFolder";
            this.tbSolutionFolder.Size = new System.Drawing.Size(533, 20);
            this.tbSolutionFolder.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(657, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 31);
            this.button2.TabIndex = 28;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(9, 146);
            this.tbLog.Margin = new System.Windows.Forms.Padding(2);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(822, 628);
            this.tbLog.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Каталог с проектом";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Рабочее решение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Скомпиллированный проект";
            // 
            // tbWorkFolder
            // 
            this.tbWorkFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWorkFolder.Location = new System.Drawing.Point(162, 47);
            this.tbWorkFolder.Margin = new System.Windows.Forms.Padding(2);
            this.tbWorkFolder.Name = "tbWorkFolder";
            this.tbWorkFolder.Size = new System.Drawing.Size(491, 20);
            this.tbWorkFolder.TabIndex = 38;
            // 
            // tbCompillngFolder
            // 
            this.tbCompillngFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCompillngFolder.Location = new System.Drawing.Point(162, 11);
            this.tbCompillngFolder.Margin = new System.Windows.Forms.Padding(2);
            this.tbCompillngFolder.Name = "tbCompillngFolder";
            this.tbCompillngFolder.Size = new System.Drawing.Size(491, 20);
            this.tbCompillngFolder.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(657, 41);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 31);
            this.button3.TabIndex = 36;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(657, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 35;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFolderCopmpare
            // 
            this.btnFolderCopmpare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderCopmpare.Location = new System.Drawing.Point(699, 5);
            this.btnFolderCopmpare.Margin = new System.Windows.Forms.Padding(2);
            this.btnFolderCopmpare.Name = "btnFolderCopmpare";
            this.btnFolderCopmpare.Size = new System.Drawing.Size(129, 67);
            this.btnFolderCopmpare.TabIndex = 34;
            this.btnFolderCopmpare.Text = "Сравнить каталоги ";
            this.btnFolderCopmpare.UseVisualStyleBackColor = true;
            this.btnFolderCopmpare.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProjTree
            // 
            this.btnProjTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjTree.Location = new System.Drawing.Point(699, 80);
            this.btnProjTree.Name = "btnProjTree";
            this.btnProjTree.Size = new System.Drawing.Size(131, 39);
            this.btnProjTree.TabIndex = 42;
            this.btnProjTree.Text = "Построить дерево проекта";
            this.btnProjTree.UseVisualStyleBackColor = true;
            this.btnProjTree.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 796);
            this.Controls.Add(this.btnProjTree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWorkFolder);
            this.Controls.Add(this.tbCompillngFolder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFolderCopmpare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.tbSolutionFolder);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSolutionFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWorkFolder;
        private System.Windows.Forms.TextBox tbCompillngFolder;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFolderCopmpare;
        private System.Windows.Forms.Button btnProjTree;
    }
}

