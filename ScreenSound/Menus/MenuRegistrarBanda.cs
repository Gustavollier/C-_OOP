using OpenAI_API;
using ScreenSound.Models ; 
namespace ScreenSound.Menus
{
    public class MenuRegistrarBanda : Menu
    { 
        MenuExibirDetalhes menu =  new();
        public override void Executar(Dictionary<string, Banda> bandasRegistradas){
            base.Executar(bandasRegistradas);
            menu.ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            //Thread.Sleep(2000);
            
        }
    }
}