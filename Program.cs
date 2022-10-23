using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("21988882222","Modelo-A","00123212321",500000);
nokia.Ligar();
nokia.InstalarAplicativo("youtube");

Console.WriteLine(" ");

Iphone iphone = new Iphone("2195585632","Modelo-B","11154654862",100000);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("instagram");