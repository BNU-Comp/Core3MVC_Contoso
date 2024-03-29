﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DerekCore3MVC_Contoso.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int NoAdults { get; set; }

        public int NoChildren { get; set; }

        public int NoInfants { get; set; }

        public FlightTypes Type { get; set; }

        public DateTime DateBooked { get; set; }

        public decimal TotalCost { get; set; }

        // navigation properties

        public virtual Flight OutboundFlight { get; set; }

        public virtual Flight InboundFlight { get; set; }

        public virtual Customer Customer { get; set; }
    }

    public enum FlightTypes 
    { 
        Economy,
        PremiumEconomy,
        Business,
        FirstClass
    }
}