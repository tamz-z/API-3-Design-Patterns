using ExternalWhatsAppLibrary;

namespace NotificationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program maakt de concrete services aan en geeft ze aan de manager.
            // Verder praat Program alleen nog met de NotificationManager en niet
            // meer rechtstreeks met de losse notificatieservices.
            NotificationManager manager =
                new NotificationManager(new EmailNotificationService());

            manager.Send(
                "student@school.nl",
                "Je nieuwe rooster staat klaar."
            );

            manager.SetNotificationService(new SmsNotificationService());

            manager.Send(
                "0612345678",
                "Je les begint over 15 minuten."
            );

            manager.SetNotificationService(new PushNotificationService());

            manager.Send(
                "student123",
                "Er staat nieuwe feedback voor je klaar."
            );

            // WhatsApp loopt via de adapter, maar voor de manager is dit
            // gewoon weer een INotificationService zoals de andere kanalen.
            manager.SetNotificationService(
                new WhatsAppNotificationAdapter(new WhatsAppClient()));

            manager.Send(
                "0612345678",
                "Je inschrijving is bevestigd."
            );

            Console.ReadLine();
        }
    }
}
