class Melee : Enemy
{
    
    public Attack Punch = new Attack("Punch", 20);
    public Attack Kick = new Attack("Kick", 15);
    public Attack Tackle = new Attack("Tackle", 25);
    public Melee(string name) : base(name, 120)
    {
        base.AttackList.Add(Punch);
        base.AttackList.Add(Kick);
        base.AttackList.Add(Tackle);
    }
    public void Rage(Enemy target)
    {
        Attack randomAtk = base.RandAtk();
        randomAtk.DmgAmount += 10;
        base.PerformAttack(target, randomAtk);
        randomAtk.DmgAmount -= 10;
    }
}