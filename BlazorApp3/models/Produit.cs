namespace BlazorApp3.models
{
    public class Produit
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public decimal Prix { get; set; }
        // ... autres propriétés du produit
        public int Quantite { get; set; }
        public Produit(int id, string nom, decimal prix, int quantite)
        {
            Id = id;
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
        }
    }
}
