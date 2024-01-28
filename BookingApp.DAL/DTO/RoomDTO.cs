﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.DAL.DTO
{
    [Table("Room")]
    public class RoomDTO
    {
        public int Id { get; set; }

        public int NumberOfRoom { get; set; }
        public int Capacity { get; set; }
        public int Price { get; set; }
        public int Hotel_Id { get; set; }

        [ForeignKey("Hotel_Id")]
        public HotelDTO? Hotel { get; set; }


    }
}