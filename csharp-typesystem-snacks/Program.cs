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
string word1;
string word2;

Console.WriteLine("Inserisci prima parola");
word1 = Console.ReadLine();

while (word1 == "")
{
    Console.WriteLine("Devi inserire almeno un carattere!");
    word1 = Console.ReadLine();
}

Console.WriteLine("Inserisci seconda parola");
word2 = Console.ReadLine();

while (word2 == "")
{
    Console.WriteLine("Devi inserire almeno un carattere!");
    word2 = Console.ReadLine();
}

if (word1.Length > word2.Length)
    Console.WriteLine("La parola più lunga è: " + word1);
else if (word1.Length < word2.Length)
    Console.WriteLine("La parola più lunga è: " + word2);
else
    Console.WriteLine("Le parole sono uguali!");

