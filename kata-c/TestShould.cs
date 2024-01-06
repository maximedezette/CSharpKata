using NFluent;
using NUnit.Framework;

namespace kata_c;

[TestFixture]
public class TestShould
{
    [Test]
    public void Indicate_that_true_is_not_false()
    {
        Check.That(true).IsFalse();
    }
}