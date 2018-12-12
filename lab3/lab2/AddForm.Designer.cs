namespace lab2
{
    partial class AddForm
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
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_weight = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.num_weight = new System.Windows.Forms.NumericUpDown();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cmBox_name = new System.Windows.Forms.ComboBox();
            this.btn_more = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_name.Location = new System.Drawing.Point(12, 18);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(77, 16);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Название:";
            // 
            // lb_weight
            // 
            this.lb_weight.AutoSize = true;
            this.lb_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_weight.Location = new System.Drawing.Point(12, 63);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(35, 16);
            this.lb_weight.TabIndex = 1;
            this.lb_weight.Text = "Вес:";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_price.Location = new System.Drawing.Point(12, 108);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(81, 16);
            this.lb_price.TabIndex = 2;
            this.lb_price.Text = "Стоимость:";
            // 
            // num_weight
            // 
            this.num_weight.Location = new System.Drawing.Point(95, 63);
            this.num_weight.Name = "num_weight";
            this.num_weight.Size = new System.Drawing.Size(120, 20);
            this.num_weight.TabIndex = 3;
            // 
            // num_price
            // 
            this.num_price.Location = new System.Drawing.Point(95, 104);
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(120, 20);
            this.num_price.TabIndex = 4;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OK.Location = new System.Drawing.Point(15, 151);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(129, 38);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "ОК";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cancel.Location = new System.Drawing.Point(186, 151);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(141, 38);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Закрыть";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cmBox_name
            // 
            this.cmBox_name.FormattingEnabled = true;
            this.cmBox_name.Items.AddRange(new object[] {
            "Книга",
            "Тетрадь",
            "Пенал",
            "Ручка",
            "Карандаш",
            "Телефон",
            "Компьютер",
            "Зеркало",
            "Блокнот",
            "Учебник",
            "Вода",
            "Перекус",
            "Пудра",
            "Зарядка",
            "Ключи"});
            this.cmBox_name.Location = new System.Drawing.Point(95, 18);
            this.cmBox_name.Name = "cmBox_name";
            this.cmBox_name.Size = new System.Drawing.Size(121, 21);
            this.cmBox_name.TabIndex = 9;
            // 
            // btn_more
            // 
            this.btn_more.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_more.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_more.Location = new System.Drawing.Point(243, 63);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(72, 39);
            this.btn_more.TabIndex = 8;
            this.btn_more.Text = "Добавить ещё...";
            this.btn_more.UseVisualStyleBackColor = true;
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // AddForm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(339, 203);
            this.Controls.Add(this.cmBox_name);
            this.Controls.Add(this.btn_more);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.num_price);
            this.Controls.Add(this.num_weight);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_weight);
            this.Controls.Add(this.lb_name);
            this.MaximumSize = new System.Drawing.Size(355, 242);
            this.MinimumSize = new System.Drawing.Size(355, 242);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление вещи";
            ((System.ComponentModel.ISupportInitialize)(this.num_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_weight;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.NumericUpDown num_weight;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cmBox_name;
        private System.Windows.Forms.Button btn_more;
    }
}