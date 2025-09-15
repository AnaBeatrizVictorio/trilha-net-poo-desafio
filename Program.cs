using DesafioPOO.Models;


// Criando Nokia com todos os dados necessários
Nokia k = new Nokia("96738-3749", "Nokia Tijolão", "987654321", 64);

k.Ligar();
k.ReceberLigacao();
k.InstalarAplicativo("Telegram");

// Criando iPhone com todos os dados necessários
Iphone i = new Iphone("98459-5294", "iPhone 14", "123456789", 128);

i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("WhatsApp");

