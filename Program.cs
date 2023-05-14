//1.Phone Book
//Write a program that allows the user to enter names and phone numbers into a phone book.
//The program should allow the user to look up a phone number by name.

//Enter names
//Enter phone numbers
//Find a phone number using a certain name.

using System.ComponentModel;

Dictionary<string, string> phoneBook = new Dictionary<string, string>();

while (true)
{
	Console.WriteLine("Enter a name (or \"q\" to quit): ");

	string name = Console.ReadLine();

	if (name == "q")
	{
		break;
	}
	Console.WriteLine("Enter the phone numbers: ", name);

	string phoneNumber = Console.ReadLine();

	phoneBook.Add(name, phoneNumber);

}


while (true)
{
	Console.WriteLine("Enter a name to look up (or 'q' to quit):");
	string nameToLookup = Console.ReadLine();

	if (nameToLookup == "q")
	{
		break;
	}

	if (phoneBook.TryGetValue(nameToLookup, out string phoneNumber))
	{
		Console.WriteLine($"Phone number for {nameToLookup}: {phoneNumber}");
	}
	else
	{
		Console.WriteLine($"No phone number found for {nameToLookup}");
	}
}


//2.Letter Counter
//Write a program that reads in a string of text and counts the number of occurrences of each letter. \
//The program should ignore case.

// Enter text
// count the number of occurences of each letter
// ignore case

Dictionary<char, int> LetterCounter = new Dictionary<char, int>();

Console.WriteLine("Enter text in order to count the letters: ");
string text = Console.ReadLine();

string lowerCaseText = text.ToLower();

foreach (char c in lowerCaseText)
{
	if (char.IsLetter(c))
	{ 
		if (LetterCounter.ContainsKey(c))
		{
			LetterCounter[c]++;
		}
	else
		{ 
			LetterCounter[c] = 1;
		}
	}
}

foreach (KeyValuePair<char, int> pair in LetterCounter)
{
	Console.WriteLine($"{pair.Key}: {pair.Value}");
}