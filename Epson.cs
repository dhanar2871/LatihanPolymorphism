 using System;

public class Epson : PrinterJenis
{
    public override void Show()
    {
      Console.WriteLine("Epson display dimension : 10*11");  
    }
    public override void Print()
    {
        Console.WriteLine("Epson Printer is Printing ...");
    }

}