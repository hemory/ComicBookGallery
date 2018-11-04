using TreeHousePractice.Models;

namespace TreeHousePractice.Data
{
    internal class GetComicBook
    {
        public GetComicBook()
        {
        }

        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
    }
}