namespace Biggeract7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private List<string> shoppingItems = new List<string>(); // Store all items


        private void Form1_Load_1(object sender, EventArgs e)

        {
            // Add categories to the ComboBox
            comboboxcategory.Items.Add("Electronics");
            comboboxcategory.Items.Add("Groceries");
            comboboxcategory.Items.Add("Clothing");
            comboboxcategory.Items.Add("Books");

            listBoxshopping.ContextMenuStrip = contextMenuListBox;

        }


        private Dictionary<string, List<string>> categoryItems = new Dictionary<string, List<string>>()
{
    {"Electronics", new List<string>()},
    {"Groceries", new List<string>()},
    {"Clothing", new List<string>()},
    {"Books", new List<string>()}
};


        private void UpdateCounter()
        {
            labelCounter.Text = $"Total Items: {listBoxshopping.Items.Count}";
        }

        /*Pastel & Soft (Friendly & Aesthetic)
Background: Soft Beige (#FAF3E0)
Primary Color: Pastel Green (#A8D5BA)
Accent Color: Peach (#FFB6A2)
Remove/Danger: Coral Red (#FF6B6B)
Text: Deep Brown (#4E4E4E)
        Shadows & Borders: Soft warm gray (#DDD2C0) for a subtle depth effect.
        */



        /*
         * List Box Color Choices
        Background: #FFF8F2 (Very light peach – keeps it warm and soft but distinct from the main background)
        Border: #E5C3B6 (Muted peach – subtle but visible separation from the background)
        Selected Item: #FFB6A2 (Peach – stands out while staying soft on the eyes)
        Hovered Item: #FFD5C2 (Slightly lighter peach – provides feedback for interaction)
        Text Color: #4E4E4E (Deep brown – consistent readability with other text elements)
        */

        //                           SELECTION _____________________________________________________________________
        private void comboboxcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxcategory.SelectedItem == null) return;

            string selectedCategory = comboboxcategory.SelectedItem.ToString();
            MessageBox.Show($"You selected the category: {selectedCategory}", "Category Selected");

            // Clear and load saved items for the selected category
            listBoxshopping.Items.Clear();
            if (categoryItems.ContainsKey(selectedCategory))
            {
                foreach (var item in categoryItems[selectedCategory])
                {
                    listBoxshopping.Items.Add(item);
                }
            }

            UpdateCounter();
        }


        // --------------------------------------------------------------------------  ADD
        private void buttonadd_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(textBoxitem.Text) || comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category and enter an item.", "Error");
                return;
            }

            string category = comboboxcategory.SelectedItem.ToString();
            string item = textBoxitem.Text;

            if (!categoryItems.ContainsKey(category))
            {
                categoryItems[category] = new List<string>();
            }

            if (categoryItems[category].Contains(item))
            {
                MessageBox.Show("This item is already in the list.", "Duplicate Item");
                return;
            }

            // Add item to the correct category list
            categoryItems[category].Add(item);

            // Update the ListBox to show only the current category's items
            listBoxshopping.Items.Clear();
            listBoxshopping.Items.AddRange(categoryItems[category].ToArray());

            textBoxitem.Clear(); // Clear input box after adding
            UpdateCounter(); // Update item count

        }
        // ----------------------------------------------- REMOVE
        private void buttonremove_Click(object sender, EventArgs e)
        {
            if (comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first.", "Error");
                return;
            }

            if (listBoxshopping.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to remove.", "Error");
                return;
            }

            string category = comboboxcategory.SelectedItem.ToString();
            string selectedItem = listBoxshopping.SelectedItem.ToString();

            // Ensure the category exists and remove the item from the list
            if (categoryItems.ContainsKey(category) && categoryItems[category].Contains(selectedItem))
            {
                categoryItems[category].Remove(selectedItem);

                // Refresh ListBox
                listBoxshopping.Items.Clear();
                listBoxshopping.Items.AddRange(categoryItems[category].ToArray());

                UpdateCounter(); // Update item count
            }
            else
            {
                MessageBox.Show("Item not found in the selected category.", "Error");
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            if (comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first.", "Error");
                return;
            }

            string category = comboboxcategory.SelectedItem.ToString();

            // Confirm the action before clearing
            DialogResult result = MessageBox.Show($"Are you sure you want to clear all items in {category}?",
                                                  "Confirm Clear",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Clear only the items for the selected category
                    categoryItems[category].Clear();

                    // Clear ListBox only for the selected category
                    listBoxshopping.Items.Clear();
                    UpdateCounter();
                }
            
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("ShoppingList.txt"))
            {
                foreach (var category in categoryItems.Keys)
                {
                    writer.WriteLine($"[{category}]"); // Write category header
                    foreach (var item in categoryItems[category])
                    {
                        writer.WriteLine(item); // Write items under category
                    }
                    writer.WriteLine(); // Add spacing for readability
                }
            }

            MessageBox.Show("Shopping list saved successfully!", "Save Complete");
        }




        // ----------------------------------------------------- STORING _________________________________======= ------ - -- 


        private void textBoxitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuListBox_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        // How to the f*ck my remove turn to  editToolStripMenuItemToolStripMenuItem_Click
        private void editToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first.", "Error");
                return;
            }

            if (listBoxshopping.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to remove.", "Error");
                return;
            }

            string category = comboboxcategory.SelectedItem.ToString();
            string selectedItem = listBoxshopping.SelectedItem.ToString();

            // Confirm removal
            DialogResult result = MessageBox.Show($"Are you sure you want to remove '{selectedItem}' from {category}?",
                                                  "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (categoryItems.ContainsKey(category) && categoryItems[category].Contains(selectedItem))
                {
                    categoryItems[category].Remove(selectedItem); // Remove from storage
                    listBoxshopping.Items.Remove(selectedItem); // Remove from ListBox
                    UpdateCounter();
                }
            }

        }


        // How to the f*ck my edit turn to  editToolStripMenuItemToolStripMenuItem1_Click

        private void editToolStripMenuItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first.", "Error");
                return;
            }

            if (listBoxshopping.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to edit.", "Error");
                return;
            }

            string category = comboboxcategory.SelectedItem.ToString();
            string selectedItem = listBoxshopping.SelectedItem.ToString();

            // Prompt user for new item name
            string newItem = Microsoft.VisualBasic.Interaction.InputBox(
                $"Edit '{selectedItem}' in {category}:", "Edit Item", selectedItem);

            // Ensure the user entered a valid item name
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                // Check if category exists and update item
                if (categoryItems.ContainsKey(category) && categoryItems[category].Contains(selectedItem))
                {
                    int index = categoryItems[category].IndexOf(selectedItem);
                    categoryItems[category][index] = newItem; // Update stored list

                    // Refresh ListBox
                    listBoxshopping.Items.Clear();
                    listBoxshopping.Items.AddRange(categoryItems[category].ToArray());

                    UpdateCounter();
                }
            }
            else
            {
                MessageBox.Show("Invalid item name. No changes were made.", "Error");
            }

        }

        // text box 1 is the search



        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // text box 1 is the search --------------------------------------------- textchange1

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first.", "Error");
                return;
            }

            string searchText = textBox1.Text.ToLower();
            string category = comboboxcategory.SelectedItem.ToString();

            // Ensure the selected category has items stored
            if (!categoryItems.ContainsKey(category)) return;

            // Filter items that start with the search text
            var filteredItems = categoryItems[category]
                .Where(item => item.ToLower().StartsWith(searchText)) // Search only at the beginning
                .ToList();

            // Update ListBox with filtered results
            listBoxshopping.Items.Clear();
            listBoxshopping.Items.AddRange(filteredItems.ToArray());

            UpdateCounter(); // Update item count after filtering

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                         "Exit Confirmation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LOADButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("ShoppingList.txt"))
            {
                categoryItems.Clear(); // Clear current dictionary
                listBoxshopping.Items.Clear();

                string currentCategory = null;

                foreach (string line in File.ReadAllLines("ShoppingList.txt"))
                {
                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        currentCategory = line.Trim('[', ']'); // Extract category name
                        if (!categoryItems.ContainsKey(currentCategory))
                        {
                            categoryItems[currentCategory] = new List<string>();
                        }
                    }
                    else if (!string.IsNullOrWhiteSpace(line) && currentCategory != null)
                    {
                        categoryItems[currentCategory].Add(line);
                    }
                }

                MessageBox.Show("Shopping list loaded successfully!", "Load Complete");
            }
            else
            {
                MessageBox.Show("No saved shopping list found.", "Load Failed");
            }
        }
    }
}
