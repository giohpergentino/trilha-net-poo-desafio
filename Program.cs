using DesafioPOO.Models;

//Testes classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 2", imei: "2222222", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
