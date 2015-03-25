using System;
using System.Collections.Generic;

namespace Cometd.Client.Transport
{
    public interface IMessageClientTransport
    {
        void setMessageTransportListener(ITransportListener listener);
    }
}
