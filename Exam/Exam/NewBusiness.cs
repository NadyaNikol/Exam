using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class NewBusiness : Form
    {
        TimeSpan ts ;
        public string path = "-";
        public string NameProject { get { return textBoxNameProject.Text; } }
        public DateTime DateProject { get { return dateTimePickerDate.Value.Date; } }
        public TimeSpan TimeProject { get { return ts; } }
        public string PriorityProject { get { return comboBoxPriority.Text; } }
        public string TagsProject { get { return comboBoxTag.Text; } }
        public string CommentsProject { get { return textBoxComments.Text; } }
        public string pathFile { get { return path; } }

        public NewBusiness()
        {
            InitializeComponent();

            comboBoxPriority.Items.Add("Низкий");
            comboBoxPriority.Items.Add("Средний");
            comboBoxPriority.Items.Add("Высокий");
            comboBoxPriority.SelectedIndex = 0;

            comboBoxTag.Items.Add("Деловые");
            comboBoxTag.Items.Add("Бизнес");
            comboBoxTag.Items.Add("Домашние");
            comboBoxTag.Items.Add("Учебные");
            comboBoxTag.Items.Add("Другие");
            comboBoxTag.SelectedIndex = 0;


        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool IsEmpty = false;
            foreach (Control item in this.Controls)
            {
                if (!String.IsNullOrEmpty( item.Text))
                {
                    MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    IsEmpty = true;
                    break;
                }
            }

            if (!IsEmpty)
            {
                ts = new TimeSpan(Convert.ToInt32(textBoxTimeHour.Text), Convert.ToInt32(textBoxTimeMinute.Text), 0);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTimeHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBoxTimeHour_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxTimeHour.Text) < 0 || Convert.ToInt32(textBoxTimeHour.Text) > 23)
                {
                    textBoxTimeHour.Text = "";
                }

                else if (textBoxTimeHour.Text.Length > 2)
                {
                    textBoxTimeHour.Text = textBoxTimeHour.Text.Remove(2);
                }
            }
            catch { }
        }

        private void textBoxTimeMinute_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxTimeMinute.Text) < 0 || Convert.ToInt32(textBoxTimeMinute.Text) > 59)
                {
                    textBoxTimeMinute.Text = "";
                }

                if (textBoxTimeMinute.Text.Length > 2 )
                {
                    textBoxTimeMinute.Text = textBoxTimeMinute.Text.Remove(2);
                }

            }
            catch { }
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All file(*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
            }
        }

        private void textBoxTimeHour_TabIndexChanged(object sender, EventArgs e)
        {
            textBoxTimeHour.TabIndex = 0;
            textBoxTimeMinute.TabIndex = 1;
        }

        private void comboBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTag.Text == "Другие")
            {
                textBoxNewTag.Visible = true;
                buttonAdd.Visible = true;
            }
            else
            {
                textBoxNewTag.Visible = false;
                buttonAdd.Visible = false;
            }
        }

        private void textBoxNewTag_Click(object sender, EventArgs e)
        {
            textBoxNewTag.Text = "";
            buttonAdd.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxNewTag.Text))
            {
                comboBoxTag.Items.Add(textBoxNewTag.Text);
                var tmp = comboBoxTag.Items[comboBoxTag.Items.Count - 1];
                comboBoxTag.Items[comboBoxTag.Items.Count - 1] = comboBoxTag.Items[comboBoxTag.Items.Count - 2];
                comboBoxTag.Items[comboBoxTag.Items.Count - 2] = tmp;
            }
            
        }

    }
}
