namespace PaintFull_Vect.Controls
{
    partial class PColor
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
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(0, 0);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(101, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // PColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnColor);
            this.Name = "PColor";
            this.Size = new System.Drawing.Size(102, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
    }
}
