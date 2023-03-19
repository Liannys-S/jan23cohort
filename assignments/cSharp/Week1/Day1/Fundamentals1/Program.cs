// loop that prints values 1-255
for(int i = 1; i <= 255; i++){
    Console.WriteLine(i);
}
//while loop
int a = 1;
while(a <= 255){
    Console.WriteLine(a);
    a++;
}

// loop that generates 5 random numbers and sums them up
Random rand = new Random();
int sum = 0;
for(int i = 0; i < 5; i++){
    int temp = rand.Next(10,21);
    Console.WriteLine(temp);
    sum += temp;
}
Console.WriteLine(sum);
//while loop
sum = 0;
int b = 0;
while(b < 5){
    int temp = rand.Next(10,21);
    Console.WriteLine(temp);
    sum += temp;
    b++;
}
Console.WriteLine(sum);

// loop that prints values 1-100 that are divisible by 3 or 5 but not both
for(int i = 1; i <= 100; i++){
    if((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0)){
        Console.WriteLine(i);
        if(i % 3 == 0){
            Console.WriteLine("Fizz");
        }else{
            Console.WriteLine("Buzz");
        }
    } else if(i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
}
//while loop
int c = 1;
while(c <= 100){
    if((c % 3 == 0 || c % 5 == 0) && !(c % 3 == 0 && c % 5 == 0)){
        Console.WriteLine(c);
        if(c % 3 == 0){
            Console.WriteLine("Fizz");
        }else{
            Console.WriteLine("Buzz");
        }
    } else if(c % 3 == 0 && c % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    c++;
}