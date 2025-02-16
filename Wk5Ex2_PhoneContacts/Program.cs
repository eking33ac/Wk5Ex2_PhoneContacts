using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5Ex2_PhoneContacts
{
    class Program
    {
        // Method to handle integer input
        static int HandleIntInput(string aPrompt, string anErrorMessage = "Your input is invalid. Please enter a whole number.\n")
        {
            // initialize return value
            int returnValue = Int32.MaxValue;


            // processing


            // start of a do while loop
            do
            {
                // A try catch to ensure the user input is valid
                try
                {
                    // Ask user to input a number
                    Console.Write(aPrompt);
                    // Convert user input to a double, collect input from user and store it in the returnValue
                    returnValue = Convert.ToInt32(Console.ReadLine());
                }
                // if that doesn't work, output an error message
                catch (Exception e)
                {
                    // output an error message
                    Console.WriteLine("\n" + anErrorMessage);
                }
            }
            // loop until returnValue has a different value


            while (returnValue == Int32.MaxValue);


            // return returnValue
            return returnValue;
        }


        // method to validate user string input
        public static string HandleStringInput(string aPrompt = "Write your sentence/string: ", string anErrorMessage = "Something went wrong on our end. Please enter a valid string input.\n")
        {
            // initialize return value
            string returnValue = "";


            // processing


            // start of a do while loop
            do
            {
                // A try catch to ensure the user input is valid
                try
                {
                    // Ask user to input a string
                    Console.Write(aPrompt);
                    // Collect input from user and store it in the returnValue
                    returnValue = (Console.ReadLine());
                }
                // if that doesn't work, output an error message
                catch (Exception e)
                {
                    // output an error message
                    Console.WriteLine(anErrorMessage);
                }
            }
            // loop until returnValue has a different value
            while (returnValue == "");


            // return returnValue
            return returnValue;
        }


        // a method to check if an integer input is between two numbers
        static int CheckIntRange(int input, int min, int max, int evaluationValue = Int32.MinValue, string errorMessage = "Your input was out of range. Input again.\n")
        {
            // initialize return value to the input
            int returnValue = input;

            // processing


            // check if the input is grater than a max value OR less than a min value
            if (input > max || input < min)
            {
                // return an error message
                Console.WriteLine(errorMessage);
                // make evaluation variable reset
                returnValue = evaluationValue;
            }


            // return returnValue
            return returnValue;
        }


        // module to add a contact
        static Dictionary<string, string> AddContact(Dictionary<string, string> contacts, string newName, string newPhoneNumber)
        {
            // initialize return value
            Dictionary<string, string> returnValue = contacts;


            // processing


            if (contacts.ContainsKey(newName) && contacts.ContainsValue(newPhoneNumber))
            {
                Console.WriteLine("This contact already exists, so no contact was added.\n");
            }
            else if (contacts.ContainsKey(newName))
            {
                Console.WriteLine("A contact with this name and a different number already exists.\nSince the name is in use, no new contact was added.\n");
            }
            else
            {
                contacts.Add(newName, newPhoneNumber);
                // let the user know the contact has been added
                Console.WriteLine("Contact added successfully!\n");
            }


            // return returnValue
            return returnValue;
        }


        // module to remove a contact
        static Dictionary<string, string> RemoveContact(Dictionary<string, string> contacts, string nameToRemove)
        {
            // initialize return value
            Dictionary<string, string> returnValue = contacts;


            // processing


            // check if the contacts dictionary contains the name we are trying to remove
            if (contacts.ContainsKey(nameToRemove))
            {
                // remove the contact from the contacts
                contacts.Remove(nameToRemove);

                // let the user know the contact has been added
                Console.WriteLine("Contact successfully removed!\n");
            }
            // if contacts does not contain the name
            else
            {
                // Tell the user the contact doesn't exist and nothing happened
                Console.WriteLine("This contact doesn't exist, so no contact was removed.\n");
            }


            // return returnValue
            return returnValue;
        }



        // module to search for a contact
        static void SearchForContact(Dictionary<string, string> contacts, string searchValue)
        {
            // processing


            // declare variables
            bool foundMatch = false; // delcare a boolean value to check if a match has been found in the search


            // for each loop to go through all key value pairs in contacts
            foreach (KeyValuePair<string, string> kvp in contacts)
            {
                // check if the name in the contacts dictionary is the same as the search value
                if (kvp.Key == searchValue)
                {
                    //output results
                    Console.WriteLine("Results:");
                    // output the searched name
                    Console.WriteLine("Name: {0}", kvp.Key);
                    // output the searched value
                    Console.WriteLine("Phone Number: {0}", kvp.Value);
                    // add line gap for readability
                    Console.WriteLine();
                    foundMatch = true;
                    break;
                }
            }

            if (foundMatch == false)
            {
                Console.WriteLine($"The name {searchValue} was not found.\n");
            }
        }



        // module to display all contacts
        static void DisplayContacts (Dictionary<string, string> contacts)
        {
            // check if there is nothing in the contacts list
            if (contacts.Count == 0)
            {
                // display 'empty' if there are no contacts
                Console.WriteLine("Empty");
                // insult the user if they have no contacts.
                Console.WriteLine("Make Friends\n");
            }

            // for each loop to go through all key value pairs in contacts
            foreach (KeyValuePair<string, string> kvp in contacts)
            {
                // display the key/name
                Console.WriteLine("Name: {0}", kvp.Key);
                // display the value/phone number
                Console.WriteLine("Phone Number: {0}", kvp.Value);
                // add line gap for readability
                Console.WriteLine();
            }
        }






        static void Main(string[] args)
        {
            // objective: create a contact storage application.
            // include 5 switch-case options with numbers
            // add contact, remove contact, search contact,
            // display all contacts, exit
            // use a dictionary or hash table


            // processing


            // Declarations
            Dictionary<string, string> contacts = new Dictionary<string, string> { };    // empty dictionary
            int userSelection = Int32.MinValue; // declaration for the userSelection integer variable
            string newName = "";        // delcare a string variable to hold new name inputs
            string newPhoneNumber = "";     // delcare a string variable to hold new phone number inputs
            string searchName = "";     // delcare a string variable to hold the search name inputs
            string removalName = "";        // delcare a string variable to hold the name removal inputs
            string removalPhoneNumber = "";     // delcare a string variable to hold phone number removal inputs


            // Display Application name
            Console.WriteLine("Welcome to the Contact Management application\n");



            // output the options to the user with their number



            // Output to tell the user they can type 1 to add a Contact
            Console.WriteLine("1. Add Contact\n");

            // Output to tell the user they can type 2 to remove a Contact
            Console.WriteLine("2. Remove Contact\n");

            // Output to tell the user they can type 3 to search for a contact
            Console.WriteLine("3. Search Contact\n");

            // Output to tell the user they can type 4 to display all contacts
            Console.WriteLine("4. Display All Contacts\n");

            // Output to tell the user they can type 5 to exit the application
            Console.WriteLine("5. Exit\n");



            // A do while loop to run the program and allow continuous choice.
            do
            {
                // do while loop to make sure the user selection is within range
                do
                {
                    // ask for and recieve user choice as an integer number
                    userSelection = HandleIntInput("Enter your choice: ");
                    // line break for readability
                    Console.Write("\n");

                    // make sure the integer input is between 1 and 5. If interger is not, reset user selection to Int32 min value
                    userSelection = CheckIntRange(userSelection, 1, 5, Int32.MinValue, "Your input was out of range. Make sure your number is between 1 and 5.\n");
                }
                while (userSelection == Int32.MinValue);


                // check if the user selection is 5, leave the while loop
                if (userSelection == 5)
                {
                    // leave the while loop
                    break;
                }


                // use a switch case to perform an operation based on the selection
                switch (userSelection)
                {
                    // Run this case if selection = 1
                    case 1:
                        // get name input and ensure it is valid
                        newName = HandleStringInput("Enter contact name: ");
                        // line break for readability
                        Console.Write("\n");


                        // get name input and ensure it is valid
                        newPhoneNumber = HandleStringInput("Enter phone number: ");
                        // line break for readability
                        Console.Write("\n");


                        // add the new grade to the list of grades
                        AddContact(contacts, newName, newPhoneNumber);


                        // Jump out of switch here.
                        break;


                    // Run this case if selection = 2
                    case 2:                        
                        // get name input and ensure it is valid
                        removalName = HandleStringInput("Enter contact name to remove: ");
                        // line break for readability
                        Console.Write("\n");
                        
                        
                        // remove the contact from the list of contacts
                        RemoveContact(contacts, removalName);


                        // Jump out of switch here.
                        break;


                    // Run this case if selection = 3
                    case 3: 
                        // get name input and ensure it is valid
                        searchName = HandleStringInput("Enter contact name to search for: ");
                        // line break for readability
                        Console.Write("\n");
                        
                        
                        // remove the contact from the list of contacts
                        SearchForContact(contacts, searchName);


                        // Jump out of switch here.
                        break;


                    // Run this case if selection = 4
                    case 4:
                        // Display all contacts
                        Console.WriteLine("Contact List\n");
                        DisplayContacts(contacts);
                        
                        // Jump out of switch here.
                        break;


                    default:
                        // Output a polite message in case of unforseen error.
                        Console.WriteLine("It seems something went wrong on our end. Please try again.");

                        // Jump out of switch here.
                        break;
                }

                // prompt user to continue the loop
                Console.WriteLine("Select what you would like to do next or quit.\n");


                // reset the evaluation variable
                userSelection = Int32.MinValue;
            }
            while (userSelection == Int32.MinValue);


            // Thank user for using the program
            Console.WriteLine("Thank you for using this program! Come again!");
            

            // Pause at the end of program for user to read
            Console.Read();

        }
    }
}
