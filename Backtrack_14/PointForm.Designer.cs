namespace Backtrack_14
{
    partial class PointForm
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
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudZ = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 147);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(95, 58);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "ОК";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(127, 147);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 58);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(12, 31);
            this.nudX.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(210, 20);
            this.nudX.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(12, 70);
            this.nudY.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(210, 20);
            this.nudY.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Z";
            // 
            // nudZ
            // 
            this.nudZ.Location = new System.Drawing.Point(12, 110);
            this.nudZ.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudZ.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nudZ.Name = "nudZ";
            this.nudZ.Size = new System.Drawing.Size(210, 20);
            this.nudZ.TabIndex = 12;
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 216);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Name = "PointForm";
            this.Text = "Точка";
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudZ;
    }
}