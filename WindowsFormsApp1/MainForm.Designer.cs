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
            this.PictrueBox = new System.Windows.Forms.PictureBox();
            this.DrawAllButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.rb_square = new System.Windows.Forms.RadioButton();
            this.rb_reactangle = new System.Windows.Forms.RadioButton();
            this.rb_ellipse = new System.Windows.Forms.RadioButton();
            this.rb_circle = new System.Windows.Forms.RadioButton();
            this.rb_line = new System.Windows.Forms.RadioButton();
            this.tb_x1 = new System.Windows.Forms.TextBox();
            this.tb_y1 = new System.Windows.Forms.TextBox();
            this.tb_x2 = new System.Windows.Forms.TextBox();
            this.tb_y2 = new System.Windows.Forms.TextBox();
            this.lbl_for_x1 = new System.Windows.Forms.Label();
            this.lbl_for_y1 = new System.Windows.Forms.Label();
            this.lbl_for_x2 = new System.Windows.Forms.Label();
            this.lbl_for_y2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictrueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictrueBox
            // 
            this.PictrueBox.BackColor = System.Drawing.Color.White;
            this.PictrueBox.Location = new System.Drawing.Point(12, 12);
            this.PictrueBox.Name = "PictrueBox";
            this.PictrueBox.Size = new System.Drawing.Size(600, 400);
            this.PictrueBox.TabIndex = 1;
            this.PictrueBox.TabStop = false;
            // 
            // DrawAllButton
            // 
            this.DrawAllButton.BackColor = System.Drawing.Color.MediumPurple;
            this.DrawAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrawAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawAllButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrawAllButton.Location = new System.Drawing.Point(12, 418);
            this.DrawAllButton.Name = "DrawAllButton";
            this.DrawAllButton.Size = new System.Drawing.Size(208, 72);
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
            this.ClearAllButton.Location = new System.Drawing.Point(226, 418);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(190, 72);
            this.ClearAllButton.TabIndex = 2;
            this.ClearAllButton.Text = "Очистить";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.BackColor = System.Drawing.Color.MediumPurple;
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrawButton.Location = new System.Drawing.Point(422, 418);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(190, 72);
            this.DrawButton.TabIndex = 3;
            this.DrawButton.Text = "Нарисовать";
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // rb_square
            // 
            this.rb_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_square.ForeColor = System.Drawing.Color.Indigo;
            this.rb_square.Location = new System.Drawing.Point(12, 536);
            this.rb_square.Name = "rb_square";
            this.rb_square.Size = new System.Drawing.Size(104, 24);
            this.rb_square.TabIndex = 7;
            this.rb_square.Text = "Квадрат";
            this.rb_square.CheckedChanged += new System.EventHandler(this.rb_square_CheckedChanged);
            // 
            // rb_reactangle
            // 
            this.rb_reactangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_reactangle.ForeColor = System.Drawing.Color.Indigo;
            this.rb_reactangle.Location = new System.Drawing.Point(122, 510);
            this.rb_reactangle.Name = "rb_reactangle";
            this.rb_reactangle.Size = new System.Drawing.Size(123, 24);
            this.rb_reactangle.TabIndex = 6;
            this.rb_reactangle.Text = "Прямоугольник";
            this.rb_reactangle.CheckedChanged += new System.EventHandler(this.rb_reactangle_CheckedChanged);
            // 
            // rb_ellipse
            // 
            this.rb_ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_ellipse.ForeColor = System.Drawing.Color.Indigo;
            this.rb_ellipse.Location = new System.Drawing.Point(12, 562);
            this.rb_ellipse.Name = "rb_ellipse";
            this.rb_ellipse.Size = new System.Drawing.Size(104, 24);
            this.rb_ellipse.TabIndex = 5;
            this.rb_ellipse.Text = "Эллипс";
            this.rb_ellipse.CheckedChanged += new System.EventHandler(this.rb_ellipse_CheckedChanged);
            // 
            // rb_circle
            // 
            this.rb_circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_circle.ForeColor = System.Drawing.Color.Indigo;
            this.rb_circle.Location = new System.Drawing.Point(122, 537);
            this.rb_circle.Name = "rb_circle";
            this.rb_circle.Size = new System.Drawing.Size(104, 24);
            this.rb_circle.TabIndex = 4;
            this.rb_circle.Text = "Круг";
            this.rb_circle.CheckedChanged += new System.EventHandler(this.rb_circle_CheckedChanged);
            // 
            // rb_line
            // 
            this.rb_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_line.ForeColor = System.Drawing.Color.Indigo;
            this.rb_line.Location = new System.Drawing.Point(12, 510);
            this.rb_line.Name = "rb_line";
            this.rb_line.Size = new System.Drawing.Size(104, 24);
            this.rb_line.TabIndex = 8;
            this.rb_line.Text = "Линия";
            this.rb_line.UseVisualStyleBackColor = false;
            this.rb_line.CheckedChanged += new System.EventHandler(this.rb_line_CheckedChanged);
            // 
            // tb_x1
            // 
            this.tb_x1.Location = new System.Drawing.Point(358, 540);
            this.tb_x1.Name = "tb_x1";
            this.tb_x1.Size = new System.Drawing.Size(100, 20);
            this.tb_x1.TabIndex = 8;
            // 
            // tb_y1
            // 
            this.tb_y1.Location = new System.Drawing.Point(358, 566);
            this.tb_y1.Name = "tb_y1";
            this.tb_y1.Size = new System.Drawing.Size(100, 20);
            this.tb_y1.TabIndex = 9;
            // 
            // tb_x2
            // 
            this.tb_x2.Location = new System.Drawing.Point(512, 540);
            this.tb_x2.Name = "tb_x2";
            this.tb_x2.Size = new System.Drawing.Size(100, 20);
            this.tb_x2.TabIndex = 10;
            // 
            // tb_y2
            // 
            this.tb_y2.Location = new System.Drawing.Point(512, 567);
            this.tb_y2.Name = "tb_y2";
            this.tb_y2.Size = new System.Drawing.Size(100, 20);
            this.tb_y2.TabIndex = 11;
            // 
            // lbl_for_x1
            // 
            this.lbl_for_x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_for_x1.ForeColor = System.Drawing.Color.RosyBrown;
            this.lbl_for_x1.Location = new System.Drawing.Point(335, 540);
            this.lbl_for_x1.Name = "lbl_for_x1";
            this.lbl_for_x1.Size = new System.Drawing.Size(100, 23);
            this.lbl_for_x1.TabIndex = 12;
            this.lbl_for_x1.Text = "X1";
            // 
            // lbl_for_y1
            // 
            this.lbl_for_y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_for_y1.ForeColor = System.Drawing.Color.RosyBrown;
            this.lbl_for_y1.Location = new System.Drawing.Point(334, 567);
            this.lbl_for_y1.Name = "lbl_for_y1";
            this.lbl_for_y1.Size = new System.Drawing.Size(100, 23);
            this.lbl_for_y1.TabIndex = 13;
            this.lbl_for_y1.Text = "Y1";
            // 
            // lbl_for_x2
            // 
            this.lbl_for_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_for_x2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_for_x2.Location = new System.Drawing.Point(487, 541);
            this.lbl_for_x2.Name = "lbl_for_x2";
            this.lbl_for_x2.Size = new System.Drawing.Size(100, 23);
            this.lbl_for_x2.TabIndex = 14;
            this.lbl_for_x2.Text = "X2";
            // 
            // lbl_for_y2
            // 
            this.lbl_for_y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_for_y2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_for_y2.Location = new System.Drawing.Point(486, 568);
            this.lbl_for_y2.Name = "lbl_for_y2";
            this.lbl_for_y2.Size = new System.Drawing.Size(101, 17);
            this.lbl_for_y2.TabIndex = 15;
            this.lbl_for_y2.Text = "Y2";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(624, 607);
            this.Controls.Add(this.DrawAllButton);
            this.Controls.Add(this.PictrueBox);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.rb_circle);
            this.Controls.Add(this.rb_ellipse);
            this.Controls.Add(this.rb_reactangle);
            this.Controls.Add(this.rb_square);
            this.Controls.Add(this.rb_line);
            this.Controls.Add(this.tb_x1);
            this.Controls.Add(this.tb_y1);
            this.Controls.Add(this.tb_x2);
            this.Controls.Add(this.tb_y2);
            this.Controls.Add(this.lbl_for_x1);
            this.Controls.Add(this.lbl_for_y1);
            this.Controls.Add(this.lbl_for_x2);
            this.Controls.Add(this.lbl_for_y2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.PictrueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictrueBox;
        private System.Windows.Forms.Button DrawAllButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.RadioButton rb_square;
        private System.Windows.Forms.RadioButton rb_reactangle;
        private System.Windows.Forms.RadioButton rb_ellipse;
        private System.Windows.Forms.RadioButton rb_circle;
        private System.Windows.Forms.RadioButton rb_line;
        private System.Windows.Forms.TextBox tb_x1;
        private System.Windows.Forms.TextBox tb_y1;
        private System.Windows.Forms.TextBox tb_x2;
        private System.Windows.Forms.TextBox tb_y2;
        private System.Windows.Forms.Label lbl_for_x1;
        private System.Windows.Forms.Label lbl_for_y1;
        private System.Windows.Forms.Label lbl_for_x2;
        private System.Windows.Forms.Label lbl_for_y2;
    }
}

