namespace intepretatorPattern;

class AddSpicesOperation : IOperation
{
    private readonly Spices _spices;

    public AddSpicesOperation(Spices spices)
    {
        _spices = spices;
    }

    public void Execute(List<Ingredient> ingredients)
    {
        Console.WriteLine("Добавление специй...");
        ingredients.Add(_spices);
        Console.WriteLine($"{_spices.Name} добавлены");
    }
}