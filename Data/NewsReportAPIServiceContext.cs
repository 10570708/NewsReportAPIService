#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsReportAPIService.Models;

namespace NewsReportAPIService.Data
{
    public class NewsReportAPIServiceContext : DbContext
    {
        public NewsReportAPIServiceContext (DbContextOptions<NewsReportAPIServiceContext> options)
            : base(options)
        {
        }

        public DbSet<NewsReportAPIService.Models.Report> Report { get; set; }
    }
}
