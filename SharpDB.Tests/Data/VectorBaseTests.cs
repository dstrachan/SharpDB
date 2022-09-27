using System.Numerics;
using SharpDB.Data;

namespace SharpDB.Tests.Data;

public class VectorBaseTests
{
    [Test]
    public void IntIndexGetsSingleElement()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        Assert.That(intVector[0], Is.EqualTo(intVector.Value[0]));
    }

    [Test]
    public void IntIndexSetsSingleElement()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        intVector[0] = 10;

        Assert.That(intVector[0], Is.EqualTo(10));
    }

    [Test]
    public void IndexIndexerGetsSingleElement()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        Assert.That(intVector[new Index(0)], Is.EqualTo(intVector.Value[0]));
    }

    [Test]
    public void IndexIndexerSetsSingleElement()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        intVector[new Index(0)] = 10;

        Assert.That(intVector[0], Is.EqualTo(10));
    }

    [Test]
    public void RangeIndexerGetsNewInstance()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        var result = intVector[..];

        Assert.That(result, Is.Not.EqualTo(intVector));
        Assert.That(result.Value, Is.EqualTo(intVector.Value));
    }

    [Test]
    public void IntArrayIndexerGetsNewInstance()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        var result = intVector[0, 2, 4, 6, 8];

        Assert.That(result, Is.Not.EqualTo(intVector));
        Assert.That(result.Value, Is.Not.EqualTo(intVector.Value));
        Assert.That(result.Value.Length, Is.EqualTo(5));
    }

    [Test]
    public void IntArrayIndexerSetsMultipleElements()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        intVector[0, 2, 4, 6, 8] = new IntVector(new[] { 10 });

        Assert.That(intVector.Value, Is.EqualTo(new[] { 10, 1, 10, 3, 10, 5, 10, 7, 10, 9 }));
        Assert.That(intVector.Value.Length, Is.EqualTo(10));

        intVector[0, 1] = new IntVector(new[] { 10, 12 });

        Assert.That(intVector.Value, Is.EqualTo(new[] { 10, 12, 10, 3, 10, 5, 10, 7, 10, 9 }));
        Assert.That(intVector.Value.Length, Is.EqualTo(10));
    }

    [Test]
    public void IntArrayIndexerSetThrowsExceptionOnInvalidLengths()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        Assert.That(() => intVector[0, 2, 4, 6, 8] = new IntVector(new[] { 10, 12 }), Throws.Exception);
        Assert.That(() => intVector[0, 10] = new IntVector(new[] { 10, 12 }), Throws.Exception);
    }

    [Test]
    public void CastReturnsTBase()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        Assert.That((int[])intVector, Is.TypeOf<int[]>());
        Assert.That((int[])intVector, Is.EqualTo(intVector.Value));
    }

    [Test]
    public void AttributeIsVectorAttribute()
    {
        var intVector = new IntVector(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        Assert.That(intVector.Attribute, Is.TypeOf<VectorAttribute>());
    }
}
