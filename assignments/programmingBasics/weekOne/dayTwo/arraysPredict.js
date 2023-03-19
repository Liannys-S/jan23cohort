
// Predict 1: will go through the array starting out at 0 and ending before array.length
// printing out each element in the array as follows:
/*
8
6
7
5
3
0
9
*/
var arr = [8,6,7,5,3,0,9]
for(var i = 0; i < arr.length; i++){    
    console.log(arr[i]);
}

// Predict 2: This loop will go through the array printing out the values of only odd numbers
// and printing out "That is odd!" for even numbers
/*
That is odd!
That is odd!
8
4
2
0 // i believe zero is considered even
That is odd!
*/ 

var arr = [7,3,8,4,2,0,1];
for(var i = 0; i < arr.length; i++){ 
    if(arr[i] % 2 == 0){
        console.log(arr[i]);
    } 
    else{
        console.log("That is odd!");
    }
}

// Predict 3: This loop will go through arr and store all negative values into newArr
// it will then change negative values in arr to positive, 0 to zero and positive values to negative
// finally it will print out both arrays 
/*
[-1,-3,-8,5,zero,2,-4,1]
[-5,-2,-1]
 */
var arr = [1,3,8,-5,0,-2,4,-1]
var newArr = []
for(var i = 0; i< arr.length; i++){
    if(arr[i] < 0){
        newArr.push(arr[i]);
        arr[i] = arr[i] * -1;
    }
    else if(arr[i] == 0){
        arr[i] = "Zero";
    }
    else{
        arr[i] = arr[i] * -1;
    }
}
console.log(arr);
console.log(newArr);
