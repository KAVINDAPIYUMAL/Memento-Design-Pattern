using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            History history = new History();

            // Initial content
            editor.Content = "Hello, ";

            // Save state
            history.SaveState(editor.Save());

            // Make changes
            editor.Content += "world!";

            // Save state
            history.SaveState(editor.Save());

            // Undo
            editor.Restore(history.GetLastState());
        }
    }
}
