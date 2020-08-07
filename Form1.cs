/* Brie Prater
 * 08/06/2020
 * CIS 353
 * Professor Cain
 * Assignment 10.2 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace week10
{
    public partial class Form1 : Form
    {
        // declaring variables
        const char SPLIT = ',';
        string PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string inputFriend;
        string checkIt;
        string[] splitFriends;
        string bday;
        string display;
        string searchIt;
        Friend friend = new Friend(); // instantiates Friend object

        public Form1()
        {
            InitializeComponent();
        }

        public class Friend // class Friend
        {
            // declaring variables
            private string lastName;
            private string phoneNumber;
            private int month;
            private int day;
            private string firstName;

            public string LastName // accessor for private variable lastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string PhoneNumber // accessor for private variable phoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            public int Month // // accessor for private variable month
            {
                get { return month; }
                set { month = value; }
            }

            public int Day // accessor for private variable day
            {
                get { return day; }
                set { day = value; }
            }

            public string FirstName // accessor for private variable firstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public override string ToString() // override class ToString
            {
                return (FirstName + ',' + LastName + ',' + PhoneNumber + ',' + Month + ',' + Day);
                // formats variable.ToString() to include variables seperated by comma
            }
        }

        public class monthOutOfRangeException : Exception // custom exception to handle month out of range
        {
            public override string Message // message informs user the month input is out of range and needs to be between 1 and 12
            {
                get
                {
                    return "Month must be between 1 and 12.";
                }
            }
        }

        public class dayOutOfRangeException : Exception // custom exception to handle day out of range
        {
            public override string Message // message informs user the day input is out of range and needs to be between 1 and 31
            {
                get
                {
                    return "Day must be between 1 and 31.";
                }
            }
        }

        private void exit_Click(object sender, EventArgs e) // method when entry tab exit button clicked
        {
            
            Application.Exit(); // terminates application
        }

        private void exit2_Click(object sender, EventArgs e) // method when read tab exit button clicked
        {
            exit_Click(sender, e); // calls method for entry tab exit button
        }

        private void exit3_Click(object sender, EventArgs e) // method for remind tab exit button clicked
        {
            exit_Click(sender, e); // calls method for entry tab exit button
        }

        private void fNameInput_TextChanged(object sender, EventArgs e)
        {
            friend.FirstName = fNameInput.Text; // sets user input to FirstName variable
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lNameInput_TextChanged(object sender, EventArgs e)
        {
            friend.LastName = lNameInput.Text; // sets user input to LastName variable
        }

        private void bMonthInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                monthInvalid.Visible = false; // hides Invalid Input label
                friend.Month = Convert.ToInt32(bMonthInput.Text); // converts user input to int and sets to Month variable
                if (friend.Month > 12 || friend.Month < 1) // verifies if input is a valid month
                {
                    throw new monthOutOfRangeException(); // user input is > 12, not a valid month, throws exception
                }
            }
            catch (System.FormatException) // if user input not int, exception thrown 
            {
                monthInvalid.Text = "Invalid Input";
                monthInvalid.Visible = true; // displays Invalid Input label
            }
            catch (monthOutOfRangeException one) // if user input is not between 1 - 12, the thrown exception is caught
            {
                monthInvalid.Text = (one.Message); // sets label text to exception message
                monthInvalid.Visible = true; // displays Invalid Input label
            }
        }

        private void bDayInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dayInvalid.Visible = false; // hids Invalid Input label
                friend.Day = Convert.ToInt32(bDayInput.Text); // converts user input to int and sets to Day variable
                if (friend.Day > 31 || friend.Day < 1) // verifies if input is a valid day
                {
                    throw new dayOutOfRangeException(); // user input is > 31, not valid day, throws exception
                }
            }
            catch (System.FormatException) // if user input not int, exception thrown
            {
                dayInvalid.Text = "Invalid Input";
                dayInvalid.Visible = true; // displays Invalid Input label
            }
            catch (dayOutOfRangeException two) // if user input is not between 1 - 31, the thrown exception is caught
            {
                dayInvalid.Text = (two.Message); // sets label text to exception message
                dayInvalid.Visible = true; // displays Invalid Input label
            }
        }

        private void pNumInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            numInvalid.Visible = true; // displays Invalid Input label if user does not enter properly formatted text
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthInvalid.Visible = false; // hides invalid input labels on form load
            dayInvalid.Visible = false;
            numInvalid.Visible = false;
        }

        private void enterFriend_Click(object sender, EventArgs e) // method for Enter Friend button click
        {
            try
            {
                inputFriend = friend.ToString(); // formats user input to override string
                using (StreamWriter toWrite = new StreamWriter(Path.Combine(PATH, "friends.txt"), true)) // opens StreamWriter
                {
                    toWrite.WriteLine(inputFriend); // writes user input to file
                    toWrite.Flush(); 
                }
                using (StreamReader toRead = new StreamReader(Path.Combine(PATH, "friends.txt"))) // opens StreamReader
                {
                    checkIt = toRead.ReadLine(); // sets checkIt to read information from file
                    toRead.Close();
                }
                if (checkIt != null) // file returns information properly
                {
                    string message = "Name: " + friend.FirstName + " " + friend.LastName + "\n" +
                        "Birthday: " + friend.Month + "/" + friend.Day + "\n" +
                        "Phone Number: " + friend.PhoneNumber + "\n" +
                        "Successfully saved to file.";
                    string title = "Successful!"; 
                    MessageBox.Show(message, title); // messageBox to inform user information has been saved to file
                }
            }
            catch // exception thrown
            {
                string message1 = "Unable to save data. Please try again.";
                string title1 = "Error";
                MessageBox.Show(message1, title1); // messageBox to inform user save unsuccessful

            }
            finally
            {
                // empties all textboxes on entry tab
                fNameInput.Text = String.Empty; 
                lNameInput.Text = String.Empty;
                bMonthInput.Text = String.Empty;
                bDayInput.Text = String.Empty;
                pNumInput.Text = String.Empty;
            }

        }

        private void pNumInput_TextChanged(object sender, EventArgs e)
        {
            numInvalid.Visible = false; // hides invalid input label
            friend.PhoneNumber = pNumInput.Text; // sets user input to PhoneNumber variable
        }

        private void readBtn_Click(object sender, EventArgs e) // method for Read button clicked
        {
            try
            {
                string[] friends = File.ReadAllLines(Path.Combine(PATH, "friends.txt"), Encoding.UTF8); // reads all lines saved to friends.txt
                foreach (string s in friends) // goes through each index in friends array
                {
                    splitFriends = s.Split(SPLIT); // splits each index at comma 
                    while (splitFriends != null) // checks that splitFriends holds data
                    {
                        // sets each index in splitFriends to a variable
                        friend.FirstName = splitFriends[0];
                        friend.LastName = splitFriends[1];
                        friend.PhoneNumber = splitFriends[2];
                        friend.Month = Convert.ToInt32(splitFriends[3]);
                        friend.Day = Convert.ToInt32(splitFriends[4]);
                        bday = splitFriends[3] + "/" + splitFriends[4]; // formats birthday to be month/day
                        // formats string to display each index with space between
                        display = String.Format("{0,-10} {1,-10} {2,30} {3,20}", splitFriends[0], splitFriends[1], splitFriends[2], bday);
                        displayEntry.Items.Add(display); // adds formatted string to listbox
                        break; // breaks while loop
                    }
                }   
            }
            catch // exception thrown
            {
                // displays error message box
                string message1 = "No data was found.";
                string title1 = "Error";
                MessageBox.Show(message1, title1);
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
             searchIt = searchInput.Text; // sets user input to searchIt variable
        }

        private void remindBtn_Click(object sender, EventArgs e) // method for Reminder button clicked
        {
            try
            {
                string[] friends = File.ReadAllLines(Path.Combine(PATH, "friends.txt"), Encoding.UTF8); // reads all lines saved to friends.txt
                foreach (string s in friends) // goes through each index in friends array
                {
                    splitFriends = s.Split(SPLIT);  // splits each index at comma 
                    while (splitFriends != null) // checks that splitFriends holds data
                    {
                        // sets each index in splitFriends to a variable
                        friend.FirstName = splitFriends[0];
                        friend.LastName = splitFriends[1];
                        friend.PhoneNumber = splitFriends[2];
                        friend.Month = Convert.ToInt32(splitFriends[3]);
                        friend.Day = Convert.ToInt32(splitFriends[4]);
                        bday = splitFriends[3] + "/" + splitFriends[4]; // formats birthday to be month/day
                        if (friend.Month == Convert.ToInt32(searchIt)) // compares Month variable to user input
                        {
                            // birthday month matches user input
                            // formats string to display each index with space between
                            display = String.Format("{0,-10} {1,-10} {2,30} {3,20}", splitFriends[0], splitFriends[1], splitFriends[2], bday);
                            displayRemind.Items.Add(display); // adds formatted string to listbox
                        }
                        break; // breaks while loop
                    }
                }
            } 
            catch // exception thrown
            {
                // displays error message box 
                string message1 = "No data was found.";
                string title1 = "Error";
                MessageBox.Show(message1, title1);
            }
            finally
            {
                searchInput.Text = String.Empty; // empties text box on remind tab
            }
        }

        private void readTab_Deselected(Object sender, TabControlEventArgs e) // method when Read tab is deselected
        {
            displayEntry.Items.Clear(); // empties listbox on read tab
            remindTab_Deselected(sender, e); // calls method for when remind tab is deselected
        }

        private void remindTab_Deselected(Object sender, TabControlEventArgs e) // method when remind tab is deselected
        {
            displayRemind.Items.Clear(); // empties listbox on remind tab
        }
    }
}
