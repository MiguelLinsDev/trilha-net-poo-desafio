using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "819999999", modelo: "Iphine 11", imei: "123456", memoria: 256 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "219777777", modelo: "Nokia C30", imei: "654321", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");