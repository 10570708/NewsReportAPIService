﻿using System.ComponentModel.DataAnnotations;

namespace NewsReportAPIService.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime UpdatedDate { get; set; }

        public bool IsPublished { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PublishedDate { get; set; }

        public CategoryType Category { get; set;  }

        public Guid CreatedBy { get; set; }
        

        public enum CategoryType
        {
            [Display(Name = "Local News")]
            LocalNews = 1,
            [Display(Name = "World News")]
            WorldNews = 2,
            Sport = 3,
            Entertainment = 4,
            Weather = 5,
            Politics = 6,
            Opinion = 7,
            [Display(Name = "Food & Drink")]
            FoodDrink = 8
        }





    }
}
