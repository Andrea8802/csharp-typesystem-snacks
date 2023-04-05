// Snack1 

int num1;
int num2;

Console.WriteLine("Inserisci primo numero...");

while (!int.TryParse(Console.ReadLine(), out num1)){
    Console.WriteLine("Non hai inserito un numero, riprova");
}

Console.WriteLine("Inserisci secondo numero...");

while (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Non hai inserito un numero, riprova");
}

if (num1 > num2)
    Console.WriteLine("Il numero più grande è: " + num1);
else if (num1 < num2)
    Console.WriteLine("Il numero più grande è: " + num2);
else
    Console.WriteLine("I numeri sono uguali!");

