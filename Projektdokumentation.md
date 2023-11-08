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

Wir programmieren ein Roulette-Spiel, das jedermann spielen kann. Man kann seinen Einsatz gewinnen oder verlieren. Dabei wird natürlich keine echte Währung eingesetzt. Bei dem Spiel setzt man ein Betrag auf ein Feld oder eine bestimmte Auswahl an Feldern. Je unwahrscheinlicher das Feld ist, desto höher der mögliche Gewinn. Nach dem Einsatz wird eine zufällige Zahl generiert, die die Roulette-Kugel ersetzt. Schlussendlich gewinnt oder verliert der Spieler seinen gesetzten Betrag und kann dann entweder nochmals spielen oder ist pleite.


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
| 1.1  |     Benutzer möchte spielen      |   Spiel starten     |      Spiel wird gestartet             |
| 2.1  |  Spiel gestartet             |     auf den Startknopf drücken    |   Spiel-Window öffnet sich.                |
| 3.1  |       Start-Knopf gedrückt       |    Betrag eingeben     |         Betrag wird korrekt angezeigt.          |
| 4.1  |       Betrag wurde eingegeben       |    Runde starten     |        Runde wird gestartet.           |
| 5.1  |      Runde wurde gestartet        |    Startknopf wurde gedrückt   |       Zufälliges Feld wird ausgegeben.            |
| 6.1  |       Zufällige Zahl wurde ausgegeben       |    Startknopf wurde gedrückt    |         Spiel vergleicht und gibt aus, ob es ein Gewinn oder ein Verlust ist.          |
| 7.1  |      Runde gespielt        |    Startknopf wurde gedrückt     |         aktuelle Geldstand wird angepasst.          |

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  20.09.2023     |    Joël       |      Projekt mit notwendigen Dateien erstellen      |        45 min       |
| 1.B  |   20.09.2023    |    alle      |       Code zum Main-Window schreiben      |     180 min          |
| 1.C | 20.09.2023 | Joël | Design fürs Main-Window erstellen| 180 min |
| 1.D|20.09.2023 | Janick| Projektdoku updaten| 20 min |
|2.A |18.10.2023 |alle |Eingabefunktion für Benutzer |135 min |
|2.B | 18.10.2023|Joël |Zufallsgenerator für die Felder schreiben |90 min |
|2.C | 18.10.2023|Ben |Projektdoku updaten | 20 min|
|3.A |25.10.2023 |alle |Code zusammensetzen und Design anpassen |180 min |
|3.B | 25.10.2023|Joël | Projektdoku updaten|10 min |
| 4.A|01.11.2023 |alle | Feinschliff und Anpassung des Designs|180 min |
|4.B |01.11.2023 | Janick & Ben|Projektdoku updaten |20 min |


## 3 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   20.09.2023    |   Joël        |   45 min            |    45 min               |
| 1.B|20.09.2023      |    alle       |       180 min        |      180 min             |
|1.C |20.09.2023 |Joël |180 min | 135 min|
|1.D |20.09.2023 |Janick |20 min |20 min |
|2.A |18.10.2023 |alle |135 min |135 min |
|2.B |18.10.2023 |Joël |90 min |60 min |
|2.C |18.10.2023 |Ben |20 min |10 min |
|3.A |25.10.2023 |alle |180 min | 180 min|
|3.B | 25.10.2023|Joël |10 min |10 min|
|4.A |01.11.2023 |alle |180 min | 180 min|
|4.B |01.11.2023 |Janick & Ben|20 min |30 min |

## 4 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |   08.11.2023    |     check     |    Janick    |
| 2.1  |    08.11.2023   |     check     |    Janick    |
| 3.1  |    08.11.2023   |     check     |    Janick    |
| 4.1  |    08.11.2023   |     check     |    Janick    |
| 5.1  |    08.11.2023   |     check     |    Janick    |
| 6.1  |    08.11.2023   |     check     |    Janick    |
| 7.1  |    08.11.2023   |     check     |    Janick    |
