namespace ReactionTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timerRandom = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.timerReaction = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerRandom
            // 
            this.timerRandom.Tick += new System.EventHandler(this.timerRandom_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(281, 149);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(218, 68);
            this.label.TabIndex = 0;
            this.label.Text = "Бортер";
            // 
            // timerReaction
            // 
            this.timerReaction.Tick += new System.EventHandler(this.timerReaction_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerRandom;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timerReaction;
    }
}

