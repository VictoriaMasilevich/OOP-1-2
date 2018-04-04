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
            this.pictrueDrawing = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pictrueDrawing
            // 
            this.pictrueDrawing.BackColor = System.Drawing.Color.White;
            this.pictrueDrawing.Location = new System.Drawing.Point(12, 12);
            this.pictrueDrawing.Name = "pictrueDrawing";
            this.pictrueDrawing.Size = new System.Drawing.Size(600, 400);
            this.pictrueDrawing.TabIndex = 1;
            this.pictrueDrawing.TabStop = false;
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.drawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawButton.Location = new System.Drawing.Point(12, 430);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(130, 60);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Нарисовать все фигуры";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(624, 502);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.pictrueDrawing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            //this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictrueDrawing)).EndInit();
            //this.ResumeLayout(false);
            //this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictrueDrawing;
        private System.Windows.Forms.Button drawButton;
    }
}

