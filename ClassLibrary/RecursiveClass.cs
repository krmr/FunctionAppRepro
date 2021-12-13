using System;

namespace ClassLibrary
{
    public class RecursiveClass
    {
        public static void RecursiveCall()
        {
            var dateTime = DateTime.Now;
            RecursiveCall();
        }
    }
}