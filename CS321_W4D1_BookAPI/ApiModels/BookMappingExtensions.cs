﻿using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public static class BookMappingExtenstions
    {

        public static BookModel ToApiModel(this Book convertedBook)
        {
            // TODO: map the Book domain object to a BookModel
            return new BookModel
            {
                Id = convertedBook.Id,
                Title = convertedBook.Title,
                OriginalLanguage = convertedBook.OriginalLanguage,
                Genre = convertedBook.Genre,
                PublicationYear = convertedBook.PublicationYear,
                AuthorId = convertedBook.AuthorId,
                Author = convertedBook.Author != null ?
                        convertedBook.Author.LastName + ", "
                        + convertedBook.Author.FirstName: "",
                PublisherId = convertedBook.PublisherId,
                Publisher = convertedBook.Publisher != null?
                            convertedBook.Publisher.Name + ", "+
                            convertedBook.Publisher.HeadQuartersLocation: ""
            };
        }

        public static Book ToDomainModel(this BookModel bookModel)
        {
            // TODO: map the BookModel to a Book domain object
            return new Book
            {
                Id = bookModel.Id,
                Title = bookModel.Title,
                OriginalLanguage = bookModel.OriginalLanguage,
                Genre = bookModel.Genre,
                PublicationYear = bookModel.PublicationYear,
                AuthorId = bookModel.AuthorId,
                PublisherId = bookModel.PublisherId
            };
        }

        public static IEnumerable<BookModel> ToApiModels(this IEnumerable<Book> authors)
        {
            return authors.Select(a => a.ToApiModel());
             //// return a new BookModel and copy the
             //// property values over from the Book
             //return new BookModel
             //{
             //    Id = book.Id,
             //    Title = book.Title,
             //    Genre = book.Genre,
             //    OriginalLanguage = book.OriginalLanguage,
             //    PublicationYear = book.PublicationYear,
             //    PublisherId = book.PublisherId,
             //    AuthorId = book.AuthorId,
             //    // concatenate the author's name properties and use it as the value of
             //    // Author. Use null if the Author is null.
             //    Author = book.Author != null
             //        ? book.Author.LastName + ", " + book.Author.FirstName
             //        : null
             //};
        }

        public static IEnumerable<Book> ToDomainModel(this IEnumerable<BookModel> authorModels)
        {
            return authorModels.Select(a => a.ToDomainModel());
             // return a new Book domain object and copy the
             // property values over from the BookModel
             //return new Book
             //{
             //    Id = bookModel.Id,
             //    Title = bookModel.Title,
             //    Genre = bookModel.Genre,
             //    OriginalLanguage = bookModel.OriginalLanguage,
             //    PublicationYear = bookModel.PublicationYear,
             //    PublisherId = bookModel.PublisherId,
             //    AuthorId = bookModel.AuthorId,
             //    // Note that we don't set the Publisher or Author object properties. 
             //    // Setting the PublisherId and AuthorId fields is enough.
             //};
        }
    }
}
