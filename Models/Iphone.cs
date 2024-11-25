namespace DesafioPOO.Models
{
    // Implementado! 
    public class Iphone : Smartphone 
    {
        public Iphone(String numero, String modelo, String imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone");
        }
        // Implementado! 
    }
}