//author YD

namespace ProgrammingLanguageConceptsA3
{
    partial class ViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.panelInstruction = new System.Windows.Forms.Panel();
            this.lblCurveLength = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelPointColor = new System.Windows.Forms.Label();
            this.labelLineColor = new System.Windows.Forms.Label();
            this.cmbLineColor = new System.Windows.Forms.ComboBox();
            this.cmbPointColor = new System.Windows.Forms.ComboBox();
            this.labelCoordinateAxis = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCurveLength = new System.Windows.Forms.Button();
            this.labelDrawingArea = new System.Windows.Forms.Label();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInstruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInstruction
            // 
            this.panelInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInstruction.Controls.Add(this.lblCurveLength);
            this.panelInstruction.Controls.Add(this.labelY);
            this.panelInstruction.Controls.Add(this.labelX);
            this.panelInstruction.Controls.Add(this.labelPointColor);
            this.panelInstruction.Controls.Add(this.labelLineColor);
            this.panelInstruction.Controls.Add(this.cmbLineColor);
            this.panelInstruction.Controls.Add(this.cmbPointColor);
            this.panelInstruction.Controls.Add(this.labelCoordinateAxis);
            this.panelInstruction.Controls.Add(this.btnExit);
            this.panelInstruction.Controls.Add(this.btnCurveLength);
            this.panelInstruction.Location = new System.Drawing.Point(574, 49);
            this.panelInstruction.Name = "panelInstruction";
            this.panelInstruction.Size = new System.Drawing.Size(339, 435);
            this.panelInstruction.TabIndex = 1;
            // 
            // lblCurveLength
            // 
            this.lblCurveLength.AutoSize = true;
            this.lblCurveLength.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurveLength.ForeColor = System.Drawing.Color.Navy;
            this.lblCurveLength.Location = new System.Drawing.Point(106, 72);
            this.lblCurveLength.Name = "lblCurveLength";
            this.lblCurveLength.Size = new System.Drawing.Size(0, 17);
            this.lblCurveLength.TabIndex = 10;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(186, 144);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(0, 17);
            this.labelY.TabIndex = 9;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(89, 143);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(0, 17);
            this.labelX.TabIndex = 8;
            // 
            // labelPointColor
            // 
            this.labelPointColor.AutoSize = true;
            this.labelPointColor.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPointColor.Location = new System.Drawing.Point(28, 179);
            this.labelPointColor.Name = "labelPointColor";
            this.labelPointColor.Size = new System.Drawing.Size(295, 15);
            this.labelPointColor.TabIndex = 7;
            this.labelPointColor.Text = "Select to change the point color";
            // 
            // labelLineColor
            // 
            this.labelLineColor.AutoSize = true;
            this.labelLineColor.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelLineColor.Location = new System.Drawing.Point(28, 261);
            this.labelLineColor.Name = "labelLineColor";
            this.labelLineColor.Size = new System.Drawing.Size(286, 15);
            this.labelLineColor.TabIndex = 6;
            this.labelLineColor.Text = "Select to change the line color";
            // 
            // cmbLineColor
            // 
            this.cmbLineColor.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLineColor.FormattingEnabled = true;
            this.cmbLineColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue"});
            this.cmbLineColor.Location = new System.Drawing.Point(46, 293);
            this.cmbLineColor.Name = "cmbLineColor";
            this.cmbLineColor.Size = new System.Drawing.Size(250, 25);
            this.cmbLineColor.TabIndex = 5;
            // 
            // cmbPointColor
            // 
            this.cmbPointColor.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPointColor.FormattingEnabled = true;
            this.cmbPointColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue"});
            this.cmbPointColor.Location = new System.Drawing.Point(46, 220);
            this.cmbPointColor.Name = "cmbPointColor";
            this.cmbPointColor.Size = new System.Drawing.Size(250, 25);
            this.cmbPointColor.TabIndex = 4;
            // 
            // labelCoordinateAxis
            // 
            this.labelCoordinateAxis.AutoSize = true;
            this.labelCoordinateAxis.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordinateAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCoordinateAxis.Location = new System.Drawing.Point(35, 107);
            this.labelCoordinateAxis.Name = "labelCoordinateAxis";
            this.labelCoordinateAxis.Size = new System.Drawing.Size(288, 17);
            this.labelCoordinateAxis.TabIndex = 2;
            this.labelCoordinateAxis.Text = "Coordinates of axises (x, y)";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(46, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCurveLength
            // 
            this.btnCurveLength.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCurveLength.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurveLength.Location = new System.Drawing.Point(46, 3);
            this.btnCurveLength.Name = "btnCurveLength";
            this.btnCurveLength.Size = new System.Drawing.Size(250, 47);
            this.btnCurveLength.TabIndex = 0;
            this.btnCurveLength.Text = "Calculate Curve Length ";
            this.btnCurveLength.UseVisualStyleBackColor = true;
            this.btnCurveLength.Click += new System.EventHandler(this.btnCurveLength_Click);
            // 
            // labelDrawingArea
            // 
            this.labelDrawingArea.AutoSize = true;
            this.labelDrawingArea.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrawingArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDrawingArea.Location = new System.Drawing.Point(176, 9);
            this.labelDrawingArea.Name = "labelDrawingArea";
            this.labelDrawingArea.Size = new System.Drawing.Size(207, 28);
            this.labelDrawingArea.TabIndex = 2;
            this.labelDrawingArea.Tag = "";
            this.labelDrawingArea.Text = "Drawing Area ";
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelInstruction.Location = new System.Drawing.Point(9, 491);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(799, 15);
            this.labelInstruction.TabIndex = 3;
            this.labelInstruction.Tag = "";
            this.labelInstruction.Text = "Left click to add a point, Right click to delete, or delete by right clicking dir" +
    "ectly to the point";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 435);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCurveLength;
            this.ClientSize = new System.Drawing.Size(917, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.labelDrawingArea);
            this.Controls.Add(this.panelInstruction);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewer Form";
            this.panelInstruction.ResumeLayout(false);
            this.panelInstruction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelInstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelCoordinateAxis;
        private System.Windows.Forms.Label labelPointColor;
        private System.Windows.Forms.Label labelLineColor;
        private System.Windows.Forms.ComboBox cmbLineColor;
        private System.Windows.Forms.ComboBox cmbPointColor;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button btnCurveLength;
        private System.Windows.Forms.Label labelDrawingArea;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurveLength;
    }
}

