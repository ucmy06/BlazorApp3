namespace BlazorApp3.models
{
    public class LigneFacture
    {
        public int Id { get; set; }
        public Produit Produit { get; set; }
        public int Quantité { get; set; }
        public decimal PrixTotal { get; set; }

        public LigneFacture(Produit produit, int quantité)
        {
            Produit = produit;
            Quantité = quantité;
            PrixTotal = produit.Prix * quantité;
        }

    }
}
