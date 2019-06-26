﻿using Data.Infrastructure;
using DATA.Infrastructure;
using Infrastructure;
using Model;
using MyFinance.Data.Infrastructure;
using Service;


namespace Services.serviceAdmin
{
    public class serviceAdmin : servicePattern<Admin>,IserviceAdmin

    {
        static IDatabaseFactory dbf = new DatabaseFactory();
        static IUnitOfWork uow = new UnitOfWork(dbf);
        public serviceAdmin() : base(uow)
        {

        }

        public bool authAdmin(string username, string password)
        {
            return this.Get(x => x.username == username || x.password == password) != null;
        }
    }
}