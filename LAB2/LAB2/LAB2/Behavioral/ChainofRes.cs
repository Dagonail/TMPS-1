using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Behavioral
{
    abstract class CommandApprover
    {
        protected CommandApprover nextcommand;
        public void SetNextApprover(CommandApprover nextcommand)
        {
            this.nextcommand = nextcommand;
        }
        public abstract void ApproveCommand(Command i);
    }

    public class Command
    {
        public bool Approve;
        public bool Allow
        {
            get { return Approve; }
        }
        public Command(bool Approve)
        {
            this.Approve = Approve;
        }
    }

     class Manager : CommandApprover
    {
        public override void ApproveCommand(Command i)
        {
            if (i.Approve == false)
            {
                Console.WriteLine("Command was cancelled after payment// Approved by Manager");
            }
            else

            {
                nextcommand.ApproveCommand(i);
            }
            
        }
    }

    class Worker : CommandApprover
    {
        public override void ApproveCommand(Command i)
        {
            if (i.Approve == true)
            {
                Console.WriteLine("Command changed by worker before payment");
            }
            else

            {
                nextcommand.ApproveCommand(i);
            }
        }
    }

}
