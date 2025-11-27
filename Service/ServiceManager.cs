using AutoMapper;
using Contracts;
using Entities.ConfigurationModels;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Collections;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IEmployeeService> _employeeService;
        private readonly Lazy<IAuthenticationServise> _authenticationServise;

        public ServiceManager(IRepositoryManager repositoryManager,
                              ILoggerManager logger,
                              IMapper mapper,
                              IEmployeeLinks employeeLinks,
                              UserManager<User> userManager,
                              IOptions<JwtConfiguration> configuration)
        {
            _companyService = new Lazy<ICompanyService>(() =>
                new CompanyService(repositoryManager, logger, mapper));
            _employeeService = new Lazy<IEmployeeService>(() => 
                new EmployeeService(repositoryManager, logger, mapper, employeeLinks));
            _authenticationServise = new Lazy<IAuthenticationServise>(() =>
                new AuthenticationServise(logger, mapper, userManager, configuration));
        }

        public ICompanyService CompanyService => _companyService.Value;
        public IEmployeeService EmployeeService => _employeeService.Value;
        public IAuthenticationServise AuthenticationServise => _authenticationServise.Value;
    }
}