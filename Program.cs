
using System.Globalization;

Analyse();
Sort();
Duplicate();


// 1
bool Compare()

{
    string stringA = "SomeNewString";
    string stringB = "SomeNewString";
    if (stringA == stringB)
        return true;
    else
        return false;
}

//2

void Analyse()
{


    string stringC = "Petro_1234_!@#9999";

    char[] digits = stringC.Where(char.IsDigit).ToArray();
    Console.WriteLine($"Number of digits in string = " + digits.Length);

    char[] letters = stringC.Where(char.IsLetter).ToArray();
    Console.WriteLine($"Number of letters in string = " + letters.Length);

    char[] stringS = stringC.ToArray();
    Console.WriteLine($"Number of other symbols in string = {stringS.Length - (digits.Length + letters.Length)}");


}

//3

void Sort()

{
    // Не заморочувався з перетворенням в один регістр. Якщо ввести великі і малі букви - відсортує окремо.
    // Інакше, чим через масив мені ніяк це не виходило знайти реалізацію цього завдання .

    string stringD = "exercisenumberthree";

    char[] stringX = stringD.ToArray();
    Array.Sort(stringX);
    Console.WriteLine(stringX);
}



//4
//підглянув таке виконання у https://www.geeksforgeeks.org/c-sharp-dictionary-containskey-method/


void Duplicate()
{
    string stringE = "exercisenumberfour+_+++_(987";

    Dictionary<char, int > key = new();
    foreach (char value in stringE)
    {
        if (key.ContainsKey(value))
            key[value]++;
        else
            key[value] = 1;
    }

    foreach (var duplicate in key)
    {
        Console.WriteLine($"Symbol {duplicate.Key} is repeating for {duplicate.Value} times");
    }
}



    


