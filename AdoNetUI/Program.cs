using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABAL;
using ADTO;

namespace AdoNetUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectXEFBAL obj = new ProjectXEFBAL();
            Console.WriteLine("Enter PSNo:");
            int inputPSNo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string inputName1 = Console.ReadLine();
            FacultyDTO facObj1 = new FacultyDTO
            {
                PSNo = inputPSNo1,
                NAME = inputName1
            };

            int returnValue1 = obj.UpdateFaculty(facObj1);

            if (returnValue1 == 1)
            {
                Console.WriteLine("Data Updated Successfully");
                Console.WriteLine("List of Faculties");
                Console.WriteLine("------------------------");
                var output = obj.GetFaculties();
                foreach (var item in output)
                {
                    Console.WriteLine(item.NAME);
                }
            }
            else
            {
                Console.WriteLine("Oopppssiiiee, Something went wrong ! ");
            }


        }
    }
}
