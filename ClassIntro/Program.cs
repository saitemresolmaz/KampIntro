using System;

namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			Course course1 = new Course()
			{
				CourseName = "C# Programming",
				Instructor = "Emre Solmaz",
				ViewRate = 75
			};

			Course course2 = new Course();
			course2.CourseName = "Java";
			course2.Instructor = "Kaan Korukluoglu";
			course2.ViewRate = 80;

			Course[] courses = new Course[] { course1, course2 };  //içinde kursları tutan Course tipinde bir array tanımladık.

			foreach (Course course in courses)
			{
				Console.WriteLine(course.CourseName + " ,"+course.Instructor);
			}
			int a = 4, b = 5;
			string result;
			result = a > b ? "a is greater than b" : a < b ? "b is greater than a" : "a is equal to b";
			Console.WriteLine(result);

		}
	}

	class Course
	{
		public string CourseName { get; set; } //prop (property kısaltması) yazip tab tab yapiyoruz.
		public string Instructor { get; set; } //Instructor = egitmen
		public int ViewRate { get; set; }  //Viewrate =izlenmeOrani
	}
}
