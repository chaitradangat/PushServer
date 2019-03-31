using System;
using System.Collections.Generic;
using System.Text;

namespace PushServer.Interfaces
{
    public interface IPushServer
    {
        string SubscribeClient(string ClientInfo);

        string UnSubscribeClient(string ClientInfo);

        bool ReceiveChanges(string ClientInfo,string ClientData);

        string SendPushNotification();
    }
}