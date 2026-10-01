> [!NOTE]
> This project is not affiliated with, endorsed by, or officially supported by Streamer.bot, Twitch, YouTube, or Kick. Streamer.bot, Twitch, YouTube, and Kick are trademarks or names of their respective owners. This project only uses features available in Streamer.bot and is provided as an independent community tool. 
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
# streamerbot-multiplatform-title-category-switcher

Prosty kod C# do Streamer.bot, który zmienia tytuł i kategorię streama na kilku platformach. Twitch, YouTube oraz Kick.


## Jak zainstalować na swój kanał

1. Wymagany Streamer.bot: https://streamer.bot/
2. Konfiguracja Streamer.bot - łączenie kont Twitch, Kick oraz YouTube.
3. Po skonfigurowaniu i posiadaniu działającego bota, należy wejść w **Commands** oraz dodać nową komendę np. !Stream (nazwa może być dowolna) najlepiej jest zezwolić na użycie komendy tylko dla moderatorów).
4. Po stworzeniu komendy należy przejść do kategorii **Actions&Queues** i następnie do zakładki **Actions**.
5. Tam należy stworzyć nową akcję o dowolnej nazwie np. **multiplatform-title-category-switcher**.
6. W Sub-Actions dodajemy klikając prawym przyciskiem myszy **Add -> Core -> C# -> Execute C# Code**
7. Następnie wklejamy kod z pliku **multiplatform.cs** -> **Save and Compile**.
8. W **Triggers** dodajemy **Core -> Commands -> Command Triggered -> wybieramy dodaną komendę z kroku trzeciego (3)**.
9. Wszystko **gotowe** komenda powinna działać <3

## Poradnik bez zbędnego gadania: 

**Wymagania**

-Streamer.bot

-Podpięte konto Twitch

-Podpięte konto YouTube, jeśli chcesz zmieniać YouTube

-Podpięte konto Kick, jeśli chcesz zmieniać Kick

-Komenda np. !stream podpięta do akcji z kodem C#


**Instalacja**

-W Streamer.bot utwórz nową akcję.

-Dodaj sub-action Execute C# Code.

-Wklej kod z pliku multiplatform.cs

-Zapisz i skompiluj kod.

-Utwórz komendę np. !stream.

-Podepnij komendę jako trigger do akcji.

-Ustaw permisje komendy, najlepiej na moderatorów.

## Komenda

Format:

```text
!stream KATEGORIA | TYTUŁ
```
Przykład:

```text
!stream Dead by Daylight | DBD z widzami, lecimy po World Rekordzik EZ czy cos takiego lol
```

## Ważne informacje 

**Kod nie zawiera tokenów ani danych prywatnych. Działa na kontach zalogowanych lokalnie w Streamer.bot u danej osoby.**

Oczywiście jest to Open-Source, można podejrzeć co i jak tam wygląda, technika pisania kodu nie jest najlepsza XD

W razie jakichś obaw bezpieczeństwa można sprawdzić co dokładnie ten kod robi i jak działa, jeśli brakuje wiedzy, można użyć AI, pewnie pomoże :)

## Zastrzeżenie

Projekt jest udostępniany “tak jak jest”, bez gwarancji działania.  
Używasz go na własną odpowiedzialność. Nie odpowiadam za problemy wynikające z błędnej konfiguracji, aktualizacji Streamer.bot, zmian API platform ani ograniczeń po stronie Twitch/YouTube/Kick.

## Disclaimer

This project is provided as-is, without warranty.  
Use it at your own risk. I am not responsible for issues caused by wrong setup, Streamer.bot updates, platform API changes, or platform-side limitations.

## Licencja

Projekt jest udostępniony na licencji MIT. Szczegóły znajdują się w pliku LICENSE.

## Nieoficjalny projekt

Ten projekt nie jest oficjalnym narzędziem Streamer.bot, Twitch, YouTube ani Kick.  
Nie jestem właścicielem ani przedstawicielem żadnej z tych platform.

Streamer.bot, Twitch, YouTube i Kick są znakami/nazwami należącymi do ich właścicieli.  
Projekt korzysta jedynie z funkcji dostępnych w Streamer.bot i jest udostępniany jako niezależne narzędzie społecznościowe.

## Unofficial project

This project is not affiliated with, endorsed by, or officially supported by Streamer.bot, Twitch, YouTube, or Kick.

Streamer.bot, Twitch, YouTube, and Kick are trademarks or names of their respective owners.  
This project only uses features available in Streamer.bot and is provided as an independent community tool.
