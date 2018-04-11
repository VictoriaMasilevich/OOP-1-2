namespace Geometry
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.DrawAllButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.rb_square = new System.Windows.Forms.RadioButton();
            this.rb_reactangle = new System.Windows.Forms.RadioButton();
            this.rb_ellipse = new System.Windows.Forms.RadioButton();
            this.rb_circle = new System.Windows.Forms.RadioButton();
            this.rb_line = new System.Windows.Forms.RadioButton();
            this.listbx = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(600, 400);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // DrawAllButton
            // 
            this.DrawAllButton.BackColor = System.Drawing.Color.MediumPurple;
            this.DrawAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrawAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawAllButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrawAllButton.Location = new System.Drawing.Point(12, 418);
            this.DrawAllButton.Name = "DrawAllButton";
            this.DrawAllButton.Size = new System.Drawing.Size(300, 70);
            this.DrawAllButton.TabIndex = 0;
            this.DrawAllButton.Text = "Нарисовать все фигуры";
            this.DrawAllButton.UseVisualStyleBackColor = false;
            this.DrawAllButton.Click += new System.EventHandler(this.DrawAllButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.MediumPurple;
            this.ClearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAllButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearAllButton.Location = new System.Drawing.Point(312, 418);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(300, 70);
            this.ClearAllButton.TabIndex = 2;
            this.ClearAllButton.Text = "Очистить";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // rb_square
            // 
            this.rb_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_square.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rb_square.Location = new System.Drawing.Point(12, 523);
            this.rb_square.Name = "rb_square";
            this.rb_square.Size = new System.Drawing.Size(104, 24);
            this.rb_square.TabIndex = 7;
            this.rb_square.Text = "Квадрат";
            this.rb_square.CheckedChanged += new System.EventHandler(this.rb_square_CheckedChanged);
            // 
            // rb_reactangle
            // 
            this.rb_reactangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_reactangle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rb_reactangle.Location = new System.Drawing.Point(163, 497);
            this.rb_reactangle.Name = "rb_reactangle";
            this.rb_reactangle.Size = new System.Drawing.Size(123, 24);
            this.rb_reactangle.TabIndex = 6;
            this.rb_reactangle.Text = "Прямоугольник";
            this.rb_reactangle.CheckedChanged += new System.EventHandler(this.rb_reactangle_CheckedChanged);
            // 
            // rb_ellipse
            // 
            this.rb_ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_ellipse.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rb_ellipse.Location = new System.Drawing.Point(12, 549);
            this.rb_ellipse.Name = "rb_ellipse";
            this.rb_ellipse.Size = new System.Drawing.Size(104, 24);
            this.rb_ellipse.TabIndex = 5;
            this.rb_ellipse.Text = "Эллипс";
            this.rb_ellipse.CheckedChanged += new System.EventHandler(this.rb_ellipse_CheckedChanged);
            // 
            // rb_circle
            // 
            this.rb_circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_circle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rb_circle.Location = new System.Drawing.Point(163, 523);
            this.rb_circle.Name = "rb_circle";
            this.rb_circle.Size = new System.Drawing.Size(104, 24);
            this.rb_circle.TabIndex = 4;
            this.rb_circle.Text = "Круг";
            this.rb_circle.CheckedChanged += new System.EventHandler(this.rb_circle_CheckedChanged);
            // 
            // rb_line
            // 
            this.rb_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_line.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rb_line.Location = new System.Drawing.Point(12, 497);
            this.rb_line.Name = "rb_line";
            this.rb_line.Size = new System.Drawing.Size(104, 24);
            this.rb_line.TabIndex = 8;
            this.rb_line.Text = "Линия";
            this.rb_line.UseVisualStyleBackColor = false;
            this.rb_line.CheckedChanged += new System.EventHandler(this.rb_line_CheckedChanged);
            // 
            // listbx
            // 
            this.listbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listbx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listbx.ItemHeight = 16;
            this.listbx.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green",
            "Orange",
            "Yellow",
            "Brown",
            "Pink"});
            this.listbx.Location = new System.Drawing.Point(312, 497);
            this.listbx.Name = "listbx";
            this.listbx.Size = new System.Drawing.Size(300, 84);
            this.listbx.TabIndex = 16;
            this.listbx.SelectedIndexChanged += new System.EventHandler(this.listbx_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(624, 590);
            this.Controls.Add(this.DrawAllButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.rb_circle);
            this.Controls.Add(this.rb_ellipse);
            this.Controls.Add(this.rb_reactangle);
            this.Controls.Add(this.rb_square);
            this.Controls.Add(this.rb_line);
            this.Controls.Add(this.listbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button DrawAllButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.RadioButton rb_square;
        private System.Windows.Forms.RadioButton rb_reactangle;
        private System.Windows.Forms.RadioButton rb_ellipse;
        private System.Windows.Forms.RadioButton rb_circle;
        private System.Windows.Forms.RadioButton rb_line;
        private System.Windows.Forms.ListBox listbx;
    }
}

