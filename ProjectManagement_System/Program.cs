using System;

namespace ProjectManagement_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Initilise.Init();

            while (true)
            {
                CLI.Login();
            }
        }
    }
}
