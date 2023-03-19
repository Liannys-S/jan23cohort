// Biggie Size - Given an array, write a function that changes all positive numbers in the array to the string "big".
// Example: makeItBig([-1,3,5,-5]) returns that same array, changed to [-1, "big", "big", -5].
function biggieSize(arr) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] > 0) {
            arr[i] = 'big'
        }
    }
    return arr
}
// var testArr = [-1,3,5,-5]
// console.log(biggieSize(testArr))

// Print Low, Return High - Create a function that takes in an array of numbers.  The function should print the lowest value in the array, and return the highest value in the array.
function printLowReturnHigh(arr) {
    var low = arr[0]
    var high = arr[0]
    for (let i = 1; i < arr.length; i++) {
        if (arr[i] < low) {
            low = arr[i]
        }
        if (arr[i] > high) {
            high = arr[i]
        }
    }
    console.log('lowest value in array: ', low)
    return high
}
// var testArr = [-1,3,5,-5]
// console.log(printLowReturnHigh(testArr))

// Print One, Return Another - Build a function that takes in an array of numbers.  The function should print the second-to-last value in the array,
// and return the first odd value in the array.
function printOneReturnAnother(arr) {
    console.log('second to last: ', arr[arr.length - 2])
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] % 2 != 0) {
            return arr[i]
        }
    }
}
// var testArr = [-1,3,5,-5]
// console.log(printOneReturnAnother(testArr))

// Double Vision - Given an array (similar to saying 'takes in an array'), create a function that returns a new array where each value in the original array has been doubled.
// Calling double([1,2,3]) should return [2,4,6] without changing the original array.
function doubleVision(arr) {
    var newArr = []
    for (let i = 0; i < arr.length; i++) {
        newArr.push(arr[i] * 2)
    }
    return newArr
}
// var testArr = [1,2,3]
// console.log(doubleVision(testArr))
// console.log(testArr)

// Count Positives - Given an array of numbers, create a function to replace the last value with the number of positive values found in the array.
// Example, countPositives([-1,1,1,1]) changes the original array to [-1,1,1,3] and returns it.
function countPositives(arr) {
    var count = 0;
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] > 0) {
            count++
        }
    }
    arr[arr.length - 1] = count
    return arr
}
// var testArr = [-1,1,1,1]
// console.log(countPositives(testArr))

// Evens and Odds - Create a function that accepts an array.  Every time that array has three odd values in a row, print "That's odd!".  Every time the array has three evens in a row, print "Even more so!".
function evenAndOdds(arr) {
    for (let i = 0; i < arr.length - 2; i++) {    // arr.length-2 helps not check the last index and cause the first if to check undefined and return true causing a logical error in the program
        if (arr[i] % 2 != 0 && arr[i + 1] % 2 != 0 && arr[i + 2] % 2 != 0) {
            console.log("That's odd!")
        }
        if (arr[i] % 2 == 0 && arr[i + 1] % 2 == 0 && arr[i + 2] % 2 == 0) {
            console.log("Even more so!")
        }
    }
}
// var testArr = [2,4,6,-1,3,5]
// evenAndOdds(testArr)

// Increment the Seconds - Given an array of numbers arr, add 1 to every other element, specifically those whose index is odd (arr[1], arr[3], arr[5], etc).  Afterward, console.log each array value and return arr.
function incrementTheSeconds(arr) {
    for (let i = 1; i < arr.length; i += 2) {
        arr[i]++
    }
    for (let i = 0; i < arr.length; i++) {
        console.log(arr[i])
    }
    return arr
}
// var testArr = [0,0,0,0,0,0]
// incrementTheSeconds(testArr)

// Previous Lengths - You are passed an array (similar to saying 'takes in an array' or 'given an array') containing strings.
// Working within that same array, replace each string with a number - the length of the string at the previous array index - and return the array.
// For example, previousLengths(["hello", "dojo", "awesome"]) should return ["hello", 5, 4]. Hint: Can for loops only go forward?
function previousLengths(arr) {
    for (let i = arr.length - 1; i > 0; i--) {
        arr[i] = arr[i - 1].length
    }
    return arr
}
// var testArr = ['hello','dojo','awesome']
// console.log(previousLengths(testArr))

// Add Seven - Build a function that accepts an array. Return a new array with all the values of the original, but add 7 to each. Do not alter the original array.
// Example, addSeven([1,2,3]) should return [8,9,10] in a new array.
function addSeven(arr) {
    var newArr = []
    for (let i = 0; i < arr.length; i++) {
        newArr.push(arr[i] + 7)
    }
    return newArr
}
// var testArr = [1,2,3]
// console.log(addSeven(testArr))

// Reverse Array - Given an array, write a function that reverses its values, in-place.
// Example: reverse([3,1,6,4,2]) returns the same array, but now contains values reversed like so... [2,4,6,1,3].  Do this without creating an empty temporary array.  (Hint: you'll need to swap values).
function reverseArr(arr) {
    var temp = 0
    var index = 0
    for (let i = 1; i <= arr.length / 2; i++) {
        temp = arr[arr.length - i]
        arr[arr.length - i] = arr[index]
        arr[index] = temp
        index++
    }
    return arr
}
// var testArr = [3,1,6,4,2]
// console.log(reverseArr(testArr))

// Outlook: Negative - Given an array, create and return a new one containing all the values of the original array, but make them all negative (not simply multiplied by -1). Given [1,-3,5], return [-1,-3,-5].
function outlookNegative(arr) {
    var newArr = []
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] > 0) {
            newArr.push(arr[i] * -1)
        } else {
            newArr.push(arr[i])
        }
    }
    return newArr
}
// var testArr = [1,-3,5]
// console.log(outlookNegative(testArr))

// Always Hungry - Create a function that accepts an array, and prints "yummy" each time one of the values is equal to "food".  If no array values are "food", then print "I'm hungry" once.
function alwaysHungry(arr) {
    var isHungry = true;
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] == 'food') {
            console.log('yummy')
            isHungry = false
        }
    }
    if (isHungry) {
        console.log("I'm hungry")
    }
}
// var testArr = ['no','no','no']
// var testArr1 = ['food','mango','food']
// alwaysHungry(testArr)
// alwaysHungry(testArr1)

// Swap Toward the Center - Given an array, swap the first and last values, third and third-to-last values, etc.
// Example: swapTowardCenter([true,42,"Ada",2,"pizza"]) turns the array into ["pizza", 42, "Ada", 2, true].
// swapTowardCenter([1,2,3,4,5,6]) turns the array into [6,2,4,3,5,1].  No need to return the array this time.
function swapTowardCenter(arr) {
    var endIndex = 1
    var last = 0
    for (let i = 0; i <= arr.length/3; i += 2) {
        last = arr[arr.length - endIndex]
        arr[arr.length - endIndex] = arr[i]
        arr[i] = last
        endIndex += 2
    }
}
// var testArr = [true,42,"Ada",2,"pizza"]
// var testArr1 = [1, 2, 3, 4, 5, 6]
// swapTowardCenter(testArr)
// swapTowardCenter(testArr1)
// console.log(testArr, testArr1)

// Scale the Array - Given an array arr and a number num, multiply all values in the array arr by the number num, and return the changed array arr.
// For example, scaleArray([1,2,3], 3) should return [3,6,9].
function scaleArray(arr, num){
    for(let i = 0; i < arr.length; i++){
        arr[i] *= num
    }
    return arr
}
// console.log(scaleArray([1,2,3], 3))
