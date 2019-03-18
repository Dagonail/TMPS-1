using System;

namespace LAB2.Structural
{

    //bridge start
    //Menu for a client
    public interface IClient
    {
        void MenuCl();
    }
    public partial class Client : IClient
    {
        
        public IAClient adult;
        public Client(IAClient adult)
        {
            this.adult = adult;
        }
        public void MenuCl()
        {
            adult.AClient();
        }

    }
   
            //adapter start
        public interface IAClient
        {
            void AClient();
        }

        public class AdultClient : IAClient
        { 
            public void AClient()
            {
                Console.WriteLine("\nAdult client. Take order...");
            }
        }

        public interface IKid
        {
            void Kid();
        }

        public class ClientKid : IKid
        {
            private string messagep;
            public ClientKid(string message) { messagep = message; }
            public void Kid()
             { 
                Console.WriteLine($"\nChild client:{messagep}. Take order...");
            }
            public void Order()
            {
                Console.WriteLine("Available...");
            }
         }
   
       
        public class AdultwKid : IAClient
        {
           
            public IKid kid;
            public AdultwKid(IKid child)
            {
                kid = child;
            }
            public void AClient()
            {
                kid.Kid();
            }
        }
    //adapter finish

    //decorator start
    public class AdultClientDecor : IAClient
    {
        public void AClient()
        {
            Console.WriteLine("\nAdult client. Take order...");
            Console.WriteLine("SERVE FIRST - client with dissabilities");
        }
    }
    //decorator finish
    //farcade 2
    public class FarcadeToy
    {
        private readonly ClientKid kid;
        public FarcadeToy(ClientKid kkid)
        {
            kid = kkid;
        }
        public void PointofSale(bool free, bool free2)
        {
            ProxyOrderGender pr = new ProxyOrderGender(free, free2);
            pr.CheckToy(kid);
        }
    }
    //proxy2
    public class ProxyOrderGender
    {
        private readonly bool free;
        private readonly bool free2;
        public ProxyOrderGender(bool next, bool next2)
        {
            free = next;
            free2 = next2;
        }
        public void CheckToy(ClientKid kid)
        {
            if (free)
            {
                if (free2)
                {
                    Console.WriteLine("\nHave TOY for girl&boy");
                    kid.Order();

                }
                else
                {
                    Console.WriteLine("\nHave TOY for boy only");
                    kid.Order();

                }

            }
            else
            {
                if (free2)
                {
                    Console.WriteLine("\nHave TOY for girl only");
                    kid.Order();

                }
                else
                {
                    Console.WriteLine("\nNO TOY");
                    kid.Order();

                }
            }
        }

    }


}

