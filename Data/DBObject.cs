using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeaTimeSite.Data.Models;

namespace TeaTimeSite.Data
{
    public class DBObject
    {
        public static void Initial(DBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(GetCategories.Select(cont => cont.Value));
            }

            if (!content.Goods.Any())
            {
                content.AddRange(
                    new Goods
                    {
                        name = "Иу Шань Шу Пуэр",
                        shortDesc = @"""Знаменитый Юньнаньский чай""",
                        longDesc = "Классика от Мэнхайской чайной фабрики - знаменитый V93",
                        img = "/img/v93.jpg",
                        price = 5m,
                        isFavorite = true,
                        isAvailable = true,
                        Category = GetCategories["Пуэры"],
                    },

                    new Goods
                    {
                        name = "Да Хун Пао",
                        shortDesc = @"""Большой Красный Халат""",
                        longDesc = "Наряду с теплыми медово-шоколадными нотами мирно соседствуют веселые звенящие цветочные ноты, дополняясь древесностью и фруктовостью",
                        img = "/img/dhp.jpg",
                        price = 5.5m,
                        isFavorite = true,
                        isAvailable = true,
                        Category = GetCategories["Улуны"],
                    },

                    new Goods
                    {
                        name = "Хун Маофен",
                        shortDesc = @"""Красные Ворсистые Пики""",
                        longDesc = "Бюджетнейший красный чай, выпивается мной литрами, когда нет желания церемониться",
                        img = "/img/hmf.jpg",
                        price = 3.2m,
                        isFavorite = true,
                        isAvailable = true,
                        Category = GetCategories["Красный чай"],
                    }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> GetCategories
        {
            get
            {
                if (category == null)
                {
                    var categoryList = new Category[]
                    {
                        new Category { categoryName = "Пуэры", description = "Самый популярный чай в интернете" },
                        new Category { categoryName = "Улуны", description = "Мир вкусов и ароматов" },
                        new Category { categoryName = "Красный чай", description = "Он же черный (в наших широтах)" },
                    };

                    category = new Dictionary<string, Category>();
                    foreach (var currentCategory in categoryList)
                    {
                        category.Add(currentCategory.categoryName, currentCategory);
                    }
                }

                return category;
            }
        }
    }
}
