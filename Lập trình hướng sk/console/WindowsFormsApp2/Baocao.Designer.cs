namespace WindowsFormsApp2
{
    partial class Baocao
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
            this.crystalReportViewer_baocao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_baocao
            // 
            this.crystalReportViewer_baocao.ActiveViewIndex = -1;
            this.crystalReportViewer_baocao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_baocao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_baocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_baocao.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_baocao.Name = "crystalReportViewer_baocao";
            this.crystalReportViewer_baocao.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer_baocao.TabIndex = 0;
            // 
            // Baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer_baocao);
            this.Name = "Baocao";
            this.Text = "Baocao";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_baocao;
    }
}