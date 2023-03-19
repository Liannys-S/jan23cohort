class Player : Enemy
{

    public Player(string name) : base(name)
    {
        Attack Strike = new Attack("Decisive Strike", 15);
        Attack Courage = new Attack("Courage", 10);
        Attack Judgement = new Attack("Judgement", 20);
        Attack Justice = new Attack("Demacian Justice", 25);
        base.AttackList.Add(Strike);
        base.AttackList.Add(Courage);
        base.AttackList.Add(Judgement);
        base.AttackList.Add(Justice);
    }

}