using LamesV2.Client.Application.wpf.Models;
using LamesV2.Client.Application.wpf.Services.Interfaces;
using LamesV2.Client.Application.wpf.ViewModels.Interfaces;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamesV2.Client.Application.wpf.ViewModels
{
    public class ViewAViewModel : BindableBase, IViewAViewModel
    {
        private readonly IAnimesService _animesService;

        public ViewAViewModel(IAnimesService animesService)
        {
            _animesService = animesService;
        }

        private List<Anime> _animes = null;
        private List<Anime> _animesIncoming = null;
        private List<Anime> _animesOngoing = null;
        private List<Anime> _animesFinished = null;

        private Anime _selectedAnime = null;
        private Anime _selectedAnimeIncoming = null;
        private Anime _selectedAnimeOngoing = null;
        private Anime _selectedAnimeFinished = null;

        public List<Anime> Animes
        {
            get { return _animes; }
            set { SetProperty(ref _animes, value); }
        }
        public List<Anime> AnimesIncoming
        {
            get { return _animesIncoming; }
            set { SetProperty(ref _animesIncoming, value); }
        }
        public List<Anime> AnimesOngoing
        {
            get { return _animesOngoing; }
            set { SetProperty(ref _animesOngoing, value); }
        }
        public List<Anime> AnimesFinished
        {
            get { return _animesFinished; }
            set { SetProperty(ref _animesFinished, value); }
        }

        public Anime SelectedAnime
        {
            get { return _selectedAnime; }
            set { SetProperty(ref _selectedAnime, value); }
        }
        public Anime SelectedAnimeIncoming
        {
            get { return _selectedAnimeIncoming; }
            set { SetProperty(ref _selectedAnimeIncoming, value); }
        }
        public Anime SelectedAnimeOngoing
        {
            get { return _selectedAnimeOngoing; }
            set { SetProperty(ref _selectedAnimeOngoing, value); }
        }
        public Anime SelectedAnimeFinished
        {
            get { return _selectedAnimeFinished; }
            set { SetProperty(ref _selectedAnimeFinished, value); }
        }

        public void LoadData()
        {
            Animes = _animesService.GetAll();
            AnimesIncoming = _animesService.GetAllByStatut(Anime.Statuts.Incoming);
            AnimesOngoing = _animesService.GetAllByStatut(Anime.Statuts.Ongoing);
            AnimesFinished = _animesService.GetAllByStatut(Anime.Statuts.Finished);
        }
    }
}
