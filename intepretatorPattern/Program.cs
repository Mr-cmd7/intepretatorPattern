using intepretatorPattern;

var grinder = new MeatGrinder();
        

grinder.AddIngredient(new Beef());
grinder.AddIngredient(new Pork());
grinder.AddIngredient(new Chicken());


grinder.AddOperation(new GrindOperation());
grinder.AddOperation(new MixOperation());
grinder.AddOperation(new AddSpicesOperation(new Spices()));


grinder.StartGrinding();