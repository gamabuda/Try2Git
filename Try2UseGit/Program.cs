string prompt = Console.ReadLine();
Coffee coffee_client = null;
if (prompt != null)
    coffee_client = CoffeeShop.OrderCoffee(prompt);

Americano coffee = coffee_client as Americano;
Console.WriteLine();

public class Coffee
{
    public void grindCoffee()
    {
        // перемалываем кофе
    }
    public void makeCoffee()
    {
        // делаем кофе
    }
    public void pourIntoCup()
    {
        // наливаем в чашку
    }
}
public class Americano : Coffee { }
public class Cappuccino : Coffee { }
public class CaffeLatte : Coffee { }
public class Espresso : Coffee { }

public static class CoffeeShop
{
    public static Coffee OrderCoffee(string type)
    {
        Coffee coffee = null;

        switch (type)
        {
            case "AMERICANO":
                coffee = new Americano();
                break;
            case "ESPRESSO":
                coffee = new Espresso();
                break;
            case "CAPPUCCINO":
                coffee = new Cappuccino();
                break;
            case "CAFFE_LATTE":
                coffee = new CaffeLatte();
                break;
        }


        Console.WriteLine($"Вот ваш кофе {coffee.GetType()}! Спасибо, приходите еще!");
        return coffee;
    }
}