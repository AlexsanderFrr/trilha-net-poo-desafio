using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11973422737", modelo: "Nokia G11 Plus NK095", imei: "111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "11987562341", modelo: "iPhone 15 Pro", imei: "1001011101", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");