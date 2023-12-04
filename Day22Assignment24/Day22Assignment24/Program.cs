using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace Day22Assignment24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Binary Serialization


            //Employee obj = new Employee()
            //{
            //    Id = 1,
            //    FName = "onkar",
            //    LName="Jadhav",
            //     Salary=50000
            //};
            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream(@"D:\mphasis\Assignments\Day-21\Day22Assignment24\Day22Assignment24\Example.txt",
            //    FileMode.Create, FileAccess.Write);

            //formatter.Serialize(stream, obj);
            //stream.Close();

            //stream = new FileStream(@"D:\mphasis\Assignments\Day-21\Day22Assignment24\Day22Assignment24\Example.txt",
            //    FileMode.Open, FileAccess.Read);

            //Employee obj2 = (Employee)formatter.Deserialize(stream);

            //Console.WriteLine(obj2.Id);
            //Console.WriteLine(obj2.FName);
            //Console.WriteLine(obj2.LName);
            //Console.WriteLine(obj2.Salary);


            //XML Serialization

            Employee emp = new Employee { Id = 1, FName = "onkar", LName="Jadhav",Salary=50000 };

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("person.xml"))
            {
                serializer.Serialize(writer, emp);
            }

            using (TextReader reader = new StreamReader("person.xml"))
            {
                Employee deserializePerson = (Employee)serializer.Deserialize(reader);
                Console.WriteLine($"ID:{deserializePerson.Id},First Name:{deserializePerson.FName},Last Name:{deserializePerson.LName},Salary:{deserializePerson.Salary}");
            }
            Console.ReadKey();


        }
    }
}
