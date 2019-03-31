using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Behavioral
{
    public interface ICommandType
    {
        void MakeCommand();
     
    }

     class PerPhone : ICommandType
    {
        void ICommandType.MakeCommand()
        {
            Console.WriteLine("Command with delivery: Hurry up!");
        }
      
    }

     class Local : ICommandType
    {
        void ICommandType.MakeCommand()
        {
            Console.WriteLine("Command on site: Guest in the building!");
        }
  
    }

     class Car : ICommandType
    {
        void ICommandType.MakeCommand()
        {
            Console.WriteLine("Command CAR! 2-5 minutes! or you get FINE!");
        }
      
    }

    public class CommandType
    {
        private ICommandType comm;
        public ICommandType Command
        {
            get { return comm; }
            set { comm = value; }
        }
        public void CommandResult()
        {
            comm.MakeCommand();
        }
    }
}
