namespace DesafioPOO.Models
{
    // Implementado
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public Iphone()
        {
            
        }
        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em seu Iphone.");
        }
    }
}