namespace c_winform
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
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.buttonForRab = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBoxMain2 = new System.Windows.Forms.RichTextBox();
            this.buttonOtchetNaProverke = new System.Windows.Forms.Button();
            this.buttonTemAdd = new System.Windows.Forms.Button();
            this.buttonTemDel = new System.Windows.Forms.Button();
            this.buttonSotrDel = new System.Windows.Forms.Button();
            this.buttonSotrAdd = new System.Windows.Forms.Button();
            this.buttonFindSotr = new System.Windows.Forms.Button();
            this.buttonDiscAdd = new System.Windows.Forms.Button();
            this.buttonDiscDel = new System.Windows.Forms.Button();
            this.buttonSotAdd = new System.Windows.Forms.Button();
            this.buttonSeeOtch = new System.Windows.Forms.Button();
            this.buttonOtchErr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Location = new System.Drawing.Point(213, 288);
            this.textBoxlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(206, 20);
            this.textBoxlogin.TabIndex = 0;
            this.textBoxlogin.Text = "Введите логин";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(213, 323);
            this.textBoxpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(206, 20);
            this.textBoxpassword.TabIndex = 1;
            this.textBoxpassword.Text = "Введите пароль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxMain.Location = new System.Drawing.Point(17, 65);
            this.richTextBoxMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.Size = new System.Drawing.Size(583, 86);
            this.richTextBoxMain.TabIndex = 3;
            this.richTextBoxMain.Text = "";
            // 
            // buttonForRab
            // 
            this.buttonForRab.Location = new System.Drawing.Point(213, 362);
            this.buttonForRab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonForRab.Name = "buttonForRab";
            this.buttonForRab.Size = new System.Drawing.Size(97, 19);
            this.buttonForRab.TabIndex = 4;
            this.buttonForRab.Text = "Отправить отчет";
            this.buttonForRab.UseVisualStyleBackColor = true;
            this.buttonForRab.Click += new System.EventHandler(this.buttonForRab_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Выйти в главное меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonForExit);
            // 
            // richTextBoxMain2
            // 
            this.richTextBoxMain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxMain2.Location = new System.Drawing.Point(17, 148);
            this.richTextBoxMain2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxMain2.Name = "richTextBoxMain2";
            this.richTextBoxMain2.Size = new System.Drawing.Size(583, 93);
            this.richTextBoxMain2.TabIndex = 6;
            this.richTextBoxMain2.Text = "";
            // 
            // buttonOtchetNaProverke
            // 
            this.buttonOtchetNaProverke.Location = new System.Drawing.Point(315, 362);
            this.buttonOtchetNaProverke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtchetNaProverke.Name = "buttonOtchetNaProverke";
            this.buttonOtchetNaProverke.Size = new System.Drawing.Size(104, 19);
            this.buttonOtchetNaProverke.TabIndex = 7;
            this.buttonOtchetNaProverke.Text = "Доработать отчёт";
            this.buttonOtchetNaProverke.UseVisualStyleBackColor = true;
            this.buttonOtchetNaProverke.Click += new System.EventHandler(this.buttonOtchetNaProverke_Click);
            // 
            // buttonTemAdd
            // 
            this.buttonTemAdd.Location = new System.Drawing.Point(472, 292);
            this.buttonTemAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTemAdd.Name = "buttonTemAdd";
            this.buttonTemAdd.Size = new System.Drawing.Size(128, 19);
            this.buttonTemAdd.TabIndex = 8;
            this.buttonTemAdd.Text = "Добавить тему";
            this.buttonTemAdd.UseVisualStyleBackColor = true;
            this.buttonTemAdd.Click += new System.EventHandler(this.buttonTemAdd_Click);
            // 
            // buttonTemDel
            // 
            this.buttonTemDel.Location = new System.Drawing.Point(472, 316);
            this.buttonTemDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTemDel.Name = "buttonTemDel";
            this.buttonTemDel.Size = new System.Drawing.Size(128, 19);
            this.buttonTemDel.TabIndex = 9;
            this.buttonTemDel.Text = "Удалить тему";
            this.buttonTemDel.UseVisualStyleBackColor = true;
            this.buttonTemDel.Click += new System.EventHandler(this.buttonTemDel_Click);
            // 
            // buttonSotrDel
            // 
            this.buttonSotrDel.Location = new System.Drawing.Point(472, 269);
            this.buttonSotrDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSotrDel.Name = "buttonSotrDel";
            this.buttonSotrDel.Size = new System.Drawing.Size(128, 19);
            this.buttonSotrDel.TabIndex = 10;
            this.buttonSotrDel.Text = "Удалить сотрудника";
            this.buttonSotrDel.UseVisualStyleBackColor = true;
            this.buttonSotrDel.Click += new System.EventHandler(this.buttonSotrDel_Click);
            // 
            // buttonSotrAdd
            // 
            this.buttonSotrAdd.Location = new System.Drawing.Point(472, 245);
            this.buttonSotrAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSotrAdd.Name = "buttonSotrAdd";
            this.buttonSotrAdd.Size = new System.Drawing.Size(128, 19);
            this.buttonSotrAdd.TabIndex = 11;
            this.buttonSotrAdd.Text = "Добавить сотрудника";
            this.buttonSotrAdd.UseVisualStyleBackColor = true;
            this.buttonSotrAdd.Click += new System.EventHandler(this.buttonSotrAdd_Click);
            // 
            // buttonFindSotr
            // 
            this.buttonFindSotr.Location = new System.Drawing.Point(472, 245);
            this.buttonFindSotr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFindSotr.Name = "buttonFindSotr";
            this.buttonFindSotr.Size = new System.Drawing.Size(128, 19);
            this.buttonFindSotr.TabIndex = 12;
            this.buttonFindSotr.Text = "Найти сотрудника";
            this.buttonFindSotr.UseVisualStyleBackColor = true;
            this.buttonFindSotr.Click += new System.EventHandler(this.buttonFindSotr_Click);
            // 
            // buttonDiscAdd
            // 
            this.buttonDiscAdd.Location = new System.Drawing.Point(472, 269);
            this.buttonDiscAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDiscAdd.Name = "buttonDiscAdd";
            this.buttonDiscAdd.Size = new System.Drawing.Size(128, 19);
            this.buttonDiscAdd.TabIndex = 13;
            this.buttonDiscAdd.Text = "Добавить дисциплину";
            this.buttonDiscAdd.UseVisualStyleBackColor = true;
            this.buttonDiscAdd.Click += new System.EventHandler(this.buttonDiscAdd_Click);
            // 
            // buttonDiscDel
            // 
            this.buttonDiscDel.Location = new System.Drawing.Point(472, 292);
            this.buttonDiscDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDiscDel.Name = "buttonDiscDel";
            this.buttonDiscDel.Size = new System.Drawing.Size(128, 19);
            this.buttonDiscDel.TabIndex = 14;
            this.buttonDiscDel.Text = "Удалить дисциплину";
            this.buttonDiscDel.UseVisualStyleBackColor = true;
            this.buttonDiscDel.Click += new System.EventHandler(this.buttonDiscDel_Click);
            // 
            // buttonSotAdd
            // 
            this.buttonSotAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSotAdd.Location = new System.Drawing.Point(67, 288);
            this.buttonSotAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSotAdd.Name = "buttonSotAdd";
            this.buttonSotAdd.Size = new System.Drawing.Size(79, 88);
            this.buttonSotAdd.TabIndex = 15;
            this.buttonSotAdd.Text = "Добавить сотрудника";
            this.buttonSotAdd.UseVisualStyleBackColor = false;
            this.buttonSotAdd.Click += new System.EventHandler(this.buttonSotAdd_Click);
            // 
            // buttonSeeOtch
            // 
            this.buttonSeeOtch.Location = new System.Drawing.Point(472, 316);
            this.buttonSeeOtch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSeeOtch.Name = "buttonSeeOtch";
            this.buttonSeeOtch.Size = new System.Drawing.Size(128, 19);
            this.buttonSeeOtch.TabIndex = 16;
            this.buttonSeeOtch.Text = "Просмотреть отчёт";
            this.buttonSeeOtch.UseVisualStyleBackColor = true;
            this.buttonSeeOtch.Click += new System.EventHandler(this.buttonSeeOtch_Click);
            // 
            // buttonOtchErr
            // 
            this.buttonOtchErr.Location = new System.Drawing.Point(472, 340);
            this.buttonOtchErr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtchErr.Name = "buttonOtchErr";
            this.buttonOtchErr.Size = new System.Drawing.Size(128, 37);
            this.buttonOtchErr.TabIndex = 17;
            this.buttonOtchErr.Text = "Отправить на исправление";
            this.buttonOtchErr.UseVisualStyleBackColor = true;
            this.buttonOtchErr.Click += new System.EventHandler(this.buttonOtchErr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 397);
            this.Controls.Add(this.buttonOtchErr);
            this.Controls.Add(this.buttonSeeOtch);
            this.Controls.Add(this.buttonSotAdd);
            this.Controls.Add(this.buttonDiscDel);
            this.Controls.Add(this.buttonDiscAdd);
            this.Controls.Add(this.buttonFindSotr);
            this.Controls.Add(this.buttonSotrAdd);
            this.Controls.Add(this.buttonSotrDel);
            this.Controls.Add(this.buttonTemDel);
            this.Controls.Add(this.buttonTemAdd);
            this.Controls.Add(this.buttonOtchetNaProverke);
            this.Controls.Add(this.richTextBoxMain2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBoxMain);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.buttonForRab);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxlogin;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox richTextBoxMain;
        private System.Windows.Forms.Button buttonForRab;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.RichTextBox richTextBoxMain2;
        private System.Windows.Forms.Button buttonOtchetNaProverke;
        private System.Windows.Forms.Button buttonTemAdd;
        private System.Windows.Forms.Button buttonTemDel;
        private System.Windows.Forms.Button buttonSotrDel;
        private System.Windows.Forms.Button buttonSotrAdd;
        private System.Windows.Forms.Button buttonFindSotr;
        private System.Windows.Forms.Button buttonDiscAdd;
        private System.Windows.Forms.Button buttonDiscDel;
        private System.Windows.Forms.Button buttonSotAdd;
        private System.Windows.Forms.Button buttonSeeOtch;
        private System.Windows.Forms.Button buttonOtchErr;
    }
}

