namespace PCTimer
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.logoutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add2hr = new System.Windows.Forms.Button();
            this.add1hr = new System.Windows.Forms.Button();
            this.add30min = new System.Windows.Forms.Button();
            this.add25min = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secCtr = new System.Windows.Forms.Label();
            this.minCtr = new System.Windows.Forms.Label();
            this.hrCtr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recordsBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutBtn.Location = new System.Drawing.Point(12, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.Location = new System.Drawing.Point(143, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit App";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.add2hr);
            this.groupBox2.Controls.Add(this.add1hr);
            this.groupBox2.Controls.Add(this.add30min);
            this.groupBox2.Controls.Add(this.add25min);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(17, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 176);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add More Time";
            // 
            // add2hr
            // 
            this.add2hr.BackColor = System.Drawing.Color.Thistle;
            this.add2hr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add2hr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add2hr.Location = new System.Drawing.Point(102, 89);
            this.add2hr.Name = "add2hr";
            this.add2hr.Size = new System.Drawing.Size(75, 64);
            this.add2hr.TabIndex = 3;
            this.add2hr.Text = "2 Hour";
            this.add2hr.UseVisualStyleBackColor = false;
            this.add2hr.Click += new System.EventHandler(this.add2hr_Click);
            // 
            // add1hr
            // 
            this.add1hr.BackColor = System.Drawing.Color.Thistle;
            this.add1hr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add1hr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add1hr.Location = new System.Drawing.Point(21, 89);
            this.add1hr.Name = "add1hr";
            this.add1hr.Size = new System.Drawing.Size(75, 64);
            this.add1hr.TabIndex = 2;
            this.add1hr.Text = "1 Hour";
            this.add1hr.UseVisualStyleBackColor = false;
            this.add1hr.Click += new System.EventHandler(this.add1hr_Click);
            // 
            // add30min
            // 
            this.add30min.BackColor = System.Drawing.Color.Aquamarine;
            this.add30min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add30min.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add30min.Location = new System.Drawing.Point(102, 19);
            this.add30min.Name = "add30min";
            this.add30min.Size = new System.Drawing.Size(75, 64);
            this.add30min.TabIndex = 1;
            this.add30min.Text = "30 Minutes";
            this.add30min.UseVisualStyleBackColor = false;
            this.add30min.Click += new System.EventHandler(this.add30min_Click);
            // 
            // add25min
            // 
            this.add25min.BackColor = System.Drawing.Color.Aquamarine;
            this.add25min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add25min.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add25min.Location = new System.Drawing.Point(21, 19);
            this.add25min.Name = "add25min";
            this.add25min.Size = new System.Drawing.Size(75, 64);
            this.add25min.TabIndex = 0;
            this.add25min.Text = "25 Minutes";
            this.add25min.UseVisualStyleBackColor = false;
            this.add25min.Click += new System.EventHandler(this.add25min_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.secCtr);
            this.groupBox1.Controls.Add(this.minCtr);
            this.groupBox1.Controls.Add(this.hrCtr);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(17, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 45);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Left";
            // 
            // secCtr
            // 
            this.secCtr.AutoSize = true;
            this.secCtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secCtr.Location = new System.Drawing.Point(116, 20);
            this.secCtr.Name = "secCtr";
            this.secCtr.Size = new System.Drawing.Size(41, 13);
            this.secCtr.TabIndex = 2;
            this.secCtr.Text = "00sec";
            // 
            // minCtr
            // 
            this.minCtr.AutoSize = true;
            this.minCtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCtr.Location = new System.Drawing.Point(75, 20);
            this.minCtr.Name = "minCtr";
            this.minCtr.Size = new System.Drawing.Size(40, 13);
            this.minCtr.TabIndex = 1;
            this.minCtr.Text = "00min";
            // 
            // hrCtr
            // 
            this.hrCtr.AutoSize = true;
            this.hrCtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrCtr.Location = new System.Drawing.Point(41, 20);
            this.hrCtr.Name = "hrCtr";
            this.hrCtr.Size = new System.Drawing.Size(32, 13);
            this.hrCtr.TabIndex = 0;
            this.hrCtr.Text = "00hr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "PCTimer Manager";
            // 
            // recordsBtn
            // 
            this.recordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recordsBtn.Location = new System.Drawing.Point(119, 301);
            this.recordsBtn.Name = "recordsBtn";
            this.recordsBtn.Size = new System.Drawing.Size(99, 23);
            this.recordsBtn.TabIndex = 15;
            this.recordsBtn.Text = "Open Records";
            this.recordsBtn.UseVisualStyleBackColor = true;
            this.recordsBtn.Click += new System.EventHandler(this.recordsBtn_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PCTimer.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(230, 332);
            this.Controls.Add(this.recordsBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(246, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(246, 370);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add2hr;
        private System.Windows.Forms.Button add1hr;
        private System.Windows.Forms.Button add30min;
        private System.Windows.Forms.Button add25min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label secCtr;
        private System.Windows.Forms.Label minCtr;
        private System.Windows.Forms.Label hrCtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recordsBtn;
    }
}