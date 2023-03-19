function printOdds1to20(){
    for(let i = 1; i < 21; i++){
        console.log(i)
    }
}
// printOdds1to20()

function decMult3(){
    for(let i = 100; i > 0; i--){
        if(i % 3 == 0){
            console.log(i)
        }
    }
}
// decMult3()

function printArr(arr){
    for(let i = 0; i < arr.length; i++){
        console.log(arr[i])
    }
}
// printArr([4,2.5,1,-0.5,-2,-3.5])

function sigma(){
    var sum = 0
    for(let i = 1; i <= 100; i++){
        sum += i
    }
    console.log(sum)
}
// sigma()

function factorial(){
    var sum = 1
    for(let i = 1; i <= 12; i++){
        sum *= i
    }
    console.log(sum)
}
// factorial()