using LamesV2.Client.Application.wpf.Models;
using LamesV2.Client.Application.wpf.Repos.Interfaces;
using LamesV2.Client.Application.wpf.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamesV2.Client.Application.wpf.Services
{
    public class AnimesService : IAnimesService
    {
        private readonly IAnimesRepository _repository;

        public AnimesService(IAnimesRepository repository)
        {
            _repository = repository;
        }

        public List<Anime> GetAll()
        {
            return _repository.GetAnimes();
        }

        public List<Anime> GetAllByStatut(Anime.Statuts statut)
        {
            return _repository.GetAnimesByStatut(statut);
        }
    }
}
