using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Text;
using System.Windows.Controls;
using WPF_move_search.Command;
using WPF_move_search.Model;
using WPF_move_search.Services;

namespace WPF_move_search.ViewModel
{

	class IMDbViewModel : ViewModelBase
	{
		private string movieTitle;
		public string MovieTitle
		{
			get => movieTitle;
			set => OnChanged(out movieTitle, value);
		}

		private ObservableCollection<Search[]> allMovie = new ObservableCollection<Search[]>();
		public ObservableCollection<Search[]> AllMovie
		{
			get => allMovie;
			set => OnChanged(out allMovie, value);
		}

		private CommandBase searchCommand;
		public CommandBase SearchCommand => searchCommand ?? (searchCommand = new CommandBase(x => { SearchMovie(); }));


		public void Clear()
		{
			MovieTitle = null;
		}


		public void SearchMovie()
		{
			AllMovie.Clear();
			if (MovieTitle != null) AllMovie.Add(new AllMovieSearch { title = MovieTitle }.SearchByTitle());
			Clear();
		}

		private Search selectedMovie = new Search();
		public Search SelectedMovie
		{
			get
			{
				if(selectedMovie!=null) SelectedMovieInfo();				
				return selectedMovie;
			}
			set => OnChanged(out selectedMovie, value);

		}

		private ObservableCollection<Movie> searchSelectedMovie = new ObservableCollection<Movie>();
		public ObservableCollection<Movie> SearchSelectedMovie
		{
			get => searchSelectedMovie;
			set => OnChanged(out searchSelectedMovie, value);
		}

		public void SelectedMovieInfo()
		{
			SearchSelectedMovie.Clear();
			SearchSelectedMovie.Add(new SelectedMovieSearch { title = selectedMovie.Title }.SearchByTitle());
			MovieImage = SearchSelectedMovie[0].Poster;
		}

		private string movieImage;
		public string MovieImage
		{

			get => movieImage;
			set => OnChanged(out movieImage, value);
		}
	}
	}




