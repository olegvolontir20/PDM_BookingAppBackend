﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BookingApp.DAL.DTO
{
    public class UserDTO : IdentityUser<int>
    {
        //public string? Name { get; set; }
        //public string? Password { get; set; }
        //public string? Email { get; set; }
        //public string? PhoneNumber { get; set; }

        public List<HotelReviewDTO>? HotelReviews { get; set; }
        public List<ApartmentReviewDTO>? ApartmentReviews { get; set; }

        public List<FavoriteHotelDTO>? FavoriteHotels { get; set; }
        public List<FavoriteApartmentDTO>? FavoriteApartments { get; set; }

    }
}