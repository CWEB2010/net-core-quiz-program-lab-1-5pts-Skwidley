﻿using System;

namespace lab_one
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] quizQuestions = new string[]
			{
				"1. Who created .Net Core?",
				"2. When was .Net Core released?",
				"3. What license does .Net Core use?",
				"4. When was .Net Core 2.0 Released?",
				"5. When was .Net Core 3.0 Announced?",
				"6. Which Language does .Net Core not have support for?",
				"7. What is the current .Net Core version?",
				"8. Which one of these is .Net Core not used for?",
				"9. What is the .Net github repository?",
				"10. Which of these packages is not included with .Net Core?"
			};

			string[,] quizAnswers = new string[10, 4]{
				{"A) Apple", "B) .Net Foundation", "C) Microsoft", "D) Amazon"},
				{"A) 2015", "B) 2016", "C) 2006", "D) 2013"},
				{"A) GNU GPL ", "B) GNU LGPL", "C) MIT License", "D) BSD 3"},
				{"A) 2017", "B) 2015", "C) 2013", "D) 2018"},
				{"A) 2017", "B) 2015", "C) 2013", "D) 2018"},
				{"A) Ruby", "B) C#", "C) F#", "D) VB .NET"},
				{"A) 3.1.1", "B) 2.0", "C) 2.0.2", "D) 2.3.1"},
				{"A) Building Websites", "B) Creating Services", "C) Hosting Websites", "D) Building Console Apps"},
				{"A) github.com/core", "B) github.com/core/dotnet", "C) github.com/dotnet", "D) github.com/dotnet/core"},
				{"A) Razor", "B) CoreCLR", "C) CoreRT", "D) CoreFX"}
			};

			string EXIT = "";
			string tempAnswer = "";
			string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
			string[] wrongAnswers = { };
			int amntCorrect = 0;

			Housekeeping();

			while (EXIT != "Q")
			{
				Console.Clear();
				for (int i = 0; i < quizQuestions.Length; i++)
				{
					Console.WriteLine(quizQuestions[i]);
					Console.WriteLine("");
					for (int j = 0; j < 4; j++)
					{
						Console.WriteLine(quizAnswers[i, j]);
					}
					Console.WriteLine("");
					tempAnswer = Console.ReadLine();
					tempAnswer = tempAnswer.ToUpper();
					if (tempAnswer == answerKey[i])
					{
						amntCorrect++;
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Correct!");
						Console.ResetColor();
						Console.WriteLine("Press <ENTER> to move on to the next question");
						while (Console.ReadKey().Key != ConsoleKey.Enter) { }
						Console.Clear();

					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Incorrect");
						Console.ResetColor();
						Console.WriteLine("Press <ENTER> to move on to the next question");
						while (Console.ReadKey().Key != ConsoleKey.Enter) { }
						Console.Clear();
					}
				}
				if (amntCorrect >= 6)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Congratulations! You have passed!");
					Console.ResetColor();
					Console.WriteLine("You got a score of {0}/10", amntCorrect);
					WrongAnswers(wrongAnswers);
					Console.WriteLine("Press any key to take the quiz again or enter 'Q' to quit.");
					EXIT = Console.ReadLine();
					EXIT = EXIT.ToUpper();
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Sorry, you have failed the quiz.");
					Console.ResetColor();
					Console.WriteLine("You got a score of {0}/10", amntCorrect);
					WrongAnswers(wrongAnswers);
					Console.WriteLine("If you would like to take the quiz again enter any key. Or press 'Q' to quit");
					EXIT = Console.ReadLine();
					EXIT = EXIT.ToUpper();
				}
			}
		}
		public static void Housekeeping()
		{
			Console.WriteLine("Welcome to the .Net Core Quiz.");
			Console.WriteLine("Press enter to begin");
			while (Console.ReadKey().Key != ConsoleKey.Enter) { }
		}

		public static void WrongAnswers(string[] wrongAnswers)
		{
			Console.WriteLine("The questions you got wrong were;");
			for (int x = 0; x < wrongAnswers.Length; x++)
			{
				Console.WriteLine(wrongAnswers[x]);
			}
		}
	}
}
