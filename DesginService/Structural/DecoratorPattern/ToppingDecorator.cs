using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignService.Structural.DecoratorPattern;


/*
 * ToppingDecorator -> IS-A  -> Basepizza
 * ToppingDecorator -> HAS-A  -> BasePizza
 * 
 */

public abstract class ToppingDecorator : BasePizza
{
}

public class ExtraCheeseDecorator : ToppingDecorator
{
    BasePizza basePizza;

    public ExtraCheeseDecorator(BasePizza basePizza)
    {
        this.basePizza = basePizza;
    }

    public override int Cost()
    {
        return this.basePizza.Cost() + 10;
    }

}

public class MushroomDecorator : ToppingDecorator
{
    BasePizza basePizza;

    public MushroomDecorator(BasePizza basePizza)
    {
        this.basePizza = basePizza;
    }

    public override int Cost()
    {
        return this.basePizza.Cost() + 20;
    }

}




