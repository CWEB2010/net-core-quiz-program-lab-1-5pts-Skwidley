using System;

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
				{"A) 2.2", "B) 2.0", "C) 2.0.2", "D) 2.3.1"},
				{"A) Building Websites", "B) Creating Services", "C) Hosting Websites", "D) Building Console Apps"},
				{"A) github.com/core", "B) github.com/core/dotnet", "C) github.com/dotnet", "D) github.com/dotnet/core"},
				{"A) Razor", "B) CoreCLR", "C) CoreRT", "D) CoreFX"}
			};

			string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
		}
    }
}
