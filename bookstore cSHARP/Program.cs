
            /*Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
            - Titolo
            - Autore
            - ISBN
            - Numero pagine
            - Peso del libro
            - Larghezza, Altezza e Profondità del libro
            - Valutazione media
            - Numero di recensioni
            - se è disponibile in versione Kindle
            - se la copertina flessibile è disponibile
            Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
            A questo punto stampiamo bene le informazioni acquisite sulla console, dove per <<nomeVariabile>> indica di stampare l’informazione contenuta nella variabile.
            Un esempio è il seguente:
            ——— IL LIBRO DI OGGI: <<titolo>> di <<autore>>——————-
            Informazioni generiche:
            ISBN: <<isbn>>
            Numero delle pagine: <<numeroPagine>> pagine
            Peso del libro: <<pesoLibro>> kg
            Dimensioni del libro: <<larghezza>> cm x <<lunghezza>> cm x <<profondita>> cm
            Informazioni Amazon:
            Numero di recensioni: <<numeroRecensioni>> recensioni
            Valutazione media: <<valutazioneMedia>> stelline
            Kindle disponibile: Si o No
            Copertina flessibile disponibile: Si o No*/




/* Autore e titolo */

string titolo;
titolo = "Clean code.Guida per diventare bravi artigiani nello sviluppo agile di software";
Console.WriteLine("Il titolo del libro è:" +titolo);

string autore;
autore = "Robert C.Martin";
Console.WriteLine("L’autore è:" +autore);

string traduttore;
traduttore = "Paolo Poli";
Console.WriteLine("Traduttore in lingua italiana è:" +traduttore);

/* ISBN */

double isbn10;
isbn10 = (8850334389);
Console.WriteLine("ISBN-10:"+isbn10);

double isbn13;
isbn13 = (9788850334384);
Console.WriteLine("ISBN-13:" +isbn13);

/* Dimensioni e pagine */

int numeroPagine;
numeroPagine = (435);
Console.WriteLine("Numero pagine:" +numeroPagine);

int pesoLibro;
pesoLibro = (860);
Console.WriteLine("Peso del libro è:" +pesoLibro + "g");

string dimensioni;
dimensioni = "Le dimensioni del libro sono:";
Console.WriteLine(dimensioni);

float larghezza;
larghezza = ((float)17.3);
Console.WriteLine("L" +larghezza + "cm");

float altezza;
altezza = ((float)2.6);
Console.WriteLine("H" +altezza + "cm");

float profondità;
profondità = ((float)17.2);
Console.WriteLine("P" +profondità + "cm");

//Informazioni Amazon

float valutazioneMedia;
valutazioneMedia = ((float)4.4);
Console.WriteLine("Valutazione media è di:" +valutazioneMedia + "stelle su 5");

string kindle;
kindle = ("Disponibile");
Console.WriteLine("Versione Kindle:" +kindle);

float prezzoKindle;
prezzoKindle = ((float)12.99);
Console.WriteLine("Prezzo kindle:" +prezzoKindle + "euro");

string copertinaFlessibile;
copertinaFlessibile = ("Disponibile");
Console.WriteLine("La copertina flessibile è:" +copertinaFlessibile);

float prezzoCopertinaFlessibile;
prezzoCopertinaFlessibile = ((float)37.90);
Console.WriteLine("Prezzo copertina flessibile:" +prezzoCopertinaFlessibile + "euro");

//fine
















