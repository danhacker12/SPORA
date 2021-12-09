using System;

namespace spora
{
    class Program
    {
        struct Spora
        {
            
            public bool IsPredator;
            public int Weight;
            public bool Isdied;

        }
        static void Main(string[] args)
        {
            
            Random x = new Random();
            
            Spora[] a = new Spora[10];
            for(int i = 0; a.Length > i; i++)
            {
                a[i] = new Spora();
                a[i].IsPredator = Convert.ToBoolean(x.Next(0, 2));
                a[i].Weight = x.Next(1, 50);
                a[i].Isdied = false;
                //Console.Write(a[i].Weight + " ");

                Console.Write(a[i].IsPredator ? "1 ":"0 " );
                
            }


            Console.WriteLine();

            for (int i = 0; i<a.Length-1; i++)
            {
                if (a[i].Isdied == true) continue;
                if (a[i].IsPredator == true && a[i+1].IsPredator==false)//0 1 0 1 1 0 1
                {
                    a[i + 1].Isdied = true;
                    
                                     
                }
                
                if (a[i].IsPredator == true && a[i+1].IsPredator == true)
                {
                    if (a[i].Weight > a[i + 1].Weight)
                    {
                        a[i + 1].Isdied = true;                       

                    }
                    else
                    {
                        a[i].Isdied = true;                        
                    }                    
                }                
            }
            for(int i=0; i < a.Length; i++)
            {
                Console.Write(a[i].Isdied ? "* ":"@ ");
            }
            //Console.Write()
        }
    }
}





















/* int b = 10;
            int q = 10;
            int[] a = new int[b];
            int[] y = new int[q];
            Console.WriteLine("weight");
            for (int i = 0; i < b; i++)
                
            {
                
                a[i] = x.Next(1, 10);
                c.weight = a[i];
                Console.Write(c.weight+ " ");
                y[i] = 
                c.IsPredator = y[i];
                
                //Console.Write(c.IsPredator+" |");
            }
            Console.WriteLine();
            int predator = 0;
            int BB = 1;
            for (int i = 0; a.Length-1 > i; i++)
            {
                if (a[i] < a[BB])//0<1||1>0
                {

                    //a[i] = 0;
                    Console.Write(a[BB]+" ");
                                        
                }
                BB++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("predator");
            int YY = 1;
            for (int j = 0; y.Length > j; j++)
            {
                if (y[j] ==1)
                {
                    Console.Write(y[YY]+" ");
                }
            }

*/