using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewsReportAPIService.Data;
using System;
using System.Linq;

namespace NewsReportAPIService.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NewsReportAPIServiceContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<NewsReportAPIServiceContext>>()))
            {
                // Look for any movies.
 //               if (context.Report.Any())
 //               {
 //                   return;   // DB has been seeded
 //               }

                context.Report.AddRange(
                    new Report
                    {
                        Title = "Healthcare worker tests positive for COVID-19 twice in 20 days in world first since pandemic began, study suggests",
                        Content = "The Spanish woman, 31, became infected with the Delta variant followed by the Omicron variant of the virus in under three weeks, according to a study. Researchers say the case shows that even vaccinated people who have had COVID-19 cannot assume they are protected against reinfection. Dr Gemma Recio, of the Institut Catala de la Salut in Spain, one of the studys authors, said it highlights the potential of the Omicron variant to evade previous immunity. The female healthcare worker, who has been kept anonymous, became infected in December 2021, 12 days after she received her booster vaccine.She had no symptoms and went into isolation for 10 days. Just days after she returned to work in January she began to show symptoms of the virus - a cough and fever as well as feeling generally unwell - and tested positive. Her case, which is being presented to the European Congress of Clinical Microbiology and Infectious Diseases in Portugal, is believed to be the shortest known gap between 			infections. Case underscores the need to carry out genomic surveillance of viruses. Dr Recio said: People who have had COVID-19 cannot assume they are protected against reinfection, even if they have been fully vaccinated. ",
                        CreatedDate = DateTime.Parse("2022-4-12"),
                        UpdatedDate = DateTime.Parse("2022-5-12"),
                        IsPublished = true,
                        PublishedDate = DateTime.Parse("2021-5-12"),
                        Category = Report.CategoryType.LocalNews, 
                        CreatedBy = Guid.Parse("e03056cf-7146-483f-a86f-e41f8332060d")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}