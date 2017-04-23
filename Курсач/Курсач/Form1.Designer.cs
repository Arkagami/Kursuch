namespace Курсач
{
    partial class okno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(okno));
            this.shashka1 = new System.Windows.Forms.Button();
            this.shashka2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shashka1
            // 
            resources.ApplyResources(this.shashka1, "shashka1");
            this.shashka1.Name = "shashka1";
            this.shashka1.UseVisualStyleBackColor = true;
            this.shashka1.Click += new System.EventHandler(this.shashka1_Click);
            this.shashka1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shashka1_MouseDown);
            this.shashka1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shashka1_MouseMove);
            // 
            // shashka2
            // 
            resources.ApplyResources(this.shashka2, "shashka2");
            this.shashka2.Name = "shashka2";
            this.shashka2.UseVisualStyleBackColor = true;
            this.shashka2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.shashka2_MouseClick);
            this.shashka2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shashka2_MouseDown);
            this.shashka2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shashka2_MouseMove);
            // 
            // okno
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shashka2);
            this.Controls.Add(this.shashka1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "okno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shashka1;
        private System.Windows.Forms.Button shashka2;
    }
}

