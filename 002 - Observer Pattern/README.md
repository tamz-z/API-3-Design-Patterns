# API 3 - Design Patterns - Observer Pattern

Uitwerking van de opdracht "API 3 – Observer Pattern" (Design Patterns).

## Opzet

Een weerstation waarbij `WeatherData` het **Subject** is en drie displays de **Observers**.
Zodra `SetMeasurements()` wordt aangeroepen, verandert de state van `WeatherData` en
worden alle geregistreerde observers automatisch bijgewerkt.

### Interfaces
- `Subject` – `RegisterObserver()`, `RemoveObserver()`, `NotifyObservers()`
- `Observer` – `Update(float temp, float humidity, float pressure)`
- `DisplayElement` – `Display()`

### Displays
- **CurrentConditionDisplay** – toont de huidige temperatuur en luchtvochtigheid.
- **ForecastDisplay** – geeft een voorspelling op basis van temperatuur en luchtvochtigheid.
- **StatisticsDisplay** – toont het gemiddelde, maximum en minimum van de temperatuur.

## Uitvoeren

```
cd ObserverPattern
dotnet run
```

## Voorbeeld output

```
--- Meting 1 ---
Huidige condities: 28°C en 65% luchtvochtigheid.
Voorspelling: Er is kans op onweer.
Statistieken: gemiddelde 28,0°C / maximum 28°C / minimum 28°C (over 1 metingen).

--- ForecastDisplay uitgeschreven ---

--- Meting 4 ---
Huidige condities: 18°C en 55% luchtvochtigheid.
Statistieken: gemiddelde 26,2°C / maximum 30°C / minimum 18°C (over 4 metingen).
```

In de main wordt ook een observer uitgeschreven met `RemoveObserver()`, waarna die
display geen updates meer ontvangt.
