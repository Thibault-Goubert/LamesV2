using LamesV2.Client.Application.wpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamesV2.Client.Application.wpf.Services.Interfaces
{
    public interface IAnimesService
    {
        List<Anime> GetAll();
        List<Anime> GetAllByStatut(Anime.Statuts statut);
    }
}
