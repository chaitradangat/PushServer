using PushServer.Interfaces;

namespace PushServer
{
    class PushServer : IPushServer
    {
        public bool ReceiveChanges(string ClientInfo, string ClientData)
        {
            throw new System.NotImplementedException();
        }

        public string SendPushNotification()
        {
            throw new System.NotImplementedException();
        }

        public string SubscribeClient(string ClientInfo)
        {
            throw new System.NotImplementedException();
        }

        public string UnSubscribeClient(string ClientInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}