﻿using System.ComponentModel.DataAnnotations;
using Conference.Data.Models;

namespace Conference.Data.Entities
{
    public class Proposal
    {
        public int Id { get; set; }
        public int ConferenceId { get; set; }
        public Conferences Conference { get; set; }
        public string Speaker { get; set; }
        public string Title { get; set; }
        public bool Approved { get; set; }

        public ProposalModel ToModel()
        {
            return new ProposalModel
            {
                Id = Id,
                ConferenceId = ConferenceId,
                Speaker = Speaker,
                Title = Title,
                Approved = Approved
            };
        }

        public static Proposal FromModel(ProposalModel model)
        {
            return new Proposal
            {
                ConferenceId = model.ConferenceId,
                Speaker = model.Speaker,
                Title = model.Title,
                Approved = model.Approved
            };
        }
    }
}
