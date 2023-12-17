namespace Backpropagation2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSave = new Button();
            tbInput1 = new TextBox();
            tbInput2 = new TextBox();
            tbInput3 = new TextBox();
            tbInput4 = new TextBox();
            tbOutput = new TextBox();
            btnCreateNN = new Button();
            btnTrainNN = new Button();
            btnTest = new Button();
            btnLoad = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbTestRecord = new ListBox();
            tbEpoch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbHN = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.35483F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.3225861F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.3225861F));
            tableLayoutPanel1.Controls.Add(btnSave, 3, 4);
            tableLayoutPanel1.Controls.Add(tbInput1, 0, 1);
            tableLayoutPanel1.Controls.Add(tbInput2, 0, 2);
            tableLayoutPanel1.Controls.Add(tbInput3, 0, 3);
            tableLayoutPanel1.Controls.Add(tbInput4, 0, 4);
            tableLayoutPanel1.Controls.Add(tbOutput, 2, 2);
            tableLayoutPanel1.Controls.Add(btnCreateNN, 3, 0);
            tableLayoutPanel1.Controls.Add(btnTrainNN, 3, 1);
            tableLayoutPanel1.Controls.Add(btnTest, 3, 2);
            tableLayoutPanel1.Controls.Add(btnLoad, 3, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel1.Location = new Point(55, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999962F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(691, 198);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(474, 159);
            btnSave.Margin = new Padding(10, 3, 10, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(207, 36);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbInput1
            // 
            tbInput1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbInput1.Font = new Font("Segoe UI", 12F);
            tbInput1.Location = new Point(3, 44);
            tbInput1.Margin = new Padding(3, 3, 10, 3);
            tbInput1.Name = "tbInput1";
            tbInput1.Size = new Size(95, 29);
            tbInput1.TabIndex = 0;
            // 
            // tbInput2
            // 
            tbInput2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbInput2.Font = new Font("Segoe UI", 12F);
            tbInput2.Location = new Point(3, 83);
            tbInput2.Margin = new Padding(3, 3, 10, 3);
            tbInput2.Name = "tbInput2";
            tbInput2.Size = new Size(95, 29);
            tbInput2.TabIndex = 1;
            // 
            // tbInput3
            // 
            tbInput3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbInput3.Font = new Font("Segoe UI", 12F);
            tbInput3.Location = new Point(3, 122);
            tbInput3.Margin = new Padding(3, 3, 10, 3);
            tbInput3.Name = "tbInput3";
            tbInput3.Size = new Size(95, 29);
            tbInput3.TabIndex = 2;
            // 
            // tbInput4
            // 
            tbInput4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbInput4.Font = new Font("Segoe UI", 12F);
            tbInput4.Location = new Point(3, 162);
            tbInput4.Margin = new Padding(3, 3, 10, 3);
            tbInput4.Name = "tbInput4";
            tbInput4.Size = new Size(95, 29);
            tbInput4.TabIndex = 3;
            // 
            // tbOutput
            // 
            tbOutput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbOutput.Enabled = false;
            tbOutput.Font = new Font("Segoe UI", 12F);
            tbOutput.Location = new Point(241, 102);
            tbOutput.Margin = new Padding(3, 3, 10, 3);
            tbOutput.Name = "tbOutput";
            tbOutput.PlaceholderText = "Output";
            tbOutput.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(tbOutput, 2);
            tbOutput.Size = new Size(213, 29);
            tbOutput.TabIndex = 4;
            // 
            // btnCreateNN
            // 
            btnCreateNN.Dock = DockStyle.Fill;
            btnCreateNN.Font = new Font("Segoe UI", 12F);
            btnCreateNN.Location = new Point(474, 3);
            btnCreateNN.Margin = new Padding(10, 3, 10, 3);
            btnCreateNN.Name = "btnCreateNN";
            btnCreateNN.Size = new Size(207, 33);
            btnCreateNN.TabIndex = 5;
            btnCreateNN.Text = "Create Neural Network";
            btnCreateNN.UseVisualStyleBackColor = true;
            btnCreateNN.Click += btnCreateNN_Click;
            // 
            // btnTrainNN
            // 
            btnTrainNN.Dock = DockStyle.Fill;
            btnTrainNN.Font = new Font("Segoe UI", 12F);
            btnTrainNN.Location = new Point(474, 42);
            btnTrainNN.Margin = new Padding(10, 3, 10, 3);
            btnTrainNN.Name = "btnTrainNN";
            btnTrainNN.Size = new Size(207, 33);
            btnTrainNN.TabIndex = 6;
            btnTrainNN.Text = "Train the Neural Network";
            btnTrainNN.UseVisualStyleBackColor = true;
            btnTrainNN.Click += btnTrainNN_Click;
            // 
            // btnTest
            // 
            btnTest.Dock = DockStyle.Fill;
            btnTest.Font = new Font("Segoe UI", 12F);
            btnTest.Location = new Point(474, 81);
            btnTest.Margin = new Padding(10, 3, 10, 3);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(207, 33);
            btnTest.TabIndex = 7;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnLoad
            // 
            btnLoad.Dock = DockStyle.Fill;
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(474, 120);
            btnLoad.Margin = new Padding(10, 3, 10, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(207, 33);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load File";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 10;
            label1.Text = "Inputs";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 42);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 4);
            pictureBox1.Size = new Size(124, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lbTestRecord, 2, 0);
            tableLayoutPanel2.Controls.Add(tbEpoch, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(tbHN, 1, 1);
            tableLayoutPanel2.Location = new Point(55, 226);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(691, 188);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lbTestRecord
            // 
            lbTestRecord.Dock = DockStyle.Fill;
            lbTestRecord.Font = new Font("Segoe UI", 10F);
            lbTestRecord.FormattingEnabled = true;
            lbTestRecord.ItemHeight = 17;
            lbTestRecord.Location = new Point(253, 3);
            lbTestRecord.Name = "lbTestRecord";
            tableLayoutPanel2.SetRowSpan(lbTestRecord, 2);
            lbTestRecord.Size = new Size(435, 182);
            lbTestRecord.TabIndex = 2;
            // 
            // tbEpoch
            // 
            tbEpoch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbEpoch.Font = new Font("Segoe UI", 12F);
            tbEpoch.Location = new Point(153, 3);
            tbEpoch.Name = "tbEpoch";
            tbEpoch.Size = new Size(94, 29);
            tbEpoch.TabIndex = 6;
            tbEpoch.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 9;
            label2.Text = "Epochs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 35);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 10;
            label3.Text = "Hidden Neurons";
            // 
            // tbHN
            // 
            tbHN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbHN.Font = new Font("Segoe UI", 12F);
            tbHN.Location = new Point(153, 38);
            tbHN.Name = "tbHN";
            tbHN.Size = new Size(94, 29);
            tbHN.TabIndex = 8;
            tbHN.TextAlign = HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbInput1;
        private TextBox tbInput2;
        private TextBox tbInput3;
        private TextBox tbInput4;
        private TextBox tbOutput;
        private Button btnCreateNN;
        private Button btnTrainNN;
        private Button btnTest;
        private TableLayoutPanel tableLayoutPanel2;
        private ListBox lbTestRecord;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private TextBox tbEpoch;
        private TextBox tbHN;
        private Label label2;
        private Label label3;
        private Button btnLoad;
        private PictureBox pictureBox1;
    }
}
