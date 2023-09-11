
/*Haz uno o más casos de prueba que comprueben que la función está bien implementada. Incluye casos de prueba para, al menos, los siguientes casos:
Una fecha en formato correcto
Una fecha que no tenga el formato correcto
Una fecha en blanco*/
using NUnit.Framework;
using System;
using Ucu.Poo.TestDateFormat;

namespace Library.Tests;
public class DateFormatterTests
{ 
    [Test]
    public void rightdate()
    {
        string date = "12/12/2020";
        string result = DateFormatter.ChangeFormat(date);
        Assert.AreEqual("2020-12-12", result);

        
    }
    [Test]
    public void wrongdate()
    {
        string date = "12/21/2020";
        string result = DateFormatter.ChangeFormat(date);
        Assert.AreEqual("error", result);
       

        
    }

    [Test]
    public void blankdate()
    {
        string date = "";
        string result = DateFormatter.ChangeFormat(date);
        Assert.AreEqual("error", result);
       
    }
}