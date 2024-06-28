namespace ScreenSound.Models;

public class Album : IAvaliavel
{
    public List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public double Media
    {
        get
        {
            if (notas.Count == 0)
                return 0;
            else
                return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum(string Nome)
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");

        if (musicas.Count > 1)
        {
            foreach (Musica musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
        }
        else{
            Console.WriteLine("Infelizmente não tem nenhuma música cadastrada");
        }
    }
}
