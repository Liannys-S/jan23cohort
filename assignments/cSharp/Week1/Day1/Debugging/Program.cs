// Challenge 1
bool amProgrammer = true; // bool cannot be converted to string, take out quotations to fix
double Age = 27.9; // int cannot have decimals, change data type to double
List<string> Names = new List<string>();
Names.Add("Monica"); // cannot convert string to List data type. use Add method
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0"); // cannot convert int into string, put quotations on the 0
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName";  //MyName needed to have double quotes since it's a string type
Console.WriteLine($"{amProgrammer} {Age} {MyName}"); // did this so the warning about not having used these variables go away
// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count - 1; i >= 0; i--) // out of bounds, i must begin at count minus 1
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers) // i is not an index but the value
{
    Console.WriteLine(i);
}

// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        
        //EvenMoreNumbers[EvenMoreNumbers.IndexOf(num)] = 0;
        //num = 0; //cannot modify collection in foreach loop. use a for loop instead
    }
}

// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
// MyString[7] = "p"; //string cannot be changed this way since it is not an array. instead use methods of the string class
MyString = MyString.Remove(7,1).Insert(7,"p");
Console.WriteLine(MyString);

// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(13);
if(randomNum == 12)
{
    Console.WriteLine("Hello"); //line will never execute because randomNum will never be 12. change limit to 13 
}


