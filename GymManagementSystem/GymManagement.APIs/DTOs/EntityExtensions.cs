﻿using GymManagement.BusinessCore.DTOs;
using GymManagement.BusinessCore.Models;

namespace GymManagement.APIs.DTOs
{
    public static class EntityExtensions
    {


        public static ReadEmployeeDTO AsDTO(this Employee employee)
            => new ReadEmployeeDTO()
            {
                EmployeeId = employee.Id,
                Salary = employee.Salary,
                ResignationDate = employee.ResignationDate,
                HireDate = employee.RegisterationDate,
               
                 CurrentJob=new ReadJobDTO(

                      employee.CurrentJob.JobId,
                      employee.CurrentJob.JobTitle
                    ) ,

                //person = new ReadPersonDTO()
                //{
                //    Name = employee.Person.Name,
                //    PersonId = employee.PersonId,
                //    Email = employee.Person.Email,
                //    PhoneNumber = employee.Person.PhoneNumber,
                //    BirthDate = employee.Person.BirthDate,
                //    Idcard = employee.Person.NationalNumber
                //},
                payments = employee.PayrollPayments.Select(employee => new ReadPaymnetsForEmployee { PaymentId = employee.PaymentId, PaymentDate = employee.PaymentDate }).ToList()

            };

        //public static MemberResponse AsDTO(this Member member)
        //    => new MemberResponse
        //    (
        //        member.Id,
        //         member.FirstName,
        //member.SecondName,
        //    member.ThirdName,
        //    member.LastName,
        //    member.NationalNumber,
        //    member.PhoneNumber,
        //    member.BirthDate,
        //    member.Address,
        //    member.Email,
        //    member.MemberWeight,
        //    member.IsActive,
        //    member.RegisterationDate
                
                
        //        //new ReadPersonDTO()
        //        //{
        //        //    Name = member.FirstName,
        //        //    PersonId = member.PersonId,
        //        //    Email = member.Person.Email,
        //        //    PhoneNumber = member.Person.PhoneNumber,
        //        //    //BirthDate = member.Person.BirthDate,
        //        //    Idcard = member.Person.NationalNumber
        //        //}
        //    );

        public static ReadUserDTO AsDTO(this AppUser user,Person person)
            => new ReadUserDTO
            (
               
                user.UserName,
                user.IsActive,
               
                
               Person: new ReadPersonDTO()
               {
                   Name = person.FirstName,
                   PersonId = person.Id,
                   Email = person.Email,
                   PhoneNumber = person.PhoneNumber,
                   BirthDate = person.BirthDate,
                   Idcard = person.NationalNumber
               }
            );

        public static ReadPermssionDTO AsDTO(this Permssion permssion)
            => new ReadPermssionDTO
            (
                    Id: permssion.Id,
                    Name: permssion.Name,

                    Role: new ReadRoleDTO(
                        permssion.Role.RoleId,
                        permssion.Role.RoleName
                        )
                );

        public static ReadRoleDTO AsDTO(this Role role)
           => new ReadRoleDTO
           (
                  RoleId: role.RoleId,
                  RoleName: role.RoleName
               );

        public static ReadJobDTO AsDTO(this Job job)
          => new ReadJobDTO
          (
                 JobId: job.JobId,
                 JobTitle: job.JobTitle
              );

        public static ReadPeriodDTO AsDTO(this Period period)
         => new ReadPeriodDTO
         (
               PeriodId: period.PeriodId,
               PeriodName: period.PeriodName,
               StartTime: period.StartTime,
               EndTime: period.EndTime
             );

        public static ReadJobHistoryDTO AsDTO(this JobHistory jobHistory
            )
           => new ReadJobHistoryDTO
           (
                  Id: jobHistory.Id,
                  StartDate: jobHistory.StartDate,
                  EndDate: jobHistory.EndDate,
                  EmpoyeeId: jobHistory.EmpoyeeId,

                  Job: new ReadJobDTO
                    (
                      JobId: jobHistory.JobId,
                      JobTitle: jobHistory.Job.JobTitle
                      )

               );

        public static ReadSubscriptionPeriodDTO AsDTO(this SubscriptionPeriod subscriptionPeriod
            )
           => new ReadSubscriptionPeriodDTO
           (
                 Id: subscriptionPeriod.Id,
                 Name: subscriptionPeriod.Name,
                 Price: subscriptionPeriod.Price

               );

        //public static ReadSubscriptionPaymentDTO AsDTO(this SubscriptionPayment subscriptionPayment
        //   )
        //  => new ReadSubscriptionPaymentDTO
        //  (
        //        PaymentId: subscriptionPayment.PaymentId,
        //        PaymentDate: subscriptionPayment.PaymentDate,
        //        PaymentAmount: subscriptionPayment.PaymentAmount,
        //CreatedByUser: new ReadUserDTO
        //(
        //    UserName: subscriptionPayment.CreatedByUser.UserName,
        //    IsActive: subscriptionPayment.CreatedByUser.IsActive,
        //   Person: new ReadPersonDTO
        //   {


        //       Name = subscriptionPayment.CreatedByUser.Person.FirstName,
        //       PersonId = subscriptionPayment.CreatedByUser.PersonId,
        //       Email = subscriptionPayment.CreatedByUser.Person.Email,
        //       PhoneNumber = subscriptionPayment.CreatedByUser.Person.PhoneNumber,
        //       BirthDate = subscriptionPayment.CreatedByUser.Person.BirthDate,
        //       Idcard = subscriptionPayment.CreatedByUser.Person.NationalNumber

        //   }

        //    ),

        // Subscription: new ReadSubscriptionDTO
        //     (
        //         SubscriptionId: subscriptionPayment.PaymentId,
        //         StartDate: subscriptionPayment.Subscription.StartDate,
        //         EndDate: subscriptionPayment.Subscription.EndDate,
        //         Coach: new ReadJobHistoryDTO
        //         (
        //             subscriptionPayment.Subscription.Coach.Id,
        //             subscriptionPayment.Subscription.Coach.EmpoyeeId,
        //             subscriptionPayment.Subscription.Coach.StartDate,
        //             subscriptionPayment.Subscription.Coach.EndDate,
        //             new ReadJobDTO
        //             (
        //                 subscriptionPayment.Subscription.Coach.Job.JobId,
        //                 subscriptionPayment.Subscription.Coach.Job.JobTitle
        //                 )
        //             ),
        //         CreatedByReceptionist: new ReadJobHistoryDTO
        //         (
        //             subscriptionPayment.Subscription.CreatedByReceptionist.Id,
        //             subscriptionPayment.Subscription.CreatedByReceptionist.EmpoyeeId,
        //             subscriptionPayment.Subscription.CreatedByReceptionist.StartDate,
        //             subscriptionPayment.Subscription.CreatedByReceptionist.EndDate,
        //             new ReadJobDTO
        //             (
        //                 subscriptionPayment.Subscription.CreatedByReceptionist.Job.JobId,
        //                 subscriptionPayment.Subscription.CreatedByReceptionist.Job.JobTitle
        //                 )
        //             ),
        //         ExcerciseType: new ReadExerciseTypeDTO
        //          (
        //             subscriptionPayment.Subscription.ExcerciseType.ExerciseTypeId,
        //             subscriptionPayment.Subscription.ExcerciseType.Name
        //             ),
        //         Member: new MemberResponse
        //         (
        //              subscriptionPayment.Subscription.Member.Id,
        //              subscriptionPayment.Subscription.Member.FirstName,
        //              subscriptionPayment.Subscription.Member.SecondName,
        //              subscriptionPayment.Subscription.Member.ThirdName,
        //              subscriptionPayment.Subscription.Member.LastName,
        //              subscriptionPayment.Subscription.Member.NationalNumber,
        //              subscriptionPayment.Subscription.Member.PhoneNumber,
        //              subscriptionPayment.Subscription.Member.BirthDate,
        //              subscriptionPayment.Subscription.Member.Address,
        //              subscriptionPayment.Subscription.Member.Email,
        //              //subscriptionPayment.Subscription.Member.PersonId,
        //              subscriptionPayment.Subscription.Member.MemberWeight,
        //              subscriptionPayment.Subscription.Member.IsActive,
        //              subscriptionPayment.Subscription.Member.RegisterationDate

        //              //new ReadPersonDTO()
        //              //{
        //              //    Name = subscriptionPayment.Subscription.Member.Person.FirstName,
        //              //    PersonId = subscriptionPayment.Subscription.Member.PersonId,
        //              //    Email = subscriptionPayment.Subscription.Member.Person.Email,
        //              //    PhoneNumber = subscriptionPayment.Subscription.Member.Person.PhoneNumber,
        //              //    BirthDate = subscriptionPayment.Subscription.Member.Person.BirthDate,
        //              //    Idcard = subscriptionPayment.Subscription.Member.Person.NationalNumber
        //              //}
        //             ),
        //         Period: new ReadPeriodDTO
        //         (
        //              PeriodId: subscriptionPayment.Subscription.Period.PeriodId,
        //              PeriodName: subscriptionPayment.Subscription.Period.PeriodName,
        //              StartTime: subscriptionPayment.Subscription.Period.StartTime,
        //              EndTime: subscriptionPayment.Subscription.Period.EndTime
        //           ),
        //         SubscriptionPeriod: new ReadSubscriptionPeriodDTO
        //         (
        //             subscriptionPayment.Subscription.SubscriptionPeriod.Id,
        //             subscriptionPayment.Subscription.SubscriptionPeriod.Name,
        //             subscriptionPayment.Subscription.SubscriptionPeriod.Price
        //             )

        //     )
        //      );



        //public static ReadSubscriptionDTO AsDTO(this Subscription subscription)
        //  => new ReadSubscriptionDTO
        //  (

        //       SubscriptionId: subscription.SubscriptionId,
        //                StartDate: subscription.StartDate,
        //                EndDate: subscription.EndDate,
        //                Coach: new ReadJobHistoryDTO
        //                (
        //                    subscription.Coach.Id,
        //                    subscription.Coach.EmpoyeeId,
        //                    subscription.Coach.StartDate,
        //                    subscription.Coach.EndDate,
        //                    new ReadJobDTO
        //                    (
        //                        subscription.Coach.Job.JobId,
        //                        subscription.Coach.Job.JobTitle
        //                        )
        //                    ),
        //                CreatedByReceptionist: new ReadJobHistoryDTO
        //                (
        //                    subscription.CreatedByReceptionist.Id,
        //                    subscription.CreatedByReceptionist.EmpoyeeId,
        //                    subscription.CreatedByReceptionist.StartDate,
        //                    subscription.CreatedByReceptionist.EndDate,
        //                    new ReadJobDTO
        //                    (
        //                        subscription.CreatedByReceptionist.Job.JobId,
        //                        subscription.CreatedByReceptionist.Job.JobTitle
        //                        )
        //                    ),
        //                ExcerciseType: new ReadExerciseTypeDTO
        //                 (
        //                    subscription.ExcerciseType.ExerciseTypeId,
        //                    subscription.ExcerciseType.Name
        //                    ),
        //                Member: new ReadMemberDTO
        //                (
        //                      subscription.Member.Id,
        //                      subscription.Member.FirstName,
        //                      subscription.Member.SecondName,
        //                      subscription.Member.ThirdName,
        //                      subscription.Member.LastName,
        //                      subscription.Member.NationalNumber,
        //                      subscription.Member.PhoneNumber,
        //                      subscription.Member.BirthDate,
        //                      subscription.Member.Address,
        //                      subscription.Member.Email,
        //                      //subscriptionPayment.Subscription.Member.PersonId,
        //                      subscription.Member.MemberWeight,
        //                      subscription.Member.IsActive,
        //                      subscription.Member.RegisterationDate

        //                    //new ReadPersonDTO()
        //                    //{
        //                    //    Name = subscription.Member.Person.FirstName,
        //                    //    PersonId = subscription.Member.PersonId,
        //                    //    Email = subscription.Member.Person.Email,
        //                    //    PhoneNumber = subscription.Member.Person.PhoneNumber,
        //                    //    BirthDate = subscription.Member.Person.BirthDate,
        //                    //    Idcard = subscription.Member.Person.NationalNumber
        //                    //}
        //                    ),
        //                Period: new ReadPeriodDTO
        //                (
        //                     PeriodId: subscription.Period.PeriodId,
        //                     PeriodName: subscription.Period.PeriodName,
        //                     StartTime: subscription.Period.StartTime,
        //                     EndTime: subscription.Period.EndTime
        //                  ),
        //                SubscriptionPeriod: new ReadSubscriptionPeriodDTO
        //                (
        //                    subscription.SubscriptionPeriod.Id,
        //                    subscription.SubscriptionPeriod.Name,
        //                    subscription.SubscriptionPeriod.Price
        //                    )

        //   );
        
        public static ReadExerciseTypeDTO AsDTO(this ExerciseType exerciseType)
       => new ReadExerciseTypeDTO
       (
            exerciseType.ExerciseTypeId,
            exerciseType.Name
           );

        public static ReadPayrollPaymentDTO AsDTO(this PayrollPayment payrollPayment)
      => new ReadPayrollPaymentDTO
      (
           payrollPayment.PaymentId,
           payrollPayment.PaymentDate,
           Employee: new ReadEmployeeDTO
           {
               EmployeeId = payrollPayment.Employee.Id,
               Salary = payrollPayment.Employee.Salary,
               ResignationDate = payrollPayment.Employee.ResignationDate,
               HireDate = payrollPayment.Employee.RegisterationDate,
            

               person = new ReadPersonDTO()
               {
                   Name = payrollPayment.Employee.FirstName,
                   PersonId = payrollPayment.EmployeeId,
                   Email = payrollPayment.Employee.Email,
                   PhoneNumber = payrollPayment.Employee.PhoneNumber,
                   BirthDate = payrollPayment.Employee.BirthDate,
                   Idcard = payrollPayment.Employee.NationalNumber
               },
               payments = payrollPayment.Employee.PayrollPayments.Select(employee => new ReadPaymnetsForEmployee { PaymentId = employee.PaymentId, PaymentDate = employee.PaymentDate }).ToList()

           }
          );

    }
}
