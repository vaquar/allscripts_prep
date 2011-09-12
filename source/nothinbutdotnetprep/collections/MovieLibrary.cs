using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections
{
    public class MovieLibrary
    {
        IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            return this.movies;
        }

        public void add(Movie movie)
        {
            movies.Add(movie);
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            //movies
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            IList<Movie> pix_List = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.production_studio == ProductionStudio.Pixar)
                {
                    pix_List.Add(m);
                }
            }
            return pix_List;
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            IList<Movie> pix_dis_List = new List<Movie>();
            foreach(Movie m in movies)
            {
                if ((m.production_studio == ProductionStudio.Disney) || (m.production_studio == ProductionStudio.Pixar))
                {
                    pix_dis_List.Add(m);
                }
            }
            return pix_dis_List;
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            IList<Movie> not_pix_List = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.production_studio != ProductionStudio.Pixar)
                {
                    not_pix_List.Add(m);
                }
            }
            return not_pix_List;
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            IList<Movie> pix_List = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.date_published.Year > year)
                {
                    pix_List.Add(m);
                }
            }
            return pix_List;
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            IList<Movie> pix_List = new List<Movie>();
            foreach (Movie m in movies)
            {
                if ((m.date_published.Year >= startingYear) && (m.date_published.Year <= endingYear))
                {
                    pix_List.Add(m);
                }
            }
            return pix_List;
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            IList<Movie> pix_List = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.genre == Genre.kids)
                {
                    pix_List.Add(m);
                }
            }
            return pix_List;
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_action_movies()
        {
            IList<Movie> pix_List = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.genre == Genre.action)
                {
                    pix_List.Add(m);
                }
            }
            return pix_List;
            //throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }
    }
}