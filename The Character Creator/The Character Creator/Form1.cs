using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace The_Character_Creator
{
    public partial class Form1 : Form
    {
        private SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
            player = new SoundPlayer("C:\\Users\\XXXXX\\source\\repos\\wise-mystical-tree.wav"); // Provide the path to your MP3 file
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            // Parse the values from the textboxes
            int strength, speed, wisdom, perspicuity, stamina, fabrication;

            if (int.TryParse(StrengthTextBox.Text, out strength) &&
                int.TryParse(SpeedTextBox.Text, out speed) &&
                int.TryParse(WisdomTextBox.Text, out wisdom) &&
                int.TryParse(PerspicuityTextBox.Text, out perspicuity) &&
                int.TryParse(StaminaTextBox.Text, out stamina) &&
                int.TryParse(FabricationTextBox.Text, out fabrication))
            {
                // Check if the sum of the values is equal to 12
                if (strength + speed + wisdom + perspicuity + stamina + fabrication == 12)
                {
                    // Get the character name from the CharacterNameTextBox
                    string characterName = CharacterNameTextBox.Text;
                    // Perform your desired action when the condition is met
                    MessageBox.Show($"Welcome, {characterName}! Enjoy your wise and mystical journey!");
                    player.Play();
                }
                else
                {
                    // Display an error message when the sum is not 12
                    MessageBox.Show("The sum of values must be 12!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display an error message if any of the textbox values are not valid integers
                MessageBox.Show("Please enter valid integer values in all textboxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
