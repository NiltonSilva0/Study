using _11Polimorfismo;

Console.WriteLine("Estagiário--------");
Estagiario estagiario = new Estagiario();
estagiario.ValeTransporte(1415);
estagiario.ValeAlimentacao(1415);
Console.WriteLine("Gerente--------");
Gerente gerente = new Gerente();
gerente.ValeTransporte(1900);
gerente.ValeAlimentacao(1900);
Console.WriteLine("Atendente--------");
Atendente atende = new Atendente();
atende.ValeTransporte(1610);
atende.ValeAlimentacao(1610);
