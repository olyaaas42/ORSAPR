using NUnit.Framework;
using SpinnerPlugin.Model;

namespace SpinnerPlugin.UnitTests
{
    [TestFixture]
    public class SpinnerParameterTest
    {
        private const double MIN_VALUE = 10;
        private const double MAX_VALUE = 30;

        [Test(Description = "Positive getter test.")]
        public void TestValueGet_CorrectValue()
        {
            //Arrange
            const double expected = 20;

            var spinnerParameter = new SpinnerParameter(20, MIN_VALUE, MAX_VALUE);
            var actual = spinnerParameter.Value;

            //Assert & Act
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test(Description = "Negative getter test. Value less then minValue")]
        public void TestMinValueSet_IncorrectValue()
        {
            const double value = 5;

            //Assert.Throws - метод. Вместо сравнения значений он пытается вызвать фрагмент кода, представленный в виде делегата,
            //чтобы убедиться, что он генерирует определенное исключение.
            var actual = Assert.Throws<System.ArgumentOutOfRangeException>(() => new SpinnerParameter(value, MIN_VALUE, MAX_VALUE));
            var expected = $"Value must be between {MIN_VALUE} and {MAX_VALUE}";

            //Is.EqualTo - Возвращает ограничение, которое проверяет два элемента на равенство.
            Assert.That(actual?.ParamName, Is.EqualTo(expected));
        }


        [Test(Description = "Negative getter test. Value bigger then maxValue")]
        public void TestValueMaxSet_IncorrectValue()
        {
            const double value = 40;

            var actual = Assert.Throws<System.ArgumentOutOfRangeException>(() => new SpinnerParameter(value, MIN_VALUE, MAX_VALUE));
            var expected = $"Value must be between {MIN_VALUE} and {MAX_VALUE}";

            Assert.That(actual?.GetType(), Is.EqualTo(typeof(System.ArgumentOutOfRangeException)));
        }
    }
}