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

            comboBoxSelection.Items.Add("Все");
            comboBoxSelection.Items.Add("На месяц");
            comboBoxSelection.Items.Add("На неделю");
            comboBoxSelection.SelectedIndex = 0;


            listColums = new List<string> { "Название", "Дата", "Время", "Приоритет", "Теги",
            "Комментарий", "Файл"};

            listViewBusiness.GridLines = true;
            listViewBusiness.FullRowSelect = true;
            listViewBusiness.View = View.Details;

            for (int i = 0; i < listColums.Count; i++)
            {
                listViewBusiness.Columns.Add(listColums[i]);
                listViewBusiness.Columns[i].Width = 110;
                comboBoxSearch.Items.Add(listColums[i]);
            }
            comboBoxSearch.SelectedIndex = 0;

            listViewBusiness.AllowDrop = true;
        }


        private void buttonNewBusiness_Click(object sender, EventArgs e)
        {
            NewBusiness business = new NewBusiness();

            if (business.ShowDialog() == DialogResult.OK)
            {

                ListBusiness.Add(new BusinessClass
                {
                    NameProj = business.NameProject,
                    DateProject = business.DateProject,
                    TimeProject = business.TimeProject,
                    PriorityProject = business.PriorityProject,
                    TagsProject = business.TagsProject,
                    CommentProject = business.CommentsProject,
                    pathFile = business.pathFile

                });

                FillListViewBusiness();


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
                item.SubItems.Add(ListBusiness[i].pathFile);

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

        private void comboBoxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthCalendar monthCalendar = new MonthCalendar();
            FillListViewBusiness();
            switch (comboBoxSelection.SelectedItem)
            {
                case "На неделю":
                    {

                        DateTime dateTime = DateTime.Now;
                        for (int i = 0; i < listViewBusiness.Columns.Count; i++)
                        {
                            if (listViewBusiness.Columns[i].Text == "Дата")
                            {
                                for (int j = 0; j < listViewBusiness.Items.Count; j++)
                                {

                                    if ((ListBusiness[j].DateProject - dateTime).TotalDays > 7)
                                    {
                                        listViewBusiness.Items.RemoveAt(j);
                                        j--;
                                    }
                                }
                                break;
                            }
                        }

                        break;
                    }

                case "На месяц":
                    {
                        FillListViewBusiness();
                        DateTime dateTime = DateTime.Now;
                        for (int i = 0; i < listViewBusiness.Columns.Count; i++)
                        {
                            if (listViewBusiness.Columns[i].Text == "Дата")
                            {
                                for (int j = 0; j < listViewBusiness.Items.Count; j++)
                                {
                                    if ((ListBusiness[j].DateProject - dateTime).TotalDays > DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
                                    {
                                        listViewBusiness.Items.RemoveAt(j);
                                        j--;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }

                default:
                    break;
            }
        }

        private void textBoxNewProject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBoxNewProject.Text) &&  e.KeyChar == 13))
                {
                    Form1 form = new Form1();
                    form.Text = textBoxNewProject.Text;
                    form.Show();
            }
            else if ((String.IsNullOrEmpty(textBoxNewProject.Text)))
            {
                MessageBox.Show("Введите название проэкта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewBusiness_DragEnter_1(object sender, DragEventArgs e)
        {
            var listView = sender as ListView;
            if (e.Data.GetDataPresent("System.Windows.Forms.ListView+SelectedListViewItemCollection") && e.AllowedEffect == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;

        }

        private void listViewBusiness_DragDrop(object sender, DragEventArgs e)
        {
            var listView = sender as ListView;

            var items = e.Data.GetData("System.Windows.Forms.ListView+SelectedListViewItemCollection") as ListView.SelectedListViewItemCollection;

            foreach (ListViewItem item in items)
            {
                item.ListView.Items.Remove(item);
                listView.Items.Add(item);
            }
        
        }

        private void listViewBusiness_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var listView1 = sender as ListView;

            listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Move);
        }
    }
}
