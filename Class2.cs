using System;
using System.Collections;
using System.Collections.Generic;

namespace UniversityLibrary
{
    public class Student : IComparable<Student>
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

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            
            int surnameComparison = Surname.CompareTo(other.Surname);
            if (surnameComparison != 0) return surnameComparison;
            
            return Name.CompareTo(other.Name);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Student other = (Student)obj;
            return Name == other.Name 
                && Surname == other.Surname 
                && RecordBookNumber == other.RecordBookNumber;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Name?.GetHashCode() ?? 0);
                hash = hash * 23 + (Surname?.GetHashCode() ?? 0);
                hash = hash * 23 + (RecordBookNumber?.GetHashCode() ?? 0);
                return hash;
            }
        }

        public virtual string[] GetInfo()
        {
            var levelStr = Level switch
            {
                StudyLevel.Bachelor => "бакалавриат",
                StudyLevel.Specialist => "специалитет",
                StudyLevel.Master => "магистратура",
                _ => "неизвестно"
            };

            return new string[]
            {
                $"{Name} {Surname}",
                $"Номер зачетной книжки: {RecordBookNumber}. Группа: {Group}. Институт: {Institute}",
                $"Уровень обучения: {levelStr}"
            };
        }
    }

    public class AcademicGroup : IEnumerable<Student>
    {
        public string Name { get; set; }
        private List<Student> students;

        public int Count => students.Count;

        public AcademicGroup(string name, IEnumerable<Student> students)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            this.students = new List<Student>();
            
            foreach (var student in students)
            {
                if (!this.students.Contains(student))
                {
                    this.students.Add(student);
                }
            }
        }

        public IEnumerator<Student> GetEnumerator() => students.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class FullTimeStudent : Student
    {
        public double ExamScore { get; set; }

        public FullTimeStudent(string name, string surname, string recordBookNumber,
                             string group, string institute, StudyLevel level, double examScore)
            : base(name, surname, recordBookNumber, group, institute, level)
        {
            ExamScore = examScore;
        }

        public override string[] GetInfo()
        {
            var info = base.GetInfo();
            Array.Resize(ref info, info.Length + 1);
            info[^1] = $"Балл ЕГЭ: {ExamScore:F1}";
            return info;
        }
    }

    public class PartTimeStudent : Student
    {
        public string Workplace { get; set; }
        public string Position { get; set; }

        public PartTimeStudent(string name, string surname, string recordBookNumber,
                             string group, string institute, StudyLevel level,
                             string workplace, string position)
            : base(name, surname, recordBookNumber, group, institute, level)
        {
            Workplace = workplace ?? throw new ArgumentNullException(nameof(workplace));
            Position = position ?? throw new ArgumentNullException(nameof(position));
        }

        public override string[] GetInfo()
        {
            var info = base.GetInfo();
            Array.Resize(ref info, info.Length + 1);
            info[^1] = $"Место работы: {Workplace}. Должность: {Position}";
            return info;
        }
    }

    public class ContractStudent : Student
    {
        public string TargetCompany { get; set; }
        public decimal TuitionFee { get; set; }

        public ContractStudent(string name, string surname, string recordBookNumber,
                             string group, string institute, StudyLevel level,
                             string targetCompany, decimal tuitionFee)
            : base(name, surname, recordBookNumber, group, institute, level)
        {
            TargetCompany = targetCompany ?? throw new ArgumentNullException(nameof(targetCompany));
            TuitionFee = tuitionFee;
        }

        public override string[] GetInfo()
        {
            var info = base.GetInfo();
            Array.Resize(ref info, info.Length + 1);
            info[^1] = $"Целевое предприятие: {TargetCompany}. Сумма обучения: {TuitionFee:C}";
            return info;
        }
    }
}