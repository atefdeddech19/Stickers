﻿using Data.Infrastructure;
using DATA.Infrastructure;
using Infrastructure;
using Model;
using MyFinance.Data.Infrastructure;
using Service;


namespace Services.serviceCommand
{
    public class serviceCommand:servicePattern<Command>,IserviceCommand
    {

       
            static IDatabaseFactory dbf = new DatabaseFactory();
            static IUnitOfWork uow = new UnitOfWork(dbf);
            public serviceCommand() : base(uow)
            {

            }

        public void validateCommande(Command cmd)
        {

            Command _cmd = this.GetById(cmd.idcmd);
            


            throw new System.NotImplementedException();
        }
    }
}