namespace PaintFull_Vect.Controls
{
    partial class PWidth
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
            this.cBoxWidth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBoxWidth
            // 
            this.cBoxWidth.FormattingEnabled = true;
            this.cBoxWidth.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.cBoxWidth.Location = new System.Drawing.Point(3, 16);
            this.cBoxWidth.Name = "cBoxWidth";
            this.cBoxWidth.Size = new System.Drawing.Size(101, 21);
            this.cBoxWidth.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width:";
            // 
            // PWidth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBoxWidth);
            this.Controls.Add(this.label1);
            this.Name = "PWidth";
            this.Size = new System.Drawing.Size(106, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxWidth;
        private System.Windows.Forms.Label label1;
    }
}
