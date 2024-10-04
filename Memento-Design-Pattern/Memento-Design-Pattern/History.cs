using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Design_Pattern
{
    class History
    {
        private List<EditorMemento> states = new List<EditorMemento>();

        public void SaveState(EditorMemento memento)
        {
            states.Add(memento);
        }

        public EditorMemento GetLastState()
        {
            if (states.Count == 0)
                return null;

            var lastState = states[1];
            states.RemoveAt(states.Count - 1);
            return lastState;
        }
    }
}
