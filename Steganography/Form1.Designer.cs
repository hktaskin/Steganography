namespace Steganography
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
            this.rdbHide = new System.Windows.Forms.RadioButton();
            this.rdbExtract = new System.Windows.Forms.RadioButton();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnHideOrExtract = new System.Windows.Forms.Button();
            this.btnDataBrowse = new System.Windows.Forms.Button();
            this.btnOutputBrowse = new System.Windows.Forms.Button();
            this.btnInputBrowse = new System.Windows.Forms.Button();
            this.cmbHideLevel = new System.Windows.Forms.ComboBox();
            this.lblline = new System.Windows.Forms.Label();
            this.btnToggleMSB = new System.Windows.Forms.Button();
            this.btnToggleLSB = new System.Windows.Forms.Button();
            this.btnGenFile = new System.Windows.Forms.Button();
            this.nupFilebytes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupFilebytes)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbHide
            // 
            this.rdbHide.AutoSize = true;
            this.rdbHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbHide.Location = new System.Drawing.Point(15, 15);
            this.rdbHide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbHide.Name = "rdbHide";
            this.rdbHide.Size = new System.Drawing.Size(74, 29);
            this.rdbHide.TabIndex = 0;
            this.rdbHide.TabStop = true;
            this.rdbHide.Text = "Hide";
            this.rdbHide.UseVisualStyleBackColor = true;
            this.rdbHide.CheckedChanged += new System.EventHandler(this.rdbHide_CheckedChanged);
            // 
            // rdbExtract
            // 
            this.rdbExtract.AutoSize = true;
            this.rdbExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbExtract.Location = new System.Drawing.Point(97, 15);
            this.rdbExtract.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbExtract.Name = "rdbExtract";
            this.rdbExtract.Size = new System.Drawing.Size(97, 29);
            this.rdbExtract.TabIndex = 1;
            this.rdbExtract.TabStop = true;
            this.rdbExtract.Text = "Extract";
            this.rdbExtract.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblData.Location = new System.Drawing.Point(15, 141);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(98, 25);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data File";
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtData.Location = new System.Drawing.Point(170, 138);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(335, 31);
            this.txtData.TabIndex = 11;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutput.Location = new System.Drawing.Point(170, 97);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(335, 31);
            this.txtOutput.TabIndex = 8;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOut.Location = new System.Drawing.Point(14, 100);
            this.lblOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(148, 25);
            this.lblOut.TabIndex = 7;
            this.lblOut.Text = "Output Bitmap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(315, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hide Level (in bits)";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIn.Location = new System.Drawing.Point(15, 59);
            this.lblIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(131, 25);
            this.lblIn.TabIndex = 4;
            this.lblIn.Text = "Input Bitmap";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInput.Location = new System.Drawing.Point(170, 56);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(335, 31);
            this.txtInput.TabIndex = 5;
            // 
            // btnHideOrExtract
            // 
            this.btnHideOrExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHideOrExtract.Location = new System.Drawing.Point(170, 179);
            this.btnHideOrExtract.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHideOrExtract.Name = "btnHideOrExtract";
            this.btnHideOrExtract.Size = new System.Drawing.Size(248, 46);
            this.btnHideOrExtract.TabIndex = 13;
            this.btnHideOrExtract.Text = "Hide or Extract";
            this.btnHideOrExtract.UseVisualStyleBackColor = true;
            this.btnHideOrExtract.Click += new System.EventHandler(this.btnHideOrExtract_Click);
            // 
            // btnDataBrowse
            // 
            this.btnDataBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDataBrowse.Location = new System.Drawing.Point(513, 136);
            this.btnDataBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDataBrowse.Name = "btnDataBrowse";
            this.btnDataBrowse.Size = new System.Drawing.Size(112, 35);
            this.btnDataBrowse.TabIndex = 12;
            this.btnDataBrowse.Text = "Browse";
            this.btnDataBrowse.UseVisualStyleBackColor = true;
            this.btnDataBrowse.Click += new System.EventHandler(this.Browse);
            // 
            // btnOutputBrowse
            // 
            this.btnOutputBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOutputBrowse.Location = new System.Drawing.Point(513, 95);
            this.btnOutputBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.Size = new System.Drawing.Size(112, 35);
            this.btnOutputBrowse.TabIndex = 9;
            this.btnOutputBrowse.Text = "Browse";
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            this.btnOutputBrowse.Click += new System.EventHandler(this.Browse);
            // 
            // btnInputBrowse
            // 
            this.btnInputBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInputBrowse.Location = new System.Drawing.Point(513, 54);
            this.btnInputBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInputBrowse.Name = "btnInputBrowse";
            this.btnInputBrowse.Size = new System.Drawing.Size(112, 35);
            this.btnInputBrowse.TabIndex = 6;
            this.btnInputBrowse.Text = "Browse";
            this.btnInputBrowse.UseVisualStyleBackColor = true;
            this.btnInputBrowse.Click += new System.EventHandler(this.Browse);
            // 
            // cmbHideLevel
            // 
            this.cmbHideLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHideLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHideLevel.FormattingEnabled = true;
            this.cmbHideLevel.Location = new System.Drawing.Point(513, 14);
            this.cmbHideLevel.Name = "cmbHideLevel";
            this.cmbHideLevel.Size = new System.Drawing.Size(75, 33);
            this.cmbHideLevel.TabIndex = 3;
            // 
            // lblline
            // 
            this.lblline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblline.BackColor = System.Drawing.Color.Black;
            this.lblline.ForeColor = System.Drawing.Color.White;
            this.lblline.Location = new System.Drawing.Point(15, 230);
            this.lblline.Name = "lblline";
            this.lblline.Size = new System.Drawing.Size(610, 4);
            this.lblline.TabIndex = 14;
            // 
            // btnToggleMSB
            // 
            this.btnToggleMSB.Location = new System.Drawing.Point(13, 246);
            this.btnToggleMSB.Name = "btnToggleMSB";
            this.btnToggleMSB.Size = new System.Drawing.Size(303, 36);
            this.btnToggleMSB.TabIndex = 15;
            this.btnToggleMSB.Text = "Toggle MSB of the bytes in BMP File";
            this.btnToggleMSB.UseVisualStyleBackColor = true;
            this.btnToggleMSB.Click += new System.EventHandler(this.btnToggleMSB_Click);
            // 
            // btnToggleLSB
            // 
            this.btnToggleLSB.Location = new System.Drawing.Point(322, 246);
            this.btnToggleLSB.Name = "btnToggleLSB";
            this.btnToggleLSB.Size = new System.Drawing.Size(303, 36);
            this.btnToggleLSB.TabIndex = 16;
            this.btnToggleLSB.Text = "Toggle LSB of the bytes in BMP File";
            this.btnToggleLSB.UseVisualStyleBackColor = true;
            this.btnToggleLSB.Click += new System.EventHandler(this.btnToggleLSB_Click);
            // 
            // btnGenFile
            // 
            this.btnGenFile.Location = new System.Drawing.Point(13, 288);
            this.btnGenFile.Name = "btnGenFile";
            this.btnGenFile.Size = new System.Drawing.Size(183, 36);
            this.btnGenFile.TabIndex = 17;
            this.btnGenFile.Text = "Generate Random File";
            this.btnGenFile.UseVisualStyleBackColor = true;
            this.btnGenFile.Click += new System.EventHandler(this.btnGenFile_Click);
            // 
            // nupFilebytes
            // 
            this.nupFilebytes.Location = new System.Drawing.Point(202, 294);
            this.nupFilebytes.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nupFilebytes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupFilebytes.Name = "nupFilebytes";
            this.nupFilebytes.Size = new System.Drawing.Size(114, 26);
            this.nupFilebytes.TabIndex = 18;
            this.nupFilebytes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "bytes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupFilebytes);
            this.Controls.Add(this.btnGenFile);
            this.Controls.Add(this.btnToggleLSB);
            this.Controls.Add(this.btnToggleMSB);
            this.Controls.Add(this.lblline);
            this.Controls.Add(this.cmbHideLevel);
            this.Controls.Add(this.btnInputBrowse);
            this.Controls.Add(this.btnOutputBrowse);
            this.Controls.Add(this.btnDataBrowse);
            this.Controls.Add(this.btnHideOrExtract);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.rdbExtract);
            this.Controls.Add(this.rdbHide);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Steganography - Halil Kemal TAŞKIN - hkt.me";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupFilebytes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbHide;
        private System.Windows.Forms.RadioButton rdbExtract;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnHideOrExtract;
        private System.Windows.Forms.Button btnDataBrowse;
        private System.Windows.Forms.Button btnOutputBrowse;
        private System.Windows.Forms.Button btnInputBrowse;
        private System.Windows.Forms.ComboBox cmbHideLevel;
        private System.Windows.Forms.Label lblline;
        private System.Windows.Forms.Button btnToggleMSB;
        private System.Windows.Forms.Button btnToggleLSB;
        private System.Windows.Forms.Button btnGenFile;
        private System.Windows.Forms.NumericUpDown nupFilebytes;
        private System.Windows.Forms.Label label1;
    }
}

