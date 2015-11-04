using JsonParser;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class NumberExtractorTester
    {
       private NumberExtractor _numberExtractor;
       [SetUp]
       public void SetUp()
       {
           _numberExtractor = new NumberExtractor();
       }

        [Test]
        public void ShouldReturnNoNumbersWithNoLabelsPresent()
        {
            var menu = new Menu {Header = "header"};
            
            menu.Items.Add(new Item {Id=5, Label = null});
            menu.Items.Add(new Item {Id=5, Label = ""});
            menu.Items.Add(new Item {Id=5, Label = null});
            menu.Items.Add(new Item {Id=50, Label = null});
            menu.Items.Add(new Item {Id=10, Label = null});
            var numbers = _numberExtractor.ExtractNumbersToAdd(menu);
            Assert.AreEqual(numbers.Count, 0);
        }

        [Test]
        public void ShouldReturnOneNumberWithLabelPresent()
        {
            var menu = new Menu { Header = "header" };

            menu.Items.Add(new Item { Id = 5, Label = null });
            menu.Items.Add(new Item { Id = 5, Label = "" });
            menu.Items.Add(new Item { Id = 5, Label = null });
            menu.Items.Add(new Item { Id = 50, Label = "Label 0" });
            menu.Items.Add(new Item { Id = 10, Label = null });
            var numbers = _numberExtractor.ExtractNumbersToAdd(menu);
            Assert.AreEqual(numbers.Count, 1);
        }

        [Test]
        public void ShouldReturnNumberWithLabelPresentIfNumberIsZero()
        {
            var menu = new Menu { Header = "header" };

            menu.Items.Add(new Item { Id = 5, Label = null });
            menu.Items.Add(new Item { Id = 5, Label = "" });
            menu.Items.Add(new Item { Id = 5, Label = null });
            menu.Items.Add(new Item { Id = 0, Label = "Label 0" });
            menu.Items.Add(new Item { Id = 10, Label = null });
            var numbers = _numberExtractor.ExtractNumbersToAdd(menu);
            Assert.AreEqual(numbers.Count, 0);
        }

        [Test]
        public void ShouldReturnAllNumbersWithLabelPresentButNotZero()
        {
            var menu = new Menu { Header = "header" };

            menu.Items.Add(new Item { Id = 5, Label = "Label 1" });
            menu.Items.Add(new Item { Id = 5, Label = "Label 2" });
            menu.Items.Add(new Item { Id = 5, Label = "Label 3" });
            menu.Items.Add(new Item { Id = 0, Label = "Label 0" });
            menu.Items.Add(new Item { Id = 10, Label = null });
            var numbers = _numberExtractor.ExtractNumbersToAdd(menu);
            Assert.AreEqual(numbers.Count, 3);
        }
    }
}
