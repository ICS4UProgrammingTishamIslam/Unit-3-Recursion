namespace BubbleSortTishamI
{
    partial class BubbleSortBinarySearchForm
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
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.nudArraySize = new System.Windows.Forms.NumericUpDown();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.chkReversed = new System.Windows.Forms.CheckBox();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.nudSearch = new System.Windows.Forms.NumericUpDown();
            this.chkApprox = new System.Windows.Forms.CheckBox();
            this.lblSearchVal = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRecursiveBinary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudArraySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(9, 19);
            this.btnCreateArray.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(99, 31);
            this.btnCreateArray.TabIndex = 0;
            this.btnCreateArray.Text = "Create Array";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.BtnCreateArray_Click);
            // 
            // nudArraySize
            // 
            this.nudArraySize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudArraySize.Location = new System.Drawing.Point(129, 26);
            this.nudArraySize.Margin = new System.Windows.Forms.Padding(2);
            this.nudArraySize.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudArraySize.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudArraySize.Name = "nudArraySize";
            this.nudArraySize.Size = new System.Drawing.Size(90, 20);
            this.nudArraySize.TabIndex = 1;
            this.nudArraySize.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArray.Location = new System.Drawing.Point(9, 79);
            this.lblArray.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(0, 18);
            this.lblArray.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(240, 19);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(99, 31);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort Array";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // chkReversed
            // 
            this.chkReversed.AutoSize = true;
            this.chkReversed.Location = new System.Drawing.Point(357, 27);
            this.chkReversed.Margin = new System.Windows.Forms.Padding(2);
            this.chkReversed.Name = "chkReversed";
            this.chkReversed.Size = new System.Drawing.Size(72, 17);
            this.chkReversed.TabIndex = 6;
            this.chkReversed.Text = "Reversed";
            this.chkReversed.UseVisualStyleBackColor = true;
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Location = new System.Drawing.Point(447, 19);
            this.btnBinarySearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(99, 31);
            this.btnBinarySearch.TabIndex = 7;
            this.btnBinarySearch.Text = "Binary Search";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.BtnBinarySearch_Click);
            // 
            // nudSearch
            // 
            this.nudSearch.Location = new System.Drawing.Point(566, 26);
            this.nudSearch.Margin = new System.Windows.Forms.Padding(2);
            this.nudSearch.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudSearch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSearch.Name = "nudSearch";
            this.nudSearch.Size = new System.Drawing.Size(90, 20);
            this.nudSearch.TabIndex = 8;
            this.nudSearch.Value = new decimal(new int[] {
            413,
            0,
            0,
            0});
            // 
            // chkApprox
            // 
            this.chkApprox.AutoSize = true;
            this.chkApprox.Location = new System.Drawing.Point(676, 26);
            this.chkApprox.Margin = new System.Windows.Forms.Padding(2);
            this.chkApprox.Name = "chkApprox";
            this.chkApprox.Size = new System.Drawing.Size(90, 17);
            this.chkApprox.TabIndex = 9;
            this.chkApprox.Text = "Approximated";
            this.chkApprox.UseVisualStyleBackColor = true;
            // 
            // lblSearchVal
            // 
            this.lblSearchVal.AutoSize = true;
            this.lblSearchVal.Location = new System.Drawing.Point(10, 429);
            this.lblSearchVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchVal.Name = "lblSearchVal";
            this.lblSearchVal.Size = new System.Drawing.Size(0, 13);
            this.lblSearchVal.TabIndex = 10;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(77, 534);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(142, 37);
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "IMPORT ARRAY";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(649, 534);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(142, 37);
            this.btnOutput.TabIndex = 12;
            this.btnOutput.Text = "OUTPUT RESULTS";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.BtnOutput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 498);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(265, 20);
            this.txtInput.TabIndex = 13;
            this.txtInput.Text = "input.txt";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(588, 498);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(265, 20);
            this.txtOutput.TabIndex = 14;
            this.txtOutput.Text = "output.txt";
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(302, 498);
            this.txtExport.Name = "txtExport";
            this.txtExport.Size = new System.Drawing.Size(265, 20);
            this.txtExport.TabIndex = 16;
            this.txtExport.Text = "export.txt";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(366, 534);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(142, 37);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "EXPORT ARRAY";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnRecursiveBinary
            // 
            this.btnRecursiveBinary.Location = new System.Drawing.Point(770, 23);
            this.btnRecursiveBinary.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecursiveBinary.Name = "btnRecursiveBinary";
            this.btnRecursiveBinary.Size = new System.Drawing.Size(74, 21);
            this.btnRecursiveBinary.TabIndex = 17;
            this.btnRecursiveBinary.Text = "RBinary";
            this.btnRecursiveBinary.UseVisualStyleBackColor = true;
            this.btnRecursiveBinary.Click += new System.EventHandler(this.BtnRecursiveBinary_Click);
            // 
            // BubbleSortBinarySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 583);
            this.Controls.Add(this.btnRecursiveBinary);
            this.Controls.Add(this.txtExport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblSearchVal);
            this.Controls.Add(this.chkApprox);
            this.Controls.Add(this.nudSearch);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.chkReversed);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.nudArraySize);
            this.Controls.Add(this.btnCreateArray);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BubbleSortBinarySearchForm";
            this.Text = "BubbleSort/BinarySearch by TishamI";
            ((System.ComponentModel.ISupportInitialize)(this.nudArraySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.NumericUpDown nudArraySize;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.CheckBox chkReversed;
        private System.Windows.Forms.Button btnBinarySearch;
        private System.Windows.Forms.NumericUpDown nudSearch;
        private System.Windows.Forms.CheckBox chkApprox;
        private System.Windows.Forms.Label lblSearchVal;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRecursiveBinary;
    }
}

