using System.Data;

public class CalculateAverageExercise
    {

        public static void Main(string[] args)
        {
            CalculateAverageExercise c_a = new CalculateAverageExercise();
            double[] temperatures = { 10.5, 15.2, 20.1, 18.7 };
             c_a.PrintAverage(temperatures);

            
        }
        public void PrintAverage(double[] temperatures)
        {
            
            double avarageTemp = CalculateAverage(temperatures);
            Console.WriteLine($"The average temperature is: {avarageTemp}"); // Print average with 2 decimal places
            
        }

        public double CalculateAverage(double[] temperatures)
        {

            double sum = 0;

        for (double i = 0; i < temperatures.Length; i++)
        {
            sum += temperatures[(int)i];
        }

        double average = sum / temperatures.Length;
        return average;
        }
        
        
     
}