namespace Dubber_Code_Test
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
			InstructionText = new Label();
			GenerateNumbersButton = new Button();
			ResultRichText = new RichTextBox();
			ResetButton = new Button();
			SuspendLayout();
			// 
			// InstructionText
			// 
			InstructionText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			InstructionText.AutoSize = true;
			InstructionText.BackColor = Color.Transparent;
			InstructionText.Font = new Font("MV Boli", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			InstructionText.ForeColor = Color.White;
			InstructionText.Location = new Point(107, 55);
			InstructionText.Name = "InstructionText";
			InstructionText.Size = new Size(601, 34);
			InstructionText.TabIndex = 1;
			InstructionText.Text = "Press the button below to generate numbers!";
			InstructionText.TextAlign = ContentAlignment.MiddleCenter;
			InstructionText.Click += InstructionText_Click;
			// 
			// GenerateNumbersButton
			// 
			GenerateNumbersButton.BackColor = Color.FromArgb(0, 192, 192);
			GenerateNumbersButton.Font = new Font("MV Boli", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			GenerateNumbersButton.ForeColor = SystemColors.ControlText;
			GenerateNumbersButton.Location = new Point(260, 144);
			GenerateNumbersButton.Name = "GenerateNumbersButton";
			GenerateNumbersButton.Size = new Size(268, 125);
			GenerateNumbersButton.TabIndex = 2;
			GenerateNumbersButton.Text = "Generate";
			GenerateNumbersButton.UseVisualStyleBackColor = false;
			GenerateNumbersButton.Click += GenerateNumbersButton_Click;
			// 
			// ResultRichText
			// 
			ResultRichText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			ResultRichText.BackColor = Color.FromArgb(0, 49, 105);
			ResultRichText.BorderStyle = BorderStyle.None;
			ResultRichText.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ResultRichText.Location = new Point(176, 308);
			ResultRichText.MaxLength = 100;
			ResultRichText.Name = "ResultRichText";
			ResultRichText.Size = new Size(416, 111);
			ResultRichText.TabIndex = 4;
			ResultRichText.Text = "";
			ResultRichText.TextChanged += ResultRichText_TextChanged;
			// 
			// ResetButton
			// 
			ResetButton.BackColor = Color.Yellow;
			ResetButton.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ResetButton.Location = new Point(678, 361);
			ResetButton.Name = "ResetButton";
			ResetButton.Size = new Size(106, 77);
			ResetButton.TabIndex = 5;
			ResetButton.Text = "Reset Lottery";
			ResetButton.UseVisualStyleBackColor = false;
			ResetButton.Click += ResetLotteryButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 49, 105);
			ClientSize = new Size(800, 450);
			Controls.Add(ResetButton);
			Controls.Add(ResultRichText);
			Controls.Add(GenerateNumbersButton);
			Controls.Add(InstructionText);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label InstructionText;
		private Button GenerateNumbersButton;
		private RichTextBox ResultRichText;
		private Button ResetButton;
	}
}
