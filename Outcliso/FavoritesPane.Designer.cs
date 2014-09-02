namespace Outcliso
{
    partial class FavoritesPane
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
            this.Favorites = new System.Windows.Forms.TreeView();
            this.Dossiers = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Favorites
            // 
            this.Favorites.Location = new System.Drawing.Point(19, 236);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(342, 217);
            this.Favorites.TabIndex = 0;
            // 
            // Dossiers
            // 
            this.Dossiers.Location = new System.Drawing.Point(19, 13);
            this.Dossiers.Name = "Dossiers";
            this.Dossiers.Size = new System.Drawing.Size(342, 199);
            this.Dossiers.TabIndex = 1;
            // 
            // FavoritesPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Dossiers);
            this.Controls.Add(this.Favorites);
            this.Name = "FavoritesPane";
            this.Size = new System.Drawing.Size(377, 470);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Favorites;
        private System.Windows.Forms.TreeView Dossiers;
    }
}
