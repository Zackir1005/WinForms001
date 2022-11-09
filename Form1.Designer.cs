
using System;

namespace WinForms001
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
            this.labelResolution = new System.Windows.Forms.Label();
            this.timer_Tick = new System.Windows.Forms.Timer(this.components);
            this.buttonMake8angle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.Location = new System.Drawing.Point(149, 122);
            this.labelResolution.MaximumSize = new System.Drawing.Size(300, 60);
            this.labelResolution.MinimumSize = new System.Drawing.Size(201, 50);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Padding = new System.Windows.Forms.Padding(1);
            this.labelResolution.Size = new System.Drawing.Size(271, 50);
            this.labelResolution.TabIndex = 0;
            this.labelResolution.Text = "Разрешение экрана                            ";
            // 
            // timer_Tick
            // 
            this.timer_Tick.Enabled = true;
            this.timer_Tick.Interval = 125;
            this.timer_Tick.Tick += new System.EventHandler(this.timer_Tick_Tick);
            // 
            // buttonMake8angle
            // 
            this.buttonMake8angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMake8angle.Location = new System.Drawing.Point(152, 64);
            this.buttonMake8angle.Name = "buttonMake8angle";
            this.buttonMake8angle.Size = new System.Drawing.Size(95, 27);
            this.buttonMake8angle.TabIndex = 1;
            this.buttonMake8angle.Text = "8-угольник";
            this.buttonMake8angle.UseVisualStyleBackColor = true;
            this.buttonMake8angle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonMake8angle_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 310);
            this.Controls.Add(this.buttonMake8angle);
            this.Controls.Add(this.labelResolution);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Timer timer_Tick;
        private System.Windows.Forms.Button buttonMake8angle;
    }
}

