# Projekt-Dokumentation


Gruppenmietglieder:
Joël Haldimann, 
Ben Müller, 
Janick Hurschler


| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   20.09.2023    | 0.0.1   | Heute haben wir uns in Windows WPF eingearbeitet und haben angefangen, das Main-Window zu programmieren. |
|    18.10.2023   | 0.0.2    |    Heute haben wir das Main-Window fertig programmiert und angefangen das eigentliche Spiel zu programmieren.      |                                                    |
|    25.10.2023   | 0.0.3   |              Heute haben wir das Spiel grundsätzlich fertig gestellt. Alle Funktionen sind programmiert.|                                                |
|01.11.2023|0.1|Heute haben wir das Spiel und den Code noch überarbeitet und den Feinschliff gemacht.|

## 1 Informieren

### 1.1 Ihr Projekt

Ein Roulette-Spiel mit Windows WPF und C#.

Wir möchten ein Roulette-Spiel programmieren, das jedermann spielen kann. Man kann sein Einsatz gewinnen und verlieren. Dabei wird keine echte Währung eingesetzt. Bei dem Spiel setzt man ein Betrag auf ein Feld oder eine bestimmte Auswahl an Feldern. Je unwahrscheinlicher das Feld ist, desto höher der möglich Gewinn. Nach dem Einsatz wird eine Zufällige Zahl generiert, die eine zwirbelnde Kugel ersetzt. Schlussendlich wird hat der Spieler richtig gesetzt und bekommt ein Gewinn oder er hat sich vertan und geht pleite.


### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |       Muss          |   Funktional   | Als ein Spieler möchte ich das Spiel starten, damit ich spielen kann. |
| 2  |  Muss               |   Funktional   |     Als ein Spieler möchte ich einen Betrag einsetzen können, damit ich ein Gewinn machen kann.                               |
|3|Muss|Funktional|Als ein Benutzer möchte ich eine funktionierende Zufalls-Funktion, damit ich spass am spielen habe.|
|4|Muss|Rand|Als ein Nutzer möchte ich die Applikation in einem WPF Window öffnen können, damit ich eine tolle Zeit beim Spielen habe.|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |     /         |   Spiel starten     |      Spiel wird gestartet             |
| 2.1  |  Spiel gestartet             |     auf den Startknopf drücken    |   Spiel-Window öffnet sich.                |
| 3.1  |       stat-Knopf gedrückt       |    Betrag eingeben     |         Betrag wird korrekt angezeigt.          |
| 4.1  |       Betrag wurde eingegeben       |    Runde starten     |        Runde wird gestartet.           |
| 5.1  |      Runde wurde gestartet        |    /     |       Zufälliges Feld wird ausgegeben.            |
| 6.1  |       Zufällige Zahl wurde ausgegeben       |    /     |         Spiel vergleicht und gibt aus, ob es ein Gewinn oder ein Verlust ist.          |
| 7.1  |      Runde gespielt        |    /     |         aktuelle Geldstand wird angepasst.          |

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

