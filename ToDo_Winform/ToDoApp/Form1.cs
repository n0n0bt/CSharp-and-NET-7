using Microsoft.EntityFrameworkCore;
using Todo.Shared;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            using (TodoContext db = new TodoContext())
            {
                DbSet<Shopping> ShoppingList = db.Shoppings;
                int y = 16;
                foreach (Shopping shopping in ShoppingList)
                {

                    CheckBox checkBox = new CheckBox();
                    checkBox.AutoSize = true;
                    checkBox.Location = new Point(88, y);
                    checkBox.Name = shopping.ShoppingItemId.ToString();
                    checkBox.Size = new Size(103, 24);
                    checkBox.TabIndex = 0;
                    checkBox.Text = shopping.ShoppingItem;
                    checkBox.UseVisualStyleBackColor = true;

                    Button button = new Button();
                    button.Location = new Point(220, y);
                    button.Name = shopping.ShoppingItemId.ToString();
                    button.Size = new Size(44, 23);
                    button.TabIndex = 1;
                    button.Text = "X";
                    button.UseVisualStyleBackColor = true;

                    panel1.Controls.Add(button);
                    panel1.Controls.Add(checkBox);
                    y += 5;

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}