using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Model;
using NUnit.Framework;

namespace NoteAppTests
{
    [TestFixture]
    public class ProjectTest
    {
        private Project _project;
        private DateTime _dateTime = DateTime.Now;
        private Note _note;

        [SetUp]
        public void Test()
        {
            _project = new Project();
            _note = new Note(_dateTime);
            _project.ListNotes.Add(_note);
        }

        [Test(Description = "Позитивный тест добавления в список")]
        public void TestAddToNoteList_CorrectValue()
        {
            var expected = new Project();
            expected.ListNotes.Add(_note);

            var actual = _project;
            
            Assert.AreEqual(expected.ListNotes.First().CreatedTime,
                actual.ListNotes.First().CreatedTime, "Некорректно инициализируется список");
        }

        [Test(Description = "Позитивный тест сортировки")]
        public void TestSort_CorrectValue()
        {
            var newDateTimeNow = DateTime.Now;
            var expected = new Project();
            _note.LastChangeTime = newDateTimeNow;
            expected.ListNotes.Add(_note);
            expected.Sort();

            var actual = newDateTimeNow;

            Assert.AreEqual(expected.ListNotes.First().LastChangeTime,
               actual , "Некорректно проходит сортировка");
        }
    }
}
