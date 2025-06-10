using NUnit.Framework;
using UniversityLibrary;

namespace UniversityLibrary.UnitTests
{
    [TestFixture]
    public class StudentUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var student = CreateTestStudent();
            
            Assert.That(student.Name, Is.EqualTo("Иван"));
            Assert.That(student.Surname, Is.EqualTo("Петров"));
            Assert.That(student.RecordBookNumber, Is.EqualTo("12345"));
            Assert.That(student.Group, Is.EqualTo("ИТ-21"));
            Assert.That(student.Institute, Is.EqualTo("Институт информационных технологий"));
            Assert.That(student.Level, Is.EqualTo(StudyLevel.Bachelor));
        }

        [Test]
        public void GetInfoTest()
        {
            var student = CreateTestStudent();
            var info = student.GetInfo();
            
            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Иван Петров"));
            Assert.That(info[1], Is.EqualTo("Номер зачетной книжки: 12345. Группа: ИТ-21. Институт: Институт информационных технологий"));
            Assert.That(info[2], Is.EqualTo("Уровень обучения: бакалавриат"));
        }

        [Test]
        public void RecordBookNumberNullTest()
        {
            Assert.Throws<ArgumentNullException>(() => 
                new Student("Иван", "Петров", null, "ИТ-21", "Институт информационных технологий", StudyLevel.Bachelor));
        }

        [Test]
public void FullTimeStudentGetInfoTest()
{
    var student = new FullTimeStudent(
        "Иван", "Петров", "12345", "ИТ-21", 
        "Институт информационных технологий", StudyLevel.Bachelor, 85.5);
    
    var info = student.GetInfo();
    
    Assert.That(info.Length, Is.EqualTo(4));
    Assert.That(info[3], Is.EqualTo($"Балл ЕГЭ: {85.5:F1}")); // Ожидаем форматированный вывод
}

        [Test]
        public void PartTimeStudentGetInfoTest()
        {
            var student = new PartTimeStudent(
                "Иван", "Петров", "12345", "ИТ-21", 
                "Институт информационных технологий", StudyLevel.Bachelor,
                "ООО Технологии", "Разработчик");
            
            var info = student.GetInfo();
            
            Assert.That(info.Length, Is.EqualTo(4));
            Assert.That(info[3], Is.EqualTo("Место работы: ООО Технологии. Должность: Разработчик"));
        }

        [Test]
        public void ContractStudentGetInfoTest()
        {
            var student = new ContractStudent(
                "Иван", "Петров", "12345", "ИТ-21", 
                "Институт информационных технологий", StudyLevel.Bachelor,
                "Яндекс", 150000m);
            
            var info = student.GetInfo();
            
            Assert.That(info.Length, Is.EqualTo(4));
            Assert.That(info[3], Does.Contain("Целевое предприятие: Яндекс"));
            Assert.That(info[3], Does.Contain("Сумма обучения"));
        }

        private Student CreateTestStudent()
        {
            return new Student(
                "Иван", 
                "Петров", 
                "12345", 
                "ИТ-21", 
                "Институт информационных технологий", 
                StudyLevel.Bachelor);
        }
    }
}