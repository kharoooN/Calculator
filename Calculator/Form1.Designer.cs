namespace Calculator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnOndalik = new System.Windows.Forms.Button();
            this.btnNegativeorPositive = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnYuzde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(284, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppName.Location = new System.Drawing.Point(8, 8);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(59, 13);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Calculator";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDisplay.Location = new System.Drawing.Point(6, 38);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(305, 86);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(6, 268);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 49);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(83, 268);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(74, 49);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(160, 268);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 49);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(160, 320);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 49);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(83, 320);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 49);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(6, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(6, 372);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 49);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(83, 372);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 49);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(160, 372);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(74, 49);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(83, 423);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 49);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnOndalik
            // 
            this.btnOndalik.BackColor = System.Drawing.Color.Black;
            this.btnOndalik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOndalik.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnOndalik.Location = new System.Drawing.Point(160, 423);
            this.btnOndalik.Name = "btnOndalik";
            this.btnOndalik.Size = new System.Drawing.Size(74, 49);
            this.btnOndalik.TabIndex = 3;
            this.btnOndalik.Text = ",";
            this.btnOndalik.UseVisualStyleBackColor = false;
            // 
            // btnNegativeorPositive
            // 
            this.btnNegativeorPositive.BackColor = System.Drawing.Color.Black;
            this.btnNegativeorPositive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNegativeorPositive.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnNegativeorPositive.Location = new System.Drawing.Point(6, 423);
            this.btnNegativeorPositive.Name = "btnNegativeorPositive";
            this.btnNegativeorPositive.Size = new System.Drawing.Size(74, 49);
            this.btnNegativeorPositive.TabIndex = 3;
            this.btnNegativeorPositive.Text = "  +/-";
            this.btnNegativeorPositive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNegativeorPositive.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(237, 164);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(74, 49);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<-";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.Location = new System.Drawing.Point(237, 268);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(74, 49);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnSub.Location = new System.Drawing.Point(237, 320);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(74, 49);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnSum.Location = new System.Drawing.Point(237, 372);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(74, 49);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnEqual.Location = new System.Drawing.Point(237, 423);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(74, 49);
            this.btnEqual.TabIndex = 3;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnDivide.Location = new System.Drawing.Point(237, 216);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(74, 49);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAll.Location = new System.Drawing.Point(160, 216);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(74, 49);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "C";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(83, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 49);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "CE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnYuzde
            // 
            this.btnYuzde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnYuzde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYuzde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnYuzde.Location = new System.Drawing.Point(6, 216);
            this.btnYuzde.Name = "btnYuzde";
            this.btnYuzde.Size = new System.Drawing.Size(74, 49);
            this.btnYuzde.TabIndex = 3;
            this.btnYuzde.Text = "%";
            this.btnYuzde.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(314, 476);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnOndalik);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnNegativeorPositive);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnYuzde);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDisplay);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnOndalik;
        private System.Windows.Forms.Button btnNegativeorPositive;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnYuzde;
    }
}

