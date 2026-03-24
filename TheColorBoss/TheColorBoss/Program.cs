/*
 * The color consists of three parts or channels: red, green, and blue, which indicate how much those
channels are lit up. Each channel can be from 0 to 255. 0 means completely off; 255 means completely
on.
The pedestal also includes some color names, with a set of numbers indicating their specific values for
each channel. These are commonly used colors: White (255, 255, 255), Black (0, 0, 0), Red (255, 0, 0),
Orange (255,165, 0), Yellow (255, 255, 0), Green (0, 128, 0), Blue (0, 0, 255), Purple (128, 0, 128).
Objectives:
• Define a new Color class with properties for its red, green, and blue channels.
• Add appropriate constructors that you feel make sense for creating new Color objects.
• Create static properties to define the eight commonly used colors for easy access.
• In your main method, make two Color-typed variables. Use a constructor to create a color instance
and use a static property for the other. Display each of their red, green, and blue channel values
*/




class Color
{
    public int R { get; set; } = 0; 
    public int G { get; set; } = 0; 
    public int B { get; set; } = 0;

    public Array[] getValues()
    {
         return [R,G,B];
    }


   public Color(int r, int g, int b)
    {
        this.R = r;
        this.G = g;
        this.B = b;
    }

    Color(string color)
    {
        switch (color) {
            case "White": this.R = 255; this.G = 255; this.B = 255;
                break;
            case "Black":
                this.R = 0; this.G = 0; this.B = 0;
                break;
            case "Red":
                this.R = 255; this.G = 0; this.B = 0;
                break;
            case "Orange":
                this.R = 255; this.G = 165; this.B = 0;
                break;
            case "Yellow":
                this.R = 255; this.G = 255; this.B = 0;
                break;
            case "Green":
                this.R = 0; this.G = 128; this.B = 0;
                break;
            case "Blue":
                this.R = 0; this.G = 0; this.B = 255;
                break;
            case "Purple":
                this.R = 128; this.G = 0; this.B = 128;
                break;
        }
    }
}