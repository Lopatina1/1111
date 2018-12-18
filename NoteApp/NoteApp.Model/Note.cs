using System;
using System.Data;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp.Model
{
    /// <summary>
    /// Класс, описывающий заметку.
    /// </summary>
    public class Note : ICloneable
    {

        [JsonProperty]
        public readonly DateTime CreatedTime;
        private DateTime _lastChangeTime;
        private string _title = "Без названия";
        private string _text;
        private DateTime _createdTime;
        private NoteCategory _noteCategory;

        /// <summary>
        /// Конструктор времени.
        /// </summary>
        public Note(DateTime createTime)
        {
            if (createTime <= DateTime.Now)
            {
                _lastChangeTime = createTime;
                CreatedTime = createTime;
            }

            else
            {
                throw new ArgumentException("Неверная дата.");
            }
        }

        /// <summary>
        /// Конструктор времени без аргумента.
        /// </summary>
        public Note()
        {
            CreatedTime = _lastChangeTime = DateTime.Now;
        }

        /// <summary>
        /// Время последнего изменения.
        /// </summary>
        public DateTime LastChangeTime
        {
            get
            {
                return _lastChangeTime;
            }
            set
            {
                if (value <= DateTime.Now)
                {
                    _lastChangeTime = value;
                }
                else
                {
                    throw new ArgumentException("Неверное время изменения заметки.");
                }
            }
        }

        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title
        {
            get
            {
                return _title; 
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Длина заголовка должна быть меньше 50 символов");
                }
                else if (value == string.Empty)
                {
                    throw new ArgumentException("Текст заголовка пуст!");
                }
                else
                    _title = value;
            }
        }


        /// <summary>
        /// Текст заметки.
        /// </summary>
        public string Text

        {
            get
            {
                return _text;
            }

            set
            {
                if (value.Length > 0)
                {
                    _text = value;
                }

                else
                {
                    throw new ArgumentException("Текст заметки отсутствует.");
                }

            }
        }


        /// <summary>
        /// Категория заметки.
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _noteCategory;
            }

            set
            {
                _noteCategory = value;
            }
               
        }

        /// <summary>
        /// Клонирование(для дублирования заметки).
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var newNote = new Note(CreatedTime);
            newNote.Title = _title;
            newNote.Text = _text;
            newNote.Category = _noteCategory;
            newNote.LastChangeTime = _lastChangeTime;
            return newNote;
        }

        public string ToString()
        {
            return $"{Title} {Text} {Category} {CreatedTime} {LastChangeTime} {Category}";
        }
    }
}