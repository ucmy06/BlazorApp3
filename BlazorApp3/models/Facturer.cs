namespace BlazorApp3.models
{
    public class Facture
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public DateTime DateFacture { get; set; }
        public List<LigneFacture> LignesFacture { get; set; } = new List<LigneFacture>();
        public decimal MontantTotal { get; set; }

        public void AjouterLigneFacture(Produit produit, int quantité)
        {
            var ligneFacture = new LigneFacture(produit, quantité);
            LignesFacture.Add(ligneFacture);
            RecalculerMontantTotal();
        }

        private void RecalculerMontantTotal()
        {
            MontantTotal = 0;
            foreach (var ligneFacture in LignesFacture)
            {
                MontantTotal += ligneFacture.PrixTotal;
            }
        }
    }
}
