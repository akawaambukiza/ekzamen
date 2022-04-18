
namespace ekzamen
{
    partial class Корзина
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Картинка1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Картинка2 = new System.Windows.Forms.PictureBox();
            this.Назад = new System.Windows.Forms.Button();
            this.Заказ = new System.Windows.Forms.Button();
            this.Название = new System.Windows.Forms.Label();
            this.Автор = new System.Windows.Forms.Label();
            this.Количество = new System.Windows.Forms.Label();
            this.Цена = new System.Windows.Forms.Label();
            this.Цена2 = new System.Windows.Forms.Label();
            this.Количество2 = new System.Windows.Forms.Label();
            this.Автор2 = new System.Windows.Forms.Label();
            this.Название2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Картинка1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Картинка2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Цена);
            this.panel1.Controls.Add(this.Количество);
            this.panel1.Controls.Add(this.Автор);
            this.panel1.Controls.Add(this.Название);
            this.panel1.Controls.Add(this.Картинка1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 177);
            this.panel1.TabIndex = 0;
            // 
            // Картинка1
            // 
            this.Картинка1.Location = new System.Drawing.Point(16, 14);
            this.Картинка1.Name = "Картинка1";
            this.Картинка1.Size = new System.Drawing.Size(138, 147);
            this.Картинка1.TabIndex = 1;
            this.Картинка1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Цена2);
            this.panel2.Controls.Add(this.Картинка2);
            this.panel2.Controls.Add(this.Количество2);
            this.panel2.Controls.Add(this.Автор2);
            this.panel2.Controls.Add(this.Название2);
            this.panel2.Location = new System.Drawing.Point(12, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 177);
            this.panel2.TabIndex = 1;
            // 
            // Картинка2
            // 
            this.Картинка2.Location = new System.Drawing.Point(16, 15);
            this.Картинка2.Name = "Картинка2";
            this.Картинка2.Size = new System.Drawing.Size(138, 147);
            this.Картинка2.TabIndex = 0;
            this.Картинка2.TabStop = false;
            // 
            // Назад
            // 
            this.Назад.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Назад.Location = new System.Drawing.Point(654, 415);
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(134, 23);
            this.Назад.TabIndex = 2;
            this.Назад.Text = "Вернуться назад";
            this.Назад.UseVisualStyleBackColor = true;
            this.Назад.Click += new System.EventHandler(this.Назад_Click);
            // 
            // Заказ
            // 
            this.Заказ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Заказ.Location = new System.Drawing.Point(538, 415);
            this.Заказ.Name = "Заказ";
            this.Заказ.Size = new System.Drawing.Size(110, 23);
            this.Заказ.TabIndex = 3;
            this.Заказ.Text = "Очистить корзину";
            this.Заказ.UseVisualStyleBackColor = true;
            this.Заказ.Click += new System.EventHandler(this.Заказ_Click);
            // 
            // Название
            // 
            this.Название.AutoSize = true;
            this.Название.Location = new System.Drawing.Point(176, 29);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(60, 13);
            this.Название.TabIndex = 2;
            this.Название.Text = "Название:";
            // 
            // Автор
            // 
            this.Автор.AutoSize = true;
            this.Автор.Location = new System.Drawing.Point(179, 56);
            this.Автор.Name = "Автор";
            this.Автор.Size = new System.Drawing.Size(40, 13);
            this.Автор.TabIndex = 3;
            this.Автор.Text = "Автор:";
            // 
            // Количество
            // 
            this.Количество.AutoSize = true;
            this.Количество.Location = new System.Drawing.Point(179, 86);
            this.Количество.Name = "Количество";
            this.Количество.Size = new System.Drawing.Size(69, 13);
            this.Количество.TabIndex = 4;
            this.Количество.Text = "Количество:";
            // 
            // Цена
            // 
            this.Цена.AutoSize = true;
            this.Цена.Location = new System.Drawing.Point(179, 119);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(36, 13);
            this.Цена.TabIndex = 5;
            this.Цена.Text = "Цена:";
            // 
            // Цена2
            // 
            this.Цена2.AutoSize = true;
            this.Цена2.Location = new System.Drawing.Point(179, 123);
            this.Цена2.Name = "Цена2";
            this.Цена2.Size = new System.Drawing.Size(36, 13);
            this.Цена2.TabIndex = 9;
            this.Цена2.Text = "Цена:";
            // 
            // Количество2
            // 
            this.Количество2.AutoSize = true;
            this.Количество2.Location = new System.Drawing.Point(179, 90);
            this.Количество2.Name = "Количество2";
            this.Количество2.Size = new System.Drawing.Size(69, 13);
            this.Количество2.TabIndex = 8;
            this.Количество2.Text = "Количество:";
            // 
            // Автор2
            // 
            this.Автор2.AutoSize = true;
            this.Автор2.Location = new System.Drawing.Point(179, 60);
            this.Автор2.Name = "Автор2";
            this.Автор2.Size = new System.Drawing.Size(40, 13);
            this.Автор2.TabIndex = 7;
            this.Автор2.Text = "Автор:";
            // 
            // Название2
            // 
            this.Название2.AutoSize = true;
            this.Название2.Location = new System.Drawing.Point(176, 33);
            this.Название2.Name = "Название2";
            this.Название2.Size = new System.Drawing.Size(60, 13);
            this.Название2.TabIndex = 6;
            this.Название2.Text = "Название:";
            // 
            // Корзина
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Заказ);
            this.Controls.Add(this.Назад);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Корзина";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Картинка1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Картинка2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Картинка1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Картинка2;
        private System.Windows.Forms.Button Назад;
        private System.Windows.Forms.Button Заказ;
        private System.Windows.Forms.Label Цена;
        private System.Windows.Forms.Label Количество;
        private System.Windows.Forms.Label Автор;
        private System.Windows.Forms.Label Название;
        private System.Windows.Forms.Label Цена2;
        private System.Windows.Forms.Label Количество2;
        private System.Windows.Forms.Label Автор2;
        private System.Windows.Forms.Label Название2;
    }
}