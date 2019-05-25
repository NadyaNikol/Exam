using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

namespace Exam
{
    public partial class Form1 : Form
    {
        List<string> listColums = null;
        List<BusinessClass> ListBusiness = new List<BusinessClass>();
        public Form1()
        {
            InitializeComponent();

            TreeNode nodeProject = new TreeNode("Rroject 1");
            treeViewProjects.Nodes.Add(nodeProject);

            listColums = new List<string> { "Название", "Дата", "Время", "Приоритет", "Теги",
            "Комментарий"};

            listViewBusiness.GridLines = true;
            listViewBusiness.FullRowSelect = true;
            listViewBusiness.View = View.Details;

            for (int i = 0; i < listColums.Count; i++)
            {
                listViewBusiness.Columns.Add(listColums[i]);
                listViewBusiness.Columns[i].Width = 100;
                comboBoxSearch.Items.Add(listColums[i]);
            }
            comboBoxSearch.SelectedIndex = 0;

            ImageList largeImList = new ImageList();
            ImageList smallImList = new ImageList();

            largeImList.ImageSize = new Size(50, 50);
            smallImList.ImageSize = new Size(30, 30);
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
                //ListViewItem item = new ListViewItem(business.NameProject);

                //item.SubItems.Add(business.DateProject.Text);
                //item.SubItems.Add(business.TimeProject.ToString());
                //item.SubItems.Add(business.PriorityProject);
                //item.SubItems.Add(business.TagsProject);
                //item.SubItems.Add(business.CommentsProject);
                //listViewBusiness.Items.Add(item);

                ListBusiness.Add(new BusinessClass
                {
                    NameProj = business.NameProject,
                    DateProject = business.DateProject,
                    TimeProject = business.TimeProject,
                    PriorityProject = business.PriorityProject,
                    TagsProject = business.TagsProject,
                    CommentProject = business.CommentsProject
                });

                FillListViewBusiness();

                treeViewProjects.Nodes.Add(business.NameProject);

            }
        }

        private void FillListViewBusiness()
        {
            listViewBusiness.Items.Clear();
            for (int i = 0; i < ListBusiness.Count; i++)
            {
                ListViewItem item = new ListViewItem(ListBusiness[i].NameProj);

                item.SubItems.Add(ListBusiness[i].DateProject.ToShortDateString());
                item.SubItems.Add(ListBusiness[i].TimeProject.ToString());
                item.SubItems.Add(ListBusiness[i].PriorityProject);
                item.SubItems.Add(ListBusiness[i].TagsProject);
                item.SubItems.Add(ListBusiness[i].CommentProject);

                listViewBusiness.Items.Add(item);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Document doc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(doc, new FileStream("Business.pdf", FileMode.Create));

            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            PdfPTable table = new PdfPTable(listViewBusiness.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase("Список дел", font));

            cell.Colspan = listViewBusiness.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);

            for (int j = 0; j < listViewBusiness.Columns.Count; j++)
            {
                cell = new PdfPCell(new Phrase(new Phrase(listColums[j], font)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }

            //Добавляем все остальные ячейки
            for (int j = 0; j < listViewBusiness.Items.Count; j++)
            {
                for (int k = 0; k < listViewBusiness.Items[j].SubItems.Count; k++)
                {
                    table.AddCell(new Phrase(listViewBusiness.Items[j].SubItems[k].Text, font));
                }
            }
            //Добавляем таблицу в документ
            doc.Add(table);
            doc.Close();
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            textBoxNewProject.Visible = true;
        }

        private void textBoxNewProject_Click(object sender, EventArgs e)
        {
            textBoxNewProject.Text = "";
        }


        private void textBoxNewProject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                treeViewProjects.Nodes.Add(textBoxNewProject.Text);
                textBoxNewProject.Clear();
                textBoxNewProject.Visible = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            comboBoxSearch.Visible = true;
            textBoxSearch.Visible = true;
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSearch.Enabled = true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillListViewBusiness();
            if (!String.IsNullOrEmpty(textBoxSearch.Text))
            {
                for (int i = 0; i < listViewBusiness.Columns.Count; i++)
                {
                    if (comboBoxSearch.Text == listViewBusiness.Columns[i].Text)
                    {
                        for (int j = 0; j < listViewBusiness.Items.Count; j++)
                        {
                            if (listViewBusiness.Items[j].SubItems[i].Text != textBoxSearch.Text)
                            {
                                listViewBusiness.Items.RemoveAt(j);
                                j--;
                            }
                        }
                        break;
                    }
                }
            }

        }
    }
}
