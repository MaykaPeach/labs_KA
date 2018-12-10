namespace lab2
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
            this.num_size = new System.Windows.Forms.NumericUpDown();
            this.lb_size = new System.Windows.Forms.Label();
            this.btn_Task = new System.Windows.Forms.Button();
            this.LstVw = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pan_size = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.pn_Task = new System.Windows.Forms.Panel();
            this.LstVwTask = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_All = new System.Windows.Forms.Label();
            this.lb_Task = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_size)).BeginInit();
            this.pan_size.SuspendLayout();
            this.pn_Task.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_size
            // 
            this.num_size.Location = new System.Drawing.Point(45, 57);
            this.num_size.Name = "num_size";
            this.num_size.Size = new System.Drawing.Size(109, 20);
            this.num_size.TabIndex = 0;
            // 
            // lb_size
            // 
            this.lb_size.AutoSize = true;
            this.lb_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_size.Location = new System.Drawing.Point(3, 28);
            this.lb_size.Name = "lb_size";
            this.lb_size.Size = new System.Drawing.Size(196, 17);
            this.lb_size.TabIndex = 1;
            this.lb_size.Text = "Максимальный вес рюкзака:";
            // 
            // btn_Task
            // 
            this.btn_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Task.Location = new System.Drawing.Point(27, 44);
            this.btn_Task.Name = "btn_Task";
            this.btn_Task.Size = new System.Drawing.Size(139, 41);
            this.btn_Task.TabIndex = 2;
            this.btn_Task.Text = "Решить задачу";
            this.btn_Task.UseVisualStyleBackColor = true;
            this.btn_Task.Click += new System.EventHandler(this.btn_Task_Click);
            // 
            // LstVw
            // 
            this.LstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_weight,
            this.col_price});
            this.LstVw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LstVw.Location = new System.Drawing.Point(3, 26);
            this.LstVw.Name = "LstVw";
            this.LstVw.Size = new System.Drawing.Size(304, 307);
            this.LstVw.TabIndex = 3;
            this.LstVw.UseCompatibleStateImageBehavior = false;
            this.LstVw.View = System.Windows.Forms.View.Details;
            // 
            // col_name
            // 
            this.col_name.Text = "Название";
            this.col_name.Width = 124;
            // 
            // col_weight
            // 
            this.col_weight.Text = "Вес";
            this.col_weight.Width = 72;
            // 
            // col_price
            // 
            this.col_price.Text = "Стоимость";
            this.col_price.Width = 104;
            // 
            // pan_size
            // 
            this.pan_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_size.Controls.Add(this.btn_add);
            this.pan_size.Controls.Add(this.lb_size);
            this.pan_size.Controls.Add(this.num_size);
            this.pan_size.Location = new System.Drawing.Point(313, 26);
            this.pan_size.Name = "pan_size";
            this.pan_size.Size = new System.Drawing.Size(198, 164);
            this.pan_size.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(27, 98);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(139, 43);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Добавить вещь";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pn_Task
            // 
            this.pn_Task.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Task.Controls.Add(this.btn_Task);
            this.pn_Task.Location = new System.Drawing.Point(313, 196);
            this.pn_Task.Name = "pn_Task";
            this.pn_Task.Size = new System.Drawing.Size(198, 137);
            this.pn_Task.TabIndex = 5;
            // 
            // LstVwTask
            // 
            this.LstVwTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LstVwTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LstVwTask.Location = new System.Drawing.Point(517, 26);
            this.LstVwTask.Name = "LstVwTask";
            this.LstVwTask.Size = new System.Drawing.Size(304, 307);
            this.LstVwTask.TabIndex = 6;
            this.LstVwTask.UseCompatibleStateImageBehavior = false;
            this.LstVwTask.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Вес";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Стоимость";
            this.columnHeader3.Width = 104;
            // 
            // lb_All
            // 
            this.lb_All.AutoSize = true;
            this.lb_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_All.Location = new System.Drawing.Point(76, 5);
            this.lb_All.Name = "lb_All";
            this.lb_All.Size = new System.Drawing.Size(141, 17);
            this.lb_All.TabIndex = 4;
            this.lb_All.Text = "Все исходные вещи:";
            // 
            // lb_Task
            // 
            this.lb_Task.AutoSize = true;
            this.lb_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Task.Location = new System.Drawing.Point(634, 5);
            this.lb_Task.Name = "lb_Task";
            this.lb_Task.Size = new System.Drawing.Size(80, 17);
            this.lb_Task.TabIndex = 7;
            this.lb_Task.Text = "Результат:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 338);
            this.Controls.Add(this.lb_Task);
            this.Controls.Add(this.lb_All);
            this.Controls.Add(this.LstVwTask);
            this.Controls.Add(this.pn_Task);
            this.Controls.Add(this.pan_size);
            this.Controls.Add(this.LstVw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(839, 377);
            this.MinimumSize = new System.Drawing.Size(839, 377);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача о рюкзаке";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.num_size)).EndInit();
            this.pan_size.ResumeLayout(false);
            this.pan_size.PerformLayout();
            this.pn_Task.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_size;
        private System.Windows.Forms.Label lb_size;
        private System.Windows.Forms.Button btn_Task;
        private System.Windows.Forms.ListView LstVw;
        private System.Windows.Forms.Panel pan_size;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_weight;
        private System.Windows.Forms.ColumnHeader col_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pn_Task;
        private System.Windows.Forms.ListView LstVwTask;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lb_All;
        private System.Windows.Forms.Label lb_Task;
    }
}

