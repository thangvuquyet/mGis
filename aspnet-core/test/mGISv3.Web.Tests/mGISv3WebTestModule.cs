﻿using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using mGISv3.EntityFrameworkCore;
using mGISv3.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace mGISv3.Web.Tests
{
    [DependsOn(
        typeof(mGISv3WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class mGISv3WebTestModule : AbpModule
    {
        public mGISv3WebTestModule(mGISv3EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(mGISv3WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(mGISv3WebMvcModule).Assembly);
        }
    }
}