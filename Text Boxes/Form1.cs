using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Boxes
{
    public partial class Form1 : Form
    {
        //Class Fields
        string myName;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Main Form Loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Submit Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Get myName
            myName = nameTextBox.Text;

            //Do Dino method
            Dino();
        }


        public void Dino()
        {
            string Cool;//Dinosaurs!
            DialogResult result = MessageBox.Show("I  have a follow up question for you " + myName + " Do you like Dinosaurs?", 
                "Question", MessageBoxButtons.YesNo);

            if (result.ToString().ToLower() == "yes")
            {
                MessageBox.Show("You are the most awesome person ever!");// type yes!
            }

            else if (result.ToString().ToLower() == "no")
            {
                MessageBox.Show("You want to go home and rethink your life.");// this is what happens when you don't like dinos
                Dino();//recalls Dino 
            }

            else
            {
                Console.WriteLine("What you entered is not supported. Please try yes or no.");// i'm lost try again
                Dino();//recalls Dino 
            }
        }
    }
}
