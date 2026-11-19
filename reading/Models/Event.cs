using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace EventHub.Models
    {
        public class Event
        {
            public int EventId { get; set; }

            public string Title { get; set; } = null!;

            public string Description { get; set; } = null!;

            public DateTime StartDate { get; set; }

            public DateTime? EndDate { get; set; }

            public int MaxAttendees { get; set; }

            // Foreign Key
            public int OrganizerId { get; set; }

            // Navigation Property
            public Organizer Organizer { get; set; } = null!;
        }
    }


