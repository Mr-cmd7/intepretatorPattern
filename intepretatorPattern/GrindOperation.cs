namespace intepretatorPattern;

class GrindOperation : IOperation
{
    public void Execute(List<Ingredient> ingredients)
    {
        Console.WriteLine("Измельчение...");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"Фарш {ingredient.Name}");
        }
    }
}