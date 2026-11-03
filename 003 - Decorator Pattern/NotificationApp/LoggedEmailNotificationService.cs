namespace NotificationApp
{
    // Zonder Decorator (inheritance): per combinatie een nieuwe class
    // LoggedEmail, LoggedSms, UrgentEmail, UrgentSms, ... = class explosion
    public class LoggedEmailNotificationService : EmailNotificationService
    {
        public override void Send(string recipient, string message)
        {
            Console.WriteLine("LOG: notificatie wordt verstuurd");
            base.Send(recipient, message);
        }
    }
}
