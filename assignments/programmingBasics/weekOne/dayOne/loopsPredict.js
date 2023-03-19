
// prediction: this loop will print out the numbers 0-14
for (var num = 0; num < 15; num++)
{
    console.log(num)
}

//prediction: this loop will display numbers (1-9 in increments of 2 (1,3,5,7,9)) divisible by 3 ex. 3,9
for(var i = 1; i < 10; i+=2){
    if(i % 3 == 0){
        console.log(i);
    }
}

//prediction: 1,4,5,8,10,11,14,16 
//enter for loop starting at i = 1 
//if i is divisible by two then add 2 to i, otherwise if i is divisible by 3 then add i to i
//output i 
//increment i
for(var j = 1; j <= 15; j++){
    if(j % 2 == 0){
        j+=2;
    }
    else if(j % 3 == 0){
        j++;
    }
    console.log(j);
}

