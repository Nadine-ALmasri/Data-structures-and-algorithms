namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
       List I =new List();
            I.AddLastList(5);
            I.AddFirstList(6);
           I.Display();
     
           var x = I.includes(6);
            Console.WriteLine(x);
          string y= I.ToString();
            Console.WriteLine(y);
        }
    }
}