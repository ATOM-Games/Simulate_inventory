namespace Simulate_inventory
{
    partial class one_at
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(panel1_MouseHover);
            this.panel1.MouseLeave += new System.EventHandler(panel1_MouseLeave);
            // 
            // one_at
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "one_at";
            this.Size = new System.Drawing.Size(25, 25);
            this.ResumeLayout(false);

        }

        void panel1_MouseLeave(object sender, System.EventArgs e)
        {
            this.mathForm.clearSelect();//.defaultState();
        }

        void panel1_MouseHover(object sender, System.EventArgs e)
        {
            this.mathForm.checkedd(this._X, this._Y);//.SelectState();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
    }
}
