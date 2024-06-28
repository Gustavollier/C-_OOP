
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    public class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas){
            
            Console.WriteLine("Tchau, volte sempre");
        }
    }
}