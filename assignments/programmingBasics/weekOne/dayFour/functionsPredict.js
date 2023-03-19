
//predict 1: This function will return "Hello" only and ignore anything after the return statement
// the return statement is then stored in variable word which is then console.log therefore the output will be :
// Hello
function greeting() {
    return "Hello";
    console.log("World");
}
var word = greeting();
console.log(word);

//predict 2: This function accepts two parameters, preferably integers. output the console logs, add the two numbers and return the sum 
// the output will be:
/*
Summing Numbers!
num1 is 3
num2 is 5 
Summing Numbers!
num1 is 4
num2 is 7
8
11
*/
function add(num1, num2) {
    console.log("Summing Numbers!");
    console.log("num1 is: " + num1);
    console.log("num2 is: " + num2);
    var sum = num1 + num2;
    return sum;
}
var result1 = add(3, 5);
var result2 = add(4, 7);
console.log(result1);
console.log(result2);

//predict 3: this function is not called and therefore will not display anything
// had it been called it would accept a parameter, preferably an integer and go through a for loop until it reaches that integer
// if the for loop passes through a 5 it will print "High Five!" otherwise will print the index number (i)
function highFive(num) {
    for (var i = 0; i < num; i++) {
        if (i == 5) {
            console.log("High Five!");
        }
        else {
            console.log(i);
        }
    }
}


