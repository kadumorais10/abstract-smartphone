using DesafioPOO.Models;

Console.WriteLine("smartphone nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "33333333", memoria: 67);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("smartphone iphone:");
Smartphone iphone = new Iphone(numero: "7777233454", modelo: "modelo 2", imei: "44444444", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");
// TODO: Realizar os testes com as classes Nokia e Iphone;