﻿using Core.EntityFramework;
using DataAcsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcsess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal :EfEntityRepositoryBase<Product,NortWindContext>, IProductDal
    {
        
       
    }
}
