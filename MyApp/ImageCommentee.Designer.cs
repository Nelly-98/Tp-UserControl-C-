
namespace MyApp
{
    partial class ImageCommentee
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Instanciation de la classe ImageConnectée
        //ImageCommentee img = new ImageCommentee();

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageCommentee));
            this.picture = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.commentaire = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelLieu = new System.Windows.Forms.Label();
            this.labelLargeur = new System.Windows.Forms.Label();
            this.labelHauteur = new System.Windows.Forms.Label();
            this.largeur = new System.Windows.Forms.TextBox();
            this.hauteur = new System.Windows.Forms.TextBox();
            this.lieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.AccessibleName = "image";
            this.picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture.ImageLocation = "C:\\Users\\test\\OneDrive\\Bureau\\Nelly_kristelle_guepnang\\MyApp\\shutterstock.jpg";
            this.picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture.InitialImage")));
            this.picture.Location = new System.Drawing.Point(3, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(640, 350);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // date
            // 
            this.date.AccessibleName = "datet";
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.Location = new System.Drawing.Point(14, 373);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(267, 26);
            this.date.TabIndex = 1;
            // 
            // commentaire
            // 
            this.commentaire.AcceptsReturn = true;
            this.commentaire.AccessibleName = "commentaire";
            this.commentaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commentaire.Location = new System.Drawing.Point(14, 456);
            this.commentaire.Multiline = true;
            this.commentaire.Name = "commentaire";
            this.commentaire.Size = new System.Drawing.Size(613, 129);
            this.commentaire.TabIndex = 2;
            this.commentaire.Text = resources.GetString("commentaire.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelLieu
            // 
            this.labelLieu.AccessibleName = "lieu";
            this.labelLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLieu.AutoSize = true;
            this.labelLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieu.Location = new System.Drawing.Point(9, 422);
            this.labelLieu.Name = "labelLieu";
            this.labelLieu.Size = new System.Drawing.Size(71, 26);
            this.labelLieu.TabIndex = 4;
            this.labelLieu.Text = "Lieu :";
            this.labelLieu.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLargeur
            // 
            this.labelLargeur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLargeur.AutoSize = true;
            this.labelLargeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLargeur.Location = new System.Drawing.Point(425, 375);
            this.labelLargeur.Name = "labelLargeur";
            this.labelLargeur.Size = new System.Drawing.Size(39, 26);
            this.labelLargeur.TabIndex = 5;
            this.labelLargeur.Text = "L :";
            // 
            // labelHauteur
            // 
            this.labelHauteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHauteur.AutoSize = true;
            this.labelHauteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHauteur.Location = new System.Drawing.Point(543, 373);
            this.labelHauteur.Name = "labelHauteur";
            this.labelHauteur.Size = new System.Drawing.Size(43, 26);
            this.labelHauteur.TabIndex = 6;
            this.labelHauteur.Text = "H :";
            // 
            // largeur
            // 
            this.largeur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.largeur.Enabled = false;
            this.largeur.Location = new System.Drawing.Point(470, 375);
            this.largeur.Name = "largeur";
            this.largeur.Size = new System.Drawing.Size(58, 26);
            this.largeur.TabIndex = 7;
            this.largeur.Text = "1068";
            this.largeur.TextChanged += new System.EventHandler(this.largeur_TextChanged);
            // 
            // hauteur
            // 
            this.hauteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hauteur.Enabled = false;
            this.hauteur.Location = new System.Drawing.Point(592, 373);
            this.hauteur.Name = "hauteur";
            this.hauteur.Size = new System.Drawing.Size(35, 26);
            this.hauteur.TabIndex = 8;
            this.hauteur.Text = "724";
            // 
            // lieu
            // 
            this.lieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lieu.Location = new System.Drawing.Point(86, 424);
            this.lieu.Name = "lieu";
            this.lieu.Size = new System.Drawing.Size(541, 26);
            this.lieu.TabIndex = 9;
            this.lieu.Text = "66 Av. de la Moullière, 45000 Orléans";
            // 
            // ImageCommentee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lieu);
            this.Controls.Add(this.hauteur);
            this.Controls.Add(this.largeur);
            this.Controls.Add(this.labelHauteur);
            this.Controls.Add(this.labelLargeur);
            this.Controls.Add(this.labelLieu);
            this.Controls.Add(this.commentaire);
            this.Controls.Add(this.date);
            this.Controls.Add(this.picture);
            this.Name = "ImageCommentee";
            this.Size = new System.Drawing.Size(647, 600);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox commentaire;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelLieu;
        private System.Windows.Forms.Label labelLargeur;
        private System.Windows.Forms.Label labelHauteur;
        private System.Windows.Forms.TextBox largeur;
        private System.Windows.Forms.TextBox hauteur;
        private System.Windows.Forms.TextBox lieu;
    }
}
