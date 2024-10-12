using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCollector.Core.Models
{
    public class Film
    {
        public Guid Id { get; }
        public string Title { get; } = string.Empty;
        public string Description { get;} = string.Empty;

        public const int MAX_TITLE_LENGTH = 256;

        private Film(Guid id, string title, string description)
        {
            Id = id;
            Title = title; 
            Description = description;
        }

        public static (Film Film, string Error) Create(Guid id, string title, string description)
        {
            var error = string.Empty;
            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
            {
                error = "Превышен размер для заголовка";
            }
            var film = new Film(id, title, description);
            return (film, error);
        }
    }
}
