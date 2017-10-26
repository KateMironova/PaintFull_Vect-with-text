namespace PaintFull_Vect.Controls
{
    partial class PDraw
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
            this.pictBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBox
            // 
            this.pictBox.BackColor = System.Drawing.Color.White;
            this.pictBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBox.Location = new System.Drawing.Point(0, 0);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(150, 150);
            this.pictBox.TabIndex = 0;
            this.pictBox.TabStop = false;
            this.pictBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictBox_MouseDown);
            this.pictBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictBox_MouseMove);
            this.pictBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictBox_MouseUp);
            // 
            // PDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictBox);
            this.Name = "PDraw";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictBox;
    }
}
