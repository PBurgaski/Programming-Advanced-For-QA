namespace _02.Articles
{
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(string newContent)
        {
            Content = newContent;
            return;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
            return;
        }
        public void Rename(string newName)
        {
            Title = newName;
            return;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string[] article = Console.ReadLine().Split(", ").ToArray();
            int n = int.Parse(Console.ReadLine());
            Article art = new Article(article[0], article[1], article[2]);
            // Logic
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ").ToArray();
                string command = input[0];
                string act = input[1];
                if (command == "Edit")
                {
                    art.Edit(act);
                }
                else if (command == "ChangeAuthor")
                {
                    art.ChangeAuthor(act);
                }
                else if (command == "Rename")
                {
                    art.Rename(act);
                }
            }
            // Output
            Console.WriteLine(art);
        }
    }
}
