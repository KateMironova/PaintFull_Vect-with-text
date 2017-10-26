namespace PaintFull_Vect.Controls
{
    partial class PPanel
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
            this.pMenu1 = new PaintFull_Vect.Controls.PMenu();
            this.pToolStrip1 = new PaintFull_Vect.Controls.PToolStrip();
            this.pColor1 = new PaintFull_Vect.Controls.PColor();
            this.pWidth1 = new PaintFull_Vect.Controls.PWidth();
            this.pType1 = new PaintFull_Vect.Controls.PType();
            this.pSave1 = new PaintFull_Vect.Controls.PSave();
            this.pLoad1 = new PaintFull_Vect.Controls.PLoad();
            this.textBar1 = new PaintFull_Vect.Controls.TextBar();
            this.pStatusStrip1 = new PaintFull_Vect.Controls.PStatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // pMenu1
            // 
            this.pMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu1.Location = new System.Drawing.Point(0, 0);
            this.pMenu1.Name = "pMenu1";
            this.pMenu1.Size = new System.Drawing.Size(924, 24);
            this.pMenu1.TabIndex = 0;
            this.pMenu1.xcom = null;
            // 
            // pToolStrip1
            // 
            this.pToolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.pToolStrip1.Name = "pToolStrip1";
            this.pToolStrip1.Size = new System.Drawing.Size(924, 27);
            this.pToolStrip1.TabIndex = 1;
            this.pToolStrip1.xcom = null;
            // 
            // pColor1
            // 
            this.pColor1.Location = new System.Drawing.Point(3, 47);
            this.pColor1.Name = "pColor1";
            this.pColor1.Size = new System.Drawing.Size(102, 23);
            this.pColor1.TabIndex = 2;
            this.pColor1.xcom = null;
            // 
            // pWidth1
            // 
            this.pWidth1.Location = new System.Drawing.Point(3, 77);
            this.pWidth1.Name = "pWidth1";
            this.pWidth1.Size = new System.Drawing.Size(106, 40);
            this.pWidth1.TabIndex = 3;
            this.pWidth1.xcom = null;
            // 
            // pType1
            // 
            this.pType1.Location = new System.Drawing.Point(3, 112);
            this.pType1.Name = "pType1";
            this.pType1.Size = new System.Drawing.Size(106, 39);
            this.pType1.TabIndex = 4;
            this.pType1.xcom = null;
            // 
            // pSave1
            // 
            this.pSave1.Location = new System.Drawing.Point(4, 158);
            this.pSave1.Name = "pSave1";
            this.pSave1.Size = new System.Drawing.Size(100, 23);
            this.pSave1.TabIndex = 5;
            this.pSave1.xcom = null;
            // 
            // pLoad1
            // 
            this.pLoad1.Location = new System.Drawing.Point(4, 188);
            this.pLoad1.Name = "pLoad1";
            this.pLoad1.Size = new System.Drawing.Size(100, 24);
            this.pLoad1.TabIndex = 6;
            this.pLoad1.xcom = null;
            // 
            // textBar1
            // 
            this.textBar1.data = null;
            this.textBar1.Location = new System.Drawing.Point(3, 219);
            this.textBar1.Name = "textBar1";
            this.textBar1.Size = new System.Drawing.Size(107, 231);
            this.textBar1.TabIndex = 7;
            this.textBar1.xcom = null;
            // 
            // pStatusStrip1
            // 
            this.pStatusStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pStatusStrip1.Location = new System.Drawing.Point(0, 450);
            this.pStatusStrip1.Name = "pStatusStrip1";
            this.pStatusStrip1.Size = new System.Drawing.Size(924, 22);
            this.pStatusStrip1.TabIndex = 8;
            this.pStatusStrip1.xcom = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(110, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 403);
            this.tabControl1.TabIndex = 9;
            // 
            // PPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pStatusStrip1);
            this.Controls.Add(this.textBar1);
            this.Controls.Add(this.pLoad1);
            this.Controls.Add(this.pSave1);
            this.Controls.Add(this.pType1);
            this.Controls.Add(this.pWidth1);
            this.Controls.Add(this.pColor1);
            this.Controls.Add(this.pToolStrip1);
            this.Controls.Add(this.pMenu1);
            this.Name = "PPanel";
            this.Size = new System.Drawing.Size(924, 472);
            this.ResumeLayout(false);

        }


        #endregion

        public PMenu pMenu1;
        private PToolStrip pToolStrip1;
        private PColor pColor1;
        private PWidth pWidth1;
        private PType pType1;
        private PSave pSave1;
        private PLoad pLoad1;
        private TextBar textBar1;
        private PStatusStrip pStatusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
