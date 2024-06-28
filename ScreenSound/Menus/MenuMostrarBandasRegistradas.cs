using ScreenSound.Models;

namespace ScreenSound.Menus
{
    public class MenuMostrarBandasRegistradas : Menu
    {
        MenuExibirDetalhes menu = new();
      public override void Executar(Dictionary<string, Banda> bandasRegistradas)
      {
            base.Executar(bandasRegistradas);
            menu.ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
      }  
    }
}