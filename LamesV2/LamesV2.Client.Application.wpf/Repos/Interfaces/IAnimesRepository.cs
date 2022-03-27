using LamesV2.Client.Application.wpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamesV2.Client.Application.wpf.Repos.Interfaces
{
    public interface IAnimesRepository
    {
        List<Anime> GetAnimes();
        List<Anime> GetAnimesByStatut(Anime.Statuts statut);
    }
}
