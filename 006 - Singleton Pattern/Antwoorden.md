# Opdracht #3 – Thread safe

| Solution to multi-threading problem | Omschrijving van toepasbaarheid |
|---|---|
| Synchronize the GetInstanceMethod() | Er kan maar één thread tegelijk in GetInstance(), dus er komt nooit een tweede boiler. Het is makkelijk te maken en goed te lezen, dus goed voor de maintainability. Nadeel: elke aanroep moet wachten, ook als de boiler al bestaat. Dat is slechter voor de performance. Past goed als GetInstance() niet vaak wordt aangeroepen. |
| Eager instantiation | De boiler wordt meteen gemaakt als de class geladen wordt, en niet pas als je hem nodig hebt. Je hebt geen lock nodig, dus het is snel (goede performance) en het is weinig code (goede maintainability). Nadeel: de boiler wordt ook gemaakt als je hem nog niet gebruikt. Past goed als je het object toch altijd nodig hebt. |
| Double Checked locking | Je lockt alleen als de boiler nog null is, en dan check je het nog een keer. Er wordt dus alleen de eerste keer gewacht, en daardoor is dit het snelst (goede performance). Maar het is de meeste en moeilijkste code, en je maakt er snel een fout in (slechte maintainability). Alleen nodig als performance echt belangrijk is. |

**Beste keuze voor de ChocolateBoiler: Synchronize**

GetInstance() wordt niet vaak aangeroepen, dus van het wachten merk je niks. Het is ook de simpelste en duidelijkste oplossing.
