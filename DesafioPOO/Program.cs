using DesafioPOO.Models;

Nokia nk =  new Nokia(numero:"(38)99906-3422", modelo:"Nokia-6", iMEI:"321321321",memoria:128);
Console.WriteLine("Smartphone Nokia");
Console.WriteLine(nk.Numero);
nk.Ligar();
nk.ReceberLigacao();
nk.InstalarAplicativo("Spotify");

Console.WriteLine("\n");

Iphone ip = new Iphone(numero: "(38)99997-3334", modelo: "Iphone-13s", iMEI: "321321321", memoria: 256);
Console.WriteLine("Smartphone Apple");
Console.WriteLine(ip.Numero);
ip.Ligar();
ip.ReceberLigacao();
ip.InstalarAplicativo("Whatsapp");