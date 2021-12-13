
namespace GenshinPityCounter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.starSelectCB = new System.Windows.Forms.ComboBox();
            this.wishesSinceLbl = new System.Windows.Forms.Label();
            this.wishCounterValue = new System.Windows.Forms.NumericUpDown();
            this.incrementCouterLbl = new System.Windows.Forms.Button();
            this.decrementCounterLbl = new System.Windows.Forms.Button();
            this.resetCounterBtn = new System.Windows.Forms.Button();
            this.chanceLbl = new System.Windows.Forms.Label();
            this.wishesNeededLbl = new System.Windows.Forms.Label();
            this.chanceValueLbl = new System.Windows.Forms.Label();
            this.wishesNeededValueLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wishCounterValue)).BeginInit();
            this.SuspendLayout();
            // 
            // starSelectCB
            // 
            this.starSelectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starSelectCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.starSelectCB.FormattingEnabled = true;
            this.starSelectCB.Items.AddRange(new object[] {
            "4-Star pity",
            "5-Star pity"});
            this.starSelectCB.Location = new System.Drawing.Point(12, 12);
            this.starSelectCB.Name = "starSelectCB";
            this.starSelectCB.Size = new System.Drawing.Size(376, 24);
            this.starSelectCB.TabIndex = 0;
            this.starSelectCB.SelectedIndexChanged += new System.EventHandler(this.starSelectCB_SelectedIndexChanged);
            // 
            // wishesSinceLbl
            // 
            this.wishesSinceLbl.AutoSize = true;
            this.wishesSinceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wishesSinceLbl.Location = new System.Drawing.Point(12, 61);
            this.wishesSinceLbl.Name = "wishesSinceLbl";
            this.wishesSinceLbl.Size = new System.Drawing.Size(172, 16);
            this.wishesSinceLbl.TabIndex = 1;
            this.wishesSinceLbl.Text = "Wishes since last 4-star";
            // 
            // wishCounterValue
            // 
            this.wishCounterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wishCounterValue.Location = new System.Drawing.Point(268, 59);
            this.wishCounterValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.wishCounterValue.Name = "wishCounterValue";
            this.wishCounterValue.Size = new System.Drawing.Size(120, 21);
            this.wishCounterValue.TabIndex = 2;
            this.wishCounterValue.ValueChanged += new System.EventHandler(this.wishCounterValue_ValueChanged);
            // 
            // incrementCouterLbl
            // 
            this.incrementCouterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incrementCouterLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.incrementCouterLbl.Location = new System.Drawing.Point(15, 102);
            this.incrementCouterLbl.Name = "incrementCouterLbl";
            this.incrementCouterLbl.Size = new System.Drawing.Size(120, 23);
            this.incrementCouterLbl.TabIndex = 3;
            this.incrementCouterLbl.Text = "Add Wish";
            this.incrementCouterLbl.UseVisualStyleBackColor = true;
            this.incrementCouterLbl.Click += new System.EventHandler(this.incrementCouterLbl_Click);
            // 
            // decrementCounterLbl
            // 
            this.decrementCounterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decrementCounterLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decrementCounterLbl.Location = new System.Drawing.Point(141, 102);
            this.decrementCounterLbl.Name = "decrementCounterLbl";
            this.decrementCounterLbl.Size = new System.Drawing.Size(120, 23);
            this.decrementCounterLbl.TabIndex = 4;
            this.decrementCounterLbl.Text = "Remove Wish";
            this.decrementCounterLbl.UseVisualStyleBackColor = true;
            this.decrementCounterLbl.Click += new System.EventHandler(this.decrementCounterLbl_Click);
            // 
            // resetCounterBtn
            // 
            this.resetCounterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetCounterBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetCounterBtn.Location = new System.Drawing.Point(268, 102);
            this.resetCounterBtn.Name = "resetCounterBtn";
            this.resetCounterBtn.Size = new System.Drawing.Size(120, 23);
            this.resetCounterBtn.TabIndex = 5;
            this.resetCounterBtn.Text = "Reset to 0";
            this.resetCounterBtn.UseVisualStyleBackColor = true;
            this.resetCounterBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // chanceLbl
            // 
            this.chanceLbl.AutoSize = true;
            this.chanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chanceLbl.Location = new System.Drawing.Point(12, 151);
            this.chanceLbl.Name = "chanceLbl";
            this.chanceLbl.Size = new System.Drawing.Size(205, 16);
            this.chanceLbl.TabIndex = 6;
            this.chanceLbl.Text = "Thoretical chance for 4-star: \r\n";
            // 
            // wishesNeededLbl
            // 
            this.wishesNeededLbl.AutoSize = true;
            this.wishesNeededLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wishesNeededLbl.Location = new System.Drawing.Point(12, 188);
            this.wishesNeededLbl.Name = "wishesNeededLbl";
            this.wishesNeededLbl.Size = new System.Drawing.Size(206, 16);
            this.wishesNeededLbl.TabIndex = 7;
            this.wishesNeededLbl.Text = "Wishes to guaranteed 4-star:";
            // 
            // chanceValueLbl
            // 
            this.chanceValueLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chanceValueLbl.AutoSize = true;
            this.chanceValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chanceValueLbl.Location = new System.Drawing.Point(267, 147);
            this.chanceValueLbl.Name = "chanceValueLbl";
            this.chanceValueLbl.Size = new System.Drawing.Size(121, 20);
            this.chanceValueLbl.TabIndex = 8;
            this.chanceValueLbl.Text = "ResetCounter";
            this.chanceValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wishesNeededValueLbl
            // 
            this.wishesNeededValueLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wishesNeededValueLbl.AutoSize = true;
            this.wishesNeededValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wishesNeededValueLbl.Location = new System.Drawing.Point(267, 188);
            this.wishesNeededValueLbl.Name = "wishesNeededValueLbl";
            this.wishesNeededValueLbl.Size = new System.Drawing.Size(121, 20);
            this.wishesNeededValueLbl.TabIndex = 9;
            this.wishesNeededValueLbl.Text = "ResetCounter";
            this.wishesNeededValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "*theoretical chance based on flat values, not including fluctuations and soft pit" +
    "y";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(400, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wishesNeededValueLbl);
            this.Controls.Add(this.chanceValueLbl);
            this.Controls.Add(this.wishesNeededLbl);
            this.Controls.Add(this.chanceLbl);
            this.Controls.Add(this.resetCounterBtn);
            this.Controls.Add(this.decrementCounterLbl);
            this.Controls.Add(this.incrementCouterLbl);
            this.Controls.Add(this.wishCounterValue);
            this.Controls.Add(this.wishesSinceLbl);
            this.Controls.Add(this.starSelectCB);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gemsin Pity Counter v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.wishCounterValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox starSelectCB;
        private System.Windows.Forms.Label wishesSinceLbl;
        private System.Windows.Forms.NumericUpDown wishCounterValue;
        private System.Windows.Forms.Button incrementCouterLbl;
        private System.Windows.Forms.Button decrementCounterLbl;
        private System.Windows.Forms.Button resetCounterBtn;
        private System.Windows.Forms.Label chanceLbl;
        private System.Windows.Forms.Label wishesNeededLbl;
        private System.Windows.Forms.Label chanceValueLbl;
        private System.Windows.Forms.Label wishesNeededValueLbl;
        private System.Windows.Forms.Label label1;
    }
}

