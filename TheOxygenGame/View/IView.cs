using System;
using System.Collections.Generic;
using System.Text;

namespace TheOxygenGame.View
{
    public interface IView<T>
    {
        void Display(T item);
    }
}
