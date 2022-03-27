using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamesV2.Client.Application.wpf.Models
{
    public class Anime
    {
        //Use bdd to populate enums ?? or create a class for it
        public enum Statuts { Incoming, Ongoing, Finished };
        public enum Genres
        {
            ScienceFiction, Romance, Mystery, Aventure, DarkFantasy, ArtsMartiaux,
            Action, Comedie, HeroicFantasy,
        };
        public enum Studios
        {
            WhiteFox, Ufotable,
            A1Picture
        }

        public string Title { get; set; }
        public string TitleOriginal { get; set; }

        public Studios Studio { get; set; }
        public Statuts Statut { get; set; }

        public List<Genres> GenreList { get; set; }
        public List<Season> Seasons { get; set; }

        public Anime(string title, string titleOriginal, List<Genres> genres, Studios studio, List<Season> seasons, Statuts statut)
        {
            Title = title;
            TitleOriginal = titleOriginal;
            GenreList = genres;
            Studio = studio;
            Seasons = seasons;
            Statut = statut;
        }
    }
}
