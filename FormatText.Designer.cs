namespace bai_15formattext
{
    partial class FormatText
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
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblLapTrinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.rabBlack = new System.Windows.Forms.RadioButton();
            this.Bold = new System.Windows.Forms.GroupBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkChan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Bold.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapten
            // 
            this.txtNhapten.Location = new System.Drawing.Point(143, 28);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(241, 20);
            this.txtNhapten.TabIndex = 0;
            this.txtNhapten.Text = "ĐỰC 2009";
            this.txtNhapten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(276, 338);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.ForeColor = System.Drawing.Color.Lime;
            this.lblLapTrinh.Location = new System.Drawing.Point(143, 338);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(100, 20);
            this.lblLapTrinh.TabIndex = 4;
            this.lblLapTrinh.Text = "ĐỰC 2009";
            this.lblLapTrinh.TextChanged += new System.EventHandler(this.lblLapTrinh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(64, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = " Lập Trình Bởi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.rabBlack);
            this.groupBox1.Controls.Add(this.radBlue);
            this.groupBox1.Controls.Add(this.radGreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "color";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.IndianRed;
            this.radRed.Location = new System.Drawing.Point(17, 19);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(40, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(16, 42);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(52, 17);
            this.radGreen.TabIndex = 0;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Cyan;
            this.radBlue.Location = new System.Drawing.Point(17, 65);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(45, 17);
            this.radBlue.TabIndex = 0;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // rabBlack
            // 
            this.rabBlack.AutoSize = true;
            this.rabBlack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rabBlack.Location = new System.Drawing.Point(17, 88);
            this.rabBlack.Name = "rabBlack";
            this.rabBlack.Size = new System.Drawing.Size(51, 17);
            this.rabBlack.TabIndex = 0;
            this.rabBlack.TabStop = true;
            this.rabBlack.Text = "black";
            this.rabBlack.UseVisualStyleBackColor = true;
            this.rabBlack.CheckedChanged += new System.EventHandler(this.rabBlack_CheckedChanged);
            // 
            // Bold
            // 
            this.Bold.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bold.Controls.Add(this.chkChan);
            this.Bold.Controls.Add(this.chkItalic);
            this.Bold.Controls.Add(this.chkBold);
            this.Bold.Location = new System.Drawing.Point(236, 69);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(148, 154);
            this.Bold.TabIndex = 10;
            this.Bold.TabStop = false;
            this.Bold.Text = "Font";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(16, 30);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(72, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(16, 62);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(91, 17);
            this.chkItalic.TabIndex = 0;
            this.chkItalic.Text = "Nghiêng Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkChan
            // 
            this.chkChan.AutoSize = true;
            this.chkChan.Location = new System.Drawing.Point(16, 95);
            this.chkChan.Name = "chkChan";
            this.chkChan.Size = new System.Drawing.Size(77, 17);
            this.chkChan.TabIndex = 0;
            this.chkChan.Text = "gach chân";
            this.chkChan.UseVisualStyleBackColor = true;
            this.chkChan.CheckedChanged += new System.EventHandler(this.chkChan_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(86, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập tên";
            // 
            // FormatText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtNhapten);
            this.Name = "FormatText";
            this.Text = "FormatText";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Bold.ResumeLayout(false);
            this.Bold.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhapten;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox lblLapTrinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox Bold;
        private System.Windows.Forms.CheckBox chkChan;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label label2;
    }
}