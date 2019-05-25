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

            listViewBusiness.GridLines = true;
            listViewBusiness.FullRowSelect = true;
            listViewBusiness.View = View.Details;
            listViewBusiness.Columns.Add("Название");
            listViewBusiness.Columns[0].Width = 100;
            listViewBusiness.Columns.Add("Дата");
            listViewBusiness.Columns[1].Width = 100;
            listViewBusiness.Columns.Add("Время");
            listViewBusiness.Columns[2].Width = 100;
            listViewBusiness.Columns.Add("Приоритет");
            listViewBusiness.Columns[3].Width = 100;
            listViewBusiness.Columns.Add("Теги");
            listViewBusiness.Columns[4].Width = 100;
            listViewBusiness.Columns.Add("Комментарий");
            listViewBusiness.Columns[5].Width = 100;

            ImageList largeImList = new ImageList();
            ImageList smallImList = new ImageList();
    
            largeImList.ImageSize = new Size(50,50);
            smallImList.ImageSize = new Size(30,30);
            largeImList.Images.Add(new Bitmap("ikon.bmp"));
            smallImList.Images.Add(new Bitmap("ikon.bmp"));


            listViewBusiness.LargeImageList = largeImList;
            listViewBusiness.SmallImageList = smallImList;
            listViewBusiness.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            CreateContextMenu();



        }

        private void CreateContextMenu()
        {
            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
            contextMenuStrip1.Items.Add("Detail");
            contextMenuStrip1.Items.Add("Tile");
            contextMenuStrip1.Items.Add("LargeIcon");
            contextMenuStrip1.Items.Add("SmallIcon");
            contextMenuStrip1.Items.Add("List");

            foreach (var item in contextMenuStrip1.Items)
            {
                (item as ToolStripMenuItem).Click += Form1_Click;
            }
            listViewBusiness.ContextMenuStrip = contextMenuStrip1;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Text)
            {
                case "Detail":
                    listViewBusiness.View = View.Details;
                    break;
                case "Tile":
                    listViewBusiness.View = View.Tile;
                    break;
                case "LargeIcon":
                    listViewBusiness.View = View.LargeIcon;
                    break;
                case "SmallIcon":
                    listViewBusiness.View = View.SmallIcon;
                    break;
                case "list":
                    listViewBusiness.View = View.List;
                    break;
                default:
                    break;
  
            }
        }

        private void buttonNewBusiness_Click(object sender, EventArgs e)
        {
            NewBusiness business = new NewBusiness();

            if (business.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(business.NameProject);

                item.SubItems.Add(business.DateProject.Text);
                item.SubItems.Add( business.TimeProject.ToString());
                item.SubItems.Add(business.PriorityProject);
                item.SubItems.Add( business.TagsProject);
                item.SubItems.Add( business.CommentsProject);


                listViewBusiness.Items.Add(item);
                treeViewProjects.Nodes.Add(business.NameProject);
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
