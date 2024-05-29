using NUnit.Framework;
using NUnit.Framework.Legacy;
using RetirementChecked;

[TestFixture]
public class PensionFundTests
{
    [Test]
    public void TestMaleAgeInRange_1()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 0;
        pensions.Gender = false;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_2()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 32;
        pensions.Gender = false;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_3()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 64;
        pensions.Gender = false;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_4()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 66;
        pensions.Gender = false;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_5()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 60;
        pensions.Gender = false;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_6()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 66.5;
        pensions.Gender = false;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_7()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 70;
        pensions.Gender = false;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_8()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 149;
        pensions.Gender = false;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_9()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 150;
        pensions.Gender = false;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_10()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 151;
        pensions.Gender = false;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_11()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 200;
        pensions.Gender = false;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_12()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 40000;
        pensions.Gender = false;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestMaleAgeInRange_13()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = -1;
        pensions.Gender = false;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_1()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = -1;
        pensions.Gender = true;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_2()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 0;
        pensions.Gender = true;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_3()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 32;
        pensions.Gender = true;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_4()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 59;
        pensions.Gender = true;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_5()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 60;
        pensions.Gender = true;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_6()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 61;
        pensions.Gender = true;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_7()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 66.5;
        pensions.Gender = true;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_8()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 70;
        pensions.Gender = true;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_9()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 149;
        pensions.Gender = true;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_10()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 150;
        pensions.Gender = true;
        string expectedOutcome = "Проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_11()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 151;
        pensions.Gender = true;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_12()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 200;
        pensions.Gender = true;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
    [Test]
    public void TestWomAgeInRange_13()
    {
        CheckPensions pensions = new CheckPensions();
        pensions.Age = 40000;
        pensions.Gender = true;
        string expectedOutcome = "Не проходит";

        string outcome = pensions.PensionFund();

        Assert.That(outcome, Is.EqualTo(expectedOutcome));
    }
}
