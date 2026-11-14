using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Task_List_App
{
    public partial class taskDetailsForm : Form
    {
        taskListForm taskListForm;

        public List<(string strName, DateTime dtDueDateTime, bool blnComplete, string strCategory)> taskInfo = new List<(string strName, DateTime dtDueDateTime, bool blnComplete, string strCategory)>();
        string currentFileName;
        string currentFilePath;
        public taskDetailsForm(taskListForm taskListForm)
        {
            InitializeComponent();
            this.taskListForm = taskListForm;
        }
        public void UpdateTaskDetailsListBox()
        {
            taskDetailsListBox.Items.Clear();
            foreach (var item in taskInfo)
            {
                taskDetailsListBox.Items.Add($"{item.strName}, {item.dtDueDateTime:MM/dd/yyyy}, {item.dtDueDateTime:HH:mm}, {item.blnComplete}, {item.strCategory}");
            }
        }
        private void taskDetailsForm_Load(object sender, EventArgs e)
        {
            currentFileName = taskListForm.currentFileName;
            currentFilePath = taskListForm.currentFilePath;

            UpdateTaskDetailsListBox();
        }




        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            var selectColorDialog1 = colorDialog1.ShowDialog();

            if (selectColorDialog1 == DialogResult.OK)
            {
                colorTextBox.Text = colorDialog1.Color.Name;
            }
        }

        private void textDetailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskDetailsListBox.SelectedItem == null) return;

            String[] splitString = taskDetailsListBox.SelectedItem.ToString().Split(',');

            string taskName = splitString[0].Trim();


            DateTime taskDueDate = DateTime.Parse(splitString[1].Trim());

            String taskDueTime = DateTime.Parse(splitString[2].Trim()).ToString("HH:mm");
            bool taskComplete = bool.Parse(splitString[3].Trim());
            string taskCategory = splitString[4].Trim();

            taskDetailsTextBox.Text = taskName;
            dateTimePicker.Value = taskDueDate;
            timeTextBox.Text = taskDueTime.ToString();
            completeCheckBox.Checked = taskComplete;
            colorTextBox.Text = taskCategory;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse(timeTextBox.Text);
            DateTime dateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, time.Hour, time.Minute, 0);
            taskInfo.Add((taskDetailsTextBox.Text, dateTime, completeCheckBox.Checked, colorTextBox.Text));

            UpdateTaskDetailsListBox();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = taskDetailsListBox.SelectedIndex;
            if (selectedIndex < 0) return;
            taskInfo.RemoveAt(selectedIndex);
            UpdateTaskDetailsListBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            taskInfo.Clear();
            this.Close();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            currentFilePath = taskListForm.currentFilePath;

            Debug.WriteLine("Saving task details to file: " + currentFilePath);
            using (StreamWriter writer = new StreamWriter(new FileStream(currentFilePath, FileMode.Create, FileAccess.Write)))
            {
                foreach (var item in taskInfo)
                {
                    writer.WriteLine($"{item.strName}, {item.dtDueDateTime}, {item.blnComplete}, {item.strCategory}");

                    Debug.WriteLine("Saved task: " + item.strName + ", " + item.dtDueDateTime + ", " + item.blnComplete + ", " + item.strCategory);
                }
            }

            taskInfo.Clear();
            this.Close();
        }
    }
}