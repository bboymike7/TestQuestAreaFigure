namespace TestFigure
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textFigure = new System.Windows.Forms.TextBox();
            this.storona1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storona2 = new System.Windows.Forms.TextBox();
            this.storona3 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proverkaText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "введите название фигуры:";
            // 
            // textFigure
            // 
            this.textFigure.Location = new System.Drawing.Point(12, 36);
            this.textFigure.Name = "textFigure";
            this.textFigure.Size = new System.Drawing.Size(268, 29);
            this.textFigure.TabIndex = 2;
            // 
            // storona1
            // 
            this.storona1.Location = new System.Drawing.Point(16, 123);
            this.storona1.Name = "storona1";
            this.storona1.Size = new System.Drawing.Size(264, 29);
            this.storona1.TabIndex = 3;
            this.storona1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "введите радиус или длины сторон фигуры:";
            this.label2.Visible = false;
            // 
            // storona2
            // 
            this.storona2.Location = new System.Drawing.Point(16, 158);
            this.storona2.Name = "storona2";
            this.storona2.Size = new System.Drawing.Size(264, 29);
            this.storona2.TabIndex = 5;
            this.storona2.Visible = false;
            // 
            // storona3
            // 
            this.storona3.Location = new System.Drawing.Point(16, 193);
            this.storona3.Name = "storona3";
            this.storona3.Size = new System.Drawing.Size(264, 29);
            this.storona3.TabIndex = 6;
            this.storona3.Visible = false;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 400);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(268, 29);
            this.result.TabIndex = 8;
            this.result.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат:";
            // 
            // proverkaText
            // 
            this.proverkaText.Location = new System.Drawing.Point(311, 9);
            this.proverkaText.Margin = new System.Windows.Forms.Padding(6);
            this.proverkaText.Name = "proverkaText";
            this.proverkaText.Size = new System.Drawing.Size(140, 56);
            this.proverkaText.TabIndex = 10;
            this.proverkaText.Text = "Далее";
            this.proverkaText.UseVisualStyleBackColor = true;
            this.proverkaText.Click += new System.EventHandler(this.proverkaText_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 559);
            this.Controls.Add(this.proverkaText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.storona3);
            this.Controls.Add(this.storona2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.storona1);
            this.Controls.Add(this.textFigure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Main_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFigure;
        private System.Windows.Forms.TextBox storona1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox storona2;
        private System.Windows.Forms.TextBox storona3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button proverkaText;
    }
}

