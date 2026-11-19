using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace EventHub.Models
    {
        public class OrganizerProfile
        {
            public int OrganizerProfileId { get; set; }

            public string? Biography { get; set; }

            public string? WebsiteUrl { get; set; }

            public string? LogoUrl { get; set; }

            // Foreign Key
            public int OrganizerId { get; set; }

            // Navigation Property
            public Organizer Organizer { get; set; } = null!;
        }
    }


