﻿using System;
using ExtStore.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace ExtStore.Models.User
{
    public class MyRoleManager : RoleManager<MyRole>
    {
        public MyRoleManager(RoleStore<MyRole> store)
                    : base(store)
        { }
        public static MyRoleManager Create(IdentityFactoryOptions<MyRoleManager> options,
                                                IOwinContext context)
        {
            return new MyRoleManager(new
                    RoleStore<MyRole>(context.Get<ApplicationContext>()));
        }
    }
}