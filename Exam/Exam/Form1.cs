using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TreeNode nodeProject = new TreeNode("Rroject 1");
            treeViewProjects.Nodes.Add(nodeProject);

        }

        private void buttonNewBusiness_Click(object sender, EventArgs e)
        {
            NewBusiness business = new NewBusiness();

            if (business.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem();

                item.Text = business.NameProject;
                item.SubItems[0].Text = business.DateProject.Text;
                item.SubItems[1].Text = business.TimeProject.ToString();
                item.SubItems[2].Text = business.PriorityProject;
                item.SubItems[3].Text = business.TagsProject;
                item.SubItems[4].Text = business.CommentsProject;


                listViewBusiness.Items.Add(item);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
