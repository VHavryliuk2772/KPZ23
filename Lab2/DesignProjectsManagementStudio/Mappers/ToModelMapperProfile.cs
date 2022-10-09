using AutoMapper;
using DesignProjectsManagementStudio.ViewModels;
using Domain.Models;
using Persistance;

namespace DesignProjectsManagementStudio.Mappers
{
    public class ToModelMapperProfile : Profile
    {
        public ToModelMapperProfile()
        {
            CreateMap<CustomerViewModel, Customer>();
            CreateMap<EmployeeViewModel, Employee>();
            CreateMap<DesignTaskViewModel, DesignTask>();
            CreateMap<EmployeeProjectTaskViewModel, EmployeeProjectTask>();
            CreateMap<ProjectViewModel, Project>();
            CreateMap<RoleViewModel, Role>();
            CreateMap<EmployeeRoleViewModel, EmployeeRole>();

            //CreateMap<ContextViewModel, ApplicationContext>();
        }
    }
}
