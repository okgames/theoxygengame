using System;
using System.Collections.Generic;
using System.Text;
using TheOxygenGame.Model;

namespace TheOxygenGame.View
{
    public abstract class ViewFactory
    {
        public abstract IView<IGameBoardModel<T>> GameboardView<T>();
        public abstract IView<string> MessageView();
    }
}
