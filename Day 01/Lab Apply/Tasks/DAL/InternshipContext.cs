using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class InternshipContext
    {
        public static List<Track> Tracks = new List<Track>
        {
            new Track
            {
                Id = 1,
                Name = "Front-End Development",
                Description = "Learn HTML, CSS, and JavaScript to build responsive web interfaces"
            },
            new Track
            {
                Id = 2,
                Name = "Back-End Development",
                Description = "Master C#, ASP.NET, and database design for server-side applications"
            },
            new Track
            {
                Id = 3,
                Name = "Mobile Development",
                Description = "Develop cross-platform mobile applications using MAUI and Xamarin"
            },
            new Track
            {
                Id = 4,
                Name = "Data Science",
                Description = "Analyze and visualize data using Python and machine learning techniques"
            },
            new Track
            {
                Id = 5,
                Name = "DevOps & Cloud",
                Description = "Deploy and manage applications on cloud platforms like Azure and AWS"
            }
        };

        public static List<Trainee> Trainees = new List<Trainee>
        {
            new Trainee
            {
                Id = 1,
                Name = "Amira Hassan",
                Email = "amira@test.com",
                Gender = Gender.Female,
                MobileNo = "01001234567",
                DateOfBirth = new DateTime(2000, 5, 15),
                IsGraduated = false
            },
            new Trainee
            {
                Id = 2,
                Name = "Ahmed Mohamed",
                Email = "ahmed@test.com",
                Gender = Gender.Male,
                MobileNo = "01002345678",
                DateOfBirth = new DateTime(1999, 8, 22),
                IsGraduated = true
            },
            new Trainee
            {
                Id = 3,
                Name = "Noor Khalil",
                Email = "noor@test.com",
                Gender = Gender.Female,
                MobileNo = "01003456789",
                DateOfBirth = new DateTime(2001, 3, 10),
                IsGraduated = false
            },
            new Trainee
            {
                Id = 4,
                Name = "Omar Ibrahim",
                Email = "omar@test.com",
                Gender = Gender.Male,
                MobileNo = "01004567890",
                DateOfBirth = new DateTime(2000, 11, 28),
                IsGraduated = false
            },
            new Trainee
            {
                Id = 5,
                Name = "Layla Youssef",
                Email = "layla@test.com",
                Gender = Gender.Female,
                MobileNo = "01005678901",
                DateOfBirth = new DateTime(1999, 6, 5),
                IsGraduated = true
            }
        };
    }
}
