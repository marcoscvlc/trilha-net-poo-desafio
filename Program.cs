using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "9999-9999" , modelo: "8210", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine ("\n");

Console.WriteLine("smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4444-4444", modelo: "14 Pro Max", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");