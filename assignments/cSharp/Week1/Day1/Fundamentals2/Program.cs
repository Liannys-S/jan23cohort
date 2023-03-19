// Three Basic Arrays
// Create an integer array with the values 0 through 9 inside.
// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)

int[] numArr = new int[]{0,1,2,3,4,5,6,7,8,9};
string[] names = new string[4];
names[0] = "Tim";
names[1] = "Martin";
names[2] = "Nikki";
names[3] = "Sara";
bool[] isTrue = new bool[10];
for(int i = 0; i < isTrue.Length; i++){
    if(i % 2 == 0){
        isTrue[i] = true;
    }
    // Console.WriteLine(isTrue[i]);
}

// List of Flavors
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
// Output the length of the List after you added the flavors.
// Output the third flavor in the List.
// Now remove the third flavor using its index location.
// Output the length of the List again. It should now be one fewer.

List<string> iceCream = new List<string>();
iceCream.Add("Vanilla");
iceCream.Add("Chocolate");
iceCream.Add("Strawberry");
iceCream.Add("Nutella");
iceCream.Add("Cookies and Cream");
Console.WriteLine(iceCream.Count);
Console.WriteLine(iceCream[2]);
iceCream.RemoveAt(2);
Console.WriteLine(iceCream.Count);

// User Dictionary
// Create a dictionary that will store string keys and string values.
// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

Dictionary<string, string> favFlavor = new Dictionary<string, string>();
Random rand = new Random();
for(int i = 0; i < names.Length; i++){
    favFlavor.Add(names[i],iceCream[rand.Next(iceCream.Count)]);
}
foreach(KeyValuePair<string, string> entry in favFlavor){
    Console.WriteLine($"{entry.Key}'s favorite flavor is {entry.Value}");
}