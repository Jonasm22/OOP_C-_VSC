
public class DictionayAnd_List
{
    static void Main(string[] args)
    {

        Dictionarios();
    }


    static void CheckAny()
    {
        List<int> numbers = [1, 2, 3, 5, 6, 7];

        bool hasNummerGreaterThanFive = numbers.Any(x => x > 5);

        System.Console.WriteLine(hasNummerGreaterThanFive);
    }

    public static void Dictionarios()
    {

        Dictionary<string, int> numbers = new Dictionary<string, int>();

        numbers.Add("Uno", 1);
        numbers.Add("Dos", 2);
        numbers.Add("tres", 3);

        foreach (KeyValuePair<string, int> i in numbers)
        {
            Console.WriteLine(i.Key + i.Value);
            //Console.WriteLine($"Key: {i.Key}, value: {i.Value}");

        }



    }





}

