namespace Simulate_inventory
{
    partial class Form1
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.inv_11 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.seles = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.seles)).BeginInit();
            this.SuspendLayout();
            // 
            // inv_11
            // 
            this.inv_11.Location = new System.Drawing.Point(12, 12);
            this.inv_11.Name = "inv_11";
            this.inv_11.Size = new System.Drawing.Size(500, 585);
            this.inv_11.TabIndex = 0;
            this.inv_11.TabStop = false;
            this.inv_11.Text = "inventory1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(518, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 585);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "inventory2";
            // 
            // seles
            // 
            this.seles.Location = new System.Drawing.Point(1024, 12);
            this.seles.Name = "seles";
            this.seles.Size = new System.Drawing.Size(120, 20);
            this.seles.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 609);
            this.Controls.Add(this.seles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.inv_11);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.seles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inv_11;
        private System.Windows.Forms.GroupBox groupBox2;


        private one_at[,] inv_1 = new one_at[20, 20];

        private void InitInv1() {
            for(int i=0; i<20; i++){
                for(int j=0; j<20; j++){
                    inv_1[i, j] = new one_at(i, j, this);
                    inv_1[i, j].Location = new System.Drawing.Point(i * 25, j * 25);
                    inv_11.Controls.Add(inv_1[i, j]);
                }
            }
            
        }

        private System.Windows.Forms.NumericUpDown seles;

    }
}

