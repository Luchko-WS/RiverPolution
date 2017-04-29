using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiverPolution
{
    public partial class MainForm : Form
    {
        int window = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideSecondWindow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                validateInputData();
                this.listBoxPlants.Select();
                window = 2;

                this.numericUpDownX.Maximum = Convert.ToInt32(this.textBoxWidth.Text);
                this.numericUpDownY.Maximum = Convert.ToInt32(this.textBoxHeight.Text);

                PolutionParameters.PolutionArray.width = Convert.ToInt32(this.textBoxWidth.Text);
                PolutionParameters.PolutionArray.height = Convert.ToInt32(this.textBoxHeight.Text);
                PolutionParameters.GDK = Convert.ToDouble(this.textBoxGDK.Text);
                PolutionParameters.fone = Convert.ToDouble(this.textBoxFone.Text);

                this.labelInfo.Text = "Розмірність: (" + PolutionParameters.PolutionArray.width + ";" +
                    PolutionParameters.PolutionArray.height + "), фон: " + PolutionParameters.fone +
                    ", ГДК: " + PolutionParameters.GDK;

                PolutionParameters.PolutionArray.values = new double[(int)this.numericUpDownY.Maximum, (int)this.numericUpDownX.Maximum];

                for (var i = 0; i < PolutionParameters.PolutionArray.height; i++)
                    for (var j = 0; j < PolutionParameters.PolutionArray.width; j++)
                        PolutionParameters.PolutionArray.values[i, j] = 0;

                hideFirstWindow();
                showSecondWindow();
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть корректні данні.");
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            window = 1;
            hideSecondWindow();
            showFirstWindow();
            listBoxPlants.Items.Clear();
        }

        private void validateInputData()
        {
            if (window == 1)
            {
                if (String.IsNullOrWhiteSpace(this.textBoxWidth.Text) || String.IsNullOrWhiteSpace(this.textBoxHeight.Text) ||
                    String.IsNullOrWhiteSpace(this.textBoxFone.Text) || String.IsNullOrWhiteSpace(this.textBoxGDK.Text))
                    throw new Exception("Is null or write space");

                Convert.ToInt32(this.textBoxWidth.Text);
                Convert.ToInt32(this.textBoxHeight.Text);
                Convert.ToDouble(this.textBoxFone.Text);
                Convert.ToDouble(this.textBoxGDK.Text);

                if (Convert.ToInt32(this.textBoxWidth.Text) <= 0 || Convert.ToInt32(this.textBoxHeight.Text) <= 0 ||
                    Convert.ToDouble(this.textBoxFone.Text) < 0 || Convert.ToDouble(this.textBoxGDK.Text) < 0)
                    throw new Exception("Can't be less or equal than zero");
            }
            else
            {
                if (String.IsNullOrWhiteSpace(this.textBoxCapacity.Text)) throw new Exception("Is null or write space");

                Convert.ToDouble(this.textBoxCapacity.Text);

                if (Convert.ToDouble(this.textBoxCapacity.Text) <= 0)
                    throw new Exception("Can't be less or equal than zero");
            }
        }

        private void showFirstWindow()
        {
            this.textBoxHeight.Visible = true;
            this.textBoxWidth.Visible = true;
            this.textBoxFone.Visible = true;
            this.buttonNext.Visible = true;
            this.textBoxGDK.Visible = true;
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label9.Visible = true;
        }

        private void hideFirstWindow()
        {
            this.textBoxHeight.Visible = false;
            this.textBoxWidth.Visible = false;
            this.textBoxFone.Visible = false;
            this.buttonNext.Visible = false;
            this.textBoxGDK.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label9.Visible = false;
        }

        private void showSecondWindow()
        {
            this.listBoxPlants.Visible = true;
            this.numericUpDownX.Visible = true;
            this.numericUpDownY.Visible = true;
            this.buttonAddItem.Visible = true;
            this.buttonRemoveItem.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.labelInfo.Visible = true;
            this.label8.Visible = true;
            this.textBoxCapacity.Visible = true;
            this.buttonPrev.Visible = true;
            this.buttonDraw.Visible = true;
        }

        private void hideSecondWindow()
        {
            this.listBoxPlants.Visible = false;
            this.numericUpDownX.Visible = false;
            this.numericUpDownY.Visible = false;
            this.buttonAddItem.Visible = false;
            this.buttonRemoveItem.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.labelInfo.Visible = false;
            this.label8.Visible = false;
            this.textBoxCapacity.Visible = false;
            this.buttonPrev.Visible = false;
            this.buttonDraw.Visible = false;
        }

        struct ListItem
        {
            public int x;
            public int y;
            public double capacity;
        }

        ListItem Item;

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                validateInputData();
                listBoxPlants.Items.Add("(" + this.numericUpDownX.Value.ToString() + ";" + this.numericUpDownY.Value.ToString() +
                    ") " + this.textBoxCapacity.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть корректні данні.");
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            readFromList(listBoxPlants.SelectedIndex);
            PolutionParameters.PolutionArray.values[Item.y - 1, Item.x - 1] = 0;
            if (listBoxPlants.SelectedIndex != -1)
                listBoxPlants.Items.RemoveAt(listBoxPlants.SelectedIndex);
        }

        private void readFromList(int index)
        {
            if (index != -1)
            {
                String str = listBoxPlants.Items[index].ToString();
                String token = "";

                int i = 1;
                while (str[i] != ';')
                {
                    token += str[i];
                    i++;
                }

                Item.x = Convert.ToInt32(token);
                i++;
                token = "";

                while (str[i] != ')')
                {
                    token += str[i];
                    i++;
                }

                Item.y = Convert.ToInt32(token);
                i++;
                token = "";

                token = str.Substring(i);
                Item.capacity = Convert.ToDouble(token);
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            CalculatePolution();

            var form = new ContainerForm();
            form.ShowDialog();

        }

        private void CalculatePolution()
        {
            if (this.listBoxPlants.Items.Count != 0)
            {
                for (var i = 0; i < this.listBoxPlants.Items.Count; i++)
                {
                    readFromList(i);
                    PolutionParameters.PolutionArray.values[Item.y - 1, Item.x - 1] = Item.capacity;
                }
            }
            else
            {
                MessageBox.Show("Не додано жодної точки скиду.");
            }

            for (var j = 0; j < PolutionParameters.PolutionArray.height; j++)
            {
                if (PolutionParameters.PolutionArray.values[j, 0] == 0) PolutionParameters.PolutionArray.values[j, 0] = PolutionParameters.fone;
                else PolutionParameters.PolutionArray.values[j, 0] += PolutionParameters.fone;
            }

            for (var i = 1; i < PolutionParameters.PolutionArray.width; i++)
            {
                for (var j = 0; j < PolutionParameters.PolutionArray.height; j++)
                {
                    if (PolutionParameters.PolutionArray.values[j, i] == 0)
                    {
                        if (j == 0) PolutionParameters.PolutionArray.values[j, i] = (PolutionParameters.PolutionArray.values[j, i - 1] + PolutionParameters.PolutionArray.values[j + 1, i - 1]) / 2;
                        else if (j == PolutionParameters.PolutionArray.height - 1) PolutionParameters.PolutionArray.values[j, i] = (PolutionParameters.PolutionArray.values[j, i - 1] + PolutionParameters.PolutionArray.values[j - 1, i - 1]) / 2;
                        else PolutionParameters.PolutionArray.values[j, i] = (PolutionParameters.PolutionArray.values[j - 1, i - 1] + PolutionParameters.PolutionArray.values[j + 1, i - 1]) / 2;
                    }
                    else
                    {
                        if (j == 0) PolutionParameters.PolutionArray.values[j, i] += (PolutionParameters.PolutionArray.values[j, i - 1] + PolutionParameters.PolutionArray.values[j + 1, i - 1]) / 2;
                        else if (j == PolutionParameters.PolutionArray.height - 1) PolutionParameters.PolutionArray.values[j, i] += (PolutionParameters.PolutionArray.values[j, i - 1] + PolutionParameters.PolutionArray.values[j - 1, i - 1]) / 2;
                        else PolutionParameters.PolutionArray.values[j, i] += (PolutionParameters.PolutionArray.values[j - 1, i - 1] + PolutionParameters.PolutionArray.values[j + 1, i - 1]) / 2;
                    }
                }
            }
        }
    }
}
