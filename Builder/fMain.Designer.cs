namespace Builder
{
    partial class fMain
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
            this.bBuild = new System.Windows.Forms.Button();
            this.tText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bBuild
            // 
            this.bBuild.Location = new System.Drawing.Point(13, 39);
            this.bBuild.Name = "bBuild";
            this.bBuild.Size = new System.Drawing.Size(364, 26);
            this.bBuild.TabIndex = 0;
            this.bBuild.Text = "Build";
            this.bBuild.UseVisualStyleBackColor = true;
            this.bBuild.Click += new System.EventHandler(this.bBuild_Click);
            // 
            // tText
            // 
            this.tText.Location = new System.Drawing.Point(13, 13);
            this.tText.Name = "tText";
            this.tText.Size = new System.Drawing.Size(364, 20);
            this.tText.TabIndex = 1;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 75);
            this.Controls.Add(this.tText);
            this.Controls.Add(this.bBuild);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 113);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(405, 113);
            this.Name = "fMain";
            this.Text = "ExeBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuild;
        private System.Windows.Forms.TextBox tText;
    }
}

