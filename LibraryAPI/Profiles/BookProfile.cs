using AutoMapper;
using LibraryAPI.Data;
using LibraryAPI.Models.Books;
using System;

namespace LibraryAPI.Profiles
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            // Book -> GetBookDetailsResponse
            CreateMap<Book, GetBookDetailsResponse>();
            // Book -> GetBooksResponseItem
            CreateMap<Book, GetBooksResponseItem>();
            // PostBookRequest -> Book
            CreateMap<PostBooksRequest, Book>()
                .ForMember(dest => dest.IsInInventory, opt => opt.MapFrom((s) => true))
                .ForMember(dest => dest.AddedToInventory, opt => opt.MapFrom((s) => DateTime.Now))
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}