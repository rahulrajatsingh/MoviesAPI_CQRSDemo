﻿using MediatR;
using Movies.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Queries.GetMovieByDirectorName
{
    public class GetMoviesByDirectorNameQuery : IRequest<IEnumerable<MovieResponse>>
    {
        public string DirectorName { get; set; }

        public GetMoviesByDirectorNameQuery(string directorName)
        {
            DirectorName = directorName;
        }
    }
}
