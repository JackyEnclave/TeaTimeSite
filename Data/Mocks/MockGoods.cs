using TeaTimeSite.Data.Interfaces;
using TeaTimeSite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaTimeSite.Data.Mocks
{
    public class MockGoods : IGoods
    {
        private readonly IGoodsCategory _categoryGoods = new MockCategory();
        public IEnumerable<Goods> Goods
        {
            get
            {
                return new List<Goods>()
                {
                    new Goods
                    {
                        name = "Иу Шань Шу Пуэр",
                        shortDesc = @"""Знаменитый Юньнаньский чай""",
                        longDesc = "Классика от Мэнхайской чайной фабрики - знаменитый V93",
                        img = "/img/v93.jpg",
                        price = 5m,
                        isFavorite = true,
                        isAvailable = true,
                        Category = _categoryGoods.AllCategories.First()
                    },

                    new Goods
                    {
                        name = "Да Хун Пао",
                        shortDesc = @"""Большой Красный Халат""",
                        longDesc = "Наряду с теплыми медово-шоколадными нотами мирно соседствуют веселые звенящие цветочные ноты, дополняясь древесностью и фруктовостью",
                        img =  "/img/dhp.jpg",
                        price = 5.5m,
                        isFavorite = true,
                        isAvailable = true,
                        Category = _categoryGoods.AllCategories.Last()
                    },

                    new Goods
                    {
                        name = "Хун Маофен",
                        shortDesc = @"""Красные Ворсистые Пики""",
                        longDesc = "Бюджетнейший красный чай, выпивается мной литрами, когда нет желания церемониться",
                        img =  "/img/hmf.jpg",
                        price = 3.2m,
                        isFavorite = true,
                        isAvailable = true,
                        Category = _categoryGoods.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Goods> FavoriteGoods { get; set; }

        public Goods GetOneGood(int id)
        {
            return Goods.FirstOrDefault(x => x.id == id);
        }
    }
}
