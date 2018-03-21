using System;
using System.Threading.Tasks;
using Akka.Actor;

namespace tst
{
    class EchoActor : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            Sender.Tell(message);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Task(() => {});
            var sys = ActorSystem.Create("Test");
            var act = sys.ActorOf(Props.Create(() => new EchoActor()));
            Console.WriteLine("Hello World!");
        }
    }
}
