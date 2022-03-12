
public static class RecyclingFacts
{
    static string[] facts = {"British households create over 26m tonnes of waste each year, the weight of around 260 large cruise ships",
     "The average person in the UK throws away around 400kg of waste each year; 7 times their body weight", "In the UK, we are only recycling 3% more waste than we did in 2010"};

    public static string RecyclingFact
    {
        get 
        {
            int i = UnityEngine.Random.Range(0, facts.Length -1);
            return facts[i];
        }
    }
}
