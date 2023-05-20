using System;

public interface MagicWeapon
{
    void GetImp();
    void Attack();
    void Sell();
    void Buy();
}

public class MagicWeaponImpl : MagicWeapon
{
    public void GetImp()
    {
        Console.WriteLine("Getting MagicWeaponImpl");
    }

    public void Attack()
    {
        Console.WriteLine("Attacking with MagicWeaponImpl");
    }

    public void Sell()
    {
        Console.WriteLine("Selling MagicWeaponImpl");
    }

    public void Buy()
    {
        Console.WriteLine("Buying MagicWeaponImpl");
    }
}

public class LightningMagicWeapon : MagicWeapon
{
    public void GetImp()
    {
        Console.WriteLine("Getting LightningMagicWeaponImpl");
    }

    public void Attack()
    {
        Console.WriteLine("Attacking with LightningMagicWeapon");
    }

    public void Sell()
    {
        Console.WriteLine("Selling LightningMagicWeapon");
    }

    public void Buy()
    {
        Console.WriteLine("Buying LightningMagicWeapon");
    }

    public void Shock()
    {
        Console.WriteLine("Shocking with LightningMagicWeapon");
    }
}

public class FrostMagicWeapon : MagicWeapon
{
    private readonly FrostMagicWeaponImpl frostMagicWeaponImpl;

    public FrostMagicWeapon(FrostMagicWeaponImpl impl)
    {
        frostMagicWeaponImpl = impl;
    }

    public void GetImp()
    {
        Console.WriteLine("Getting FrostMagicWeaponImpl");
    }

    public void Attack()
    {
        Console.WriteLine("Attacking with FrostMagicWeapon");
    }

    public void Sell()
    {
        Console.WriteLine("Selling FrostMagicWeapon");
    }

    public void Buy()
    {
        Console.WriteLine("Buying FrostMagicWeapon");
    }

    public void Freeze()
    {
        Console.WriteLine("Freezing with FrostMagicWeapon");
    }
}

public class FireMagicWeapon : MagicWeapon
{
    private readonly FireMagicWeaponImpl fireMagicWeaponImpl;

    public FireMagicWeapon(FireMagicWeaponImpl impl)
    {
        fireMagicWeaponImpl = impl;
    }

    public void GetImp()
    {
        Console.WriteLine("Getting FireMagicWeaponImpl");
    }

    public void Attack()
    {
        Console.WriteLine("Attacking with FireMagicWeapon");
    }

    public void Sell()
    {
        Console.WriteLine("Selling FireMagicWeapon");
    }

    public void Buy()
    {
        Console.WriteLine("Buying FireMagicWeapon");
    }

    public void Burn()
    {
        Console.WriteLine("Burning with FireMagicWeapon");
    }
}

public class FrostMagicWeaponImpl
{
    public void FreezeImp()
    {
        Console.WriteLine("Freezing with FrostMagicWeaponImpl");
    }
}

public class LightningMagicWeaponImpl
{
    public void ShockImp()
    {
        Console.WriteLine("Shocking with LightningMagicWeaponImpl");
    }
}

public class FireMagicWeaponImpl
{
    public void BurnImp()
    {
        Console.WriteLine("Burning with FireMagicWeaponImpl");
    }
}

public class AstrtusWang
{
    public void BuyImp()
    {
        Console.WriteLine("Buying MagicWeaponImpl");
    }

    public void SellImp()
    {
        Console.WriteLine("Selling MagicWeaponImpl");
    }

    public void FreezeImp()
    {
        Console.WriteLine("Freezing with FrostMagicWeaponImpl");
    }

    public void AttackImp()
    {
        Console.WriteLine("Attacking with MagicWeaponImpl");
    }
}

public class ElectricShock
{
    public void BuyImp()
    {
        Console.WriteLine("Buying MagicWeaponImpl");
    }

    public void SellImp()
    {
        Console.WriteLine("Selling MagicWeaponImpl");
    }

    public void ShockImp()
    {
        Console.WriteLine("Shocking with LightningMagicWeaponImpl");
    }

    public void AttackImp()
    {
        Console.WriteLine("Attacking with MagicWeaponImpl");
    }
}

public class FireBurn
{
    public void BuyImp()
    {
        Console.WriteLine("Buying MagicWeaponImpl");
    }

    public void SellImp()
    {
        Console.WriteLine("Selling MagicWeaponImpl");
    }

    public void BurnImp()
    {
        Console.WriteLine("Burning with FireMagicWeaponImpl");
    }

    public void AttackImp()
    {
        Console.WriteLine("Attacking with MagicWeaponImpl");
    }
}

class Program
{
    static void Main()
    {
        MagicWeapon magicWeapon = new MagicWeaponImpl();
        magicWeapon.GetImp();
        magicWeapon.Attack();
        magicWeapon.Sell();
        magicWeapon.Buy();

        Console.WriteLine();

        LightningMagicWeapon lightningMagicWeapon = new LightningMagicWeapon();
        lightningMagicWeapon.GetImp();
        lightningMagicWeapon.Attack();
        lightningMagicWeapon.Sell();
        lightningMagicWeapon.Buy();
        lightningMagicWeapon.Shock();

        Console.WriteLine();

        FrostMagicWeaponImpl frostMagicWeaponImpl = new FrostMagicWeaponImpl();
        FrostMagicWeapon frostMagicWeapon = new FrostMagicWeapon(frostMagicWeaponImpl);
        frostMagicWeapon.GetImp();
        frostMagicWeapon.Attack();
        frostMagicWeapon.Sell();
        frostMagicWeapon.Buy();
        frostMagicWeapon.Freeze();

        Console.WriteLine();

        FireMagicWeaponImpl fireMagicWeaponImpl = new FireMagicWeaponImpl();
        FireMagicWeapon fireMagicWeapon = new FireMagicWeapon(fireMagicWeaponImpl);
        fireMagicWeapon.GetImp();
        fireMagicWeapon.Attack();
        fireMagicWeapon.Sell();
        fireMagicWeapon.Buy();
        fireMagicWeapon.Burn();

        Console.WriteLine();

        AstrtusWang astrtusWang = new AstrtusWang();
        astrtusWang.BuyImp();
        astrtusWang.SellImp();
        astrtusWang.FreezeImp();
        astrtusWang.AttackImp();

        Console.WriteLine();

        ElectricShock electricShock = new ElectricShock();
        electricShock.BuyImp();
        electricShock.SellImp();
        electricShock.ShockImp();
        electricShock.AttackImp();

        Console.WriteLine();

        FireBurn fireBurn = new FireBurn();
        fireBurn.BuyImp();
        fireBurn.SellImp();
        fireBurn.BurnImp();
        fireBurn.AttackImp();
    }
}
