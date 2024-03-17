using BackpackProblem;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BackpackProblem")]

namespace WinFormsApp_Backpack_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Run_button_1_Click(object sender, EventArgs e)
        {
            // Parsowanie danych z TextBox
            int numberOfItems;
            int capacity;
            int seed;

            if (!int.TryParse(Number_of_items.Text, out numberOfItems) ||
                !int.TryParse(Capacity.Text, out capacity) ||
                !int.TryParse(Seed.Text, out seed))
            {
                MessageBox.Show("WprowadŸ poprawne wartoœci dla liczby przedmiotów, pojemnoœci i ziarna!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Utwórz instancjê problemu plecakowego
            BackpackProblem.BackpackProblem problem = new BackpackProblem.BackpackProblem(numberOfItems, seed);

            // Wyœwietl przedmioty wygenerowane w instancji
            Instance.Text = problem.ToString();

            // Rozwi¹¿ problem plecakowy
            Result result = problem.Solve(capacity);

            // Wyœwietl wynik w textBoxie wynikowym
            Results.Text = $"Selected Items: {string.Join(", ", result.SelectedItems)}\r\nTotal Value: {result.TotalValue}\r\nTotal Weight: {result.TotalWeight}\r\n" + result.SelectedItemsToString(problem.Items);


            // Wyœwietl wyniki w TextBox
            //Results.Text = $"Selected Items:\r\n{result.SelectedItemsToString(problem.items)}\r\n{result.ToString()}";
        }

        private void Number_of_items_TextChanged(object sender, EventArgs e)
        {

      
        }
    }
}
