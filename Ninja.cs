public class Ninja
{
    private int calorieIntake;
   
    public List<Food> FoodHistory { get; private set; }

    //  constructor

public Ninja(){
    calorieIntake =0;
    FoodHistory = new List<Food>();   
}
    // add a public "getter" property called "IsFull"
public bool IsFull{
    get { return calorieIntake > 1200; }
}

    // build out the Eat method
    public void Eat(Food item)
    {
        if (!IsFull)
        {
            calorieIntake+= item.Calories;
            FoodHistory.Add(item);
            string savor = "";
            if (item.IsSpicy)
            {
                savor = "spicy";
            }
            else
            {
                savor = "sweet";
            }
            Console.WriteLine($"{item.Name} {savor}");
        }
        else
        {
            Console.WriteLine("Ninja full of food :/");
        }
    }
}

