namespace ScreenSound.Models;

public class Avaliacao 
{
public Avaliacao(int nota)
{
    Nota = nota;
}
public static Avaliacao Parse(string texto)
{
    int nota = int.Parse(texto);
    return new Avaliacao(nota);
}

public int Nota { get; }
}
