﻿using CC.GraduationProject.EFDAL;
using CC.GraduationProject.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.GraduationProject.DALFactory
{
    public partial class DbSession : IDbSession
    {
        public int SaveChanges()
        {
            return DbContentFactory.GetCurrentDbContent().SaveChanges();
        }
    }
}
