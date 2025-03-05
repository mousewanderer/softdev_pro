namespace Biggeract7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> shoppingItems = new List<string>(); // Store all items


        private void UpdateCounter()
        {
            labelCounter.Text = $"Total Items: {listBoxshopping.Items.Count}";
        }



        private void comboboxcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboboxcategory.SelectedItem.ToString();
            MessageBox.Show($"You selected the category: {selectedCategory}", "Category Selected");
        }

        private void buttonadd_Click(object sender, EventArgs e)



        {


            // Ensure the item is not empty
            if (!string.IsNullOrWhiteSpace(textBoxitem.Text) && comboboxcategory.SelectedItem != null)
            {

                string category = comboboxcategory.SelectedItem.ToString();
                string item = textBoxitem.Text;
                string formattedItem = $"{category}: {item}";


                shoppingItems.Add(textBoxitem.Text); // Add to storage list
                listBoxshopping.Items.Add(textBoxitem.Text); // Add the item to the ListBox
                textBoxitem.Clear(); // Clear the TextBox after adding the item
                UpdateCounter(); // Update item count



            }
            else if (listBoxshopping.Items.Contains(textBoxitem.Text))
            {
                MessageBox.Show("This item is already in the list.", "Duplicate Item");
            }
            else
            {
                MessageBox.Show("Please enter an item to add to your shopping list.", "Error");
            }

        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            if (listBoxshopping.SelectedItem != null)
            {
                shoppingItems.Remove(listBoxshopping.SelectedItem.ToString()); // Remove from storage list
                listBoxshopping.Items.Remove(listBoxshopping.SelectedItem); // Remove from ListBox
                UpdateCounter(); // Update item count
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Error");
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            listBoxshopping.Items.Clear();
            shoppingItems.Clear(); // Clear storage list
            UpdateCounter(); // Update item count
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("ShoppingList.txt"))
            {
                foreach (var item in listBoxshopping.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Shopping list saved to ShoppingList.txt");
        }

        private void Form1_Load_1(object sender, EventArgs e)

        {
            // Add categories to the ComboBox
            comboboxcategory.Items.Add("Electronics");
            comboboxcategory.Items.Add("Groceries");
            comboboxcategory.Items.Add("Clothing");
            comboboxcategory.Items.Add("Books");

            listBoxshopping.ContextMenuStrip = contextMenuListBox;

        }

        private void textBoxitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuListBox_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        // How to the fuck my remove turn to  editToolStripMenuItemToolStripMenuItem_Click
        private void editToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listBoxshopping.SelectedItem != null)
            {
                listBoxshopping.Items.Remove(listBoxshopping.SelectedItem);
                UpdateCounter(); // Update item count
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Error");
            }

        }


        // How to the fuck my edit turn to  editToolStripMenuItemToolStripMenuItem1_Click

        private void editToolStripMenuItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (listBoxshopping.SelectedItem != null)
            {
                // Prompt user to enter a new name
                string newItem = Microsoft.VisualBasic.Interaction.InputBox(
                    "Edit item:", "Edit Item", listBoxshopping.SelectedItem.ToString());

                // Ensure the user didn't leave it empty
                if (!string.IsNullOrWhiteSpace(newItem))
                {
                    int selectedIndex = listBoxshopping.SelectedIndex;
                    listBoxshopping.Items[selectedIndex] = newItem;

                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Error");
            }


        }

        // text box 1 is the search

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();

            // Filter list items based on category or item name
            var filteredItems = shoppingItems
                .Where(item => item.ToLower().Contains(searchText))
                .ToList();

            // Update ListBox with filtered results
            listBoxshopping.Items.Clear();
            listBoxshopping.Items.AddRange(filteredItems.ToArray());

            UpdateCounter(); // Update item count after filtering

        }
    }
}
