/* 
Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
*/

Console.Write("Enter an English word: ");
var input = Console.ReadLine().ToLower();
var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
var numberOfVowels = 0;
for(var i = 0; i < input.Length; i++)
{
    if(vowels.Contains(input[i]))
    {
        numberOfVowels++;
    }
}
Console.WriteLine("Number of vowels: " + numberOfVowels);

