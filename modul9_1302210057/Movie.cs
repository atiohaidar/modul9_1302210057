namespace modul9_1302210057
{
    public class Movie
    {
        public String title { get; set; }
        public String director { get; set; }
        public List<String> start { get; set; }
        public String description { get; set; }

        public Movie(String title, String director, List<String> start, String description) { 
            this.title = title;
            this.director = director;
            this.start = start;
            this.description = description;

        }

        
    }
}
