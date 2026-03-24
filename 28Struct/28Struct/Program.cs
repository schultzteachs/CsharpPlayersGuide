
Coordinate One = new Coordinate(6,7);


Coordinate Two = new Coordinate(9,7);


One.IsAdjacent(One, Two);


struct Coordinate(int row, int col)
{
   public int row;
   public int col;

    public void IsAdjacent(Coordinate a, Coordinate b)
    {
        if (a.row == b.row || a.col == b.col)
        {
            Console.WriteLine("Adjacent!");
        }
        else { Console.WriteLine("NOT ADJACENT"); }
    }
 
}