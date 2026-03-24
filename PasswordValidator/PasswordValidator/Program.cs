/*
• Passwords must be at least 6 letters long and no more than 13 letters long.
• Passwords must contain at least one uppercase letter, one lowercase letter, and one number.
OBJECT-ORIENTED DESIGN 193
• Passwords cannot contain a capital T or an ampersand (&) because Ingelmar in IT has decreed it.
That last rule seems random, and you wonder if the pedestal is just tormenting you with obscure rules.
You ponder for a moment about how to decide if a character is uppercase, lowercase, or a number, but
while scratching your head, you notice a piece of folded parchment on the ground near your feet. You
pick it up, unfold it, and read it:
foreach with a string lets you get its characters!
> foreach (char letter in word) { ... }
char has static methods to categorize letters!
> char.IsUpper('A'), char.IsLower('a'), char.IsDigit('0')
That might be useful information! You are grateful to whoever left it behind. It is signed simply “A.”
Objectives:
• Define a new PasswordValidator class that can be given a password and determine if the
password follows the rules above.
• Make your main method loop forever, asking for a password and reporting whether the password is
allowed using an instance of the PasswordValidator class.
*/
string? pass = " ";
PasswordValidator validator = new PasswordValidator();
Console.WriteLine("This is a password validator program.");
Console.WriteLine("• Passwords must be at least 6 letters long and no more than 13 letters long.");
Console.WriteLine("• Passwords must contain at least one uppercase letter, one lowercase letter, and one number.");
Console.WriteLine("• Passwords cannot contain a capital T or an ampersand (&) because Ingelmar in IT has decreed it.");

while (true){

    Console.WriteLine("What is your password?");
    pass = Console.ReadLine();

   
    Console.WriteLine($"YOUR PASSWORD IS ALLOWED: {validator.Validate(pass)}");

}

class PasswordValidator
{
    public bool Validate(string pass)
    {
        return LengthCheck(pass) && UpperCheck(pass) && LowerCheck(pass) && NumberCheck(pass) && TAmpCheck(pass); 
    }

    public bool LengthCheck(string pass)
    {
        return (pass.Length > 5) && (pass.Length < 14);
    }

    //one upper
    public bool UpperCheck(string pass)
    {
        int up = 0;
        foreach (char c in pass)
        {
          if (char.IsUpper(c))
            {
               up ++; 
            }
                
        } if (up > 0) {
            return true;
        }
        else return false;
    }
    //one lower
    public bool LowerCheck(string pass)
    {
        int low = 0;
        foreach (char c in pass)
        {
            if (char.IsLower(c))
            {
                low++;
            }

        }
        if (low > 0)
        {
            return true;
        }
        else return false;
    }
    //one number
    public bool NumberCheck(string pass)
    {
        int num = 0;
        foreach (char c in pass)
        {
            if (char.IsDigit(c))
            {
                num++;
            }

        }
        if (num > 0)
        {
            return true;
        }
        else return false;
    }
    public bool TAmpCheck(string pass)
    {
        int TAmp = 0;
        foreach (char c in pass)
        {
            if ((c == Convert.ToChar("T")) || (c== Convert.ToChar("&")))
            {
                TAmp++;
            }

        }
        if (TAmp > 0)
        {
            return false;
        }
        else return true;
    }

    //todo

}