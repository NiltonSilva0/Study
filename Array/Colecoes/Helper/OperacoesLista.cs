namespace Colecoes.Helper;

public class OperacoesLista
{
    public void ImprimirLista(List<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine($"Estados na lista original: {item}");
        }
    }
    public void RemoverLista(List<string> lista, string estado)
    {
        lista.Remove(estado);
    }
}