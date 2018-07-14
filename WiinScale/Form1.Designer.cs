namespace WiinScale
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
            this.ConnectionStatus = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionStatus.Location = new System.Drawing.Point(0, 0);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(421, 25);
            this.ConnectionStatus.TabIndex = 0;
            this.ConnectionStatus.Text = "...";
            // 
            // Weight
            // 
            this.Weight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(0, 0);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(421, 248);
            this.Weight.TabIndex = 1;
            this.Weight.Text = "...";
            this.Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ConnectionStatus);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Weight);
            this.splitContainer1.Size = new System.Drawing.Size(421, 277);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 277);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "WiinScale";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ConnectionStatus;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

