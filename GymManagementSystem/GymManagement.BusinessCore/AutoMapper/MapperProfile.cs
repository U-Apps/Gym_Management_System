using AutoMapper;

namespace GymManagement.BusinessCore.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            /*
            CreateMap<TbEmployee, Employee>()
                .ForMember(dust => dust.PayrollPayments, src => src.MapFrom(src => src.TbPayrollPayments))
                .ForMember(dust=> dust.Person, src => src.MapFrom(src => src.Person))
                .ForMember(dust=> dust.CurrentJob, src => src.MapFrom(src => src.CurrentJob))
                .ForMember(dust=> dust.EmployeementHistory, src => src.MapFrom(src => src.EmployeementHistory))
                .ReverseMap();


            CreateMap<TbExerciseType, ExerciseType>()
                .ForMember(dust => dust.Subscriptions, src => src.MapFrom(src => src.TbSubscriptions))
                .ReverseMap();


            CreateMap<TbJob, Job>().ForMember(dust => dust.JobHistories, src => src.MapFrom(src => src.TbJobHistories))
                .ForMember(dust => dust.Employees, src => src.MapFrom(src => src.TbEmployees))
                .ReverseMap();


            CreateMap<TbJobHistory, JobHistory>()
                .ForMember(dust => dust.SubscriptionCoaches, src => src.MapFrom(src => src.TbSubscriptionCoaches))
                .ForMember(dust => dust.SubscriptionCreatedByReceptionists, src => src.MapFrom(src => src.TbSubscriptionCreatedByReceptionists))
                .ForMember(dust => dust.Job, src => src.MapFrom(src => src.Job))
                .ForMember(dust => dust.Employee, src => src.MapFrom(src => src.Employee))
                .ReverseMap();


            CreateMap<TbMember, Member>()
                .ForMember(dust => dust.Subscriptions, src => src.MapFrom(src => src.TbSubscriptions))
                .ReverseMap();
            CreateMap<TbPerson, Person>()
                .ForMember(dust => dust.BirthDate, src => src.MapFrom(src => src.BirthDate))
                .ReverseMap();

            CreateMap<TbPayrollPayment, PayrollPayment>().ReverseMap();


            CreateMap<TbPeriod, Period>()
                .ForMember(dust => dust.Subscriptions, src => src.MapFrom(src => src.TbSubscriptions))
                .ReverseMap();


            CreateMap<TbSubsciptionPeriod, SubscriptionPeriod>()
                .ForMember(dust => dust.Subscriptions, src => src.MapFrom(src => src.TbSubscriptions))
                .ReverseMap();


            CreateMap<TbSubscription, Subscription>().ReverseMap();


            CreateMap<TbSubscriptionPayment, SubscriptionPayment>().ReverseMap();

            CreateMap<AppUser, User>().ReverseMap().ForSourceMember(src=>src.Password,src=>src.DoNotValidate());
            */

            


        }


    }
}
