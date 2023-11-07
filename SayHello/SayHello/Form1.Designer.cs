namespace SayHello
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			SayHelloButton = new Button();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// SayHelloButton
			// 
			SayHelloButton.Location = new Point(147, 230);
			SayHelloButton.Name = "SayHelloButton";
			SayHelloButton.Size = new Size(75, 23);
			SayHelloButton.TabIndex = 0;
			SayHelloButton.Text = "Say hello";
			SayHelloButton.UseVisualStyleBackColor = true;
			SayHelloButton.Click += SayHelloButton_Click;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(147, 139);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(360, 50);
			textBox1.TabIndex = 1;
			textBox1.Text = "Hello there!";
			textBox1.TextAlign = HorizontalAlignment.Center;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(textBox1);
			Controls.Add(SayHelloButton);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button SayHelloButton;
		private TextBox textBox1;
	}
}