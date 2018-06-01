namespace AdPosterUI
{
    partial class ScheduleForm
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
            this.chkSelect = new System.Windows.Forms.CheckedListBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.chkFHA = new System.Windows.Forms.CheckBox();
            this.chkCourtesy = new System.Windows.Forms.CheckBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtStrtNo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboStartMode = new System.Windows.Forms.ComboBox();
            this.cboExecute = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkSelect
            // 
            this.chkSelect.CausesValidation = false;
            this.chkSelect.CheckOnClick = true;
            this.chkSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkSelect.FormattingEnabled = true;
            this.chkSelect.Location = new System.Drawing.Point(12, 24);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(149, 124);
            this.chkSelect.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(56, 370);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(117, 13);
            this.Label5.TabIndex = 45;
            this.Label5.Text = "Include FHA Disclaimer";
            // 
            // chkFHA
            // 
            this.chkFHA.AutoSize = true;
            this.chkFHA.BackColor = System.Drawing.Color.Transparent;
            this.chkFHA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkFHA.ForeColor = System.Drawing.Color.DimGray;
            this.chkFHA.Location = new System.Drawing.Point(37, 370);
            this.chkFHA.Name = "chkFHA";
            this.chkFHA.Size = new System.Drawing.Size(13, 12);
            this.chkFHA.TabIndex = 44;
            this.chkFHA.UseVisualStyleBackColor = false;
            // 
            // chkCourtesy
            // 
            this.chkCourtesy.AutoSize = true;
            this.chkCourtesy.BackColor = System.Drawing.Color.Transparent;
            this.chkCourtesy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkCourtesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCourtesy.ForeColor = System.Drawing.Color.DimGray;
            this.chkCourtesy.Location = new System.Drawing.Point(37, 352);
            this.chkCourtesy.Name = "chkCourtesy";
            this.chkCourtesy.Size = new System.Drawing.Size(13, 12);
            this.chkCourtesy.TabIndex = 43;
            this.chkCourtesy.UseVisualStyleBackColor = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(52, 351);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(163, 13);
            this.Label8.TabIndex = 42;
            this.Label8.Text = "Include credit to listing brokerage";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(215, 191);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(31, 20);
            this.txtNumber.TabIndex = 41;
            this.txtNumber.Text = "1";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStrtNo
            // 
            this.txtStrtNo.Location = new System.Drawing.Point(215, 152);
            this.txtStrtNo.Name = "txtStrtNo";
            this.txtStrtNo.Size = new System.Drawing.Size(31, 20);
            this.txtStrtNo.TabIndex = 40;
            this.txtStrtNo.Text = "1";
            this.txtStrtNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.ForeColor = System.Drawing.Color.Snow;
            this.Label4.Location = new System.Drawing.Point(197, 136);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 13);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Start Number";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.BackColor = System.Drawing.Color.Transparent;
            this.n.ForeColor = System.Drawing.Color.Snow;
            this.n.Location = new System.Drawing.Point(188, 175);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(85, 13);
            this.n.TabIndex = 38;
            this.n.Text = "Number of Posts";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(35, 241);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 20);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "Start Mode";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(35, 191);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(111, 20);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "Execute Mode";
            // 
            // cboStartMode
            // 
            this.cboStartMode.FormattingEnabled = true;
            this.cboStartMode.Location = new System.Drawing.Point(11, 264);
            this.cboStartMode.Name = "cboStartMode";
            this.cboStartMode.Size = new System.Drawing.Size(260, 21);
            this.cboStartMode.TabIndex = 32;
            // 
            // cboExecute
            // 
            this.cboExecute.FormattingEnabled = true;
            this.cboExecute.Location = new System.Drawing.Point(11, 217);
            this.cboExecute.Name = "cboExecute";
            this.cboExecute.Size = new System.Drawing.Size(260, 21);
            this.cboExecute.TabIndex = 31;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(191, 291);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 48);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(97, 291);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 48);
            this.btnStop.TabIndex = 34;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(11, 291);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 48);
            this.btnStart.TabIndex = 33;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(191, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(191, 92);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 30);
            this.btnRemove.TabIndex = 29;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 430);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.chkFHA);
            this.Controls.Add(this.chkCourtesy);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtStrtNo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.n);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cboStartMode);
            this.Controls.Add(this.cboExecute);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.chkSelect);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckedListBox chkSelect;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.CheckBox chkFHA;
        internal System.Windows.Forms.CheckBox chkCourtesy;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtNumber;
        internal System.Windows.Forms.TextBox txtStrtNo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label n;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cboStartMode;
        internal System.Windows.Forms.ComboBox cboExecute;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnRemove;
    }
}