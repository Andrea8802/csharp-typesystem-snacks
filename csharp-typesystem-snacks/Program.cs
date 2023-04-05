using System.Net.WebSockets;

internal class Program
{
    private static void Main(string[] args)
    {
        // Snack1 ----------

        //int num1;
        //int num2;

        //Console.WriteLine("Inserisci primo numero...");

        //while (!int.TryParse(Console.ReadLine(), out num1)){
        //    Console.WriteLine("Non hai inserito un numero, riprova");
        //}

        //Console.WriteLine("Inserisci secondo numero...");

        //while (!int.TryParse(Console.ReadLine(), out num2))
        //{
        //    Console.WriteLine("Non hai inserito un numero, riprova");
        //}

        //if (num1 > num2)
        //    Console.WriteLine("Il numero più grande è: " + num1);
        //else if (num1 < num2)
        //    Console.WriteLine("Il numero più grande è: " + num2);
        //else
        //    Console.WriteLine("I numeri sono uguali!");


        // Snack 2 ----------
        //string word1;
        //string word2;

        //Console.WriteLine("Inserisci prima parola");
        //word1 = Console.ReadLine();

        //while (word1 == "")
        //{
        //    Console.WriteLine("Devi inserire almeno un carattere!");
        //    word1 = Console.ReadLine();
        //}

        //Console.WriteLine("Inserisci seconda parola");
        //word2 = Console.ReadLine();

        //while (word2 == "")
        //{
        //    Console.WriteLine("Devi inserire almeno un carattere!");
        //    word2 = Console.ReadLine();
        //}

        //if (word1.Length > word2.Length)
        //    Console.WriteLine($"Le parole sono: '{word1}' e '{word2}'");
        //else if (word1.Length < word2.Length)
        //    Console.WriteLine($"Le parole sono: '{word2}' e '{word1}'");
        //else
        //    Console.WriteLine($"Le parole sono: '{word1}' e '{word2}'");

        // Snack 3 ----------

        //int numRimanenti = 10;
        //int numUtente;
        //int somma = 0;


        //for (int i = 0; i < numRimanenti; i++)
        //{
        //    Console.WriteLine("Rimanenti: " + (numRimanenti - i));
        //    Console.WriteLine("Inserisci un numero: ");
        //    while (!int.TryParse(Console.ReadLine(), out numUtente))
        //    {
        //        Console.WriteLine("Rimanenti: " + (numRimanenti - i));
        //        Console.WriteLine("Devi inserire un numero!");
        //    }

        //    somma += numUtente;

        //}

        //Console.WriteLine("La somma è: " + somma);


        // Snack 4 ----------

        //int[] numeri = {2, 3, 4, 5, 6, 7, 8};
        //int somma = 0;

        //for (int i = 0; i < numeri.Length; i++)
        //{
        //    somma += numeri[i];

        //}

        //Console.WriteLine("La somma è: " + somma);

        //Console.WriteLine("La media è: " + somma / numeri.Length);


        // Snack 5 ----------

        //int numUtente;

        //Console.WriteLine("Inserisci un numero");

        //while(!int.TryParse(Console.ReadLine(), out numUtente))
        //{
        //    Console.WriteLine("Devi inserire un numero!");

        //}

        //if(numUtente % 2 == 0) 
        //    Console.WriteLine("Il numero è: " + numUtente);
        //else
        //    Console.WriteLine("Il numero è: " + (numUtente + 1));


        // Snack 6 ----------

        //using System;

        //string[] invitati = { "Hadson", "Davide", "Igor", "Andrea" };
        //string nomeUtente;

        //Console.WriteLine("Inserisci il tuo nome...");
        //nomeUtente = Console.ReadLine();


        //while (nomeUtente == "")
        //{
        //    Console.WriteLine("Devi inserire il tuo nome!");
        //    nomeUtente = Console.ReadLine();
        //}

        //if (invitati.Contains(nomeUtente))
        //    Console.WriteLine("Benvenuto!");
        //else
        //    Console.WriteLine("Non sei invitato!");


        // Snack 7 ----------

        //int[] numeri = new int[6];
        //int numero = 0;
        //for (int i = 0; i <  numeri.Length; i++)
        //{
        //    Console.WriteLine("Inserisci un numero!");
        //    while(!int.TryParse(Console.ReadLine(), out numero)){
        //        Console.WriteLine("Devi inserire un numero!");

        //    }
        //    if (numero % 2 != 0)
        //        numeri[i] = numero;
        //}

        //Console.WriteLine("I numeri sono: ");
        //for (int i = 0; i < numeri.Length; i++)
        //{
        //    if (numeri[i] > 0)
        //        Console.WriteLine(numeri[i]);

        //}


        // Snack 8 ----------

        //int[] numeri = { 23, 44, 3, 1, 65, 23, 11, 45 };
        //int somma = 0;

        //for(int i = 0; i < numeri.Length; i++)
        //{
        //    if(i % 2 != 0)
        //    {
        //        somma += numeri[i];
        //    } 
        //}

        //Console.WriteLine(somma);   


        // Snack 9 ----------

        //int[] numbers = new int[0];
        //int somma = 0;
        //int num;

        //while (somma < 50)
        //{
        //    Console.Write("Inserisci un numero: ");

        //    while (!int.TryParse(Console.ReadLine(), out num))
        //      {
        //       Console.WriteLine("Devi inserire un numero!");
        //      }

        //        Array.Resize(ref numbers, numbers.Length + 1);
        //    numbers[numbers.Length - 1] = num;

        //    somma += num;
        //}

        //Console.WriteLine("I numeri sono:");

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}


        // Snack 10 ----------
        //Console.WriteLine("Inserisci il numero di array da generare:");
        //int n = int.Parse(Console.ReadLine());

        //Random random = new Random();
        //for (int i = 0; i < n; i++)
        //{
        //    int[] array = new int[10];
        //    for (int x = 0; x < array.Length; x++)
        //    {
        //        array[x] = random.Next(1, 101);
        //    }
        //    Console.WriteLine("Array " + (i + 1) + ": " + string.Join(", ", array));
        //}


        // Snack 11 ----------
        //Console.Write("Inserisci la prima parola: ");
        //string parola1 = Console.ReadLine();
        //Console.Write("Inserisci la seconda parola: ");
        //string parola2 = Console.ReadLine();

        //if (confronta_lunghezza(parola1, parola2))
        //{
        //    Console.WriteLine(parola1);
        //    Console.WriteLine(parola2);
        //}
        //else
        //{
        //    Console.WriteLine(parola1.Length > parola2.Length ? parola1 : parola2);
        //}


        // Snack 12 ----------
        //Console.Write("Inserisci un numero intero: ");
        //int numero = Convert.ToInt32(Console.ReadLine());

        //if (IsPari(numero))
        //{
        //    Console.WriteLine(numero + " è un numero pari.");
        //}
        //else
        //{
        //    Console.WriteLine(numero + " è un numero dispari.");
        //}


}

    static bool confronta_lunghezza(string parola1, string parola2)
    {
        return parola1.Length == parola2.Length;
    }

    static bool IsPari(int numero)
    {
        return numero % 2 == 0;
    }
}