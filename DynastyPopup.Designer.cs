namespace L5R
{
    partial class DynastyPopup
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


       




        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.buttonPass = new System.Windows.Forms.Button();
            this.purchaseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(13, 298);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(75, 23);
            this.buttonPurchase.TabIndex = 0;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // buttonPass
            // 
            this.buttonPass.Location = new System.Drawing.Point(170, 298);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(75, 23);
            this.buttonPass.TabIndex = 1;
            this.buttonPass.Text = "Pass";
            this.buttonPass.UseVisualStyleBackColor = true;
            // 
            // purchaseTableLayoutPanel
            // 
            this.purchaseTableLayoutPanel.ColumnCount = 1;
            this.purchaseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.purchaseTableLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.purchaseTableLayoutPanel.Name = "purchaseTableLayoutPanel";
            this.purchaseTableLayoutPanel.RowCount = 5;
            this.purchaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.purchaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.purchaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.purchaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.purchaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.purchaseTableLayoutPanel.Size = new System.Drawing.Size(232, 266);
            this.purchaseTableLayoutPanel.TabIndex = 2;
            // 
            // DynastyPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 329);
            this.Controls.Add(this.purchaseTableLayoutPanel);
            this.Controls.Add(this.buttonPass);
            this.Controls.Add(this.buttonPurchase);
            this.Name = "DynastyPopup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.TableLayoutPanel purchaseTableLayoutPanel;
    }
}
