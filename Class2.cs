using UniversityLibrary;

namespace UniversityLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly string RecordBookNumber;
        public string Group { get; set; }
        public string Institute { get; set; }
        public readonly StudyLevel Level;

        public Student(string name, string surname, string recordBookNumber, string group, string institute, StudyLevel level)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            RecordBookNumber = recordBookNumber ?? throw new ArgumentNullException(nameof(recordBookNumber));
            Group = group ?? throw new ArgumentNullException(nameof(group));
            Institute = institute ?? throw new ArgumentNullException(nameof(institute));
            Level = level;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[3];
            info[0] = $"{Name} {Surname}";
            info[1] = $"Номер зачетной книжки: {RecordBookNumber}. Группа: {Group}. Институт: {Institute}";
            
            string level;
            switch (Level)
            {
                case StudyLevel.Bachelor:
                    level = "бакалавриат";
                    break;
                case StudyLevel.Specialist:
                    level = "специалитет";
                    break;
                case StudyLevel.Master:
                    level = "магистратура";
                    break;
                default:
                    level = "неизвестно";
                    break;
            }
            
            info[2] = $"Уровень обучения: {level}";
            return info;
        }
    }
}