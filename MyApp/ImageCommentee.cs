using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class ImageCommentee : UserControl
    {

        //1- Constructeur par défaut
        public ImageCommentee()
        {
            InitializeComponent();
        }
        //2- Constructeur d'initialisation de 04 Paramètres
        public ImageCommentee(PictureBox image, DateTimePicker datetime, string lieu, string commentaire)
        {
            Image = image;
            DateTime = datetime;
            Lieu = lieu;
            Commentaire = commentaire;
        }

        //3- Un constructeur ayant pour seul paramètre le chemin d'accès à une instance de la classe
        private static ImageCommentee _instance;
        public static ImageCommentee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ImageCommentee();
                return _instance;

            }
        }

        //4 Getters de touts les attributs et 5 Setters des attributs modifiables
        public PictureBox Image { get; set; }
        public DateTimePicker DateTime { get; set; }
        public string Lieu { get; set; }
        public float Hauteur { get; }
        public float Largeur { get; }
        public string Commentaire { get; set; }

        //Methode save()
        public void save()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void largeur_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }
    }
}
