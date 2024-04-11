﻿namespace mGISv3.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly mGISv3DbContext _context;

        public InitialHostDbBuilder(mGISv3DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
