using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NoteApp.Model;
using NUnit.Framework;

namespace NoteAppTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private Note _note;
        private Project _project;

        [SetUp]
        public void Test()
        {
            _note = new Note(DateTime.Now);
            _note.Text = "note";
            _project = new Project();
            _project.ListNotes.Add(_note);
        }

        [Test(Description = "Позитивный тест сериализации. Сохранение")]
        public void TestProjectManagerSaveTToFile_CorrectValue()
        {
            ProjectManager.SaveToFile(_project, ProjectManager.PathToDocuments);

            var actual = ProjectManager.Load(ProjectManager.PathToDocuments).ListNotes.Last();
            Assert.AreEqual(_note.Text, actual.Text, "Сериализация работает неверно!");
        }

        [Test(Description = "Сохранение в неверный путь.")]
        public void TestProjectManagerSaveToFile_NotCorrectPath()
        {
            Assert.Throws<System.IO.IOException>(() => { ProjectManager.SaveToFile(_project, "c:\\distribution\\"); },
                "Должно возникать исключение, если путь неверен.");
        }

        [Test(Description = "Открытие из неверного пути.")]
        public void TestProjectManagerLoadFromFile_NotCorrectPath()
        {
            Assert.Throws<System.IO.FileNotFoundException>(() =>
            {
                var project = ProjectManager.Load("c:\\distribution\\");
            }, "Должно возникать исключение, если путь неверен.");
        }

        [Test(Description = "Открытие испорченного файла пути.")]
        public void TestProjectManagerLoadFromFile_NotCorrectFile()
        {
            var text = "I not correct file";
            var fileName = "C:\\Users\\Anna\\test.txt";
            File.WriteAllText(fileName, text);
            Assert.Throws<JsonReaderException>(() =>
            {
                var project = ProjectManager.Load(fileName);
            }, "Должно возникать исключение, если файл испорчен.");
        }
    }
}