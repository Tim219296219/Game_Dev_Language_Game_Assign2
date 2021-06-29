
namespace Languages_Game
{
    partial class FrmLangSelect
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
            this.btnFrench = new System.Windows.Forms.Button();
            this.btnSpanish = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFrench
            // 
            this.btnFrench.BackgroundImage = global::Languages_Game.Properties.Resources.france;
            this.btnFrench.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrench.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrench.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFrench.Location = new System.Drawing.Point(147, 76);
            this.btnFrench.Name = "btnFrench";
            this.btnFrench.Size = new System.Drawing.Size(91, 72);
            this.btnFrench.TabIndex = 0;
            this.btnFrench.UseVisualStyleBackColor = true;
            this.btnFrench.Click += new System.EventHandler(this.btnFrench_Click);
            // 
            // btnSpanish
            // 
            this.btnSpanish.BackgroundImage = global::Languages_Game.Properties.Resources.spain;
            this.btnSpanish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpanish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpanish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpanish.Location = new System.Drawing.Point(147, 180);
            this.btnSpanish.Name = "btnSpanish";
            this.btnSpanish.Size = new System.Drawing.Size(91, 72);
            this.btnSpanish.TabIndex = 1;
            this.btnSpanish.UseVisualStyleBackColor = true;
            this.btnSpanish.Click += new System.EventHandler(this.btnSpanish_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(104, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(185, 25);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Select a language";
            // 
            // FrmLangSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Languages_Game.Properties.Resources.Select_language_21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 282);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnSpanish);
            this.Controls.Add(this.btnFrench);
            this.MaximizeBox = false;
            this.Name = "FrmLangSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrench;
        private System.Windows.Forms.Button btnSpanish;
        private System.Windows.Forms.Label lblHeading;
    }
}