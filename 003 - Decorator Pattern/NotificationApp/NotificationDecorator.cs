namespace NotificationApp
{
    // Decorator: abstracte basisclass voor alle extra's
    // IS-A: een decorator is zelf ook een INotificationService, dus je kunt hem weer inpakken
    public abstract class NotificationDecorator
        : INotificationService
    {
        // HAS-A / composition: de service die deze decorator inpakt
        protected INotificationService notificationService;

        public NotificationDecorator(
            INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public abstract void Send(
            string recipient,
            string message);
    }
}
