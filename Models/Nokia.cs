namespace DesafioPOO.Models
{
    // Implemantado!
    public class Nokia : Smartphone
    {
        public Nokia(String numero, String modelo, String imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no aparelho Nokia");
        }    
        // Implementado!
    }
}