namespace LamesV2.Client.Application.wpf.Models
{
    public class Season
    {
        public string Title { get; set; }
        public string TitleOriginal { get; set; }
        public int NbEpisodes { get; set; }

        public Season(string title, string titleOriginal, int nbEpisodes)
        {
            Title = title;
            TitleOriginal = titleOriginal;
            NbEpisodes = nbEpisodes;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}