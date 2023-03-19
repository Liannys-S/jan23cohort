class Enemy{
    string Name;
    int Health;
    public List<Attack> AttackList;

    public Enemy(string name){
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }
    public Attack RandAtk(){
        Random rand = new Random();
        int indexRand = rand.Next(AttackList.Count);
        return AttackList[indexRand];
    }
}