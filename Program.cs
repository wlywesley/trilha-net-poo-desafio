using DesafioPOO.Models;

// Implementado
Nokia nokia = new Nokia("1", "52", "1654465456", "32");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("1", "52", "1654465456", "32");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Waze");
