namespace ReplitUnits.Week3;

public class Adventurer
{
    private static int _adventurers = 0;
    
    private string _name;
    private int _maxHp;
    private int _maxMp;

    private int _hp;
    private int _mp;

    private int _level = 0;
    private int _gold = 0;
    private int _silver = 0;
    private int _copper = 0;

    public Adventurer()
    {
        Adventurer._adventurers++;
    }

    public Adventurer(string name, int maxHp, int maxMp)
    {
        _name = name;
        _maxHp = maxHp;
        _maxMp = maxMp;
        _hp = maxHp;
        _mp = maxMp;
        Adventurer._adventurers++;
    }


    public Adventurer(string name, int maxHp, int maxMp, int level, int gold)
    {
        _name = name;
        _maxHp = maxHp;
        _maxMp = maxMp;
        _hp = maxHp;
        _mp = maxMp;
        _level = level;
        _gold = gold;
        Adventurer._adventurers++;
    }

    public int Gold
    {
        get => _gold;
        set => _gold = value;
    }

    public int Silver
    {
        get => _silver;
        set => _silver = value;
    }

    public int Copper
    {
        get => _copper;
        set => _copper = value;
    }
    
    public int Hp
    {
        get
        {
            return (_hp / _maxHp) * 100;
        }
    }

    public void Introduction()
    {
        Console.WriteLine("Hi, I am an adventurer, and I am ready to adventure!");
    }

    public void Description()
    {
        Console.WriteLine(_name);
        Console.WriteLine("{0} Max HP", _maxHp);
        Console.WriteLine("{0} Max MP", _maxMp);
        Console.WriteLine("Level {0}", _level);
    }

    public void SayGold()
    {
        Console.WriteLine("{0} has {1} gold pieces", _name, _gold);
    }

    public void DealDamage(int damageTaken)
    {
        Console.WriteLine("You has taken {0}", damageTaken);
        _hp -= damageTaken;

        if (_hp <= 0)
        {
            DealDamage();
        }
    }
    
    public void DealDamage()
    {
        DealDamage(1);
    }

    public void PlayerDeath()
    {
        Console.WriteLine("You have died!");
    }

    public bool UseMana(int manaUsed)
    {
        if (_mp < manaUsed)
        {
            Console.WriteLine("You do not have enough mana!");
            return false;
        }
        
        Console.WriteLine("You have used {0} mana", manaUsed);
        _mp -= manaUsed;
        return true;
    }

    public bool UseMana()
    {
        return UseMana(1);
    }

    public void ConvertCopperToSilver()
    {
        int newSilver = Copper / 10;
        _silver += newSilver;

        _copper -= newSilver * 10;
    }
    
    public void ConvertSilverToGold()
    {
        int newGold = Silver / 10;
        _gold += newGold;

        _silver -= newGold * 10;
    }
    
    public void ConvertGoldToSilver()
    {
        _silver += _gold * 10;
    }
    
    public void ConvertSilverToCopper()
    {
        _copper += _silver * 10;
    }

    public void BuySomthing(int coppperPrice)
    {
        ConvertGoldToSilver();
        ConvertSilverToCopper();
        
        if (_copper < coppperPrice)
        {
            Console.WriteLine("You do not have enough copper pieces to buy this");
            return;
        }
        
        _copper -= coppperPrice;
        ConvertCopperToSilver();
        ConvertSilverToGold();
    }

    public static int GetNumberOfAdventures()
    {
        return _adventurers;
    }
}