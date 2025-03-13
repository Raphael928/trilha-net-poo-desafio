using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone i1 = new Iphone("123", "iphone 13", "1234567", 128);
i1.ReceberLigacao();
i1.InstalarAplicativo("WhatsApp");

Nokia n1 = new Nokia("554", "nokia 2280", "55489779", 64);
n1.ReceberLigacao();
n1.InstalarAplicativo("Telegram");