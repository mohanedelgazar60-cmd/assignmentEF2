using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventHub
{
    public enum BadgeTier
    {
        Standard,
        VIP
    }

    public class Badge
    {
        public int BadgeId { get; set; }

        public string BadgeNumber { get; set; } = null!;

        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }

        // Foreign Key
        public int AttendeeId { get; set; }

        // Navigation Property
        public Attendee Attendee { get; set; } = null!;
    }
}


