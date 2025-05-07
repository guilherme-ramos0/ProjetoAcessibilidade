namespace Acessibilidade.Models
{
    public class Posto
    {
        public int IdPostos { get; set; }
        public string Nome { get; set; }
        public string Zona { get; set; }
        public int Zonas_idZonas { get; set; }
        public Zona ZonaInfo { get; set; }
    }
}