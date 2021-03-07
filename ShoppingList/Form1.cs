using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double textboxUnit = 1;
        double checkboxUnit = 1;
        double button1Unit = 1;
        double button2Unit = 1;
        private object textbox1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox textbox1 = new TextBox();
            this.Controls.Add(textbox1);
            CheckBox checkbox1 = new CheckBox();
            this.Controls.Add(checkbox1);
            Button button2 = new Button();
            this.Controls.Add(button2);

            textbox1.Top = (int)(textboxUnit * 80);
            textbox1.Left = 100;
            textboxUnit = textboxUnit + 0.5;
            textbox1.Size = new Size(300, 24);
            textbox1.Visible = true;

            checkbox1.Top = (int)(checkboxUnit * 80);
            checkbox1.Left = 440;
            checkboxUnit = checkboxUnit + 0.5;
            checkbox1.Visible = true;

            button1.Top = (int)(button1Unit * 80);
            button1.Left = 34;
            button1Unit = button1Unit + 0.5;

            button2.Top = (int)(button2Unit * 80);
            button2.Left = 560;
            button2Unit = button2Unit + 0.5;
            button2.Text = "Smazat";
            button2.Size = new Size(80, 24);
            button2.Visible = true;
        }
    }
}
