namespace TaskManager.View.Forms
{
    partial class UserInputTaskForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            DescriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            StartDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            DueDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            CategoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            SaveButton = new Guna.UI2.WinForms.Guna2Button();
            CancelButton = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(103, 36);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Add new Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 1;
            label2.Text = "Task description";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BorderRadius = 12;
            DescriptionTextBox.CustomizableEdges = customizableEdges1;
            DescriptionTextBox.DefaultText = "";
            DescriptionTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DescriptionTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DescriptionTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DescriptionTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DescriptionTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DescriptionTextBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DescriptionTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DescriptionTextBox.Location = new Point(12, 135);
            DescriptionTextBox.Margin = new Padding(5);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderForeColor = Color.Silver;
            DescriptionTextBox.PlaceholderText = "Enter task description";
            DescriptionTextBox.SelectedText = "";
            DescriptionTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DescriptionTextBox.Size = new Size(357, 55);
            DescriptionTextBox.TabIndex = 2;
            // 
            // StartDateTimePicker
            // 
            StartDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StartDateTimePicker.Animated = true;
            StartDateTimePicker.BorderRadius = 12;
            StartDateTimePicker.Checked = true;
            StartDateTimePicker.CustomizableEdges = customizableEdges3;
            StartDateTimePicker.FillColor = Color.Lavender;
            StartDateTimePicker.Font = new Font("Segoe UI", 9F);
            StartDateTimePicker.Format = DateTimePickerFormat.Long;
            StartDateTimePicker.Location = new Point(12, 248);
            StartDateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            StartDateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            StartDateTimePicker.Name = "StartDateTimePicker";
            StartDateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges4;
            StartDateTimePicker.Size = new Size(255, 36);
            StartDateTimePicker.TabIndex = 3;
            StartDateTimePicker.Value = new DateTime(2026, 2, 26, 16, 56, 42, 366);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 220);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 4;
            label3.Text = "Start date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 322);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 6;
            label4.Text = "Due date";
            // 
            // DueDateTimePicker
            // 
            DueDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DueDateTimePicker.Animated = true;
            DueDateTimePicker.BorderRadius = 12;
            DueDateTimePicker.Checked = true;
            DueDateTimePicker.CustomizableEdges = customizableEdges5;
            DueDateTimePicker.FillColor = Color.Lavender;
            DueDateTimePicker.Font = new Font("Segoe UI", 9F);
            DueDateTimePicker.Format = DateTimePickerFormat.Long;
            DueDateTimePicker.Location = new Point(12, 350);
            DueDateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DueDateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DueDateTimePicker.Name = "DueDateTimePicker";
            DueDateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DueDateTimePicker.Size = new Size(255, 36);
            DueDateTimePicker.TabIndex = 5;
            DueDateTimePicker.Value = new DateTime(2026, 2, 26, 16, 56, 42, 366);
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.BackColor = Color.Transparent;
            CategoryComboBox.BorderColor = Color.FromArgb(64, 64, 64);
            CategoryComboBox.BorderRadius = 12;
            CategoryComboBox.CustomizableEdges = customizableEdges7;
            CategoryComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            CategoryComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CategoryComboBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CategoryComboBox.ForeColor = Color.FromArgb(64, 64, 64);
            CategoryComboBox.ItemHeight = 30;
            CategoryComboBox.Items.AddRange(new object[] { "General", "Personal", "Work", "School", "Health", "Shopping" });
            CategoryComboBox.Location = new Point(12, 448);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            CategoryComboBox.Size = new Size(195, 36);
            CategoryComboBox.StartIndex = 0;
            CategoryComboBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 424);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 8;
            label5.Text = "Category";
            // 
            // SaveButton
            // 
            SaveButton.BorderRadius = 20;
            SaveButton.BorderThickness = 1;
            SaveButton.CustomizableEdges = customizableEdges9;
            SaveButton.DisabledState.BorderColor = Color.DarkGray;
            SaveButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SaveButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SaveButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SaveButton.FillColor = Color.Transparent;
            SaveButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SaveButton.ForeColor = Color.Black;
            SaveButton.Location = new Point(295, 520);
            SaveButton.Name = "SaveButton";
            SaveButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            SaveButton.Size = new Size(78, 45);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            // 
            // CancelButton
            // 
            CancelButton.BorderRadius = 20;
            CancelButton.BorderThickness = 1;
            CancelButton.CustomizableEdges = customizableEdges11;
            CancelButton.DisabledState.BorderColor = Color.DarkGray;
            CancelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CancelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CancelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CancelButton.FillColor = Color.Transparent;
            CancelButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(211, 520);
            CancelButton.Name = "CancelButton";
            CancelButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            CancelButton.Size = new Size(78, 45);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.Click += CancelButton_Click;
            // 
            // UserInputTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(385, 595);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(label5);
            Controls.Add(CategoryComboBox);
            Controls.Add(label4);
            Controls.Add(DueDateTimePicker);
            Controls.Add(label3);
            Controls.Add(StartDateTimePicker);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserInputTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserInputTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox DescriptionTextBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartDateTimePicker;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DueDateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox CategoryComboBox;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
    }
}