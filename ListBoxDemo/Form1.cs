using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDemo
{
    public partial class Form1 : Form
    {
        // private List<string> strings;
        // private BindingList<string> strings;
        private BindingList<dynamic> users;
        public Form1()
        {
            InitializeComponent();
            /* strings = new BindingList<string> {
                "Hello",
                "WinForms"
            }; */
            users = new BindingList<dynamic> {
                new { Id = 1, Name = "Name1", Pasword = "P1", Created_at = DateTime.Now },
                new { Id = 2, Name = "Name2", Pasword = "P2", Created_at = DateTime.Now }
            };
            // demoListBox.Items.AddRange(strings.ToArray());
            demoListBox.DataSource = users;
            demoListBox.DisplayMember = "Name";
            demoListBox.ValueMember = "Id";
            /* demoListBox.SelectionMode = SelectionMode.One;
            demoListBox.SelectedIndexChanged += (s, a) => {
                Console.WriteLine(demoListBox.SelectedItem);
            };*/

            demoListBox.SelectionMode = SelectionMode.MultiExtended;
            /*demoListBox.MultiColumn = true;
            demoListBox.Items.AddRange(new object[] {
            "Item 1, column 1, column 3",
            "Item 2, column 1, column 3",
            "Item 3, column 1, column 3",
            "Item 4, column 1, column 3",
            "Item 5, column 1, column 3",
            "Item 1, column 2, column 3",
            "Item 2, column 2, column 3",
            "Item 3, column 2"});*/
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //strings.Add(stringTextBox.Text);
            users.Add(stringTextBox.Text);
            // demoListBox.Items.Add(stringTextBox.Text);
        }

        private void deleteItemsButton_Click(object sender, EventArgs e)
        {
            // v1
            /*List<dynamic> toRemove = new List<dynamic>();
            foreach (var item in demoListBox.SelectedItems)
            {
                toRemove.Add(item);
            }
            toRemove.ForEach((toRemoveItem) => { users.Remove(toRemoveItem); });*/
            // v2
        }
    }
}
