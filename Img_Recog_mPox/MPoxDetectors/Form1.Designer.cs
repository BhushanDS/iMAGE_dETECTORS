namespace MPoxDetectors
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
            this.bAttachImage = new System.Windows.Forms.Button();
            this.bExecutePython = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAttachImage
            // 
            this.bAttachImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAttachImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAttachImage.Location = new System.Drawing.Point(84, 266);
            this.bAttachImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAttachImage.Name = "bAttachImage";
            this.bAttachImage.Size = new System.Drawing.Size(174, 29);
            this.bAttachImage.TabIndex = 0;
            this.bAttachImage.Text = "Attach Image";
            this.bAttachImage.UseVisualStyleBackColor = true;
            this.bAttachImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // bExecutePython
            // 
            this.bExecutePython.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExecutePython.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bExecutePython.Location = new System.Drawing.Point(84, 320);
            this.bExecutePython.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bExecutePython.Name = "bExecutePython";
            this.bExecutePython.Size = new System.Drawing.Size(174, 33);
            this.bExecutePython.TabIndex = 1;
            this.bExecutePython.Text = "Execute Python";
            this.bExecutePython.UseVisualStyleBackColor = true;
            this.bExecutePython.Click += new System.EventHandler(this.bExecutePython_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(59, 22);
            this.pbImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(264, 199);
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.label2);
            this.panelResult.Location = new System.Drawing.Point(0, 368);
            this.panelResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(335, 42);
            this.panelResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(120, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "No Output";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(120, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bAbout
            // 
            this.bAbout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAbout.Location = new System.Drawing.Point(271, 329);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(52, 21);
            this.bAbout.TabIndex = 5;
            this.bAbout.Text = "About";
            this.bAbout.UseVisualStyleBackColor = true;
            this.bAbout.Click += new System.EventHandler(this.bAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(334, 424);
            this.Controls.Add(this.bAbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.bExecutePython);
            this.Controls.Add(this.bAttachImage);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Monkey Pox Detectors";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bAttachImage;
        private Button bExecutePython;
        private PictureBox pbImage;
        private Panel panelResult;
        private Label label1;
        private Label label2;
        private Button bAbout;
    }
}