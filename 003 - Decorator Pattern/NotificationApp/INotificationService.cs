using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApp
{
    // Component: gemeenschappelijke interface voor de services én de decorators
    public interface INotificationService
    {
        void Send(string recipient, string message);
    }
}
