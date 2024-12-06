namespace intepretatorPattern;

class MixOperation : IOperation
{
    public void Execute(List<Ingredient> ingredients)
    {
        Console.WriteLine("Смешивание...");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Name} смешанна");
        }
    }
}