using System;
using System.Collections.Generic;
using System.Text;
using TheOxygenGame.Model;

namespace TheOxygenGame.View
{
    public interface IViewFactory
    {
        IView<IGameBoardModel<T>> GameboardView<T>();
        IView<string> MessageView();
    }
}
