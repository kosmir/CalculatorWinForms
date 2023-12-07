namespace CalculatorWinForms
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
            tableLayoutPanel1 = new TableLayoutPanel();
            One = new Button();
            Two = new Button();
            button16 = new Button();
            Division = new Button();
            Multiply = new Button();
            Minus = new Button();
            Plus = new Button();
            dot = new Button();
            Four = new Button();
            button2 = new Button();
            Five = new Button();
            Six = new Button();
            Seven = new Button();
            Equal = new Button();
            Eight = new Button();
            Nine = new Button();
            textBox1 = new TextBox();
            Clear = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(One, 0, 0);
            tableLayoutPanel1.Controls.Add(Two, 1, 0);
            tableLayoutPanel1.Controls.Add(button16, 2, 0);
            tableLayoutPanel1.Controls.Add(Division, 3, 3);
            tableLayoutPanel1.Controls.Add(Multiply, 3, 2);
            tableLayoutPanel1.Controls.Add(Minus, 3, 1);
            tableLayoutPanel1.Controls.Add(Plus, 3, 0);
            tableLayoutPanel1.Controls.Add(dot, 0, 3);
            tableLayoutPanel1.Controls.Add(Four, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 3);
            tableLayoutPanel1.Controls.Add(Five, 1, 1);
            tableLayoutPanel1.Controls.Add(Six, 2, 1);
            tableLayoutPanel1.Controls.Add(Seven, 0, 2);
            tableLayoutPanel1.Controls.Add(Equal, 2, 3);
            tableLayoutPanel1.Controls.Add(Eight, 1, 2);
            tableLayoutPanel1.Controls.Add(Nine, 2, 2);
            tableLayoutPanel1.Location = new Point(30, 96);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(536, 230);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // One
            // 
            One.Dock = DockStyle.Fill;
            One.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            One.ForeColor = SystemColors.ControlText;
            One.Location = new Point(3, 3);
            One.Name = "One";
            One.Size = new Size(128, 51);
            One.TabIndex = 13;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += Digit_Click;
            // 
            // Two
            // 
            Two.Dock = DockStyle.Fill;
            Two.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Two.Location = new Point(137, 3);
            Two.Name = "Two";
            Two.Size = new Size(128, 51);
            Two.TabIndex = 14;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Digit_Click;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Fill;
            button16.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            button16.Location = new Point(271, 3);
            button16.Name = "button16";
            button16.Size = new Size(128, 51);
            button16.TabIndex = 15;
            button16.Text = "3";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Digit_Click;
            // 
            // Division
            // 
            Division.Dock = DockStyle.Fill;
            Division.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Division.Location = new Point(405, 174);
            Division.Name = "Division";
            Division.Size = new Size(128, 53);
            Division.TabIndex = 8;
            Division.Text = "/";
            Division.UseVisualStyleBackColor = true;
            Division.Click += Operator_Click;
            // 
            // Multiply
            // 
            Multiply.Dock = DockStyle.Fill;
            Multiply.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Multiply.Location = new Point(405, 117);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(128, 51);
            Multiply.TabIndex = 4;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Operator_Click;
            // 
            // Minus
            // 
            Minus.Dock = DockStyle.Fill;
            Minus.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Minus.Location = new Point(405, 60);
            Minus.Name = "Minus";
            Minus.Size = new Size(128, 51);
            Minus.TabIndex = 3;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Operator_Click;
            // 
            // Plus
            // 
            Plus.Dock = DockStyle.Fill;
            Plus.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Plus.Location = new Point(405, 3);
            Plus.Name = "Plus";
            Plus.Size = new Size(128, 51);
            Plus.TabIndex = 2;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Operator_Click;
            // 
            // dot
            // 
            dot.Dock = DockStyle.Fill;
            dot.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            dot.Location = new Point(3, 174);
            dot.Name = "dot";
            dot.Size = new Size(128, 53);
            dot.TabIndex = 12;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += Operator_Click;
            // 
            // Four
            // 
            Four.Dock = DockStyle.Fill;
            Four.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Four.Location = new Point(3, 60);
            Four.Name = "Four";
            Four.Size = new Size(128, 51);
            Four.TabIndex = 9;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Digit_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            button2.Location = new Point(137, 174);
            button2.Name = "button2";
            button2.Size = new Size(128, 53);
            button2.TabIndex = 1;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Digit_Click;
            // 
            // Five
            // 
            Five.Dock = DockStyle.Fill;
            Five.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Five.Location = new Point(137, 60);
            Five.Name = "Five";
            Five.Size = new Size(128, 51);
            Five.TabIndex = 10;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Digit_Click;
            // 
            // Six
            // 
            Six.Dock = DockStyle.Fill;
            Six.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Six.Location = new Point(271, 60);
            Six.Name = "Six";
            Six.Size = new Size(128, 51);
            Six.TabIndex = 11;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Digit_Click;
            // 
            // Seven
            // 
            Seven.Dock = DockStyle.Fill;
            Seven.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Seven.Location = new Point(3, 117);
            Seven.Name = "Seven";
            Seven.Size = new Size(128, 51);
            Seven.TabIndex = 5;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Digit_Click;
            // 
            // Equal
            // 
            Equal.Dock = DockStyle.Fill;
            Equal.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Equal.Location = new Point(271, 174);
            Equal.Name = "Equal";
            Equal.Size = new Size(128, 53);
            Equal.TabIndex = 0;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click_1;
            // 
            // Eight
            // 
            Eight.Dock = DockStyle.Fill;
            Eight.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Eight.Location = new Point(137, 117);
            Eight.Name = "Eight";
            Eight.Size = new Size(128, 51);
            Eight.TabIndex = 6;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Digit_Click;
            // 
            // Nine
            // 
            Nine.Dock = DockStyle.Fill;
            Nine.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Nine.Location = new Point(271, 117);
            Nine.Name = "Nine";
            Nine.Size = new Size(128, 51);
            Nine.TabIndex = 7;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Digit_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 40F);
            textBox1.Location = new Point(33, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(530, 78);
            textBox1.TabIndex = 1;
            // 
            // Clear
            // 
            Clear.Anchor = AnchorStyles.None;
            Clear.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Clear.Location = new Point(33, 329);
            Clear.Name = "Clear";
            Clear.Size = new Size(530, 44);
            Clear.TabIndex = 2;
            Clear.Text = "Clear Calculations";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 388);
            Controls.Add(Clear);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "My Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button16;
        private Button Two;
        private Button One;
        private Button dot;
        private Button Six;
        private Button Five;
        private Button Four;
        private Button Division;
        private Button Nine;
        private Button Eight;
        private Button Seven;
        private Button Multiply;
        private Button Minus;
        private Button Plus;
        private Button button2;
        private Button Equal;
        private TextBox textBox1;
        private Button Clear;
    }
}
