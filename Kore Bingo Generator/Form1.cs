using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kore_Bingo_Generator
{
    public partial class Form1 : Form
    {
        private string filePath = "used_numbers.txt";
        private HashSet<int> usedNumbers;

        public Form1()
        {
            InitializeComponent();
            usedNumbers = LoadUsedNumbers(filePath);

            // Set the background image
            this.BackgroundImage = Resource1.drown; // Assuming drown.png is correctly added to Resources
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int numberOfRandomNumbers;
            if (!int.TryParse(txtNumberInput.Text, out numberOfRandomNumbers) || numberOfRandomNumbers < 1)
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            // Perform the random number generation logic
            List<int> availableNumbers = Enumerable.Range(1, 300).Except(usedNumbers).ToList();

            if (numberOfRandomNumbers > availableNumbers.Count)
            {
                MessageBox.Show($"Please enter a number between 1 and {availableNumbers.Count}.");
                return;
            }

            Random random = new Random();
            List<int> newNumbers = new List<int>();

            for (int i = 0; i < numberOfRandomNumbers; i++)
            {
                int index = random.Next(availableNumbers.Count);
                int randomNumber = availableNumbers[index];
                availableNumbers.RemoveAt(index);

                newNumbers.Add(randomNumber);
                usedNumbers.Add(randomNumber);
            }

            SaveUsedNumbers(filePath, usedNumbers);

            listBoxNumbers.Items.Clear();
            foreach (int number in newNumbers)
            {
                listBoxNumbers.Items.Add(number);
            }

            // Calculate the result (input number x 500,000)
            long result = numberOfRandomNumbers * 500000;

            // Display the result with commas
            lblCalculationResult.Text = $"Calculated Result: {result:N0}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, string.Empty); // Clears the file content
                MessageBox.Show("All numbers have been cleared from the file.");
                usedNumbers.Clear(); // Also clear the in-memory used numbers set
                listBoxNumbers.Items.Clear(); // Optionally clear the displayed list
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }
        }

        private HashSet<int> LoadUsedNumbers(string filePath)
        {
            HashSet<int> usedNumbers = new HashSet<int>();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int number))
                    {
                        usedNumbers.Add(number);
                    }
                }
            }
            return usedNumbers;
        }

        private void SaveUsedNumbers(string filePath, HashSet<int> usedNumbers)
        {
            File.WriteAllLines(filePath, usedNumbers.Select(n => n.ToString()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
