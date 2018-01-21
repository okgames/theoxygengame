using System;
using System.Collections.Generic;
using System.Text;
using TheOxygenGame.Model;

namespace TheOxygenGame.View.Console
{
    public class ConsoleViewFactory : ViewFactory
    {        
        
        public override IView<IGameBoardModel<T>> GameboardView<T>()
        {
            return new GameboardView<T>();
        }

        public override IView<string> MessageView()
        {
            return new MessageView();
        }
    }
}
