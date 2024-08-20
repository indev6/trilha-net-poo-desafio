using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("888-289", "ce22", "1234", 126);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");
Console.Write("Numero" + n1.Numero);
n1.NomeModelo();

Iphone i1 = new Iphone("123-333", "13p", "5554", 256);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Jogo");
Console.Write("Numero" + i1.Numero);
i1.NomeModelo();