namespace Exam
{
    partial class NewBusiness
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
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxTimeHour = new System.Windows.Forms.TextBox();
            this.textBoxTimeMinute = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelTags = new System.Windows.Forms.Label();
            this.comboBoxTag = new System.Windows.Forms.ComboBox();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.labelComments = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.textBoxNameProject = new System.Windows.Forms.TextBox();
            this.labelNameProject = new System.Windows.Forms.Label();
            this.textBoxNewTag = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(136, 122);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(176, 26);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // textBoxTimeHour
            // 
            this.textBoxTimeHour.Location = new System.Drawing.Point(136, 185);
            this.textBoxTimeHour.Name = "textBoxTimeHour";
            this.textBoxTimeHour.Size = new System.Drawing.Size(60, 26);
            this.textBoxTimeHour.TabIndex = 1;
            this.textBoxTimeHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTimeHour.TabIndexChanged += new System.EventHandler(this.textBoxTimeHour_TabIndexChanged);
            this.textBoxTimeHour.TextChanged += new System.EventHandler(this.textBoxTimeHour_TextChanged);
            this.textBoxTimeHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimeHour_KeyPress);
            // 
            // textBoxTimeMinute
            // 
            this.textBoxTimeMinute.Location = new System.Drawing.Point(218, 185);
            this.textBoxTimeMinute.Name = "textBoxTimeMinute";
            this.textBoxTimeMinute.Size = new System.Drawing.Size(60, 26);
            this.textBoxTimeMinute.TabIndex = 2;
            this.textBoxTimeMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTimeMinute.TextChanged += new System.EventHandler(this.textBoxTimeMinute_TextChanged);
            this.textBoxTimeMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimeHour_KeyPress);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(14, 122);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 20);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Дата:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(14, 185);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(62, 20);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Время:";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(136, 251);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(169, 28);
            this.comboBoxPriority.TabIndex = 5;
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(14, 258);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(97, 20);
            this.labelPriority.TabIndex = 6;
            this.labelPriority.Text = "Приоритет:";
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(14, 326);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(47, 20);
            this.labelTags.TabIndex = 7;
            this.labelTags.Text = "Теги:";
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Location = new System.Drawing.Point(136, 318);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(172, 28);
            this.comboBoxTag.TabIndex = 8;
            this.comboBoxTag.SelectedIndexChanged += new System.EventHandler(this.comboBoxTag_SelectedIndexChanged);
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(135, 385);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(526, 141);
            this.textBoxComments.TabIndex = 9;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(9, 385);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(117, 20);
            this.labelComments.TabIndex = 10;
            this.labelComments.Text = "Комментарий:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = ":";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(91, 572);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(319, 126);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(513, 572);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(336, 126);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(776, 452);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(75, 75);
            this.buttonAddFile.TabIndex = 14;
            this.buttonAddFile.Text = "AddFile";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // textBoxNameProject
            // 
            this.textBoxNameProject.Location = new System.Drawing.Point(135, 69);
            this.textBoxNameProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNameProject.Name = "textBoxNameProject";
            this.textBoxNameProject.Size = new System.Drawing.Size(714, 26);
            this.textBoxNameProject.TabIndex = 15;
            // 
            // labelNameProject
            // 
            this.labelNameProject.AutoSize = true;
            this.labelNameProject.Location = new System.Drawing.Point(16, 29);
            this.labelNameProject.Name = "labelNameProject";
            this.labelNameProject.Size = new System.Drawing.Size(153, 20);
            this.labelNameProject.TabIndex = 16;
            this.labelNameProject.Text = "Название проэкта:";
            // 
            // textBoxNewTag
            // 
            this.textBoxNewTag.Location = new System.Drawing.Point(330, 305);
            this.textBoxNewTag.Name = "textBoxNewTag";
            this.textBoxNewTag.Size = new System.Drawing.Size(150, 26);
            this.textBoxNewTag.TabIndex = 17;
            this.textBoxNewTag.Text = "Введите текст...";
            this.textBoxNewTag.Visible = false;
            this.textBoxNewTag.Click += new System.EventHandler(this.textBoxNewTag_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(330, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 42);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // NewBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 743);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNewTag);
            this.Controls.Add(this.labelNameProject);
            this.Controls.Add(this.textBoxNameProject);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.comboBoxTag);
            this.Controls.Add(this.labelTags);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxTimeMinute);
            this.Controls.Add(this.textBoxTimeHour);
            this.Controls.Add(this.dateTimePickerDate);
            this.Name = "NewBusiness";
            this.Text = "NewBusiness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxTimeHour;
        private System.Windows.Forms.TextBox textBoxTimeMinute;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.ComboBox comboBoxTag;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.TextBox textBoxNameProject;
        private System.Windows.Forms.Label labelNameProject;
        private System.Windows.Forms.TextBox textBoxNewTag;
        private System.Windows.Forms.Button buttonAdd;
    }
}