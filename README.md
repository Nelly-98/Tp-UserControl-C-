# Tp-UserControl-C-
Contrôle User permettant d'associer une image à un certains nombre d'informations liées à cette image

Le  but  de  ce  projet,  qui  doit  être  réalisé  avec  Visual  Studio  en  C#,    est  de  concevoir  un contrôle utilisateur (une instance héritée de la classe UserControl) permettant d’associer une image  ou  une  photo  (gérée  par  un  contrôle  de  type PictureBox)  à  un  certain  nombre d’informations liées à cette image.  Ces informations (les attributs) seront au nombre de 6 : Le chemin d’accès au fichier contenant le composant sauvegardé (ayant le meme nom de fichier que l’image mais pour extension imgc). La date de la prise de vue de l’image (Le 1/1/1900) si la date n’est pas connue. Le lieu de la prise de vue. La largeur de la photo originale. La hauteur de la photo originale. Un commentaire associé à cette prise de vue. 

Les conditions suivantes doivent être respectées : La hauteur et la largeur de l’image originale ne doivent pas être modifiables. Les autres informations doivent être modifiables. La totalité de l’image originale doit être visible lorsque la taille du document est modifiée. Les proportions de l’image originale doivent être respectées

La classe devra avoir pour nom ImageCommentée et disposer des éléments suivants : Un constructeur par défaut (sans paramètre) initialisant une instance sans image. Un constructeur ayant 4 paramètres (le chemin d’accès de l’image, la date de la prise de vue, le lieu de la prise de vue et le commentaire associé). Un  constructeur  ayant  pour  seul  paramètre  le  chemin  d’accès  à  une  instance  de  la  classe ImageCommentée sauvegardée sur disque. Les accesseurs (getters) correspondants à tous les attributs. Les mutateurs (setters) correspondant aux attributs modifiables. Une  méthode  ayant  pour  nom save  qui  enregistre  les  informations  de  l’instance courante dans un fichier binaire (une instance de la classe BinaryWriter.) L’application principale devra disposer d’un menu proposant les opérations suivantes : Sélectionner une image, la commenter et sauvegarder l’image commentée. Sélectionner et afficher une image déjà commentée. 



