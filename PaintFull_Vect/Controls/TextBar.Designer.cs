namespace PaintFull_Vect.Controls
{
    partial class TextBar
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
            this.SetText = new System.Windows.Forms.TextBox();
            this.btnColorTxt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboAngleTxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboAlignTxt = new System.Windows.Forms.ComboBox();
            this.btnSetTxt = new System.Windows.Forms.Button();
            this.btnFontTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetText
            // 
            this.SetText.Location = new System.Drawing.Point(7, 3);
            this.SetText.Name = "SetText";
            this.SetText.Size = new System.Drawing.Size(95, 20);
            this.SetText.TabIndex = 0;
            // 
            // btnColorTxt
            // 
            this.btnColorTxt.Location = new System.Drawing.Point(9, 70);
            this.btnColorTxt.Name = "btnColorTxt";
            this.btnColorTxt.Size = new System.Drawing.Size(95, 23);
            this.btnColorTxt.TabIndex = 2;
            this.btnColorTxt.Text = "Color";
            this.btnColorTxt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Angle:";
            // 
            // comboAngleTxt
            // 
            this.comboAngleTxt.FormattingEnabled = true;
            this.comboAngleTxt.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "180"});
            this.comboAngleTxt.Location = new System.Drawing.Point(43, 194);
            this.comboAngleTxt.Name = "comboAngleTxt";
            this.comboAngleTxt.Size = new System.Drawing.Size(61, 21);
            this.comboAngleTxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Align:";
            // 
            // comboAlignTxt
            // 
            this.comboAlignTxt.FormattingEnabled = true;
            this.comboAlignTxt.Items.AddRange(new object[] {
            "Center",
            "Top",
            "Bottom",
            "Left",
            "Right"});
            this.comboAlignTxt.Location = new System.Drawing.Point(14, 162);
            this.comboAlignTxt.Name = "comboAlignTxt";
            this.comboAlignTxt.Size = new System.Drawing.Size(90, 21);
            this.comboAlignTxt.TabIndex = 10;
            // 
            // btnSetTxt
            // 
            this.btnSetTxt.Location = new System.Drawing.Point(9, 29);
            this.btnSetTxt.Name = "btnSetTxt";
            this.btnSetTxt.Size = new System.Drawing.Size(93, 23);
            this.btnSetTxt.TabIndex = 11;
            this.btnSetTxt.Text = "Set text";
            this.btnSetTxt.UseVisualStyleBackColor = true;
            // 
            // btnFontTxt
            // 
            this.btnFontTxt.Location = new System.Drawing.Point(10, 111);
            this.btnFontTxt.Name = "btnFontTxt";
            this.btnFontTxt.Size = new System.Drawing.Size(94, 23);
            this.btnFontTxt.TabIndex = 12;
            this.btnFontTxt.Text = "Font";
            this.btnFontTxt.UseVisualStyleBackColor = true;
            // 
            // TextBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFontTxt);
            this.Controls.Add(this.btnSetTxt);
            this.Controls.Add(this.comboAlignTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboAngleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnColorTxt);
            this.Controls.Add(this.SetText);
            this.Name = "TextBar";
            this.Size = new System.Drawing.Size(107, 231);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SetText;
        private System.Windows.Forms.Button btnColorTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboAngleTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAlignTxt;
        private System.Windows.Forms.Button btnSetTxt;
        private System.Windows.Forms.Button btnFontTxt;
    }
}
