// creating Arrays with to dimension + Exercise

using System.Runtime.CompilerServices;

public class TwoDimentionalArrays(){


    public static void Main(string[] args)
    {
        Exersice();

    }

    public static void MyTdArray(){

       int[,] MyArray2D = new int [3,3]; 

        //
        //
        //

        int[,,] MyArray3D = new int [3,3,3]; 


        int[,] MyArray2DInizilized = {{1,2}, {3,4}};
        
        //[1] [2] row 0
        //[3] [4] row 1

         //System.Console.WriteLine(MyArray2DInizilized[0,0]);
         
         //System.Console.WriteLine(MyArray2DInizilized[1,0]);

        MyArray2DInizilized[0,0] = 5;

        //System.Console.WriteLine(MyArray2DInizilized[0,0]);


        string[,] TictacToeField = 
        {
            {"O","X","X"},
            {"O","0","X"},
            {"X ","X","0"},
           

        };  string[,] UnderstandingIndex = 
        {
            {"0,0","0,1","0,2"},
            {"1,0","1,1","1,2"},
            {"2,0","2,1","2,2"}, 
        };

       // System.Console.WriteLine(UnderstandingIndex[1,2]);
    }

    public static void Exersice(){

        int[,] MyHw = 
        {

            {1,2,3},
            {4,5,6},
            {7,8,9},
            
        };

        int v1 = MyHw[0,0] + MyHw[0,1] + MyHw[0,2];
        int v2 = MyHw[1,0] + MyHw[1,1] + MyHw[1,2];
        int v3 = MyHw[2,0] + MyHw[2,1] + MyHw[2,2];

       
        System.Console.WriteLine($"{v1}\n{v2}\n{v3}"   );

    }   
}
