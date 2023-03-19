var users = [{name: "Michael", age:37}, {name: "John", age:30}, {name: "David", age:27}];

//print Johns age
console.log("Johns's age: ", users[1].age)// output 30

//print the name of the first object
console.log("First objects name is: ", users[0].name)

// print names and ages using for loop
for(let i = 0; i < users.length; i++){
    console.log(`${users[i].name} - ${users[i].age}`)
}

