using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestProject1"), InternalsVisibleTo("Backpack_Problem_lab1_GUI")]

namespace BackpackProblem
{
    internal class BackpackProblem
    {
        private int numberOfItems;
        private List<Item> items;
        public List<Item> Items => items;

        public BackpackProblem(int n, int seed)
        {
            numberOfItems = n;
            items = new List<Item>();

            Random rand = new Random(seed);
            for (int i = 0; i < numberOfItems; i++)
            {
                int value = rand.Next(1, 11);
                int weight = rand.Next(1, 11);
                items.Add(new Item(i + 1, value, weight));
            }

        }
        public void ReverseItemsOrder()
        {
            items.Reverse();
        }
        public int GetNumberOfItems()
        {
            return items.Count;
        }


        public Result Solve(int capacity)
        {
            items.Sort((x, y) => y.ValuePerWeight.CompareTo(x.ValuePerWeight));

            List<int> selectedItems = new List<int>();
            int totalValue = 0;
            int totalWeight = 0;

            foreach (var item in items)
            {
                if (totalWeight + item.Weight <= capacity)
                {
                    selectedItems.Add(item.Id);
                    totalValue += item.Value;
                    totalWeight += item.Weight;
                }
                else
                {
                    break;
                }
            }

            return new Result(selectedItems, totalValue, totalWeight);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, items.Select(item => $"Item {item.Id}: Value = {item.Value}, Weight = {item.Weight}"));
        }

    }
}

