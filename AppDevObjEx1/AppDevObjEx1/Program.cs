using System;

namespace AppDevObjEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Course objectOne = new Course();
            objectOne.Writer();

            Course objectTwo = new Course(1550);
            objectTwo.Writer();
        }
    }
}
