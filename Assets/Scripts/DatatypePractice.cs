using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine; //Allows us to manipulate Unity functions

public class DatatypePractice : MonoBehaviour //Class Declaration
{
    //WHOLE NUMBERS
    public int num1; //int is 4 bytes - Stores whole numbers from -2,147,483,648 to 2,147,483,648
    public int num2; // public or private, then datatype, then name of variable

    public long num3; //long is 8 bytes - Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,036,854,775,808

    public uint num4; //uint is _STILL_ 4 bytes, allows up to ~4.29 billion (POSITIVE ONLY)
    public ulong num5; //ulong is _STILL_ 8 bytes, allows up to ~18.4 quintillion (POSITIVE ONLY)

    //DECIMALS
    public float num6 = 3.1415f; //float is 4 bytes - Stores decimal numbers up to 6-7 digits
    public double num7 = 3.14159265; // double is 8 bytes - Stores decimal numbers up to 15-16 digits - used more higher precision


    //TRUE OR FALSE
    public bool isProgrammingHard = true; //bool is 1 bit - Only stores True/False (or technically, 0/1)

    

    //DATA SIZES
    //1 Byte = 8 bits
    //1024 Bytes = 1 Kilobyte
    //1024 Kilobytes = 1 Megabyte
    //1024 Megabytes = 1 Gigabyte
    //1024 Gigabytes = 1 Terabyte

    //300Mbps - This is not 300MBps - this is 300 Megabits per second
    //1 gigabit internet = download speed of 125 MegaBYTES per second max

    //TEXT VARIABLES
    public char charizard = 'a';
    public char blastoise = 'b';
    public char venusaur = 'c';

    public string monsters = "Pokemon are cool, but so is Undertale, " +
        "so I wanted to refer to it here anyway, but now this " +
        "is getting long, " +
        "but I'll show that it's okay to do this by showing something else shortly.";

    //THESE ARE DATATYPES? NEXT TIME ON SCRIPTING FOR GAME
    public Light theLightThatShinesFromTheSky;
    public Transform theThingThatLetsUsMoveAround;


    // Start is called before the first frame update
    void Start() //Everything in a function happens line by line in order!
    {
        Debug.Log("The starting number for num1 is: " + num1); // Debug.Log() will display a log in the console for a string or variable/s put inside
        num1 = num1 + 1; //simple addition!
        Debug.Log("The end number for num1 after adding 1 is: " + num1);

        DisplayCharizard(); // A FUNCTION BUT DON'T WORRY ABOUT IT YET

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayCharizard() //This is a function that can be called in other
                            //areas that will run the code in here at the place it
                            //was called.
    {
        Debug.Log(charizard);
    }
}
