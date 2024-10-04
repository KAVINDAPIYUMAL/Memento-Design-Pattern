using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Design_Pattern
{
    class TextEditor
    {
        private string content;

        public string Content
        {
            get => content;
            set
            {
                content = value;
                Console.WriteLine($"Current Content: {content}");
            }
        }

        public EditorMemento Save()
        {
            return new EditorMemento(content);
        }

        public void Restore(EditorMemento memento)
        {
            content = memento.Content;
            Console.WriteLine($"Restored Content: {content}");
        }
    }
}
