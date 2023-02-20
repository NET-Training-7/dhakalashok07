using System;
using System.IO;

class ExceptionHandling
{
    public void CreateNewFile()
    {
        FileStream stream = default;
        try
        {
            var folderPath = @"C:\Users\dhaka\Desktop\git folder\dhakalashok07\Fundamentals\FDHandling";
            var file = "File";
            var fileFullPath = $"{folderPath}\\{file}";

            if (!Directory.Exists(folderPath))
            {
                throw new IOException("'FDHandling1' folder does not exit.");
            }
            
            stream = File.Create(fileFullPath);
            stream.WriteByte(255);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Can't create new file.\nERROR:{ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Can't create new file.\nGeneric Error:{ex.Message}");
        }
        finally
        {
            stream.Close();
        }
    }
 

public void DoClassWork()
{
    try
    // Calculate remaining days for Holi festival
    {
        DateTime holiDate = new DateTime(2023, 3, 7);
        TimeSpan remainingDays = holiDate - DateTime.Today;
        Console.WriteLine($"Only {remainingDays.Days} days left until Holi!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while calculating remaining days for Holi festival: {ex.Message}");
    }

    Console.WriteLine("Happy Holi!");
}
}