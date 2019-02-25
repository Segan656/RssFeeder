namespace RSSFeeder
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
            this.btnURL = new System.Windows.Forms.Button();
            this.newsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sourceCB = new System.Windows.Forms.ComboBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.addBtn = new System.Windows.Forms.Button();
            this.timerBtn = new System.Windows.Forms.Button();
            this.intervalTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnURL
            // 
            this.btnURL.Location = new System.Drawing.Point(375, 75);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(75, 23);
            this.btnURL.TabIndex = 4;
            this.btnURL.Text = "Отобразить";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // newsPanel
            // 
            this.newsPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.newsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newsPanel.AutoScroll = true;
            this.newsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.newsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.newsPanel.Location = new System.Drawing.Point(57, 135);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.newsPanel.Size = new System.Drawing.Size(523, 352);
            this.newsPanel.TabIndex = 5;
            this.newsPanel.WrapContents = false;
            // 
            // sourceCB
            // 
            this.sourceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceCB.FormattingEnabled = true;
            this.sourceCB.ItemHeight = 13;
            this.sourceCB.Location = new System.Drawing.Point(205, 75);
            this.sourceCB.Name = "sourceCB";
            this.sourceCB.Size = new System.Drawing.Size(150, 21);
            this.sourceCB.TabIndex = 7;
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(626, 135);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(137, 20);
            this.tbURL.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(782, 132);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // timerBtn
            // 
            this.timerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.timerBtn.Location = new System.Drawing.Point(782, 243);
            this.timerBtn.Name = "timerBtn";
            this.timerBtn.Size = new System.Drawing.Size(75, 23);
            this.timerBtn.TabIndex = 11;
            this.timerBtn.Text = "Изменить";
            this.timerBtn.UseVisualStyleBackColor = true;
            this.timerBtn.Click += new System.EventHandler(this.timerBtn_Click);
            // 
            // intervalTb
            // 
            this.intervalTb.Location = new System.Drawing.Point(626, 246);
            this.intervalTb.Name = "intervalTb";
            this.intervalTb.Size = new System.Drawing.Size(137, 20);
            this.intervalTb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(663, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добавить источник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(603, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Таймер обновления ленты (секунды)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(294, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Список лент";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(903, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerBtn);
            this.Controls.Add(this.intervalTb);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.sourceCB);
            this.Controls.Add(this.newsPanel);
            this.Controls.Add(this.btnURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.FlowLayoutPanel newsPanel;
        private System.Windows.Forms.ComboBox sourceCB;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button timerBtn;
        private System.Windows.Forms.TextBox intervalTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

