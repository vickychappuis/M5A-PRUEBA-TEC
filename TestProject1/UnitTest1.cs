using Baldosas;

namespace baldosas.tests;

[TestClass]
public class UnitTest1
{
    private string _nombreMaterial = "ceramica";
    private int _precioMaterial = 10;
    [TestMethod]
    public void Material_ShouldConstruct()
    {
        var material = new Material(_nombreMaterial, _precioMaterial);
        Assert.AreEqual(_nombreMaterial, material.Nombre);
        Assert.AreEqual(_precioMaterial, material.Precio);
    }
}