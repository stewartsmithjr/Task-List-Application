namespace Task_List_App
{
    partial class taskDetailsForm
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
            this.taskDetailsListBox = new System.Windows.Forms.ListBox();
            this.taskDetailsTextBox = new System.Windows.Forms.TextBox();
            this.taskLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.catagoryLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.completeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // taskDetailsListBox
            // 
            this.taskDetailsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDetailsListBox.FormattingEnabled = true;
            this.taskDetailsListBox.Location = new System.Drawing.Point(12, 19);
            this.taskDetailsListBox.Name = "taskDetailsListBox";
            this.taskDetailsListBox.Size = new System.Drawing.Size(579, 602);
            this.taskDetailsListBox.TabIndex = 0;
            this.taskDetailsListBox.SelectedIndexChanged += new System.EventHandler(this.textDetailsListBox_SelectedIndexChanged);
            // 
            // taskDetailsTextBox
            // 
            this.taskDetailsTextBox.Location = new System.Drawing.Point(610, 72);
            this.taskDetailsTextBox.Name = "taskDetailsTextBox";
            this.taskDetailsTextBox.Size = new System.Drawing.Size(178, 20);
            this.taskDetailsTextBox.TabIndex = 1;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(607, 56);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(34, 13);
            this.taskLabel.TabIndex = 2;
            this.taskLabel.Text = "Task:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(607, 138);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(607, 229);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(33, 13);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time:";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(610, 246);
            this.timeTextBox.Mask = "90:00";
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(178, 20);
            this.timeTextBox.TabIndex = 7;
            this.timeTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(610, 155);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // catagoryLabel
            // 
            this.catagoryLabel.AutoSize = true;
            this.catagoryLabel.Location = new System.Drawing.Point(607, 328);
            this.catagoryLabel.Name = "catagoryLabel";
            this.catagoryLabel.Size = new System.Drawing.Size(52, 13);
            this.catagoryLabel.TabIndex = 9;
            this.catagoryLabel.Text = "Category:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(610, 354);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.ReadOnly = true;
            this.colorTextBox.Size = new System.Drawing.Size(178, 20);
            this.colorTextBox.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(610, 440);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(610, 469);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(610, 553);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(610, 583);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(610, 380);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 15;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // completeCheckBox
            // 
            this.completeCheckBox.AutoSize = true;
            this.completeCheckBox.Location = new System.Drawing.Point(610, 273);
            this.completeCheckBox.Name = "completeCheckBox";
            this.completeCheckBox.Size = new System.Drawing.Size(70, 17);
            this.completeCheckBox.TabIndex = 16;
            this.completeCheckBox.Text = "Complete";
            this.completeCheckBox.UseVisualStyleBackColor = true;
            // 
            // taskDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.completeCheckBox);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.catagoryLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.taskDetailsTextBox);
            this.Controls.Add(this.taskDetailsListBox);
            this.Name = "taskDetailsForm";
            this.Text = "taskDetailsForm";
            this.Load += new System.EventHandler(this.taskDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox taskDetailsListBox;
        private System.Windows.Forms.TextBox taskDetailsTextBox;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.MaskedTextBox timeTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label catagoryLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.CheckBox completeCheckBox;
    }
}