using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.Data
{
    public class DbObjects
    {
        public static void Initial(AppDbContent dbContent)
        {
            if (!dbContent.Category.Any())
            {
                dbContent.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!dbContent.Coffe.Any())
            {
                dbContent.AddRange(
                   new Coffe
                    {
                        name = "Арабика",
                        shortDesc = "В кофе всегда чувствуется ярко-выраженная кислинка;" +
                                    " в зависимости от сорта могут быть сладковатые оттенки.",
                        longDesc = "Арабика впервые была открыта в Эфиопии," +
                                   " хотя об этом до сих пор ведутся дискуссии." +
                                   " Сейчас сорт культивируется по всему миру: от Центральной и Восточной Африки," +
                                   " Индии и Индонезии до Латинской Америки.",
                        img = "/img/Arabica.jpg",
                        price = 600, 
                        isFavorite = true,
                        avaiable = true,
                        Category =Categories["СортКофе"]
                    },
                    new Coffe
                    {
                        name = "Робуста",
                        shortDesc = "Название произошло от английского «robust» — сильный, плотный. " +
                                    "Это связано с тем, что робуста устойчива к болезням, " +
                                    "почти не восприимчива к внешним воздействиям и требует меньше внимания" +
                                    " при производстве и обработке, чем арабика.",
                        longDesc = "При заваривании получается терпкий кофе с высоким содержанием кофеина" +
                                   " и приглушенным ароматом, во вкусе легкая горечь.",
                        img = "/img/Robusta.jpg",
                        price = 500, 
                        isFavorite = true,
                        avaiable = true,
                        Category =Categories["СортКофе"]
                    },
                    new Coffe
                    {
                        name = "Наполеон",
                        shortDesc = "Считается, что десерт впервые приготовили придворные кондитеры Николая II" +
                                    " для приема в честь столетней годовщины победы в Отечественной войне 1812 года.",
                        longDesc = "Торт, по форме напоминающий двууголку, состоял всего из двух основных компонентов:" +
                                   " заварного крема и коржей из бездрожжевого слоеного теста. На приеме, конечно же," +
                                   " заметили, что торт похож на головной убор Бонапарта," +
                                   " поэтому десерт мгновенно окрестили «Наполеоном». Название прижилось.",
                        img = "/img/Napoleon.jpg",
                        price = 1500, 
                        isFavorite = true,
                        avaiable = true,
                        Category =Categories["Сладости"]
                    },
                   new Coffe
                   {
                       name = "JACOBS MONARCH",
                       shortDesc = "Jacobs Monarch обладает богатым, классическим вкусом " +
                                   "и притягательным ароматом, благодаря искусному сочетанию " +
                                   "отборных кофейных зёрен и глубокой обжарке, " +
                                   "и является наиболее популярным кофе в линейке Jacobs. " +
                                   "Приготовьте кофе Jacobs Monarch для себя и своих близких и почувствуйте " +
                                   "его вдохновляющую Аромагию",
                       longDesc = "",
                       img = "/img/monarh.jpg",
                       price = 1500, 
                       isFavorite = true,
                       avaiable = true,
                       Category =Categories["СортКофе"]
                   });
            }

            dbContent.SaveChanges();
        }

        private static Dictionary<string, Category> caregory;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (caregory==null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "СортКофе", desc = "Описание сорта"},
                        new Category {categoryName = "Сладости", desc = "тортики и различные закуски"}
                    };
                    caregory = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        caregory.Add(el.categoryName,el);
                    }
                }
                return caregory;
            }
        }
    }
}