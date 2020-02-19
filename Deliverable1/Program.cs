﻿using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define essential variables
            string vacationType;
            string destination = "destination";
            int groupSize;
            string travelSuggestion = "first class";
            // Define loop variables
            bool vacationTypeError;
            bool groupSizeError;
            string anotherTrip;

            // Ask questions
            do {
                // Ask vacation type
                do {
                    vacationTypeError = false;
                    Console.WriteLine("What kind of trip would you like to go on; musical, tropical, or adventurous?");
                    vacationType = Console.ReadLine();

                    // Determine destination
                    if (vacationType == "musical")
                    {
                        destination = "New Orleans";
                    }
                    else if (vacationType == "tropical")
                    {
                        destination = "a beach vacation in Mexico";
                    }
                    else if (vacationType == "adventurous")
                    {
                        destination = "the Grand Canyon for whitewater rafting";
                    }
                    else
                    {
                        Console.WriteLine("This vacation type is not supported.");
                        vacationTypeError = true;
                    }
                } while( vacationTypeError == true );

                // Ask group size
                do
                {
                    groupSizeError = false;
                    Console.WriteLine("How many are in your group?");
                    int.TryParse(Console.ReadLine(), out groupSize);

                    // Determine travel suggestion
                    if (groupSize >= 1 && groupSize <= 2)
                    {
                        travelSuggestion = "first class";
                    }
                    else if (groupSize >= 3 && groupSize <= 5)
                    {
                        travelSuggestion = "a helicopter";
                    }
                    else if (groupSize >= 6)
                    {
                        travelSuggestion = "a charter flight";
                    }
                    else if (groupSize < 1)
                    {
                        Console.WriteLine("Group size must be one or more.");
                        groupSizeError = true;
                    }
                } while( groupSizeError == true );

                // Ouput travel suggestion and destination
                Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take " + travelSuggestion + " to " + destination + ".");
                Console.WriteLine("Would you like to plan another trip?");
                anotherTrip = Console.ReadLine();

            } while( anotherTrip == "yes" || anotherTrip == "y"); 
            
        }
    }
}