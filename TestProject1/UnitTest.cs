using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackpackProblem;

namespace TestProject
{
    [TestClass]
    public class BackpackProblemTests
    {
        [TestMethod]
        public void TestIfAtLeastOneItemFits()
        {
            // Arrange
            int capacity = 10; // Pojemnoœæ plecaka
            int n = 5; // Liczba przedmiotów
            int seed = 42; // Ziarno do generowania liczb losowych
            BackpackProblem.BackpackProblem problem = new BackpackProblem.BackpackProblem(n, seed);

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.IsTrue(result.SelectedItems.Count > 0); // Sprawdzenie, czy zwrócono co najmniej jeden element
        }

        [TestMethod]
        public void TestIfNoItemFits()
        {
            // Arrange
            int capacity = 1; // Pojemnoœæ plecaka
            int n = 5; // Liczba przedmiotów
            int seed = 42; // Ziarno do generowania liczb losowych
            BackpackProblem.BackpackProblem problem = new BackpackProblem.BackpackProblem(n, seed);

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(0, result.SelectedItems.Count); // Sprawdzenie, czy zwrócono puste rozwi¹zanie
        }
        [TestMethod]
        public void TestIfOrderOfItemsAffectsSolution()
        {
            // Arrange
            int capacity = 10; // Pojemnoœæ plecaka
            int n = 5; // Liczba przedmiotów
            int seed = 42; // Ziarno do generowania liczb losowych
            BackpackProblem.BackpackProblem problem1 = new BackpackProblem.BackpackProblem(n, seed);
            BackpackProblem.BackpackProblem problem2 = new BackpackProblem.BackpackProblem(n, seed);
            problem2.ReverseItemsOrder(); // Odwrócenie kolejnoœci przedmiotów

            // Act
            Result result1 = problem1.Solve(capacity); // Pierwsze rozwi¹zanie
            Result result2 = problem2.Solve(capacity); // Drugie rozwi¹zanie po odwróceniu kolejnoœci

            // Assert
            Assert.AreEqual(result1.TotalValue, result2.TotalValue); // Sprawdzenie, czy ³¹czna wartoœæ pozosta³a taka sama
            Assert.AreEqual(result1.TotalWeight, result2.TotalWeight); // Sprawdzenie, czy ³¹czna waga pozosta³a taka sama
            CollectionAssert.AreEqual(result1.SelectedItems, result2.SelectedItems); // Sprawdzenie, czy lista wybranych przedmiotów jest taka sama
        }
        [TestMethod]
        public void TestSpecificInstanceSolution()
        {
            // Arrange
            int capacity = 20;// Pojemnoœæ plecaka
            int n = 4; // Liczba przedmiotów
            List<Item> items = new List<Item>
            {
                new Item(1, 5, 10), // Przedmiot 1: Wartoœæ = 6, Waga = 8 0,5
                new Item(2, 3, 3), // Przedmiot 2: Wartoœæ = 2, Waga = 3 1
                new Item(3, 1, 7), // Przedmiot 3: Wartoœæ = 8, Waga = 11 0,14285
                new Item(4, 6, 1), // Przedmiot 3: Wartoœæ = 8, Waga = 11 6
            };

            //Item przedmiot = items[1];
            //przedmiot.Value = 4;
            //items[1] = przedmiot;

            int seed = 55; // Ziarno do generowania liczb losowych
            BackpackProblem.BackpackProblem problem = new BackpackProblem.BackpackProblem(n, seed);

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(14, result.TotalValue); // Oczekiwana ³¹czna wartoœæ
            Assert.AreEqual(14, result.TotalWeight); // Oczekiwana ³¹czna waga
            CollectionAssert.AreEqual(new List<int> { 4, 2, 1 }, result.SelectedItems); // Oczekiwana lista wybranych przedmiotów
        }
        [TestMethod]
        public void TestIfCorrectNumberOfItemsGenerated()
        {
            // Arrange
            int numberOfItems = 10; // Oczekiwana liczba przedmiotów
            int seed = 42; // Ziarno do generowania liczb losowych

            // Act
            BackpackProblem.BackpackProblem problem = new BackpackProblem.BackpackProblem(numberOfItems, seed);

            // Assert
            Assert.AreEqual(numberOfItems, problem.GetNumberOfItems()); // Sprawdzenie, czy lista zawiera dok³adnie n elementów
        }
        [TestMethod]
        public void TestZeroCapacityBackpack()
        {
            // Arrange
            int capacity = 0; // Pojemnoœæ plecaka
            int numberOfItems = 5; // Liczba przedmiotów
            int seed = 42; // Ziarno do generowania liczb losowych
            BackpackProblem.BackpackProblem problem = new BackpackProblem.BackpackProblem(numberOfItems, seed);

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(0, result.SelectedItems.Count); // Sprawdzenie, czy zwrócono puste rozwi¹zanie
        }

        [TestMethod]
        public void TestEmptyItemList()
        {
            // Arrange
            int capacity = 10; // Pojemnoœæ plecaka
            int numberOfItems = 0; // Liczba przedmiotów
            int seed = 42; // Ziarno do generowania liczb losowych
            BackpackProblem.BackpackProblem problem = new BackpackProblem.BackpackProblem(numberOfItems, seed);

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(0, result.SelectedItems.Count); // Sprawdzenie, czy zwrócono puste rozwi¹zanie
        }

        [TestMethod]
        public void TestEmptyBackpack()
        {
            // Arrange
            int capacity = 10; // Pojemnoœæ plecaka
            int seed = 42; // Ziarno do generowania liczb losowych
            BackpackProblem.BackpackProblem problem = new BackpackProblem.BackpackProblem(0, seed);

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(0, result.SelectedItems.Count); // Oczekiwane puste rozwi¹zanie
            Assert.AreEqual(0, result.TotalValue); // Oczekiwana ³¹czna wartoœæ równa zero
            Assert.AreEqual(0, result.TotalWeight); // Oczekiwana ³¹czna waga równa zero
        }
        [TestMethod]
        public void TestForLargeNumberOfItems()
        {
            // Arrange
            int capacity = 100; // Pojemnoœæ plecaka
            int numberOfItems = 100; // Liczba przedmiotów
            int seed = 42; // Ziarno do generowania liczb losowych
            BackpackProblem.BackpackProblem problem = new BackpackProblem.BackpackProblem(numberOfItems, seed);

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.IsTrue(result.TotalWeight <= capacity); // Sprawdzenie, czy ³¹czna waga nie przekracza pojemnoœci plecaka
        }



    }
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void TestItemValuePerWeight()
        {
            // Arrange
            int id = 1;
            int value = 6;
            int weight = 8;
            double expectedValuePerWeight = 0.75;

            // Act
            Item item = new Item(id, value, weight);

            // Assert
            Assert.AreEqual(expectedValuePerWeight, item.ValuePerWeight);
        }
        [TestMethod]
        public void TestItemId()
        {
            // Arrange
            int id = 1;
            int value = 5;
            int weight = 3;

            // Act
            Item item = new Item(id, value, weight);

            // Assert
            Assert.AreEqual(id, item.Id); //Sprawdzenie, czy identyfikator przedmiotu zosta³ poprawnie ustawiony
        }
    }
    [TestClass]
    public class ResultTests
    {
        [TestMethod]
        public void TestResultToString()
        {
            // Arrange
            List<int> selectedItems = new List<int> { 1, 2, 3 };
            int totalValue = 15;
            int totalWeight = 10;
            Result result = new Result(selectedItems, totalValue, totalWeight);

            // Act
            string resultString = result.ToString();

            // Assert
            string expectedString = "Selected Items: 1, 2, 3, Total Value: 15, Total Weight: 10";
            Assert.AreEqual(expectedString, resultString);
        }
    }
}
