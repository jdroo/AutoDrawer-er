﻿namespace AutoDrawerer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transThreshNumeric = new System.Windows.Forms.NumericUpDown();
            this.blackThreshNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.intervalInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pathList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transThreshNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackThreshNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.24242F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.59715F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 555);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Location = new System.Drawing.Point(2, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.transThreshNumeric);
            this.panel1.Controls.Add(this.blackThreshNumeric);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.intervalInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.uploadButton);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 128);
            this.panel1.TabIndex = 1;
            // 
            // transThreshNumeric
            // 
            this.transThreshNumeric.Location = new System.Drawing.Point(214, 103);
            this.transThreshNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.transThreshNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.transThreshNumeric.Name = "transThreshNumeric";
            this.transThreshNumeric.Size = new System.Drawing.Size(63, 20);
            this.transThreshNumeric.TabIndex = 7;
            this.transThreshNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.transThreshNumeric.ValueChanged += new System.EventHandler(this.transThreshNumeric_ValueChanged);
            // 
            // blackThreshNumeric
            // 
            this.blackThreshNumeric.Location = new System.Drawing.Point(214, 81);
            this.blackThreshNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.blackThreshNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blackThreshNumeric.Name = "blackThreshNumeric";
            this.blackThreshNumeric.Size = new System.Drawing.Size(63, 20);
            this.blackThreshNumeric.TabIndex = 6;
            this.blackThreshNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.blackThreshNumeric.ValueChanged += new System.EventHandler(this.blackThreshNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Transparency Threshold (0-255)";
            // 
            // intervalInput
            // 
            this.intervalInput.Location = new System.Drawing.Point(183, 57);
            this.intervalInput.Margin = new System.Windows.Forms.Padding(2);
            this.intervalInput.MaxLength = 10;
            this.intervalInput.Name = "intervalInput";
            this.intervalInput.Size = new System.Drawing.Size(94, 20);
            this.intervalInput.TabIndex = 7;
            this.intervalInput.Text = "100000";
            this.intervalInput.TextChanged += new System.EventHandler(this.intervalInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Black Threshold (0-255)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Interval (100 nanoseconds)";
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(0, 25);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(288, 25);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear Image";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.AutoSize = true;
            this.uploadButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(0, 0);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(2);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(288, 25);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Load Image";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.customButton);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pathList);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.processButton);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Location = new System.Drawing.Point(462, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 128);
            this.panel2.TabIndex = 2;
            // 
            // customButton
            // 
            this.customButton.AutoSize = true;
            this.customButton.Location = new System.Drawing.Point(11, 98);
            this.customButton.Margin = new System.Windows.Forms.Padding(2);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(92, 23);
            this.customButton.TabIndex = 11;
            this.customButton.Text = "Custom";
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(17, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Must process image before drawing";
            // 
            // pathList
            // 
            this.pathList.DisplayMember = "name";
            this.pathList.FormattingEnabled = true;
            this.pathList.Location = new System.Drawing.Point(121, 85);
            this.pathList.Margin = new System.Windows.Forms.Padding(2);
            this.pathList.Name = "pathList";
            this.pathList.Size = new System.Drawing.Size(149, 43);
            this.pathList.TabIndex = 9;
            this.pathList.ValueMember = "path";
            this.pathList.SelectedIndexChanged += new System.EventHandler(this.pathList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Drawing Patterns";
            // 
            // processButton
            // 
            this.processButton.AutoSize = true;
            this.processButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(0, 25);
            this.processButton.Margin = new System.Windows.Forms.Padding(2);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(288, 25);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "Process Image";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(0, 0);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(288, 25);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "DRAW";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.widthInput);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 502);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 51);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Width";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(41, 14);
            this.widthInput.Margin = new System.Windows.Forms.Padding(2);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(207, 20);
            this.widthInput.TabIndex = 1;
            this.widthInput.TextChanged += new System.EventHandler(this.widthInput_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.heightInput);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(462, 502);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(288, 51);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Height";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(44, 14);
            this.heightInput.Margin = new System.Windows.Forms.Padding(2);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(205, 20);
            this.heightInput.TabIndex = 2;
            this.heightInput.TextChanged += new System.EventHandler(this.heightInput_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Image File";
            this.openFileDialog1.Filter = "(*jpeg, *.jpg, *.png, *.bmp)|*jpeg;*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(752, 555);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(768, 594);
            this.Name = "Form1";
            this.Text = "AutoDrawer-er";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transThreshNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackThreshNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox intervalInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown transThreshNumeric;
        private System.Windows.Forms.NumericUpDown blackThreshNumeric;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.ListBox pathList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button customButton;
    }
}

