
//1. Iterate and print values 
static void PrintList(List<string> MyList)
{
    //foreach loop
    foreach(string name in MyList){
      //  Console.WriteLine(name);
    }
    //for loop
    for(int i = 0; i < MyList.Count; i++){
       // Console.WriteLine(MyList[i]);
    }
    //lambda expression
    MyList.ForEach((name) => Console.WriteLine(name));
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);

//2. Print Sum
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach(int n in IntList){
        sum += n;
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);

//3. Find Max
static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach(int n in IntList){
        if(n > max){
            max = n;
        }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));

//4. Square the Values
static List<int> SquareValues(List<int> IntList)
{
    for(int i = 0; i < IntList.Count; i++){
        IntList[i] *= IntList[i];
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);
TestIntList3.ForEach((n) => Console.WriteLine(n));

//5. Replace Negative Numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    for(int i = 0; i < IntArray.Length; i++){
        if(IntArray[i] < 0){
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);
foreach(var n in TestIntArray){
    Console.WriteLine(n);
}

//6. Print Dictionary
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach(var entry in MyDictionary){
        Console.WriteLine($"{entry.Key} : {entry.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

//7. Find Key
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    bool exists = false;
    foreach(var entry in MyDictionary){
        if(entry.Key == SearchTerm){
            exists = true;
        }
    }
    return exists;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

//8. Generate a Dictionary
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> newDictionary = new Dictionary<string, int>();
    if(Names.Count != Numbers.Count){
        Console.WriteLine("The indexes of the lists are not equal, please try again");
        return newDictionary;
    }
    for(int i = 0; i < Names.Count; i++){
        newDictionary.Add(Names[i], Numbers[i]);
    }
    return newDictionary;
}
List<string> names = new List<string>();
names.Add("Julie");
names.Add("Harold");
names.Add("James");
names.Add("Monica");
names.Add("Monica");
List<int> numbers = new List<int>();
numbers.Add(6);
numbers.Add(12);
numbers.Add(7);
numbers.Add(10);
var generatedDict = GenerateDictionary(names,numbers);
foreach(var entry in generatedDict){
    Console.WriteLine($"Name: {entry.Key} Number: {entry.Value}");
}

// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here

