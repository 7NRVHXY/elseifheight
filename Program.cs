namespace elseifheight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 170;    
            bool isMale = false; 
            if (height>180 ) 
            {
                Console.WriteLine("arxa sira");
            }
            else if (height>170 && height < 180)
            {
                Console.WriteLine("orta sira");
            }
            else //en sonda bize zaten 170den kicikler lazimdi ona gore sert yazmaga ehtiyac yoxdu
            {
                Console.WriteLine("on sira "); 
            }
            if (isMale)
            {
                Console.WriteLine("sag teref");
            }
            else
            {
                Console.WriteLine("sol teref");
            }
        }
    }
}