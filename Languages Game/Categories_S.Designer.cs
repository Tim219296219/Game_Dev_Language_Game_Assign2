
namespace Languages_Game
{
    partial class FrmCategoriesS
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
            this.btnPhrases = new System.Windows.Forms.Button();
            this.btnNumbers = new System.Windows.Forms.Button();
            this.btnShapes = new System.Windows.Forms.Button();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnFruits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPhrases
            // 
            this.btnPhrases.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhrases.Location = new System.Drawing.Point(142, 77);
            this.btnPhrases.Name = "btnPhrases";
            this.btnPhrases.Size = new System.Drawing.Size(110, 45);
            this.btnPhrases.TabIndex = 0;
            this.btnPhrases.Text = "Phrases";
            this.btnPhrases.UseVisualStyleBackColor = true;
            this.btnPhrases.Click += new System.EventHandler(this.btnPhrases_Click);
            // 
            // btnNumbers
            // 
            this.btnNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbers.Location = new System.Drawing.Point(142, 137);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(110, 45);
            this.btnNumbers.TabIndex = 1;
            this.btnNumbers.Text = "Numbers";
            this.btnNumbers.UseVisualStyleBackColor = true;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnShapes
            // 
            this.btnShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShapes.Location = new System.Drawing.Point(142, 201);
            this.btnShapes.Name = "btnShapes";
            this.btnShapes.Size = new System.Drawing.Size(110, 45);
            this.btnShapes.TabIndex = 2;
            this.btnShapes.Text = "Shapes";
            this.btnShapes.UseVisualStyleBackColor = true;
            this.btnShapes.Click += new System.EventHandler(this.btnShapes_Click);
            // 
            // btnAnimals
            // 
            this.btnAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimals.Location = new System.Drawing.Point(142, 263);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(110, 45);
            this.btnAnimals.TabIndex = 3;
            this.btnAnimals.Text = "Animals";
            this.btnAnimals.UseVisualStyleBackColor = true;
            this.btnAnimals.Click += new System.EventHandler(this.btnAnimals_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(106, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(179, 25);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "Select a category";
            // 
            // btnFruits
            // 
            this.btnFruits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFruits.Location = new System.Drawing.Point(142, 330);
            this.btnFruits.Name = "btnFruits";
            this.btnFruits.Size = new System.Drawing.Size(110, 45);
            this.btnFruits.TabIndex = 5;
            this.btnFruits.Text = "Fruits";
            this.btnFruits.UseVisualStyleBackColor = true;
            this.btnFruits.Click += new System.EventHandler(this.btnFruits_Click);
            // 
            // FrmCategoriesS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Languages_Game.Properties.Resources.Spain_oragami;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 412);
            this.Controls.Add(this.btnFruits);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnAnimals);
            this.Controls.Add(this.btnShapes);
            this.Controls.Add(this.btnNumbers);
            this.Controls.Add(this.btnPhrases);
            this.MaximizeBox = false;
            this.Name = "FrmCategoriesS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPhrases;
        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.Button btnShapes;
        private System.Windows.Forms.Button btnAnimals;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnFruits;
    }
}