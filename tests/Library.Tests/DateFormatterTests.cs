using System;
using TestDateFormat;

namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    // Test para los datos en formato correcto.
    [Test]
    public void Test1()
    {
        const string date = "10/11/1997";
        const string expected = "10/11/1997 se convierte a 1997-11-10";

        Assert.AreEqual(expected, DateFormatter.ChangeFormat(date));
        Assert.Pass("Paso la prueba 1.");
    }

    // Test para los datos en formato incorrecto.
    [Test]
    public void Test2()
    {   
        const string date = "10111997";
        const string expected = "El formato no es valido.";
        Assert.AreEqual(expected, DateFormatter.ChangeFormat(date));
        Assert.Pass("Paso la prueba 2.");
    }


    // Test por si los datos ingresados son vacios.
    [Test]
    public void Test3()
    {
        const string expected = "Se ha ingresado un dato vacio.";
        const string wrongDate = "";
        const string wrongDate2 = null;

        Assert.AreEqual(expected,DateFormatter.ChangeFormat(wrongDate));
        Assert.AreEqual(expected,DateFormatter.ChangeFormat(wrongDate2));
        Assert.Pass("Paso la prueba 3.");
    }
}