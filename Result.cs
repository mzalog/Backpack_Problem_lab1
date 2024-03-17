using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BackpackProblem
{
    internal class Result
    {
        public List<int> SelectedItems { get; }
        public int TotalValue { get; }
        public int TotalWeight { get; }

        public Result(List<int> selectedItems, int totalValue, int totalWeight)
        {
            SelectedItems = selectedItems;
            TotalValue = totalValue;
            TotalWeight = totalWeight;
        }

        public override string ToString()
        {
            return $"Selected Items: {string.Join(", ", SelectedItems)}, Total Value: {TotalValue}, Total Weight: {TotalWeight}";
        }

        public string SelectedItemsToString(List<Item> items)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Selected Items with value and weight:");
            foreach (int itemId in SelectedItems)
            {
                Item selectedItem = items.FirstOrDefault(item => item.Id == itemId);
                if (selectedItem != null)
                {
                    sb.AppendLine($"Item {selectedItem.Id}: Value = {selectedItem.Value}, Weight = {selectedItem.Weight}");
                }
            }
            return sb.ToString();
        }

    }



}
