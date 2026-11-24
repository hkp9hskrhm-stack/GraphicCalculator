namespace lesson1
{
    partial class frmCalculator
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
            btnPercent = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnExec = new Button();
            toolStrip1 = new ToolStrip();
            labelStatus = new ToolStripLabel();
            txtDisplay = new TextBox();
            btnReset = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Segoe UI", 14F);
            btnPercent.Location = new Point(11, 210);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(42, 46);
            btnPercent.TabIndex = 0;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnKeypadOperationClick;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14F);
            btn0.Location = new Point(53, 210);
            btn0.Name = "btn0";
            btn0.Size = new Size(42, 46);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnKeypadClick;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 14F);
            btnDot.Location = new Point(95, 210);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(42, 46);
            btnDot.TabIndex = 0;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnKeypadClick;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Segoe UI", 14F);
            btnMul.Location = new Point(137, 210);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(42, 46);
            btnMul.TabIndex = 0;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnKeypadOperationClick;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 14F);
            btnDiv.Location = new Point(137, 164);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(42, 46);
            btnDiv.TabIndex = 0;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnKeypadOperationClick;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14F);
            btnMinus.Location = new Point(137, 72);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(42, 46);
            btnMinus.TabIndex = 0;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnKeypadOperationClick;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 14F);
            btnPlus.Location = new Point(137, 118);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(42, 46);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnKeypadOperationClick;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14F);
            btn9.Location = new Point(95, 72);
            btn9.Name = "btn9";
            btn9.Size = new Size(42, 46);
            btn9.TabIndex = 0;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnKeypadClick;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14F);
            btn8.Location = new Point(53, 72);
            btn8.Name = "btn8";
            btn8.Size = new Size(42, 46);
            btn8.TabIndex = 0;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnKeypadClick;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14F);
            btn7.Location = new Point(11, 72);
            btn7.Name = "btn7";
            btn7.Size = new Size(42, 46);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnKeypadClick;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14F);
            btn4.Location = new Point(11, 118);
            btn4.Name = "btn4";
            btn4.Size = new Size(42, 46);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnKeypadClick;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14F);
            btn5.Location = new Point(53, 118);
            btn5.Name = "btn5";
            btn5.Size = new Size(42, 46);
            btn5.TabIndex = 0;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnKeypadClick;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14F);
            btn6.Location = new Point(95, 118);
            btn6.Name = "btn6";
            btn6.Size = new Size(42, 46);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnKeypadClick;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14F);
            btn3.Location = new Point(95, 164);
            btn3.Name = "btn3";
            btn3.Size = new Size(42, 46);
            btn3.TabIndex = 0;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnKeypadClick;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14F);
            btn2.Location = new Point(53, 164);
            btn2.Name = "btn2";
            btn2.Size = new Size(42, 46);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnKeypadClick;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14F);
            btn1.Location = new Point(11, 164);
            btn1.Name = "btn1";
            btn1.Size = new Size(42, 46);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnKeypadClick;
            // 
            // btnExec
            // 
            btnExec.Font = new Font("Segoe UI", 14F);
            btnExec.Location = new Point(11, 256);
            btnExec.Name = "btnExec";
            btnExec.Size = new Size(168, 42);
            btnExec.TabIndex = 1;
            btnExec.Text = "=";
            btnExec.UseVisualStyleBackColor = true;
            btnExec.Click += btnKeypadOperationClick;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { labelStatus });
            toolStrip1.Location = new Point(0, 344);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(192, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // labelStatus
            // 
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 22);
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 24);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(167, 23);
            txtDisplay.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 14F);
            btnReset.Location = new Point(11, 298);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(168, 42);
            btnReset.TabIndex = 4;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnKeypadOperationClick;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 369);
            Controls.Add(btnReset);
            Controls.Add(txtDisplay);
            Controls.Add(toolStrip1);
            Controls.Add(btnExec);
            Controls.Add(btnPlus);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnMinus);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnPercent);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCalculator";
            Text = "Calculator";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPercent;
        private Button btn0;
        private Button btnDot;
        private Button btnMul;
        private Button btnDiv;
        private Button btnMinus;
        private Button btnPlus;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnExec;
        private ToolStrip toolStrip1;
        private ToolStripLabel labelStatus;
        private TextBox txtDisplay;
        private Button btnReset;
    }
}
