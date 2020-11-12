using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace vetej
{
    public partial class Form1 : Form
    {
        PetOwner joppe = new PetOwner();
        int petIndex;
        int ballIndex;
        int foodIndex;
        public Form1()
        {
            InitializeComponent();
            comboBoxAnimal.Text = "Pets"; // Namn till combobox, så användaren ser vilken lista tillhör box
            comboBoxBall.Text = "Bolls";
            comboBoxFood.Text = "Foods";
            richTextBox1.Text = ("Welcome to joppes farm. By clicking on the button you can use the functions");
        }
        private void comboBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            petIndex = comboBoxAnimal.SelectedIndex; //vald item 
            ballIndex = comboBoxBall.SelectedIndex;
            foodIndex = comboBoxFood.SelectedIndex;
        }
        private void PlayAnimalBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            comboBoxAnimal.Items.Clear();
            comboBoxBall.Items.Clear();
            comboBoxFood.Items.Clear(); // Clear behövs, annars varje button click skulle addera listan om och om
            foreach (var i in joppe.balls)
            {
                comboBoxBall.Items.Add(i.Color + " ball");
            }
            foreach (var i in joppe.pets)
            {
                comboBoxAnimal.Items.Add(i.Name + " " + i.Breed);
            }
            richTextBox1.AppendText("Choose a boll and THEN an animal from the list down below\n"); //Jag vet inte var för men jag valde animal först appen crashade. Kanske dåligt flowchart?
            richTextBox1.AppendText("Click then on simulate PLAY");

        }
        private void SimulateBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string finalText = joppe.Fetch(petIndex, ballIndex); // tar emot return värde, sen skriver ut den
            richTextBox1.AppendText(finalText);
        }
        private void AnimalListBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var i in joppe.pets)
            {
                richTextBox1.AppendText(i.Name + ", " + i.Age + ", " + i.Breed + ", " + i.Fav_food + "\n");
            }
        }
        private void BallListBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var i in joppe.balls)
            {
                richTextBox1.AppendText(i.Color + "\n");
            }
        }
        private void FoodListBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var i in joppe.foods)
            {
                richTextBox1.AppendText(i.Type + "\n");
            }
        }
        private void SaveToTxtBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            joppe.SaveToTxt(); // metod anrop
            richTextBox1.AppendText("Saved");
        }
        private void CheckBollBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < joppe.balls.Count; i++)
            {
                if (joppe.balls[i].Quality < 2)
                {
                    richTextBox1.AppendText("Too low quality, we need to fix the " + joppe.balls[i] + ".\n");
                    joppe.balls[i].Quality = +5;
                }
                else
                {
                    richTextBox1.AppendText(joppe.balls[i].Color + " is useable\n");
                }
            }
        }
        private void FeedAnimalBtn_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            comboBoxAnimal.Items.Clear();
            comboBoxBall.Items.Clear();
            comboBoxFood.Items.Clear();
            foreach (var i in joppe.foods)
            {
                comboBoxFood.Items.Add(i.Type);
            }
            foreach (var i in joppe.pets)
            {
                comboBoxAnimal.Items.Add(i.Name + " " + i.Breed);
            }
            richTextBox1.AppendText("Choose food and THEN an animal from the list down below\n");
            richTextBox1.AppendText("Click then on simulate FEED");
        }

        private void SimulateFeedBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string sum = joppe.Feed(petIndex, foodIndex);
            richTextBox1.AppendText(sum);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
