
using System.Runtime.ConstrainedExecution;

class Program
{



    static void Main(string[] args)
    {
        //Folder Create
        // Directory.CreateDirectory("C:\\Users\\acer\\Desktop\\MyTaskFolder1");
        // Directory.CreateDirectory("C:\\Users\\acer\\Desktop\\MyTaskFolder2");



        //Current Folder path
        //Console.WriteLine(Directory.GetCurrentDirectory());

        //Folder Delete
        //Directory.Delete("C:\\Users\\acer\\Desktop\\MyTaskFolder1");

        //File Create
        //using FileStream fileStream = new("C:\\Users\\acer\\Desktop\\MyTaskFolder1\\myTaskFile.txt", FileMode.OpenOrCreate);

        //File Delete

        // File.Delete("C:\\Users\\acer\\Desktop\\MyTaskFolder\\myTaskFile.txt");

        //File Move

        //string destinationPath = Path.Combine("C:\\Users\\acer\\Desktop\\MyTaskFolder2", "myTaskFile.txt");

        //File.Move("C:\\Users\\acer\\Desktop\\MyTaskFolder1\\myTaskFile.txt", destinationPath);

        //File Search for Name

        DirectoryInfo directoryInfo = new("C:\\Users\\acer\\Desktop\\MyTaskFolder2");

        foreach (FileInfo file in directoryInfo.GetFiles())
        {

            if (file.Name == "myTaskFile.txt"){
                Console.WriteLine("hello");
            }

        }


    }
}

