using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServer
{
    public class MessageHub : Hub
    {
        public void SendToAll(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }
    }
}
