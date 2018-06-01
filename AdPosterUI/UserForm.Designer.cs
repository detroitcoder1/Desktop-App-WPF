namespace AdPosterUI
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemarks1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemarks2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.bntClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact Phone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "PhoneNumber", true));
            this.txtPhone.Location = new System.Drawing.Point(96, 92);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(208, 20);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = global::AdPosterUI.Properties.Settings.Default.Phone;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(AdPosterLibrary.Model.User);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location";
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdPosterUI.Properties.Settings.Default, "City", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCity.Location = new System.Drawing.Point(96, 129);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(322, 20);
            this.txtCity.TabIndex = 5;
            this.txtCity.Text = global::AdPosterUI.Properties.Settings.Default.City;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "State";
            // 
            // txtRemarks1
            // 
            this.txtRemarks1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdPosterUI.Properties.Settings.Default, "Remarks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRemarks1.Location = new System.Drawing.Point(96, 189);
            this.txtRemarks1.Name = "txtRemarks1";
            this.txtRemarks1.Size = new System.Drawing.Size(322, 20);
            this.txtRemarks1.TabIndex = 7;
            this.txtRemarks1.Text = global::AdPosterUI.Properties.Settings.Default.Remarks;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remarks ";
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdPosterUI.Properties.Settings.Default, "State", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtState.Location = new System.Drawing.Point(96, 155);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(322, 20);
            this.txtState.TabIndex = 9;
            this.txtState.Text = global::AdPosterUI.Properties.Settings.Default.State;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Remarks";
            // 
            // txtRemarks2
            // 
            this.txtRemarks2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdPosterUI.Properties.Settings.Default, "Remarks2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRemarks2.Location = new System.Drawing.Point(96, 217);
            this.txtRemarks2.Name = "txtRemarks2";
            this.txtRemarks2.Size = new System.Drawing.Size(322, 20);
            this.txtRemarks2.TabIndex = 11;
            this.txtRemarks2.Text = global::AdPosterUI.Properties.Settings.Default.Remarks2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Additional Info";
            // 
            // txtInfo
            // 
            this.txtInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdPosterUI.Properties.Settings.Default, "Info", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtInfo.Location = new System.Drawing.Point(96, 257);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(322, 20);
            this.txtInfo.TabIndex = 13;
            this.txtInfo.Text = global::AdPosterUI.Properties.Settings.Default.Info;
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(256, 311);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(75, 33);
            this.bntClose.TabIndex = 15;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdPosterUI.Properties.Settings.Default, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtName.Location = new System.Drawing.Point(96, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = global::AdPosterUI.Properties.Settings.Default.Name;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 356);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRemarks2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRemarks1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::AdPosterUI.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::AdPosterUI.Properties.Settings.Default.Location;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemarks1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemarks2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}