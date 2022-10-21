using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "33924", modelo: "Modelo 1", imei: "7742149", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia(numero: "23712", modelo: "Modelo 2", imei: "5428532", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Ifood");