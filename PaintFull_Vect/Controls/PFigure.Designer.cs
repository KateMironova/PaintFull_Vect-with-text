namespace PaintFull_Vect.API
{
    partial class PFigure
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
            this.ctxMenu1 = new PaintFull_Vect.Controls.CtxMenu(this);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            //// 
            //// ctxMenu1
            //// 
            this.ctxMenu1.Location = new System.Drawing.Point(0, 0);
            this.ctxMenu1.Name = "ctxMenu1";
            this.ctxMenu1.Size = new System.Drawing.Size(150, 150);
            this.ctxMenu1.TabIndex = 0;
            // 
            // PFigure
            // 
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseDown);
            this.MouseLeave += new System.EventHandler(this.PFigure_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CtxMenu ctxMenu1;
    }
}
