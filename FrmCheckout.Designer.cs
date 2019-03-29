namespace CHEXC
{
    partial class FrmCheckout
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
            this.statusTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusTime
            // 
            this.statusTime.AutoSize = true;
            this.statusTime.Location = new System.Drawing.Point(13, 13);
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(0, 12);
            this.statusTime.TabIndex = 0;
            // 
            // FrmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 402);
            this.Controls.Add(this.statusTime);
            this.Name = "FrmCheckout";
            this.Text = "收银";
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusTime;
    }
}