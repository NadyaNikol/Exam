namespace Exam
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
            this.treeViewProjects = new System.Windows.Forms.TreeView();
            this.listViewBusiness = new System.Windows.Forms.ListView();
            this.buttonNewBussnes = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxNewProject = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // treeViewProjects
            // 
            this.treeViewProjects.Location = new System.Drawing.Point(12, 85);
            this.treeViewProjects.Name = "treeViewProjects";
            this.treeViewProjects.Size = new System.Drawing.Size(238, 438);
            this.treeViewProjects.TabIndex = 0;
            // 
            // listViewBusiness
            // 
            this.listViewBusiness.Location = new System.Drawing.Point(280, 85);
            this.listViewBusiness.Name = "listViewBusiness";
            this.listViewBusiness.Size = new System.Drawing.Size(866, 438);
            this.listViewBusiness.TabIndex = 1;
            this.listViewBusiness.UseCompatibleStateImageBehavior = false;
            // 
            // buttonNewBussnes
            // 
            this.buttonNewBussnes.Location = new System.Drawing.Point(280, 12);
            this.buttonNewBussnes.Name = "buttonNewBussnes";
            this.buttonNewBussnes.Size = new System.Drawing.Size(110, 67);
            this.buttonNewBussnes.TabIndex = 2;
            this.buttonNewBussnes.Text = "New business";
            this.buttonNewBussnes.UseVisualStyleBackColor = true;
            this.buttonNewBussnes.Click += new System.EventHandler(this.buttonNewBusiness_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(418, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 69);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(494, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(74, 69);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.Location = new System.Drawing.Point(12, 12);
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Size = new System.Drawing.Size(110, 51);
            this.buttonNewProject.TabIndex = 5;
            this.buttonNewProject.Text = "New Project";
            this.buttonNewProject.UseVisualStyleBackColor = true;
            this.buttonNewProject.Click += new System.EventHandler(this.buttonNewProject_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(626, 10);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(174, 28);
            this.comboBoxSearch.TabIndex = 6;
            this.comboBoxSearch.Visible = false;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // textBoxNewProject
            // 
            this.textBoxNewProject.Location = new System.Drawing.Point(12, 12);
            this.textBoxNewProject.Multiline = true;
            this.textBoxNewProject.Name = "textBoxNewProject";
            this.textBoxNewProject.Size = new System.Drawing.Size(238, 57);
            this.textBoxNewProject.TabIndex = 8;
            this.textBoxNewProject.Text = "Введите название проэкта...";
            this.textBoxNewProject.Visible = false;
            this.textBoxNewProject.Click += new System.EventHandler(this.textBoxNewProject_Click);
            this.textBoxNewProject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewProject_KeyPress);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Enabled = false;
            this.textBoxSearch.Location = new System.Drawing.Point(626, 45);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(174, 26);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.Visible = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxSelection
            // 
            this.comboBoxSelection.FormattingEnabled = true;
            this.comboBoxSelection.Location = new System.Drawing.Point(934, 31);
            this.comboBoxSelection.Name = "comboBoxSelection";
            this.comboBoxSelection.Size = new System.Drawing.Size(174, 28);
            this.comboBoxSelection.TabIndex = 10;
            this.comboBoxSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelection_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1198, 612);
            this.Controls.Add(this.comboBoxSelection);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxNewProject);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.buttonNewProject);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNewBussnes);
            this.Controls.Add(this.listViewBusiness);
            this.Controls.Add(this.treeViewProjects);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewProjects;
        private System.Windows.Forms.ListView listViewBusiness;
        private System.Windows.Forms.Button buttonNewBussnes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonNewProject;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        public System.Windows.Forms.TextBox textBoxNewProject;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSelection;
    }
}

