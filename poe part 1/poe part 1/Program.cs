// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace poe;
public class POE
{
    //declaring arrays 
    String[] ingreList;
    double[] ingreQuantity;
    int[] ingreMeasurements;
    string[] units;
    String[] description;

    //declaring my variables 
    string RecipeName;
    int engreNum;
    double n;
    int step;
    int count= 1;
    Boolean m = true;
    public POE()
    {    
        //initialising the  arrays
        String[] ingreList = new String[0];
        double[] ingreQuantity = new double[0];
        int[] ingreMeasurements = new int[0];
        string[] units = new string[0];
        String[] description = new string[0];
    }


    public void EnterRecipe()//methord for entering recipe details 
    {

        Console.WriteLine("Welcome ");
        Console.WriteLine("enter recipe name ");
        RecipeName = Console.ReadLine();// user must input Recipe name


        Console.WriteLine("Enter  the number of ingridients you want to enter ");
        engreNum = int.Parse(Console.ReadLine());// user must enter the number of ingridients that she or he want to input

        //allocating the arrays indexs 
        ingreList = new string[engreNum];
        ingreQuantity = new double[engreNum];
        ingreMeasurements = new int[engreNum];
        units = new string[engreNum];

        int k = 1;
        for (int i = 0; i < engreNum; i++)
        {

            Boolean p = true;

            Console.WriteLine("ingredient "+ k+" name: ");
            ingreList[i] = Console.ReadLine(); // user must input the ingredient 

            while (p)
            {
                try
                {
                    Console.WriteLine("ingredient Quantity");
                    ingreQuantity[i] = int.Parse(Console.ReadLine());//user must input the Quantity
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine( "please input proper Quantity");
                }
            }
            
            Console.WriteLine("units of the ingredients measurements (mg),(g),(kg),(ml),(l),(teaspoon),(cups)");//user must enter Quantity units
            units[i] = Console.ReadLine();
            Boolean n = true;
            while (n)//loop that ensures that the user inputs the right units 
            {
                if (units[i].Equals("mg"))
                {
                    break;
                }
                else if (units[i].Equals("g"))
                {
                    break;
                }
                else if (units[i].Equals("kg"))
                {
                    break;
                }
                else if (units[i].Equals("ml"))
                {
                    break;
                }
                else if (units[i].Equals("l"))
                {
                    break;
                }
                else if (units[i].Equals("teaspoon"))
                {
                    break;
                }
                else if (units[i].Equals("cups"))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("units of the ingredients measurements (mg),(g),(kg),(ml),(l)");
                    units[i] = Console.ReadLine();
                }
                

            }
            k++;





        }

        Console.WriteLine("num of steps ");
        int step = int.Parse(Console.ReadLine());// user must input the number of steps 

        description = new String[step];
        for (int i = 0; i < step; i++)
        {
            Console.WriteLine("please enter  step " + count + " of the recipe");
            description[i] = Console.ReadLine();// user must enter the steps 

            count++;
        }
    }

    public void Display()//methord to desplay the recipe steps and ingridients 
    {
        int k= 1;
        int count1 = 1;
        Console.WriteLine("****************************************** ");
        if (ingreList.Length  > 0)
        {
            Console.WriteLine(" Recipe : " + RecipeName);
        }
        else { Console.WriteLine("There's no recipe saved "); }
      

        for (int i = 0; i < ingreList.Length; i++)
        {
            Console.WriteLine(" ingridients : "+ k );

            Console.WriteLine( ingreList[i] + " " + ingreQuantity[i] + " " + units[i]);
            k++;
        }

        for (int i = 0; i < description.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Steps ");
            Console.WriteLine("step " + count1 + description[i]);
            
            count1++;
        }
        Console.WriteLine("****************************************** ");
    }

    public void ChangeQuantity() //methords that allow the user to change the quantity ....try catch 
    {



        Console.WriteLine("Choose the factor that you would like ingredients to be affected with: \n 1-0.5(half) \n2-2(double) \n3- 3(triple) \n");
         n = int.Parse(Console.ReadLine());
      
        for (int i = 0; i < ingreQuantity.Length; i++)
        {
            if (ingreQuantity[i] == 8 || units[i].Equals("teaspoon") ||n==2)
            {
                ingreQuantity[i] = 1;
                units[i] = "cups";
            }
            else if (n==1)
            {
                ingreQuantity[i] *= 0.5;
                Console.WriteLine(" Quantity changed ");
            }else
            {
                ingreQuantity[i] *= n;
                Console.WriteLine(" Quantity changed ");
            }
            

        }// if 8 spoon is  = 1 cup 

        
    }

    public void Normal()//methord that makes resert the quantity to the origial one........ try
    {
        
        
            for (int i = 0; i < ingreQuantity.Length; i++)
            {

            if (n == 1)
            {
                ingreQuantity[i] /= 0.5;
                Console.WriteLine(" Quantity changed ");
            }
            else
            {
                ingreQuantity[i] /= n;
                Console.WriteLine(" Quantity changed ");
            }

        }
        
        
        
    }

    public void clear() //methord to clear the arrays 
    {
        ingreList = new String[0];
        ingreQuantity = new double[0];
        ingreMeasurements = new int[0];
        units = new string[0];
        description = new string[0];

        Console.WriteLine(" Recipe cart clead");
    }



}


public class poe
{
    public static void Main(String[] args)//main class
    {
        Console.ForegroundColor = ConsoleColor.Green;
        POE pOE = new POE();
     //   int l;
        while (true)
        {
            //menu that makes the user to choose what he or she wants to do 

            Console.WriteLine("************************************************* ");
            Console.WriteLine("1.Enter  Recipe details ");
            Console.WriteLine("2.Display recipe  ");
            Console.WriteLine("3.change Quantity ");
            Console.WriteLine("4.Clear your recipes  ");
            Console.WriteLine("5. set normal Quantity ");
            Console.WriteLine("6.Done  ");

           int l = int.Parse(Console.ReadLine());
            

           

            switch (l)
            {
               // case 0:
                case 1:
                    pOE.EnterRecipe();
                    break;
                case 2:
                    pOE.Display();
                    break;
                case 3:
                    pOE.ChangeQuantity();
                    break;
                case 4:
                    pOE.clear();
                    break;
                case 5:
                    pOE.Normal();
                    break;
                case 6:
                    return;
                default:
                    break;

            }

           
        }
        Console.WriteLine("************************************************* ");
        Console.WriteLine("Good bye ");
    }
}
