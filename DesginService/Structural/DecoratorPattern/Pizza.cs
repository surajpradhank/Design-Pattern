namespace DesignService.Structural.DecoratorPattern;

/*
 * 
 * 
 * 
 */

public abstract class BasePizza
{
    public abstract int Cost();
}

public class Farmhouse : BasePizza
{
    public override int Cost()
    {
        return 200;
    }
}

public class VegDelight : BasePizza
{
    public override int Cost()
    {
        return 120;
    }
}

public class Margherita : BasePizza
{
    public override int Cost()
    {
        return 100;
    }
}