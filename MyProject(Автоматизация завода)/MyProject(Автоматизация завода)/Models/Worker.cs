﻿namespace MyProject.Models
{
    public class Worker : Person
    {
        public string Role { get; set; } // занимаемая должность, и чем он занимается

        public void ShowInfoAboutWorker(Person person, string role)
        {
            Console.WriteLine($"Full Name: {person.FullName}, Role: {role}, BirthDay: {person.Birthday}");
        }

        public override void DoWork()
        {
            base.DoWork();

            Console.WriteLine("I am done " + GetType().Name + " from overwriten method");
        }
    }
}
