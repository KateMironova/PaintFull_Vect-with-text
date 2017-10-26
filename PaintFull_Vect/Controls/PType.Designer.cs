namespace PaintFull_Vect.Controls
{
    partial class PType
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
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "Line",
            "Ellipse",
            "Rectangle",
            "RoundRectangle"});
            this.cBoxType.Location = new System.Drawing.Point(3, 16);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(101, 21);
            this.cBoxType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type:";
            // 
            // PType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBoxType);
            this.Controls.Add(this.label2);
            this.Name = "PType";
            this.Size = new System.Drawing.Size(106, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.Label label2;
    }
}
