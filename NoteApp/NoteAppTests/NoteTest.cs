using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Model;
using NUnit.Framework;

namespace NoteAppTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;
        private DateTime _dateTimeNow = DateTime.Now;

        [SetUp]
        public void Test()
        {
            _note = new Note(_dateTimeNow);
            _note.Title = "Title";
            _note.Text = "Text";
            _note.Category = NoteCategory.Documents;
            
        }

        [Test(Description = "Позитивный тест конструктора")]
        public void TestNote_CorrectValue()
        {
            //Новое значение для проверки
            var expected = new Note(_dateTimeNow);

            //Идеальное значение для проверки
            var actual = _note;

            Assert.AreEqual(expected.CreatedTime, actual.CreatedTime, "Некорректное значение даты создания");
        }

        [Test(Description = "Негативный тест конструктора")]
        public void TestNote_IncorrectValue()
        {
            var time = _dateTimeNow.AddDays(365);

            Assert.Throws<ArgumentException>(() =>
            {
                var note = new Note(time);
            }, "Должно возникать исключение, если дата создания заметки находится в будущем времени");
        }

        [Test(Description = "Позитивный тест времени изменения")]
        public void TestLastChangeTime_CorrectValue()
        {
            //Новое значение для проверки
            var expected = new Note(_dateTimeNow);

            //Идеальное значение для проверки
            var actual = _note;

            Assert.AreEqual(expected.LastChangeTime, actual.LastChangeTime, "Некорректное значение даты изменения");
        }

        [Test(Description = "Негативный тест времени изменения")]
        public void TestLastChangeTime_IncorrectValue()
        {
            var time = _dateTimeNow.AddDays(365);

            Assert.Throws<ArgumentException>(() => { _note.LastChangeTime = time; },
                "Должно возникать исключение, если дата изменения заметки находится в будущем времени");
        }

        [Test(Description = "Позитивный тест заголовка")]
        public void TestTitle_CorrectValue()
        {
            //Новое значение для проверки
            var expected = new Note(_dateTimeNow);
            expected.Title = "Title";
            //Идеальное значение для проверки
            var actual = _note;

            Assert.AreEqual(expected.Title, actual.Title, "Некорректное значение заголовка");
        }

        [Test(Description = "Позитивный тест текста")]
        public void TestText_CorrectValue()
        {
            //Новое значение для проверки
            var expected = new Note(_dateTimeNow);
            expected.Text = "Text";
            //Идеальное значение для проверки
            var actual = _note;

            Assert.AreEqual(expected.Text, actual.Text, "Некорректное значение текста");
        }

        [Test(Description = "Негативный тест заголовка")]
        public void TestTitle_IncorrectValue()
        {
            var title = string.Empty;

            Assert.Throws<ArgumentException>(() => { _note.Title = title; },
                "Должно возникать исключение, если заголовок заметки пустой");
        }

        [Test(Description = "Негативный тест текста")]
        public void TestText_IncorrectValue()
        {
            var text = string.Empty;

            Assert.Throws<ArgumentException>(() => { _note.Text = text; },
                "Должно возникать исключение, если текст заметки пустой");
        }

        [Test(Description = "Негативный тест заголовка")]
        public void TestTitle1_IncorrectValue()
        {
            var title = "ппппппппппппппппппппппппппппппппппппппппппппппппппп";

            Assert.Throws<ArgumentException>(() => { _note.Title = title; },
                "Должно возникать исключение, если длина заголовка заметки больше 50 символов");
        }

        [Test(Description = "Позитивный тест категории")]
        public void TestCategory_CorrectValue()
        {
            //Новое значение для проверки
            var expected = new Note(_dateTimeNow);
            expected.Category = NoteCategory.Documents;
            //Идеальное значение для проверки
            var actual = _note;

            Assert.AreEqual(expected.Category, actual.Category, "Некорректное значение категории");
        }

        [Test(Description = "Позитивный тест клонирования")]
        public void TestClone_CorrectValue()
        {
            //Новое значение для проверки
            var expected = (Note)_note.Clone();
            //Идеальное значение для проверки
            var actual = _note;

            Assert.AreEqual(expected.Text, actual.Text, "Некорректное значение клонирования");
        }
    }
}
