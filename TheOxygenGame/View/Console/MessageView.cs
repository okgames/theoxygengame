using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TheOxygenGame.View.Console
{
    public class MessageView : IView<string>
    {
        public void Display(string item)
        {
            Clear();
            WriteLine(item);
        }
    }
}
