using System;
using DatabaseDAL.Entity;
using DatabaseDAL.Memory;

namespace DatabaseDAL
{
    class Program
    {
        static void Main(string[] args)
        {

            InitMemory.Init();

            var age = new Age();
            age.AgeStart = 1;

            GetEntitiyByField.GetData(new Age().EntityName(),Age.AgeFields.AgeStart.ToString(),1);

            Console.ReadKey();
        }
        

    }
}
