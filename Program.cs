//C# Program Creates Geomentry Shapes using Stars

using System;

class Shapes_Creation
{
    public static void Main()
    {
        ////Global Varibales
        int space = 0;
    START:

        //User to choose Which Shape need to be calculated
        Console.Write("Enter Shape to be Calculated: \n");
        Console.Write("S-SQUARE\n" +
            "R-RECTANGLE\n" +
            "T-TRIANGLE\n" +
            "P-POLYGON\n" +
            "C-CIRCLE: ");
        //Saving user input  in a Character variable
        char shape = Convert.ToChar(Console.ReadLine().ToUpper());

        Console.Clear();

        switch (shape)
        {
            case 'S':
                //Getting Area and Perimeter as Input from user
                Console.WriteLine("**********Welcome to Square Calculation**********");
                Console.Write("Enter P-PERIMETER\n" +
                    "A-AREA\n" +
                    "B-Both Calculation: ");
                char squareInput = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.Clear();

                //Getting Side Length of Square
                //Getting Input From User
                Console.Write("Enter Side Length of Square: ");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                //Switching For Specific Calculation
                switch (squareInput)
                {
                    case 'P':
                        //Displaying Value to User
                        Console.WriteLine("Side Length of a Square: " + l);
                        Console.WriteLine("Perimeter of a Square: " + (4 * l) + " mm");
                        Console.WriteLine("---------Shape Formation According to Lenght Value----------");

                        //Looping to Display Perimeter of a Shape
                        //Loop to Display Horizontal Stars
                        for (int r = 0; r < l; r++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                        //Loop for Empty Space for Shape
                        space = l - 2;
                        for (int i = 0; i < l - 2; i++)
                        {
                            Console.Write("* ");
                            for (int j = 0; j < space * 2; j++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("*");
                            Console.WriteLine();
                        }
                        //Loop to Display Horzontal Stars
                        for (int r = 0; r < l; r++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                        break;

                    case 'A':

                        //Displaying Value to User
                        Console.WriteLine("Side Length of a Square: " + l);
                        Console.WriteLine("Area of a Square: " + (l * l) + " mm");

                        Console.WriteLine("---------Shape Formation According to Length Value----------");

                        //Loop for displaying Stars in Square Shape
                        for (int i = 0; i < l; i++)
                        {
                            for (int j = 0; j < l; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;


                    case 'B':
                        //Displaying Value to User
                        Console.WriteLine("Side Length of a Square: " + l);
                        Console.WriteLine("Perimeter of a Square: " + (4 * l) + " mm");
                        Console.WriteLine("---------Shape Formation According to Lenght Value----------");

                        //Looping to Display Perimeter of a Shape
                        //Loop to Display Horizontal Stars
                        for (int r = 0; r < l; r++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                        //Loop for Empty Space for Shape
                        space = (int)(l - 2);
                        for (int i = 0; i < l - 2; i++)
                        {
                            Console.Write("* ");
                            for (int j = 0; j < space * 2; j++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("*");
                            Console.WriteLine();
                        }
                        //Loop to Display Horzontal Stars
                        for (int r = 0; r < l; r++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();

                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Side Length of a Square: " + l);
                        Console.WriteLine("Area of a Square: " + (l * l) + " mm");

                        Console.WriteLine("---------Shape Formation According to Length Value----------");

                        //Loop for displaying Stars in Square Shape
                        for (int i = 0; i < l; i++)
                        {
                            for (int j = 0; j < l; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;


                    default:
                        Console.WriteLine("Enter Valid Calculation!!");
                        Console.Clear();
                        break;
                }

                break;

            default:
                Console.WriteLine("Enter Valid Shape!!");
                Console.Clear();
                break;
                goto START;
        }



        Console.ReadKey();
    }
}