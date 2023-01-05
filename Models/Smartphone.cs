namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementado
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private string Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            // Implementado
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public Smartphone()
        {

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}