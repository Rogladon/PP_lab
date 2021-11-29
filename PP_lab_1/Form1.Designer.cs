
namespace PP_lab_1 {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.generate2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.save2 = new System.Windows.Forms.Button();
			this.save1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox.Location = new System.Drawing.Point(5, 125);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(338, 323);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// generate2
			// 
			this.generate2.Location = new System.Drawing.Point(347, 40);
			this.generate2.Name = "generate2";
			this.generate2.Size = new System.Drawing.Size(100, 23);
			this.generate2.TabIndex = 3;
			this.generate2.Text = "Генерация";
			this.generate2.UseVisualStyleBackColor = true;
			this.generate2.Click += new System.EventHandler(this.generate2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(147, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Схема 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(593, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Схема 2";
			// 
			// save2
			// 
			this.save2.Location = new System.Drawing.Point(569, 79);
			this.save2.Name = "save2";
			this.save2.Size = new System.Drawing.Size(100, 23);
			this.save2.TabIndex = 6;
			this.save2.Text = "Сохранить";
			this.save2.UseVisualStyleBackColor = true;
			this.save2.Click += new System.EventHandler(this.save2_Click);
			// 
			// save1
			// 
			this.save1.Location = new System.Drawing.Point(119, 79);
			this.save1.Name = "save1";
			this.save1.Size = new System.Drawing.Size(100, 23);
			this.save1.TabIndex = 7;
			this.save1.Text = "Сохранить";
			this.save1.UseVisualStyleBackColor = true;
			this.save1.Click += new System.EventHandler(this.save1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.Location = new System.Drawing.Point(450, 125);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(338, 323);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.save1);
			this.Controls.Add(this.save2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.generate2);
			this.Controls.Add(this.pictureBox);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button generate2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button save2;
		private System.Windows.Forms.Button save1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

