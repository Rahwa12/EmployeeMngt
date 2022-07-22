using AutoMapper;
using EmpManagement.Models;

namespace EmpManagement.Resources
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeResource, Employee>();
         
        }
    }
}
