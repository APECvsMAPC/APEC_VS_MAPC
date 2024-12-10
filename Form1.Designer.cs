namespace Pyaterochka
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.product = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.paul = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.men = new System.Windows.Forms.RadioButton();
            this.girl = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(215, 20);
            this.name.TabIndex = 1;
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Location = new System.Drawing.Point(105, 67);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(41, 13);
            this.product.TabIndex = 2;
            this.product.Text = "Товар:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 20);
            this.textBox3.TabIndex = 4;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(86, 127);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(69, 13);
            this.quantity.TabIndex = 5;
            this.quantity.Text = "Количество:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 20);
            this.textBox4.TabIndex = 6;
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.Location = new System.Drawing.Point(94, 179);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(55, 13);
            this.telephone.TabIndex = 7;
            this.telephone.Text = "Телефон:";
            this.telephone.Click += new System.EventHandler(this.Label4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 255);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(215, 20);
            this.textBox5.TabIndex = 8;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(67, 239);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(107, 13);
            this.email.TabIndex = 9;
            this.email.Text = "Электронная почта:";
            // 
            // paul
            // 
            this.paul.AutoSize = true;
            this.paul.Location = new System.Drawing.Point(105, 287);
            this.paul.Name = "paul";
            this.paul.Size = new System.Drawing.Size(30, 13);
            this.paul.TabIndex = 10;
            this.paul.Text = "Пол:";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(80, 349);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 15;
            this.save.Text = "Cохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.Location = new System.Drawing.Point(80, 303);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(71, 17);
            this.men.TabIndex = 17;
            this.men.TabStop = true;
            this.men.Text = "Мужской";
            this.men.UseVisualStyleBackColor = true;
            // 
            // girl
            // 
            this.girl.AutoSize = true;
            this.girl.Location = new System.Drawing.Point(80, 326);
            this.girl.Name = "girl";
            this.girl.Size = new System.Drawing.Size(72, 17);
            this.girl.TabIndex = 18;
            this.girl.TabStop = true;
            this.girl.Text = "Женский";
            this.girl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 387);
            this.Controls.Add(this.girl);
            this.Controls.Add(this.men);
            this.Controls.Add(this.save);
            this.Controls.Add(this.paul);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.product);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Пятёрочка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label telephone;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label paul;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RadioButton men;
        private System.Windows.Forms.RadioButton girl;
    }
}

