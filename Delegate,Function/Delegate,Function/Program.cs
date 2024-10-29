namespace Delegate_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region person
            List<Person> people = new List<Person>
        {
            new Person("Kamil", "ov", 25),
            new Person("Elvin", "ova", 19),
            new Person("Aysel", "Mamedova", 22),
            new Person("Kamil", "Aliyev", 30),
            new Person("Nigar", "Quliyeva", 18),
            new Person("Orxan", "ov", 21)
        };


            List<Person> kamilPersons = people.FindAll(p => p.Name == "Kamil");
            Console.WriteLine("Adi Kamil olan shexsler:");
            foreach (Person person in kamilPersons)
            {
                Console.WriteLine($"{person.Name} {person.Surname}, Yash: {person.Age}");
            }


            List<Person> surnameFiltered = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
            Console.WriteLine("\nSoyadi 'ov' ve ya 'ova' ile biten shexsler:");
            foreach (Person person in surnameFiltered)
            {
                Console.WriteLine($"{person.Name} {person.Surname}, Yaş: {person.Age}");
            }


            List<Person> ageFiltered = people.FindAll(p => p.Age > 20);
            Console.WriteLine("\nYashi 20-dan boyuk olan shexsler:");
            foreach (Person person in ageFiltered)
            {
                Console.WriteLine($"{person.Name} {person.Surname}, Yash: {person.Age}");
            }

            #endregion
            List<Exam> exams = new List<Exam>
        {
            new Exam("Mathematics", TimeSpan.FromHours(2), DateTime.Now.AddDays(-3)),
            new Exam("Physics", TimeSpan.FromHours(1.5), DateTime.Now.AddDays(-5)),
            new Exam("Chemistry", TimeSpan.FromHours(3), DateTime.Now.AddDays(2)),
            new Exam("Biology", TimeSpan.FromHours(2.5), DateTime.Now.AddDays(6)),
            new Exam("History", TimeSpan.FromHours(1), DateTime.Now.AddDays(-1)),
            new Exam("Geography", TimeSpan.FromHours(2), DateTime.Now.AddHours(-1))
        };

            DateTime oneWeekAgo = DateTime.Now.AddDays(-7);
            DateTime now = DateTime.Now;

            
            var upcomingExams = exams.Where(e => e.StartDate >= oneWeekAgo && e.StartDate <= now.AddDays(7));
            Console.WriteLine("\n\nSon 1 hefte erzinde olan imtahanlar:");
            foreach (var exam in upcomingExams)
            {
                Console.WriteLine($"Movzu: {exam.Subject}, Muddet: {exam.ExamDuration.TotalHours} saat");
            }

          
            var longDurationExams = exams.Where(e => e.ExamDuration.TotalHours > 2);
            Console.WriteLine("\n2 saatdan uzun cheken imtahanlar:");
            foreach (var exam in longDurationExams)
            {
                Console.WriteLine($"Movzu: {exam.Subject}, Muddet: {exam.ExamDuration.TotalHours} saat");
            }

           
            var ongoingExams = exams.Where(e => e.StartDate <= now && e.EndDate >= now);
            Console.WriteLine("\nBashlayib amma bitmemish imtahanlar:");
            foreach (var exam in ongoingExams)
            {
                Console.WriteLine($"Movzu: {exam.Subject}, Time: {exam.ExamDuration.TotalHours} hour");
            }
        }
    }
}
