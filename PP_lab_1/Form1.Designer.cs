
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
			this.Fragment = new System.Windows.Forms.Button();
			this.MoveTo = new System.Windows.Forms.Button();
			this.MoveTo2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox.Location = new System.Drawing.Point(5, 125);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(783, 323);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// Fragment
			// 
			this.Fragment.Location = new System.Drawing.Point(12, 83);
			this.Fragment.Name = "Fragment";
			this.Fragment.Size = new System.Drawing.Size(104, 23);
			this.Fragment.TabIndex = 4;
			this.Fragment.Text = "Развернуть";
			this.Fragment.UseVisualStyleBackColor = true;
			this.Fragment.Click += new System.EventHandler(this.Fragment_Click);
			// 
			// MoveTo
			// 
			this.MoveTo.Location = new System.Drawing.Point(135, 83);
			this.MoveTo.Name = "MoveTo";
			this.MoveTo.Size = new System.Drawing.Size(104, 23);
			this.MoveTo.TabIndex = 5;
			this.MoveTo.Text = "Сместить";
			this.MoveTo.UseVisualStyleBackColor = true;
			this.MoveTo.Click += new System.EventHandler(this.MoveTo_Click);
			// 
			// MoveTo2
			// 
			this.MoveTo2.Location = new System.Drawing.Point(259, 83);
			this.MoveTo2.Name = "MoveTo2";
			this.MoveTo2.Size = new System.Drawing.Size(104, 23);
			this.MoveTo2.TabIndex = 6;
			this.MoveTo2.Text = "Совместить";
			this.MoveTo2.UseVisualStyleBackColor = true;
			this.MoveTo2.Click += new System.EventHandler(this.MoveTo2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MoveTo2);
			this.Controls.Add(this.MoveTo);
			this.Controls.Add(this.Fragment);
			this.Controls.Add(this.pictureBox);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button Fragment;
		private System.Windows.Forms.Button MoveTo;
		private System.Windows.Forms.Button MoveTo2;
	}
}

