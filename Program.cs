//Realizzare un programma in grado di chiedere a un utente una stringa, una chiave numerica,
//che possa realizzare un cifratore o decifratore del cifrario di cesare 

using System.Collections;
using System.Security.Principal;

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

//funzione per cifrare la frase
string cipher(string frase, int chiave)
{
    char[] arrayDaCifrare = stringToArray(frase.ToLower());

    for (int i = 0; i < arrayDaCifrare.Length; i++)
    {
       //Il carattere "space"(posizione ascii 32) non cambia
        if (arrayDaCifrare[i] == 32)
        {
            arrayDaCifrare[i] = arrayDaCifrare[i];
        }

        else

        {
            //i caratteri cambiano di posizione secondo la chiave
            arrayDaCifrare[i] = ((char)(arrayDaCifrare[i] + chiave));

            //Se si va oltre si riparte dalla prima lettera dell'alfabeto
            if (arrayDaCifrare[i] > 122)
                arrayDaCifrare[i] = ((char)(arrayDaCifrare[i] - 29 + chiave));            
        }
    }
    return new string(arrayDaCifrare);
}

//funzione per decifrare la frase criptata
string decipher(string frase, int chiave)
{
    char[] arrayDaDecifrare = stringToArray(frase.ToLower());

    for (int i = 0; i < arrayDaDecifrare.Length; i++)
    {
        //Il carattere "space"(posizione ascii 32) non cambia
        if (arrayDaDecifrare[i] == 32)
        {
            arrayDaDecifrare[i] = arrayDaDecifrare[i];
        }

        else
        {
            //i caratteri cambiano di posizione secondo la chiave
            arrayDaDecifrare[i] = ((char)(arrayDaDecifrare[i] - chiave));

            if (arrayDaDecifrare[i] < 97)
                arrayDaDecifrare[i] = ((char)(arrayDaDecifrare[i] - chiave + 29));
        }
    }
    return new string(arrayDaDecifrare);
}

Console.WriteLine("Digita 0 per criptare una frase, 1 per decriptare");
string sceltaUtente = Console.ReadLine();

if(sceltaUtente != "0" && sceltaUtente != "1")
    Console.WriteLine("Sei capace di premere un tasto?");
else
{
    if (sceltaUtente == "0")
    {
        Console.WriteLine("Inserisci una frase da criptare");
        string fraseUtente = Console.ReadLine();
        Console.WriteLine("Scegli una chiave numerica");
        int chiaveUtente = Convert.ToInt32(Console.ReadLine());
        string fraseCifrata = cipher(fraseUtente, chiaveUtente);
        Console.WriteLine("la frase criptata è: " + fraseCifrata);
    }
    if (sceltaUtente == "1")
    {
        Console.WriteLine("Inserisci un codice da decriptare");
        string fraseUtente = Console.ReadLine();
        Console.WriteLine("Inserisci una chiave numerica");
        int chiaveUtente = Convert.ToInt32(Console.ReadLine());
        string fraseDecifrata = decipher(fraseUtente, chiaveUtente);
        Console.WriteLine("la frase criptata è: " + fraseDecifrata);
    }
}



