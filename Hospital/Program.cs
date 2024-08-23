using System;
using System.IO;
class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("If you want to login as doctor type doctor or if you want to login as admin type admin");

        string doctorLogin = "doctor";
        string adminLogin = "admin";

        string loginAs = "";

        bool trueS = true;

        string adminUsername = "admin";
        string adminPassword = "123456";

        string doctorPassword = "123456";

        int cursorLeft = Console.CursorLeft;
        int cursorTop = Console.CursorTop;

        while (trueS)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Your choice: ");
            Console.ForegroundColor = ConsoleColor.White;

            loginAs = Console.ReadLine();

            if (loginAs == adminLogin || loginAs == doctorLogin)
            {
                Console.WriteLine("");
                trueS = false;
            }
            else
            {
                Console.SetCursorPosition(0, cursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, cursorTop - 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please try again:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, cursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, cursorTop);
            }
        }//typing doctor or admin corrector
        Console.Clear();

        string username = "";
        string password = "";

        //admin login
        if (loginAs == adminLogin)
        {
            trueS = true;
            Console.WriteLine("Please type username");
            Console.WriteLine("");
            while (trueS)
            {
                Console.Write("Username: ");
                cursorLeft = Console.CursorLeft;
                cursorTop = Console.CursorTop;

                username = Console.ReadLine();

                if (username == adminUsername)
                {
                    trueS = false;
                }
                else
                {
                    Console.SetCursorPosition(0, cursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, cursorTop - 1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please try again:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, cursorTop);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, cursorTop);
                }
            }
            Console.WriteLine("");
            trueS = true;
            Console.WriteLine("Please type password");
            Console.WriteLine("");
            while (trueS)
            {
                Console.Write("Password: ");
                cursorLeft = Console.CursorLeft;
                cursorTop = Console.CursorTop;

                password = Console.ReadLine();

                if (password == adminPassword)
                {
                    trueS = false;
                }
                else
                {
                    Console.SetCursorPosition(0, cursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, cursorTop - 1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please try again:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, cursorTop);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, cursorTop);
                }
            }

            Console.Clear();

            //

            Console.WriteLine("Do you want to add doctor as admin");
            string yes = "yes";
            string no = "no";
            string yesNo = Console.ReadLine();
            Console.Clear();
            if (yesNo == yes)
            {
                // Prompt the user for the doctor's name
                Console.WriteLine("First and last name of doctor:");
                string firstLastNameDoctor = Console.ReadLine();

                // Sanitize the folder name to remove invalid characters
                string sanitizedFolderName = string.Concat(firstLastNameDoctor.Split(Path.GetInvalidFileNameChars()));

                // Ensure the folder name is valid
                if (string.IsNullOrWhiteSpace(sanitizedFolderName))
                {
                    Console.WriteLine("Invalid folder name. Please enter a valid name.");
                    return;
                }

                // Define the path for the new folder in the current working directory
                string folderPath = Path.Combine(Directory.GetCurrentDirectory(), sanitizedFolderName);

                // Create the folder
                Directory.CreateDirectory(folderPath);
                Console.WriteLine($"Folder '{sanitizedFolderName}' created successfully.");

                //////////////////////////////////////////////////////////////////////////////////////////////////////



                // Prompt the user for details to be written in the text file
                Console.WriteLine("Enter doctor speciality:");
                string doctorDetails = Console.ReadLine();

                // Define the path for the text file within the new folder
                string filePath = Path.Combine(folderPath, doctorDetails+".txt");

                // Create and write to the text file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(doctorDetails);
                }
                //patient
                string patientsFolderPath = Path.Combine(folderPath, "patients");

                // Create the "patients" folder
                Directory.CreateDirectory(patientsFolderPath);
                Console.WriteLine($"Subfolder 'patients' created in folder '{sanitizedFolderName}'.");

                Console.WriteLine($"Text file 'details.txt' created in folder '{sanitizedFolderName}' with the provided details.");
            }
            else if (yesNo == no)
            {
                Console.WriteLine("oke");
            }
        }

        if (loginAs == doctorLogin)
        {
            bool validUsername = false;
            Console.WriteLine("Please type the doctor's username (folder name):");
            Console.WriteLine("");
            while (!validUsername)
            {
                Console.Write("Username: ");
                cursorLeft = Console.CursorLeft;
                cursorTop = Console.CursorTop;

                username = Console.ReadLine();

                // Define the path for the doctor's folder
                string doctorFolderPath = Path.Combine(Directory.GetCurrentDirectory(), username);

                // Check if the folder exists
                if (Directory.Exists(doctorFolderPath))
                {
                    validUsername = true;
                    Console.WriteLine("Username is valid. Access granted.");
                    // Proceed with password check or other logic
                }
                else
                {
                    Console.SetCursorPosition(0, cursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, cursorTop - 1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Folder does not exist. Please try again:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, cursorTop);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, cursorTop);
                }
            }
        }
            Console.WriteLine("");
            trueS = true;
            Console.WriteLine("Please type password");
            Console.WriteLine("");
            while (trueS)
            {
                Console.Write("Password: ");
                cursorLeft = Console.CursorLeft;
                cursorTop = Console.CursorTop;

                password = Console.ReadLine();

                if (password == doctorPassword)
                {
                    trueS = false;
                }
                else
                {
                    Console.SetCursorPosition(0, cursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, cursorTop - 1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please try again:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, cursorTop);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, cursorTop);
                }
            }

            Console.Clear();

            //

            if (username == "Doktor Goran")
            {
                string doctorFolderPath = Path.Combine("Doktor Goran");

                // Check if the folder exists
                if (Directory.Exists(doctorFolderPath))
                {
                    Console.WriteLine($"Accessing folder: {doctorFolderPath}");
                    Console.WriteLine("");

                    // List files or handle the folder contents
                    string[] files = Directory.GetFiles(doctorFolderPath);
                    Console.WriteLine("Files in the folder:");
                    foreach (string file in files)
                    {
                        Console.WriteLine(Path.GetFileName(file));
                       
                    }
                    Console.WriteLine("Patient folder");


                    //patients add
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to add new patient?");
                    string yesNo = Console.ReadLine();
                    Console.Clear();
                    if (yesNo == "yes")
                    {
                        // Define the path for the "patients" folder
                        string patientsFolderPath = Path.Combine(doctorFolderPath, "patients");

                        // Create the "patients" folder
                        Directory.CreateDirectory(patientsFolderPath);

                        // Prompt the user for the patient's full name
                        Console.WriteLine("Enter the patient's full name:");
                        string patientFullName = Console.ReadLine();

                        // Sanitize the patient name to remove invalid characters
                        string sanitizedPatientName = string.Concat(patientFullName.Split(Path.GetInvalidFileNameChars()));

                        // Define the path for the new patient text file
                        string patientFilePath = Path.Combine(patientsFolderPath, sanitizedPatientName + ".txt");

                        // Create and write to the patient text file
                        using (StreamWriter writer = new StreamWriter(patientFilePath))
                        {
                            // Prompt the user for patient details
                            Console.WriteLine("Enter patient year of birth nn/nn/nnnn");
                            string patientDetails = Console.ReadLine();

                            // Write the patient details to the file
                            writer.WriteLine($"Full Name: {patientFullName}");
                            writer.WriteLine($"Birth Year: {patientDetails}");
                        }

                        Console.WriteLine($"Patient file '{sanitizedPatientName}.txt' created and updated with details in 'patients' folder.");

                    }

                    else if (yesNo == "no")
                    {
                        Console.Clear();
                    }



                    //details
                    Console.WriteLine("if you want to list patients type 1 if you want to see patient details type 2");
                    string OneOrTwo = Console.ReadLine();
                    Console.Clear();
                    if (OneOrTwo == "1")
                    {
                        // Define the path for the "patients" folder
                        string patientsFolderPath = Path.Combine(doctorFolderPath, "patients");

                        // Check if the "patients" folder exists
                        if (Directory.Exists(patientsFolderPath))
                        {
                            // Get all patient files in the folder
                            string[] patientFiles = Directory.GetFiles(patientsFolderPath);

                            Console.WriteLine("List of patients:");
                            foreach (string file in patientFiles)
                            {
                                // Print the file name (patient name) without the .txt extension
                                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                            }
                        }
                        else
                        {
                            Console.WriteLine("No patients found. The 'patients' folder does not exist.");
                        }
                    }
                    
                    else if (OneOrTwo == "2")
                    {
                        // Define the path for the "patients" folder
                        string patientsFolderPath = Path.Combine(doctorFolderPath, "patients");

                        // Check if the "patients" folder exists
                        if (Directory.Exists(patientsFolderPath))
                        {
                            // Prompt the user for the patient's full name
                            Console.WriteLine("Enter the full name of the patient:");
                            string patientFullName = Console.ReadLine();

                            // Sanitize the patient name to remove invalid characters
                            string sanitizedPatientName = string.Concat(patientFullName.Split(Path.GetInvalidFileNameChars()));

                            // Define the path for the patient's text file
                            string patientFilePath = Path.Combine(patientsFolderPath, sanitizedPatientName + ".txt");

                            // Check if the file exists
                            if (File.Exists(patientFilePath))
                            {
                                // Read and display the contents of the file
                                string fileContent = File.ReadAllText(patientFilePath);
                                Console.WriteLine("Patient details:");
                                Console.WriteLine(fileContent);
                            }
                            else
                            {
                                Console.WriteLine("Patient file does not exist.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No patients found. The 'patients' folder does not exist.");
                        }
                    }
                    // You can add code here to handle files or interact with them
                }
                else
                {
                    Console.WriteLine("Doctor's folder does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Invalid username.");
            }
        }



        

        
    }



