using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignService.Structural.DecoratorPattern;


/*
 * ToppingDecorator -> IS-A  -> BasePizza
 * ToppingDecorator -> HAS-A  -> BasePizza
 * 
 */

public abstract class ToppingDecorator : BasePizza
{
    protected BasePizza basePizza;

    protected ToppingDecorator(BasePizza basePizza)
    {
        this.basePizza = basePizza;
    }
}

public class ExtraCheeseDecorator : ToppingDecorator
{

    public ExtraCheeseDecorator(BasePizza basePizza) : base(basePizza)
    {
        this.basePizza = basePizza;
    }

    public override int Cost()
    {
        return basePizza.Cost() + 10;
    }

}

public class MushroomDecorator : ToppingDecorator
{
    

    public MushroomDecorator(BasePizza basePizza) : base(basePizza)
    {
        this.basePizza = basePizza;
    }

    public override int Cost()
    {
        return basePizza.Cost() + 20;
    }

}




