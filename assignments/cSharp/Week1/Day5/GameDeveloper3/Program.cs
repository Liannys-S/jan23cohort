
Console.WriteLine("Hey kid! Lookout you got a fireball heading your way!");
Console.WriteLine("What the heck are you doing here in the arena with no weapons, born yesterday or something?");
Console.WriteLine("I'm AL, What's your name pal?");

string name = Console.ReadLine();

Console.WriteLine($"{name}? Yikes, your parents didn't like you huh? Well listen here you pitiful thing, if you wanna live to see the light of day grab that sword and get to fighting!");
Console.WriteLine("Woah! Don't swing it at me idiot! Aim at the enemies...");
bool playing = false;
do{
Player player1 = new Player(name);

//adding all enemy types to a list a getting a random one to fight 
Ranged ashe = new Ranged("Ashe");
Melee olaf = new Melee("Olaf");
Magic veigar =  new Magic("Veigar");
ashe.Dash(); // setting this up so ashe can attack
List<Enemy> enemyList = new List<Enemy>();
enemyList.Add(ashe);
enemyList.Add(olaf);
enemyList.Add(veigar);
Random rand = new Random();
Enemy enemy = enemyList[rand.Next(enemyList.Count)];



    Console.WriteLine("An enemy is coming your way!");
    bool fighting = true;
    while(fighting){
        Console.WriteLine("Pick an attack to fight them with: (enter a number 1-4)");
        Console.WriteLine($"[1] {player1.AttackList[0].Name}");
        Console.WriteLine($"[2] {player1.AttackList[1].Name}");
        Console.WriteLine($"[3] {player1.AttackList[2].Name}");
        Console.WriteLine($"[4] {player1.AttackList[3].Name}");
        string atkNum = Console.ReadLine();
        if(atkNum == "1"){
            player1.PerformAttack(enemy,player1.AttackList[0]);
        }else if(atkNum == "2"){
            player1.PerformAttack(enemy,player1.AttackList[1]);
        }else if(atkNum == "3"){
            player1.PerformAttack(enemy,player1.AttackList[2]);
        }else if(atkNum == "4"){
            player1.PerformAttack(enemy,player1.AttackList[3]);
        }
        else{
            Console.WriteLine("You really don't know how to follow instructions huh? I ain't got time to loop this for you so you lose your chance to attack");
        }
        if(enemy.Health == 0){
            Console.WriteLine("Well look at that, guess you are good for something!");
            Console.WriteLine($"{enemy.Name} is defeated. All Hail our victor, {player1.Name}!!!");
            fighting = false;
            playing = PlayAgain();
            break;
        }
        Console.WriteLine("Now it's your enemy's turn, brace yourself!");
        enemy.PerformAttack(player1,enemy.RandAtk());
        if(player1.Health == 0){
            Console.WriteLine("Well this was expected... Rest in pieces buddy, you sure were brave, stupid, but brave...");
            fighting = false;
            playing = PlayAgain();
        }
    }
}while(playing);

static bool PlayAgain(){
    Console.WriteLine("Would you like to play again? y/n");
    string input = Console.ReadLine();
    if(input == "y"){
        return true;
    }else{
        return false;
    }
}