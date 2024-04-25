namespace Task1
{
    public abstract class SoundPath
    {
        public abstract string Language { get; }
    }

    public abstract class Subtitle
    {
        public abstract string Language { get; }
    }

    public class EnglishSoundPath : SoundPath
    {
        public override string Language => "English";
    }

    public class EnglishSubtitle : Subtitle
    {
        public override string Language => "English";
    }
    public class RussionSoundPath : SoundPath
    {
        public override string Language => "Russion";
    }

    public class RussionSubtitle : Subtitle
    {
        public override string Language => "Russion";
    }




    public class Movie
    {
        public string Name { get; }
        public SoundPath SoundPath { get; }
        public Subtitle Subtitle { get; }
        public Movie(string name, SoundPath soundPath, Subtitle subtitle)
        {
            Name = name;
            SoundPath = soundPath;
            Subtitle = subtitle;
        }
    }


    public class Cinema
    {
        public List<Movie> movies = new List<Movie>();
        public void OrderMovie(Movie movie)
        {
            movies.Add(movie);
            AddEvent?.Invoke(this, new Add() { Movie = movie });
        }
        public event EventHandler<Add>? AddEvent;
    }
    public class Add : EventArgs
    {
        public Movie Movie { get; set; }
    }
}
