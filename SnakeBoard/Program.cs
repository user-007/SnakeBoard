using System;

namespace SnakeBoard
{ /*
   
   * * * * * 
   * * * * * 
   * * * * * 
   * * * * * 
   * * * * * 
   */
    class Program
    {
        static void Main(string[] args)
        {
  
            Console.WriteLine("Please enter the dimensions of the grid:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Cell cell = new Cell(x, y);
            //testing the constructor
            //Console.WriteLine(cell.print_x());
            //Console.WriteLine(cell.print_y());
            Console.WriteLine("Enter the coordinates of the row:");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            Row row = new Row(i,j);
            Console.WriteLine("Enter the dimensions of the grid:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
    

        }
    }
}
