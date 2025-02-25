﻿using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public static class AuthorMappingExtensions
    {

        public static AuthorModel ToApiModel(this Author author)
        {
            return new AuthorModel
            {
                // TODO: map Author properties to corresponding AuthorModel properties
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                BirthDate = author.BirthDate
            };
        }

        public static Author ToDomainModel(this AuthorModel authorModel)
        {
            return new Author
            {
                // TODO: map AuthorModel properties to corresponding Author props
                Id = authorModel.Id,
                FirstName = authorModel.FirstName,
                LastName = authorModel.LastName,
                BirthDate = authorModel.BirthDate
            };
        }

        public static IEnumerable<AuthorModel> ToApiModels(this IEnumerable<Author> authors)
        {
           /* return authors.Select(a => a.ToApiModel()); */
             // return a new AuthorModel and copy the
             // property values from the Author domain model
             return new AuthorModel
             {
                 Id = authors.Id,
                 BirthDate = authors.BirthDate,
                 FirstName = authors.FirstName,
                 LastName = authors.LastName
             };
        }

        public static IEnumerable<Author> ToDomainModel(this IEnumerable<AuthorModel> authorModels)
        {
            /*return authorModels.Select(a => a.ToDomainModel());*/
             // return a new Author domain model and copy the
             // property values over from the AuthorModel
             return new Author
             {
                 Id = authorModel.Id,
                 BirthDate = authorModel.BirthDate,
                 FirstName = authorModel.FirstName,
                 LastName = authorModel.LastName,
             };
        }
    }
}
