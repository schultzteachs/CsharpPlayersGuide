



public class CustomArrow
{
    public string arrowhead { get; set; } = " ";
    public string fletching { get; set; } = " ";

    private float _length;
    public float length
    {
        get => _length;
        set
        {
            if (value < 60) _length = 60f;
            else if (value > 100) _length = 100f;
            else _length = value;
        }
    }
    public static CustomArrow CreateEliteArrow()
    {
        return new CustomArrow()
        {
            static sting arrowhead =
        };
    }


}





//Menu for arrows
enum ArrowType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeather, GooseFeather }