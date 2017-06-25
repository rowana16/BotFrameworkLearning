using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bot_Application1.Models
{
    public enum BedSizeOptions
    {
        King, Queen, Single, Double
    }

    public enum AmenititesOptions
    {
        Kitchen, ExtraTowels, GymAccess, Wifi
    }

    [Serializable]
    public class RoomReservation
    {
        public BedSizeOptions? Bedsize;
        public int? NumberOfOccupants;
        public DateTime? CheckInDate;
        public int? NumberOfDaysToStay;
        public List<AmenititesOptions> Amenities;


        public static IForm<RoomReservation> BuildForm()
        {
            return new FormBuilder<RoomReservation>()
                .Message("Welcome to the hotel reservation bot!")
                .Build();
        }
    }
}