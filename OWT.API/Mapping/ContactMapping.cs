using AutoMapper;
using OWT.Data.EntityModels;
using OWT.Domain.Models;
using OWT.Domain.Models.Requests;
using System.Linq;

namespace OWT.API.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Skill, SkillModel>();
            CreateMap<SkillModel, Skill>();
            CreateMap<Contact, ContactModel>()
            .ForMember(s => s.Skills, opt => opt.MapFrom(p => p.ContactSkill.Select(x=>x.Skill).ToList())).ReverseMap();

            //CreateMap<OWT.Data.EntityModels.ContactSkill, SkillModel>()
            //        .ForMember(d => d.Id, opt => opt.MapFrom(s => s.SkillId))
            //        .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Skill.Name));

            //CreateMap<ContactModel, Contact>();

            //CreateMap<SkillModel, OWT.Data.EntityModels.ContactSkill>()
            //      .ForMember(d => d.SkillId, opt => opt.MapFrom(s => s.Id));

            CreateMap<AddContactRequest, ContactModel>();
            CreateMap<UpdateContactRequest, ContactModel>();
        }
    }
}
