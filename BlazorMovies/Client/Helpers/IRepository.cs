using System.Collections.Generic;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client2.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
