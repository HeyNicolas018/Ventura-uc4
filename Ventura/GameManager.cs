using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventura
{
    public class GameManager
    {
        private static GameManager instance;
        private GameManager() { }
        public static GameManager Instance = instance ??= new GameManager();


        public void IniciaMenu()
        {
            MenuGame.Instance.ChamaMenu();
            if 
        }

        public static void IniciaJogo()
        {
            Gameplay.Instance.Layout();
        }
    }
}
