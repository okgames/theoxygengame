using System;
using System.Collections.Generic;
using System.Text;
using TheOxygenGame.Model;

namespace TheOxygenGame.View.Console
{
    public class ConsoleViewFactory : IViewFactory
    {        
        
        public IView<IGameBoardModel<T>> GameboardView<T>()
        {
            return new GameboardView<T>();
        }

        public IView<string> MessageView()
        {
            return new MessageView();
        }
    }
}
