using LamesV2.Client.Application.wpf.Models;
using LamesV2.Client.Application.wpf.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamesV2.Client.Application.wpf.Repos
{
    public class AnimesRepository : IAnimesRepository
    {
        private List<Anime> _animes = null;
        public AnimesRepository()
        {
            _animes =  new List<Anime>
            {
                new Anime(
                    "Steins;Gate",
                    "シュタインズ・ゲート",
                    new List<Anime.Genres>{Anime.Genres.ScienceFiction, Anime.Genres.Romance, Anime.Genres.Mystery},
                    Anime.Studios.WhiteFox,
                    new List<Season>{
                        new Season("Steins;Gate", "シュタインズ・ゲート", 25),
                        new Season("Steins;Gate 0", "シュタインズ・ゲート ゼロ", 24)
                    },
                    Anime.Statuts.Incoming
                ),
                new Anime(
                    "Kimetsu no yaiba",
                    "鬼滅の刃",
                    new List<Anime.Genres>{Anime.Genres.Aventure, Anime.Genres.ArtsMartiaux, Anime.Genres.DarkFantasy},
                    Anime.Studios.Ufotable,
                    new List<Season>{
                        new Season("Kimetsu no yaiba", "鬼滅の刃", 26),
                        new Season("Kimetsu no Yaiba – Yūkaku-hen", "鬼滅の刃 - 遊廓編", 18)
                    },
                    Anime.Statuts.Ongoing
                ),
                new Anime(
                    "Nanatsu no taizai",
                    "七つの大罪",
                    new List<Anime.Genres>{Anime.Genres.Action,Anime.Genres.Aventure, Anime.Genres.Romance, Anime.Genres.Comedie, Anime.Genres.HeroicFantasy},
                    Anime.Studios.A1Picture,
                    new List<Season>{
                        new Season("Nanatsu no taizai", "七つの大罪", 25),
                        new Season("Nanatsu no Taizai: Seisen no Shirushi", "七つの大罪 聖戦の予兆", 4),
                        new Season("Nanatsu no Taizai: Imashime no Fukkatsu", "七つの大罪 戒めの復活", 24),
                        new Season("Nanatsu no Taizai: Kamigami no Gekirin", "七つの大罪 神々の逆鱗", 24),
                        new Season("Nanatsu no Taizai: Fundo no Shinpan", "七つの大罪 憤怒の審判", 24),
                        new Season("Nanatsu no Taizai: Seisen no Shirushi", "七つの大罪 聖戦の予兆", 24)
                    },
                    Anime.Statuts.Finished
                ),
            };
        }
    
        public List<Anime> GetAnimes()
        {
            return _animes;
        }
        public List<Anime> GetAnimesByStatut(Anime.Statuts statut)
        {
            return _animes.Where(a => a.Statut == statut).ToList();
        }
    }
}
