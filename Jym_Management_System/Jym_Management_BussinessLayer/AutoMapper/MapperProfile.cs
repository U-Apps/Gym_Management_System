using AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jym_Management_BussinessLayer.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<TbEmployee, Employee>()
                .ForMember(dust => dust.PayrollPayments, src => src.MapFrom(src => src.TbPayrollPayments))
                .ReverseMap();


            CreateMap<TbExerciseType, ExerciseType>()
                .ForMember(dust => dust.Subscriptions, src => src.MapFrom(src => src.TbSubscriptions))
                .ReverseMap();


            CreateMap<TbJob, Job>().ForMember(dust => dust.JobHistories, src => src.MapFrom(src => src.TbJobHistories)).ReverseMap();


            CreateMap<TbJobHistory, JobHistory>()
                .ForMember(dust => dust.SubscriptionCoaches, src => src.MapFrom(src => src.TbSubscriptionCoaches))
                .ForMember(dust => dust.SubscriptionCreatedByReceptionists, src => src.MapFrom(src => src.TbSubscriptionCreatedByReceptionists))
                .ReverseMap();


            CreateMap<TbMember, Member>()
                .ForMember(dust => dust.Subscriptions, src => src.MapFrom(src => src.TbSubscriptions))
                .ReverseMap();


            CreateMap<TbPayrollPayment, PayrollPayment>().ReverseMap();


            CreateMap<TbPeriod, Period>()
                .ForMember(dust => dust.Subscriptions, src => src.MapFrom(src => src.TbSubscriptions))
                .ReverseMap();


            CreateMap<TbPermssion, Permssion>().ForMember(dust => dust.Users, src => src.MapFrom(src => src.TbUsers)).ReverseMap();
            CreateMap<TbPerson, Person>()
                .ForMember(dust => dust.Employees, src => src.MapFrom(src => src.TbEmployees))
                .ForMember(dust => dust.Members, src => src.MapFrom(src => src.TbMembers))
                .ForMember(dust => dust.Users, src => src.MapFrom(src => src.TbUsers))
                .ReverseMap();


            CreateMap<TbRole, Role>()
                .ForMember(dust => dust.Permssions, src => src.MapFrom(src => src.TbPermssions))
                .ReverseMap();


            CreateMap<TbSubsciptionPeriod, SubsciptionPeriod>()
                .ForMember(dust => dust.Subscriptions, src => src.MapFrom(src => src.TbSubscriptions))
                .ReverseMap();


            CreateMap<TbSubscription, Subscription>().ReverseMap();


            CreateMap<TbSubscriptionPayment, SubscriptionPayment>().ReverseMap();


            CreateMap<TbUser, User>().ReverseMap();

        }


    }
}
