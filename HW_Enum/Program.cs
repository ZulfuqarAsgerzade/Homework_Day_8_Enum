using HW_Enum.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Transactions;

public class Program
{
    public static void Main()
    {
        
        Console.WriteLine(EnumExtension.GetDisplayName(DbConnections.SQL));

        Console.WriteLine(EnumExtension.GetDisplayName(Colors.Green));

    }
}