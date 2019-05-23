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
        TimeSpan ts = new TimeSpan();
        DateTime dt = new DateTime();
        public string NameProject { get { return textBoxNameProject.Text; } }
        public DateTimePicker DateProject { get { return dateTimePickerDate; } }
        public DateTime TimeProject { get { return DateTime.Parse($"{textBoxTimeHour.Text}:{textBoxTimeMinute}"); } }
        public string PriorityProject { get { return comboBoxPriority.Text; } }
        public string TagsProject { get { return comboBoxTag.Text; } }
        public string CommentsProject { get { return textBoxComments.Text; } }

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
            this.DialogResult = DialogResult.OK;
            this.Close();
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

            }
        }

        private void textBoxTimeHour_TabIndexChanged(object sender, EventArgs e)
        {
            textBoxTimeHour.TabIndex = 0;
            textBoxTimeMinute.TabIndex = 1;
        }
    }
}
