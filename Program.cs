//Realizzare un programma in grado di chiedere a un utente una stringa, una chiave numerica,
//che possa realizzare un cifratore o decifratore del cifrario di cesare 

using System.Collections;
//string[] alfabeto = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

//funzione per trasformare una stringa in un array 
char[] stringToArray(string parola)
{ 
    char[] parolaArray = new char[parola.Length];

    for (int i = 0; i < parola.Length; i++)
    {
        parolaArray[i] = parola[i];
    }
    return parolaArray;
}

Console.WriteLine("Inserisci una parola");
string parolaUtente = Console.ReadLine();
stringToArray(parolaUtente);

void StampaArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write( array[i]);
    }
    Console.Write("]");
}

StampaArray(stringToArray(parolaUtente));


void cipher(string[] frase, int chiave)
{
    string[] alfabeto = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string fraseCifrata = "";
    string[] arrayCifrato = new string[frase.Length];

    for (int i = 0; i < frase.Length; i++)
    {
        arrayCifrato[i] = frase[i];
    
    }
}



