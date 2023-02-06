using System.IO;
using System;
using System.Text;
public class Journal
{
    public List<Entry> Entries = new List<Entry>();
    public void ShowAll()
    {
        Entry journal = new Entry();

        for (int i = 0; i < Entries.Count(); i++)
        {
            Console.WriteLine($"Date: {Entries[i].Date}");
            Console.WriteLine($"Prompt: {Entries[i].Prompt}");
            Console.WriteLine($"Entry: {Entries[i].Text}");
            Console.WriteLine();
        }
    }

    public string newFileName = "";
    public void saveFile()
    {
        string file = $"{newFileName}";

        // The line below will create a text file, my_file.txt, in 
        // the Text_Files folder in D:\ drive.
        // The CreateText method that returns a StreamWriter object
        using (StreamWriter outputFile = new StreamWriter(newFileName))
        {
            for (int i = 0; i < Entries.Count(); i++)
            {
                outputFile.WriteLine($"Date: {Entries[i].Date}");
                outputFile.WriteLine($"Prompt: {Entries[i].Prompt}");
                outputFile.WriteLine($"Entry: {Entries[i].Text}");
                outputFile.WriteLine();
            }
        }
    }

    public string file = "";
    public void loadFile()
    {
        string filename = $"{file}";
        string[] journalText = System.IO.File.ReadAllLines(filename);
        System.Console.WriteLine($"Contents of {filename} is: ");
        foreach (string line in journalText)
        {
            // Use a tab to indent each line of the file.
            Console.WriteLine("\t" + line);
        }

    }

}



// public class Journal
// {
//     public List<Entry> Entries = new List<Entry>();

//     public void ShowAll()
//     {
//         for (int i = 0; i < Entries.Count(); i++)
//         {
//             Console.WriteLine($"Date: {Entries[i].Date}");
//             Console.WriteLine($"Date: {Entries[i].Prompt}");
//             Console.WriteLine($"Date: {Entries[i].Text}");
//             Console.WriteLine();
//         }
//     }


// }
