
namespace DoubleGame
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.outTxt = new System.Windows.Forms.Label();
            this.generateNumber = new System.Windows.Forms.Button();
            this.numberToReach = new System.Windows.Forms.Label();
            this.btnRewind = new System.Windows.Forms.Button();
            this.steps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(116, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(116, 56);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "*2";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(116, 27);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // outTxt
            // 
            this.outTxt.AutoSize = true;
            this.outTxt.Location = new System.Drawing.Point(37, 66);
            this.outTxt.Name = "outTxt";
            this.outTxt.Size = new System.Drawing.Size(13, 13);
            this.outTxt.TabIndex = 3;
            this.outTxt.Text = "0";
            // 
            // generateNumber
            // 
            this.generateNumber.Location = new System.Drawing.Point(40, 186);
            this.generateNumber.Name = "generateNumber";
            this.generateNumber.Size = new System.Drawing.Size(131, 23);
            this.generateNumber.TabIndex = 4;
            this.generateNumber.Text = "Начать играть";
            this.generateNumber.UseVisualStyleBackColor = true;
            this.generateNumber.Click += new System.EventHandler(this.generateNumber_Click);
            // 
            // numberToReach
            // 
            this.numberToReach.AutoSize = true;
            this.numberToReach.Location = new System.Drawing.Point(84, 170);
            this.numberToReach.Name = "numberToReach";
            this.numberToReach.Size = new System.Drawing.Size(45, 13);
            this.numberToReach.TabIndex = 5;
            this.numberToReach.Text = "Число :";
            // 
            // btnRewind
            // 
            this.btnRewind.Location = new System.Drawing.Point(116, 114);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(75, 23);
            this.btnRewind.TabIndex = 6;
            this.btnRewind.Text = "Rewind";
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // steps
            // 
            this.steps.AutoSize = true;
            this.steps.Location = new System.Drawing.Point(87, 216);
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(45, 13);
            this.steps.TabIndex = 7;
            this.steps.Text = "Шагов :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 256);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.btnRewind);
            this.Controls.Add(this.numberToReach);
            this.Controls.Add(this.generateNumber);
            this.Controls.Add(this.outTxt);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label outTxt;
        private System.Windows.Forms.Button generateNumber;
        private System.Windows.Forms.Label numberToReach;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Label steps;
    }
}

