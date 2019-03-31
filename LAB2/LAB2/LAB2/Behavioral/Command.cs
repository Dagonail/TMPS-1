using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Behavioral
{
    public interface ICommand
    {
        void Execute();
    }
    public class UndoCommand : ICommand
    {
        private IMenu menu;
        public IMenu Menu
        {
            get { return menu; }
        }
        public UndoCommand(IMenu originalmenu)
        {
            menu = originalmenu;
        }
        public void Execute()
        {
            new UndoPerformer().Undo(this);
        }
    }

    public class Invoker
    {
        private Stack<ICommand> commandlist = new Stack<ICommand>();

        public void Run()
        {
            while (commandlist.Count > 0)
                commandlist.Pop().Execute();
        }
        public void AddCommand(ICommand c)
        {
            commandlist.Push(c);
        }
    }
    public class UndoPerformer
    {
        public void Undo(ICommand c)
        {
            if (c is UndoCommand)
            {
                IMenu originalmenu = (c as UndoCommand).Menu;
                Console.WriteLine("Moving back to position: " + originalmenu.ToString());
            }
            
        }
    }

}
