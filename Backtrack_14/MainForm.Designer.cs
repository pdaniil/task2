namespace Backtrack_14
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 13);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(376, 239);
            this.dgv.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(394, 13);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(109, 43);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(394, 61);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(109, 43);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Удалить";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(394, 110);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(109, 43);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Удалить все";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // btTask
            // 
            this.btTask.Location = new System.Drawing.Point(394, 159);
            this.btTask.Name = "btTask";
            this.btTask.Size = new System.Drawing.Size(109, 43);
            this.btTask.TabIndex = 5;
            this.btTask.Text = "Главная задача";
            this.btTask.UseVisualStyleBackColor = true;
            this.btTask.Click += new System.EventHandler(this.BtTask_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 265);
            this.Controls.Add(this.btTask);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgv);
            this.Name = "MainForm";
            this.Text = "Бэктрек";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btTask;
    }
}

