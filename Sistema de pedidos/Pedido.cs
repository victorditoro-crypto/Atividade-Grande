namespace PedidosMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; } = "";
        public string Produto { get; set; } = "";
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public string Status { get; set; } = "";

        public double Total
        {
            get
            {
                return Quantidade * PrecoUnitario;
            }
        }
    }
}