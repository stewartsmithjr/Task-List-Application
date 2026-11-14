/*
 * 
 * ‘Affirmation of Authorship:

‘Name:Stewart Smith Jr

‘Date: 10/11/2026

‘I affirm that this program was created by me. It is solely my work and ‘does not include any work done by anyone else.
 * 
 * 
 * */
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

namespace Task_List_App
{
    public partial class taskListForm : Form
    {
        taskDetailsForm taskDetailsForm;
        public taskListForm()
        {
            InitializeComponent();

            taskDetailsForm = new taskDetailsForm(this);
        }

        public string currentFileName;
        public string currentFilePath;
        void CreateFileDetails(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a file name.", "Missing File Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("The file name contains invalid characters.", "Invalid File Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();

                currentFilePath = Path.Combine(currentDirectory, fileName + ".txt");

                using (StreamWriter writer = new StreamWriter(currentFilePath, false))
                {
                }

                currentFileName = fileName;

                if (!filesListBox.Items.Contains(currentFilePath))
                {
                    filesListBox.Items.Add(currentFilePath);
                }

                taskDetailsForm.taskInfo.Clear();
                taskDetailsForm.UpdateTaskDetailsListBox();

                taskDetailsForm.ShowDialog();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have permission to create a file in this folder.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not create the file: " + ex.Message,
                    "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void OpenFileDetails()
        {
            try
            {
                openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Filter = "Text files (*.txt)|*.txt";

                var result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog1.FileName;

                    taskDetailsForm.taskInfo.Clear();

                    using (StreamReader reader = new StreamReader(new FileStream(selectedFileName, FileMode.Open, FileAccess.Read)))
                    {
                        string fileContent;

                        while ((fileContent = reader.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(fileContent))
                            {
                                continue;
                            }

                            string taskName;
                            string taskDueDate;
                            bool taskComplete;
                            string taskColor;

                            string[] substring = fileContent.Split(',');

                            if (substring.Length < 4)
                            {
                                continue;
                            }

                            taskName = substring[0].Trim();

                            taskDueDate = substring[1].Trim();
                            taskComplete = bool.Parse(substring[2].Trim());
                            taskColor = substring[3].Trim();

                            taskDetailsForm.taskInfo.Add((taskName, DateTime.Parse(taskDueDate), taskComplete, taskColor));
                        }
                    }

                    currentFilePath = selectedFileName;
                    currentFileName = Path.GetFileNameWithoutExtension(selectedFileName);
                    fileNameTextBox.Text = currentFileName;

                    if (!filesListBox.Items.Contains(selectedFileName))
                    {
                        filesListBox.Items.Add(selectedFileName);
                    }

                    taskDetailsForm.UpdateTaskDetailsListBox();

                    taskDetailsForm.ShowDialog();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file could not be found.", "File Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The folder could not be found.", "Folder Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have permission to open this file.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("The file has a date or true/false value that couldn't be read.",
                    "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not read the file: " + ex.Message, "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            CreateFileDetails(fileNameTextBox.Text);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDetails();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}