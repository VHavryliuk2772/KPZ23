using AutoMapper;
using DesignProjectsManagementStudio.ViewModels;
using Domain.Models;
using Persistance;

namespace DesignProjectsManagementStudio.Mappers
{
    public class ToViewModelMapperProfile : Profile
    {
        public ToViewModelMapperProfile()
        {
            CreateMap<EmployeeRole, EmployeeRoleViewModel>();
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<DesignTask, DesignTaskViewModel>();
            CreateMap<EmployeeProjectTask, EmployeeProjectTaskViewModel>();
            CreateMap<Project, ProjectViewModel>()
                .ForMember(vm => vm.Project, g => g.MapFrom(m => m));

            CreateMap<Role, RoleViewModel>();

            CreateMap<ApplicationContext, ContextViewModel>();
        }
    }
}
