using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Conference.Data.Models;

namespace Conference.Data.Entities
{
    public class Conferences
    {
        public Conferences()
        {
            Start = DateTime.Now;
        }
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public DateTime Start { get; set; }

        [StringLength(250)]
        public string Location { get; set; }

        public List<Attendee> Attendees { get; set; }

        public ConferenceModel ToModel()
        {
            return new ConferenceModel
            {
                Id = Id,
                Location = Location,
                Name = Name,
                Start = Start,
                AttendeeCount = Attendees == null ? 0 : Attendees.Count()
            };
        }

        public static Conferences FromModel(ConferenceModel model)
        {
            return new Conferences
            {
                Location = model.Location,
                Name = model.Name,
                Start = model.Start
            };
        }
    }
}
