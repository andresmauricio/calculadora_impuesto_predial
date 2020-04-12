using System;

public class Taxes
{
    public int valueProperty;
    public int resultProperty;
    public void getDataUser()
    {
        Console.WriteLine("Escriba el valor de su propiedad:");
        valueProperty = int.Parse(Console.ReadLine());

    }
    public void calculateValue()
    {
        resultProperty = (valueProperty * 2) / 100;
        Console.WriteLine("Para tu propiedad de valor ${0}, el valor de tu impuesto es de ${1}", valueProperty, resultProperty);
    }

}