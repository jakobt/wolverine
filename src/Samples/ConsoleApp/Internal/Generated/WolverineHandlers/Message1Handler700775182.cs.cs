// <auto-generated/>
#pragma warning disable

namespace Internal.Generated.WolverineHandlers
{
    // START: Message1Handler700775182
    public class Message1Handler700775182 : Wolverine.Runtime.Handlers.MessageHandler
    {


        public override System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            var messageHandler = new MyApp.MessageHandler();
            var message1 = (TestMessages.Message1)context.Envelope.Message;
            messageHandler.Handle(message1);
            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: Message1Handler700775182
    
    
}
