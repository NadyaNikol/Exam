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
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(91, 79);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(119, 20);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // textBoxTimeHour
            // 
            this.textBoxTimeHour.Location = new System.Drawing.Point(91, 120);
            this.textBoxTimeHour.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimeHour.Name = "textBoxTimeHour";
            this.textBoxTimeHour.Size = new System.Drawing.Size(41, 20);
            this.textBoxTimeHour.TabIndex = 1;
            this.textBoxTimeHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTimeHour.TabIndexChanged += new System.EventHandler(this.textBoxTimeHour_TabIndexChanged);
            this.textBoxTimeHour.TextChanged += new System.EventHandler(this.textBoxTimeHour_TextChanged);
            this.textBoxTimeHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimeHour_KeyPress);
            // 
            // textBoxTimeMinute
            // 
            this.textBoxTimeMinute.Location = new System.Drawing.Point(145, 120);
            this.textBoxTimeMinute.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimeMinute.Name = "textBoxTimeMinute";
            this.textBoxTimeMinute.Size = new System.Drawing.Size(41, 20);
            this.textBoxTimeMinute.TabIndex = 2;
            this.textBoxTimeMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTimeMinute.TextChanged += new System.EventHandler(this.textBoxTimeMinute_TextChanged);
            this.textBoxTimeMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimeHour_KeyPress);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(9, 79);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Дата:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(9, 120);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Время:";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(91, 163);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(114, 21);
            this.comboBoxPriority.TabIndex = 5;
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(9, 168);
            this.labelPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(64, 13);
            this.labelPriority.TabIndex = 6;
            this.labelPriority.Text = "Приоритет:";
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(9, 212);
            this.labelTags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(34, 13);
            this.labelTags.TabIndex = 7;
            this.labelTags.Text = "Теги:";
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Location = new System.Drawing.Point(91, 207);
            this.comboBoxTag.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(116, 21);
            this.comboBoxTag.TabIndex = 8;
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(90, 250);
            this.textBoxComments.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(352, 93);
            this.textBoxComments.TabIndex = 9;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(6, 250);
            this.labelComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(80, 13);
            this.labelComments.TabIndex = 10;
            this.labelComments.Text = "Комментарий:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = ":";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(337, 120);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(105, 82);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(468, 122);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 82);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(517, 294);
            this.buttonAddFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(50, 49);
            this.buttonAddFile.TabIndex = 14;
            this.buttonAddFile.Text = "AddFile";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // textBoxNameProject
            // 
            this.textBoxNameProject.Location = new System.Drawing.Point(90, 45);
            this.textBoxNameProject.Name = "textBoxNameProject";
            this.textBoxNameProject.Size = new System.Drawing.Size(477, 20);
            this.textBoxNameProject.TabIndex = 15;
            // 
            // labelNameProject
            // 
            this.labelNameProject.AutoSize = true;
            this.labelNameProject.Location = new System.Drawing.Point(11, 19);
            this.labelNameProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameProject.Name = "labelNameProject";
            this.labelNameProject.Size = new System.Drawing.Size(104, 13);
            this.labelNameProject.TabIndex = 16;
            this.labelNameProject.Text = "Название проэкта:";
            // 
            // NewBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 483);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}