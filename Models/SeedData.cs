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
                 if (context.Report.Any())
                {
                    return;   // DB has been seeded
                }

                context.Report.AddRange(
                    new Report
                    {
                        Title = "Healthcare worker tests positive for COVID-19 twice in 20 days in world first since pandemic began, study suggests",
                        Content = "The Spanish woman, 31, became infected with the Delta variant followed by the Omicron variant of the virus in under three weeks, according to a study. Researchers say the case shows that even vaccinated people who have had COVID-19 cannot assume they are protected against reinfection. Dr Gemma Recio, of the Institut Catala de la Salut in Spain, one of the studys authors, said it highlights the potential of the Omicron variant to evade previous immunity. The female healthcare worker, who has been kept anonymous, became infected in December 2021, 12 days after she received her booster vaccine.She had no symptoms and went into isolation for 10 days. Just days after she returned to work in January she began to show symptoms of the virus - a cough and fever as well as feeling generally unwell - and tested positive. Her case, which is being presented to the European Congress of Clinical Microbiology and Infectious Diseases in Portugal, is believed to be the shortest known gap between 			infections. Case underscores the need to carry out genomic surveillance of viruses. Dr Recio said: People who have had COVID-19 cannot assume they are protected against reinfection, even if they have been fully vaccinated. ",
                        CreatedDate = DateTime.Parse("2022-1-14"),
                        UpdatedDate = DateTime.Parse("2022-3-19"),
                        IsPublished = true,
                        PublishedDate = DateTime.Parse("2022-1-14"),
                        Category = Report.CategoryType.WorldNews, 
                        CreatedBy = Guid.Parse("e03056cf-7146-483f-a86f-e41f8332060d")
                    },
                    new Report
                    {
                        Title = "Channel 4 gave us everything from The Big Breakfast to Big Brother - so will a sale lead to shows losing their edge?",
                        Content = "Launching 40 years ago with Richard Whiteley introducing the now long-running afternoon favourite Countdown, this was a commercially funded way to deliver to under-served audiences and break up the duopoly of ITV and the BBC. Channel 4 was designed to be disruptive. In recent years, it has normalised different body types with full-frontal nudity in Naked Attraction, delivered 24 hours of programming featuring only black presenters, actors, writers and experts, and brought us the masterful (and now leading BAFTA-nominated) drama about the AIDs crisis, It's A Sin. Currently owned by the government, it is in a unique position in that it receives its funding from advertising, not the taxpayer. The government has argued that the broadcaster's long-term future needs to be secured amid concerns for its survival in the streaming era, with Culture Secretary Nadine Dorries saying its ownership is holding it back.",
                        CreatedDate = DateTime.Parse("2022-6-18"),
                        UpdatedDate = DateTime.Parse("2022-6-18"),
                        IsPublished = true,
                        PublishedDate = DateTime.Parse("2022-6-18"),
                        Category = Report.CategoryType.Entertainment, 
                        CreatedBy = Guid.Parse("e03056cf-7146-483f-a86f-e41f8332060d")
                    },
                    new Report
                    {
                        Title = "Parade of Wonders cancelled after spring snowfall in Calgary.",
                        Content = "Never mind raining on our parade. Mother Nature decided to drop some serious snow Friday morning and it has led to the cancellation of a much-anticipated local event.  Environment Canada said the city could expect to see 10-15 centimetres of snow before it tapers off in the afternoon. The sudden and unexpected snow has forced the cancellation of the Calgary Expo’s Parade of Wonders, which would have seen hundreds marching in their best movie, cartoon and comic book themed costumes in the downtown.  There is a 30 per cent chance that the snow will turn to rain in the afternoon which could make for slippery driving conditions during the afternoon rush home. So far, Calgary Transit isn’t reporting any delays and it looks like traffic is still flowing with no reported collisions on city roadways.  Early this evening the showers could continue with it clearing later in the night. Airdrie, Cochrane, Olds and Sundre are also under a snowfall warning. The good news out of all of this is the weekend weather is looking very nice with sunny skies and a high of 12 degrees for both Saturday and Sunday. ",
                        CreatedDate = DateTime.Parse("2022-1-3"),
                        UpdatedDate = DateTime.Parse("2022-2-12"),
                        IsPublished = true,
                        PublishedDate = DateTime.Parse("2022-1-9"),
                        Category = Report.CategoryType.Weather, 
                        CreatedBy = Guid.Parse("e03056cf-7146-483f-a86f-e41f8332060d")
                    },
                    new Report
                    {
                        Title = "Government parties must work together on turf future as talks begin next week",
                        Content = "Government parties will have to work together to agree rules banning the sale of turf, according to a Green Party Minister of State. Pippa Hackett would not be drawn on whether the controversial plan would be a red line issue for the Government but said: It is a Programme for Government commitment to deliver on air quality, and it is an absolutely necessity that we do that. Speaking on Saturday with Katie Hannon, Ms Hackett said the regulations are still in a draft phase, and there is a lot of work to be done. But she said they have to be seen as a public health measure as 1,300 people are dying every year because of inhalation of fire fuel. The regulations are part of moves to introduce a nationwide ban on smoky coal in September of this year.",
                        CreatedDate = DateTime.Parse("2022-4-12"),
                        UpdatedDate = DateTime.Parse("2022-4-12"),
                        IsPublished = true,
                        PublishedDate = DateTime.Parse("2022-4-12"),
                        Category = Report.CategoryType.Politics, 
                        CreatedBy = Guid.Parse("e03056cf-7146-483f-a86f-e41f8332060d")
                    },
                    new Report
                    {
                        Title = "People are struggling to pay their energy bills – here is a simple idea that could help",
                        Content = "With 40% of us likely to fall into fuel poverty as price rises hit, what if those with the broadest shoulders took the load? There are solutions, short and long term. Here is a particularly imaginative one, from Fuel Poverty Action, which would reverse the perversities in current pricing. Give everyone a minimum quantity of free energy, paid for by ending fossil fuel subsidies and by windfall taxes, then via higher prices on profligate energy use. Taking this idea, I’d suggest the minimum should be enough to just about manage frugally in a small home and you would then raise the tariff on a steep gradient for all extra energy used, so big properties and heavy users pay higher and higher rates the more they use, covering the cost of the free energy. The incentive for everyone would be to cut back as much as they could, so high-earners who never bothered about it before would find energy extravagance exorbitant. They too would soon be turning off lights and devices on standby, using less water (energy intensive) and wearing more vests and jumpers. The present system does the opposite. With standing charges, the lowest users pay the highest rates, those with prepay meters pay monstrous rates, and it tails off for high users the more they use.",
                        CreatedDate = DateTime.Parse("2020-6-21"),
                        UpdatedDate = DateTime.Parse("2020-8-22"),
                        IsPublished = true,
                        PublishedDate = DateTime.Parse("2020-6-12"),
                        Category = Report.CategoryType.Opinion, 
                        CreatedBy = Guid.Parse("e03056cf-7146-483f-a86f-e41f8332060d")
                    },
                    new Report
                    {
                        Title = "Max Verstappen passes Charles Leclerc to win the Sprint!",
                        Content = "Red Bull Max Verstappen caught and passed Ferrari Charles Leclerc with two laps to go to win the sprint race at the Emilia Romagna Grand Prix. The result gives the world champion pole position for the start of the main race on Sunday, and reduces his deficit in the championship to 45 points. The late lunge at Imola gives Verstappen an extra eight points for his championship tally But, in a weird quirk, no Saturday sprint race winner has capitalised by winning the following day’s Grand Prix. Still, the result sees Verstappen lead the grid for Sunday with Leclerc alongside him. Sergio Perez finished third, while Carlos Sainz moved from 10th to fourth as Red Bull and Ferrari blocked out the front two rows of the grid. However, Leclerc admitted some concerns in the Scuderia garage after the sprint ended.",
                        CreatedDate = DateTime.Parse("2020-6-21"),
                        UpdatedDate = DateTime.Parse("2020-8-22"),
                        IsPublished = true,
                        PublishedDate = DateTime.Parse("2020-6-12"),
                        Category = Report.CategoryType.Sport, 
                        CreatedBy = Guid.Parse("e03056cf-7146-483f-a86f-e41f8332060d")
                    },
                    new Report
                    {
                        Title = "Tech enabled Flash Coffee makes debut in Hing Kong.",
                        Content = "Hong Kong's love for coffee runs deep, causing a constant wave of new cafes and coffee shops to open up everywhere you turn in this caffeine-addicted city – and there's always room for more. Flash Coffee, a tech-enabled coffee chain that launched in Jakarta last year, is making a splash in Hong Kong with at least four new locations. The brand promises top-quality premium roasts curated by global barista champions that you can grab and go for convenience. The Flash part, we're guessing, is all about the technology that drives the experience. In other words, you can download a Flash Coffee mobile app that allows you to order, pay and customise your coffee online before you collect it in-store or have it delivered. ",
                        CreatedDate = DateTime.Parse("2022-2-12"),
                        UpdatedDate = DateTime.Parse("2022-2-13"),
                        IsPublished = true,
                        PublishedDate = DateTime.Parse("2022-2-12"),
                        Category = Report.CategoryType.FoodDrink, 
                        CreatedBy = Guid.Parse("e03056cf-7146-483f-a86f-e41f8332060d")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}