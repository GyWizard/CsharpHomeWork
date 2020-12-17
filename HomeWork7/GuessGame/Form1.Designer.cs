
namespace GuessGame
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
            this.guess = new System.Windows.Forms.Button();
            this.outTxt = new System.Windows.Forms.Label();
            this.inText = new System.Windows.Forms.TextBox();
            this.steps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(61, 152);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(170, 37);
            this.guess.TabIndex = 0;
            this.guess.Text = "Угадать";
            this.guess.UseVisualStyleBackColor = true;
            this.guess.Click += new System.EventHandler(this.guess_Click);
            // 
            // outTxt
            // 
            this.outTxt.AutoSize = true;
            this.outTxt.Location = new System.Drawing.Point(100, 32);
            this.outTxt.Name = "outTxt";
            this.outTxt.Size = new System.Drawing.Size(94, 13);
            this.outTxt.TabIndex = 1;
            this.outTxt.Text = "УГАДАЙ ЧИСЛО";
            // 
            // inText
            // 
            this.inText.Location = new System.Drawing.Point(103, 78);
            this.inText.Name = "inText";
            this.inText.Size = new System.Drawing.Size(77, 20);
            this.inText.TabIndex = 2;
            // 
            // steps
            // 
            this.steps.AutoSize = true;
            this.steps.Location = new System.Drawing.Point(113, 117);
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(67, 13);
            this.steps.TabIndex = 3;
            this.steps.Text = "Попыток : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 232);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.inText);
            this.Controls.Add(this.outTxt);
            this.Controls.Add(this.guess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guess;
        private System.Windows.Forms.Label outTxt;
        private System.Windows.Forms.TextBox inText;
        private System.Windows.Forms.Label steps;
    }
}

