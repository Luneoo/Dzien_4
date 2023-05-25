using System.Diagnostics.Metrics;
using System.Threading;

int number = 854632;
string numberToString = number.ToString();
char[] letters = numberToString.ToArray();

int[] counter = new int[10];

for (int i = 0; i < 10; i++)
{
    counter[i] = 0;
}

foreach (char letter in letters)
{
    if (letter == '0') counter[0]++;

    else if (letter == '1') counter[1]++;

    else if (letter == '2') counter[2]++;

    else if (letter == '3') counter[3]++;

    else if (letter == '4') counter[4]++;

    else if (letter == '5') counter[5]++;

    else if (letter == '6') counter[6]++;

    else if (letter == '7') counter[7]++;

    else if (letter == '8') counter[8]++;

    else if (letter == '9') counter[9]++;

}

Console.WriteLine("Liczba to " + number);

for (int i = 0; i <= 9; i++)
{
    Console.WriteLine("Cyfr " + i + "-> " + counter[i]);
}

/*
Rozwiązanie numer dwa:

var zero = 0;
var one = 0;
var two = 0;
var three = 0;
var four = 0;
var five = 0;
var six = 0;
var seven = 0;
var eight = 0;
var nine = 0;

foreach (char letter in letters)
{
    if (letter == '0')zero++;

    else if (letter == '1') one++;
    
    else if (letter == '2') two++;

    else if (letter == '3') three++;

    else if (letter == '4') four++;

    else if (letter == '5') five++;

    else if (letter == '6') six++;

    else if (letter == '7') seven++;

    else if (letter == '8') eight++;

    else if (letter == '9') nine++;

}

Console.WriteLine("0->" + zero);
Console.WriteLine("1->" + one); 
Console.WriteLine("2->" + two);
Console.WriteLine("3->" + three);
Console.WriteLine("4->" + four);
Console.WriteLine("5->" + five);
Console.WriteLine("6->" + six);
Console.WriteLine("7->" + seven);
Console.WriteLine("8->" + eight);
Console.WriteLine("9->" + nine);

*/

