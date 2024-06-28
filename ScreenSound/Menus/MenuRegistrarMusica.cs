using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    public class MenuRegistrarMusica : Menu
    {
        MenuExibirDetalhes menu =  new MenuExibirDetalhes();

        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            menu.ExibirTituloDaOpcao("Adicionar música");
            Console.Write("Digite o nome da banda cujo deseja adicionar uma música: ");
            string nomeDaBanda = Console.ReadLine()!;
            if(bandasRegistradas.ContainsKey(nomeDaBanda)){
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;

                if(banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
                {
                    Console.WriteLine("Escreva o nome da música na qual deseja adicionar:");
                    string nomeMusica = Console.ReadLine();
                    Banda artista =  new Banda(nomeDaBanda);
                    Album album = new(tituloAlbum);
                    album.AdicionarMusica(new Musica(artista,nomeMusica));

                    Console.Write($"A música {nomeMusica} foi adicionada com sucesso !");
                    Thread.Sleep(2000);
                    Console.Clear();

                }
                else {
                Console.Write($"Não foi possivel encontrar o álbum {tituloAlbum}");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                }
            }
            else{
                Console.WriteLine($"Não foi possível encontrar o nome {nomeDaBanda}, tente novamente !");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear(); 
            }
        }
    }
}