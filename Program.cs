using DesafioPOO.Models;

Console.WriteLine("Testando Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "9999-5555", modelo: "Nokia 3015", imei: "0123456789", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Testando Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "22222-7777", modelo: "Iphone 16", imei: "9876543210)", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
// Testado! 
