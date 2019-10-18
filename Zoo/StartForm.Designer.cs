namespace Zoo
{
    partial class StartForm
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCreateArthropod = new System.Windows.Forms.Button();
            this.buttonCreateBird = new System.Windows.Forms.Button();
            this.buttonCreateMammal = new System.Windows.Forms.Button();
            this.buttonCreateFish = new System.Windows.Forms.Button();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(298, 34);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(203, 76);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCreateArthropod
            // 
            this.buttonCreateArthropod.Location = new System.Drawing.Point(167, 143);
            this.buttonCreateArthropod.Name = "buttonCreateArthropod";
            this.buttonCreateArthropod.Size = new System.Drawing.Size(203, 76);
            this.buttonCreateArthropod.TabIndex = 1;
            this.buttonCreateArthropod.Text = "Членистоногое";
            this.buttonCreateArthropod.UseVisualStyleBackColor = true;
            this.buttonCreateArthropod.Visible = false;
            this.buttonCreateArthropod.Click += new System.EventHandler(this.buttonCreateArthropod_Click);
            // 
            // buttonCreateBird
            // 
            this.buttonCreateBird.Location = new System.Drawing.Point(429, 143);
            this.buttonCreateBird.Name = "buttonCreateBird";
            this.buttonCreateBird.Size = new System.Drawing.Size(203, 76);
            this.buttonCreateBird.TabIndex = 2;
            this.buttonCreateBird.Text = "Птица";
            this.buttonCreateBird.UseVisualStyleBackColor = true;
            this.buttonCreateBird.Visible = false;
            // 
            // buttonCreateMammal
            // 
            this.buttonCreateMammal.Location = new System.Drawing.Point(167, 237);
            this.buttonCreateMammal.Name = "buttonCreateMammal";
            this.buttonCreateMammal.Size = new System.Drawing.Size(203, 76);
            this.buttonCreateMammal.TabIndex = 3;
            this.buttonCreateMammal.Text = "Млекопитающее";
            this.buttonCreateMammal.UseVisualStyleBackColor = true;
            this.buttonCreateMammal.Visible = false;
            // 
            // buttonCreateFish
            // 
            this.buttonCreateFish.Location = new System.Drawing.Point(429, 237);
            this.buttonCreateFish.Name = "buttonCreateFish";
            this.buttonCreateFish.Size = new System.Drawing.Size(203, 76);
            this.buttonCreateFish.TabIndex = 4;
            this.buttonCreateFish.Text = "Рыба";
            this.buttonCreateFish.UseVisualStyleBackColor = true;
            this.buttonCreateFish.Visible = false;
            // 
            // textBoxMain
            // 
            this.textBoxMain.Location = new System.Drawing.Point(125, 58);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(580, 22);
            this.textBoxMain.TabIndex = 5;
            this.textBoxMain.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.buttonCreateFish);
            this.Controls.Add(this.buttonCreateMammal);
            this.Controls.Add(this.buttonCreateBird);
            this.Controls.Add(this.buttonCreateArthropod);
            this.Controls.Add(this.buttonCreate);
            this.Name = "StartForm";
            this.Text = "Живность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCreateArthropod;
        private System.Windows.Forms.Button buttonCreateBird;
        private System.Windows.Forms.Button buttonCreateMammal;
        private System.Windows.Forms.Button buttonCreateFish;
        private System.Windows.Forms.TextBox textBoxMain;
    }
}

