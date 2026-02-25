namespace TaskManager.Data.Controllers
{
    partial class TaskController
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            StatusLabel = new Label();
            TickBox = new Guna.UI2.WinForms.Guna2CheckBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 8;
            guna2Panel1.Controls.Add(TickBox);
            guna2Panel1.Controls.Add(StatusLabel);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(guna2CircleProgressBar1);
            guna2Panel1.CustomizableEdges = customizableEdges2;
            guna2Panel1.FillColor = Color.DarkSlateGray;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel1.Size = new Size(1341, 80);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.FillColor = Color.Yellow;
            guna2CircleProgressBar1.FillThickness = 5;
            guna2CircleProgressBar1.Font = new Font("Segoe UI", 12F);
            guna2CircleProgressBar1.ForeColor = Color.White;
            guna2CircleProgressBar1.Location = new Point(85, 16);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressColor = Color.Yellow;
            guna2CircleProgressBar1.ProgressColor2 = Color.FromArgb(255, 128, 0);
            guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            guna2CircleProgressBar1.ProgressThickness = 3;
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new Size(47, 47);
            guna2CircleProgressBar1.TabIndex = 8;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.Value = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(151, 27);
            label1.Name = "label1";
            label1.Size = new Size(360, 30);
            label1.TabIndex = 9;
            label1.Text = "Learn C# programming(preposition)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(582, 27);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 10;
            label2.Text = "25-02-2026";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(764, 27);
            label3.Name = "label3";
            label3.Size = new Size(125, 30);
            label3.TabIndex = 11;
            label3.Text = "25-02-2026";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(951, 27);
            label4.Name = "label4";
            label4.Size = new Size(93, 30);
            label4.TabIndex = 12;
            label4.Text = "Personal";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StatusLabel.ForeColor = Color.Yellow;
            StatusLabel.Location = new Point(1181, 27);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(105, 30);
            StatusLabel.TabIndex = 13;
            StatusLabel.Text = "Pending...";
            // 
            // TickBox
            // 
            TickBox.Animated = true;
            TickBox.AutoSize = true;
            TickBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            TickBox.CheckedState.BorderRadius = 0;
            TickBox.CheckedState.BorderThickness = 0;
            TickBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            TickBox.Location = new Point(30, 27);
            TickBox.Name = "TickBox";
            TickBox.Size = new Size(15, 14);
            TickBox.TabIndex = 14;
            TickBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            TickBox.UncheckedState.BorderRadius = 0;
            TickBox.UncheckedState.BorderThickness = 0;
            TickBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // TaskController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "TaskController";
            Size = new Size(1341, 80);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2CheckBox TickBox;
        private Label StatusLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
