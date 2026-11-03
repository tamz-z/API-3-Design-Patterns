# API 3 – Design Patterns

Mijn uitwerkingen voor het vak **API 3 – Design Patterns** (Software Developer, ROC Nijmegen), geschreven in C# / .NET.
Elke opdracht staat in een eigen map, met de patterns op volgorde van behandeling.

| Map | Pattern | Project | Wat zit erin | .NET |
|---|---|---|---|---|
| `001 - Strategy Pattern` | Strategy | `StrategyPattern` | Eenden met uitwisselbaar vlieg-, kwaak- en zwemgedrag (FlyBehavior, QuackBehavior, SwimBehavior), inclusief RobotDuck die tijdens het draaien van gedrag wisselt | 6.0 |
| `002 - Observer Pattern` | Observer | `ObserverPattern` | Weerstation: `WeatherData` als Subject, drie displays als Observers (zie README in de map) | 8.0 |
| `003 - Decorator Pattern` | Decorator | `NotificationApp` | Notificaties uitbreiden met Logging-, Urgent- en Timestamp-decorators; antwoorden staan in de README van het project | 8.0 |
| `005 - Abstract Factory Pattern` | (Abstract) Factory Method | `StarbuzzCoffeeShop` | Starbuzz-koffiebar: dranken alleen te bestellen via `StarbuzzCoffeeShop` met de enum `CoffeeMix`, gebouwd op de decorators | 6.0 |
| `006 - Singleton Pattern` | Singleton | `SingletonPattern` | Chocolate Factory: `ChocolateBoiler` als Singleton, thread safe met `MethodImplOptions.Synchronized` (antwoorden in `Antwoorden.md`) | 6.0 |
| `007 - Adapter Pattern` | Adapter | `AdapterPattern` | `TurkeyAdapter` en `GooseAdapter` laten een kalkoen en een gans zich gedragen als een eend | 6.0 |
| `007 - Adapter Pattern` | Adapter | `NotificationApp` | `WhatsAppNotificationAdapter` koppelt een externe WhatsApp-library aan `INotificationService` | 8.0 |
| `008 - Facade Pattern` | Facade | `GameApp` | Startopdracht: `GameFacade` start en stopt alle subsystemen van een game (antwoorden in `GameApp/Antwoorden.md`) | 10.0 |
| `008 - Facade Pattern` | Facade | `FacadePattern` | Home Theater met `HomeTheaterFacade` (film kijken, CD en radio luisteren) en de opdracht over het Principle of Least Knowledge (antwoorden in `Antwoorden.md`) | 6.0 |

## Uitvoeren

Installeer de .NET SDK van de versie in de tabel. Ga daarna naar de map van het project en start het:

```
cd "002 - Observer Pattern/ObserverPattern"
dotnet run
```

Je kunt ook het `.csproj`- of `.sln`-bestand openen in Visual Studio.

## Herkomst

Deze repo bundelt mijn losse opdracht-repo's. De commitgeschiedenis van elke opdracht is meegenomen.

| Opdracht | Oorspronkelijke repo |
|---|---|
| Strategy | [Design-Patterns-and-Strategy-Pattern-Duck](https://github.com/tamz-z/Design-Patterns-and-Strategy-Pattern-Duck) (dezelfde code staat ook in [Design-Patterns---Strategy-Pattern](https://github.com/tamz-z/Design-Patterns---Strategy-Pattern)) |
| Observer | [API-3---Design-Patterns---Observer-Pattern](https://github.com/tamz-z/API-3---Design-Patterns---Observer-Pattern) |
| Decorator + Abstract Factory | [Design-Patterns---Decorator](https://github.com/tamz-z/Design-Patterns---Decorator) (branch `main` en `factory-pattern`) |
| Adapter – NotificationApp | [Design-Patterns---Adapter-Pattern](https://github.com/tamz-z/Design-Patterns---Adapter-Pattern) |
| Adapter – Turkey en Goose | [Design-Patterns---Adapter-Pattern-opdracht-turkey](https://github.com/tamz-z/Design-Patterns---Adapter-Pattern-opdracht-turkey) |
| Facade | [Design-Patterns---Facade-Pattern-Startopdracht](https://github.com/tamz-z/Design-Patterns---Facade-Pattern-Startopdracht) (branch `main` en `opdracht-008`) |
