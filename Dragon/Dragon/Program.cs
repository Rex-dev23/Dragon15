using System;

public class Dragon
{
    private int maxHp;
    private int currentHp;
    private int maxAttack;
    private int totalDamage;
    private int numAttacks;
    private Random random;

    public Dragon(int maxHp, int maxAttack)
    {
        this.maxHp = maxHp;
        this.currentHp = maxHp;
        this.maxAttack = maxAttack;
        this.totalDamage = 0;
        this.numAttacks = 0;
        this.random = new Random();
    }

    public void Strike(Dragon enemy)
    {
        if (numAttacks % 2 == 0)
        {
            int damage = random.Next(1, maxAttack + 1);
            enemy.TakeDamage(damage);
            totalDamage += damage;
            numAttacks++;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHp = Math.Max(currentHp - damage, 0);
    }

    public void Heal(int amount)
    {
        currentHp = Math.Min(currentHp + amount, maxHp);
    }

    public int GetCurrentHp()
    {
        return currentHp;
    }

    public int GetTotalDamage()
    {
        int damage = totalDamage;
        totalDamage = 0;
        numAttacks = 0;
        return damage;
    }

    public double GetAverageDamage()
    {
        if (numAttacks == 0)
        {
            return 0.0;
        }
        else
        {
            return (double)totalDamage / numAttacks;
        }
    }
}
