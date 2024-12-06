namespace intepretatorPattern;

class MeatGrinder
{
    private List<IOperation> _operations;
    private List<Ingredient> _ingredients;

    public MeatGrinder()
    {
        _operations = new List<IOperation>();
        _ingredients = new List<Ingredient>();
    }
    
    public void AddOperation(IOperation operation)
    {
        _operations.Add(operation);
    }
    
    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }
    
    public void StartGrinding()
    {
        foreach (var operation in _operations)
        {
            operation.Execute(_ingredients);
        }
    }
}
