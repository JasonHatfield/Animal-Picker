// Jason Hatfield
// This is my original work.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape_Maker
{
    public partial class shapeMaker : Form
    {
        /// <summary>
        /// Write a Windows Forms program that uses radio buttons, check boxes, 
        /// and list boxes. Your program may do anything you wish, but should 
        /// demonstrate appropriate use of each of the controls.
        /// </summary>
        public shapeMaker()
        {
            InitializeComponent();
        }
        
        private void drawButton_Click(object sender, EventArgs e)
        {
            SelectAnimals();
        }
        
        private void clearButton_Click(object sender, EventArgs e)
        // clear the form
        {
            HidePictures();
            ClearAll();
        }

        class Animal
        // create the Animal class
        {
            public string name;
            public string age;
        }

        private void ClearAll()
        // clear all selections
        {
            animalsListBox.ClearSelected();
            ClearRadioButtons();
            ClearCheckBoxes();
            ClearNameLabel();
            ClearAgeLabel();
            HidePictures();
        }

        private void HidePictures()
        // hide all pictures.
        {
            dogInPictureBox.Hide();
            dogOutPictureBox.Hide();
            catInPictureBox.Hide();
            catOutPictureBox.Hide();
            horseInPictureBox.Hide();
            horseOutPictureBox.Hide();
            chickenInPictureBox.Hide();
            chickenOutPictureBox.Hide();
            cowInPictureBox.Hide();
            cowOutPictureBox.Hide();
        }

        private void ClearNameLabel()
        {
            outputNameLabel.Text = "";
        }

        private void ClearAgeLabel()
        {
            outputAgeLabel.Text = "";
        }

        private void ClearCheckBoxes()
        {
            nameCheckBox.Checked = false;
            ageCheckBox.Checked = false;
        }

        private void ClearRadioButtons()
        {
            insideRadioButton.Checked = false;
            outsideRadioButton.Checked = false;
        }

        // selects the animal based on the list box and radio buttons and displays a picture
        private void SelectAnimals()
        {
            // try catches the exception when no animal is selected.
            try 
            {
                // hides any pictures from the previous attempt (if any)
                HidePictures();
                // executes if dog is selected
                if (animalsListBox.SelectedItem.Equals("Dog"))
                {
                    if (insideRadioButton.Checked == true)
                    {
                        dogInPictureBox.Show();
                        AnimalInformation();
                    }
                    else if (outsideRadioButton.Checked == true)
                    {
                        dogOutPictureBox.Show();
                        AnimalInformation();
                    }
                    else
                    {
                        MessageBox.Show("Select either inside or outside as a location for your " + animalsListBox.SelectedItem.ToString() + ".");
                    }

                }

                else if (animalsListBox.SelectedItem.Equals("Cat"))
                {
                    if (insideRadioButton.Checked == true)
                    {
                        catInPictureBox.Show();
                        AnimalInformation();
                    }
                    else if (outsideRadioButton.Checked == true)
                    {
                        catOutPictureBox.Show();
                        AnimalInformation();
                    }
                    else
                    {
                        MessageBox.Show("Select either inside or outside as a location for your " + animalsListBox.SelectedItem.ToString() + ".");
                    }

                }

                else if (animalsListBox.SelectedItem.Equals("Horse"))
                {
                    if (insideRadioButton.Checked == true)
                    {
                        horseInPictureBox.Show();
                        AnimalInformation();
                    }
                    else if (outsideRadioButton.Checked == true)
                    {
                        horseOutPictureBox.Show();
                        AnimalInformation();
                    }
                    else
                    {
                        MessageBox.Show("Select either inside or outside as a location for your " + animalsListBox.SelectedItem.ToString() + ".");
                    }
                }

                else if (animalsListBox.SelectedItem.Equals("Chicken"))
                {
                    if (insideRadioButton.Checked == true)
                    {
                        chickenInPictureBox.Show();
                        AnimalInformation();
                    }
                    else if (outsideRadioButton.Checked == true)
                    {
                        chickenOutPictureBox.Show();
                        AnimalInformation();
                    }
                    else
                    {
                        MessageBox.Show("Select either inside or outside as a location for your " + animalsListBox.SelectedItem.ToString() + ".");
                    }
                }

                else if (animalsListBox.SelectedItem.Equals("Cow"))
                {
                    if (insideRadioButton.Checked == true)
                    {
                        cowInPictureBox.Show();
                        AnimalInformation();
                    }
                    else if (outsideRadioButton.Checked == true)
                    {
                        cowOutPictureBox.Show();
                        AnimalInformation();
                    }
                    else
                    {
                        MessageBox.Show("Select either inside or outside as a location for your " + animalsListBox.SelectedItem.ToString() + ".");
                    }
                }
            }
            // displays a message to have the user select an animal from the list if exception is thrown
            catch
            {
                MessageBox.Show("Select an animal from the list.");
            }
            

        }

        // selects the information to be displayed to the labels
        private void AnimalInformation()
        {
            // dog
            if (animalsListBox.SelectedItem.Equals("Dog"))
            {
                if (insideRadioButton.Checked == true)
                {
                    Animal dogIn = new Animal
                    {
                        name = "Buddy",
                        age = "10 Months"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + dogIn.name.ToString(); 
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }
                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + dogIn.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
                else
                {
                    Animal dogOut = new Animal
                    {
                        name = "Champ",
                        age = "2 Years Old"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + dogOut.name.ToString();
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }

                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + dogOut.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
            }
            // cat
            else if (animalsListBox.SelectedItem.Equals("Cat"))
            {
                if (insideRadioButton.Checked == true)
                {
                    Animal catIn = new Animal
                    {
                        name = "Zeus",
                        age = "4 Years Old"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + catIn.name.ToString();
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }
                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + catIn.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
                else
                {
                    Animal catOut = new Animal
                    {
                        name = "Thunder",
                        age = "2 Years Old"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + catOut.name.ToString();
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }
                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + catOut.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
            }
            // horse
            else if (animalsListBox.SelectedItem.Equals("Horse"))
            {
                if (insideRadioButton.Checked == true)
                {
                    Animal horseIn = new Animal
                    {
                        name = "Shadow",
                        age = "6 Years Old"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + horseIn.name.ToString();
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }
                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + horseIn.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
                else
                {
                    Animal horseOut = new Animal
                    {
                        name = "Big John",
                        age = "8 Years Old"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + horseOut.name.ToString();
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }
                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + horseOut.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
            }
            // chicken
            else if (animalsListBox.SelectedItem.Equals("Chicken"))
            {
                if (insideRadioButton.Checked == true)
                {
                    Animal chickenIn = new Animal
                    {
                        name = "Bessy",
                        age = "1 Year Old"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + chickenIn.name.ToString();
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }
                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + chickenIn.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
                else
                {
                    Animal chickenOut = new Animal
                    {
                        name = "Clucky McClucker Face",
                        age = "18 Months Old"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + chickenOut.name.ToString();
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }
                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + chickenOut.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
            }
            // cow
            else if (animalsListBox.SelectedItem.Equals("Cow"))
            {
                if (insideRadioButton.Checked == true)
                {
                    Animal cowIn = new Animal
                    {
                        name = "Clyde",
                        age = "4 Years Old"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + cowIn.name.ToString();
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }
                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + cowIn.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
                else
                {
                    Animal cowOut = new Animal
                    {
                        name = "Sunshine",
                        age = "5 Years Old"
                    };

                    if (nameCheckBox.Checked == true)
                    {
                        outputNameLabel.Text = "Name: " + cowOut.name.ToString();
                    }
                    else
                    {
                        outputNameLabel.Text = "";
                    }
                    if (ageCheckBox.Checked == true)
                    {
                        outputAgeLabel.Text = "Age: " + cowOut.age.ToString();
                    }
                    else
                    {
                        outputAgeLabel.Text = "";
                    }
                }
            }
        }
    }
}

