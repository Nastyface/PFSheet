﻿using PFSheet.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSheet.DAL.Service
{
    public interface IClassService
    {
        IEnumerable<IPFClass> GetClasses(); 
    }
}
