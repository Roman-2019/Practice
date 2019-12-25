using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13
{
    public struct Abonement 
    {
        Guid Id { get; set; }
        DateTime EndDate { get; set; }
        Human Human { get; set; }
    }
    public abstract class Human 
    {
        public string Name { get; private set; }
    }


    public class Admin 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public interface IGym 
    {

    }

    public class Gym
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Admin CurrentAdmin { get; set; }

        public List<Section> Sections = new List<Section>();
        public List<Abonement> Abonements { get; set; }
    }

    public interface IfitnessClub 
    {
        // bool Act { get; }// не отвечает не за какое поведение - это не правильно - все залы можно назвать фитнесзалом
        List<Schedule> GetFitnessSchedule();
    }

    public abstract class Schedule 
    {
        public Section Section { get; set; }
        public Human Trainer { get; set; }
    }

    public class Section 
    {
        public string Name { get; set; }
        public SectionType Type { get; set; }
    }

    public enum SectionType 
    {
        Fitness
    }
}
