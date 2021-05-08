using System.Collections.Generic;
using System.Linq;
using Travellers_Coffee.Data.interfaces;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.Data.mocks
{
    public class MockCoffee : IAllProducts
    {
        private readonly ICoffeCategory _categoryCoffee=new MockCategory();
        public IEnumerable<Coffe> Coffes
        {
            get
            {
                return new List<Coffe>
                {
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
                        Category =_categoryCoffee.allCategories.First()
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
                        Category =_categoryCoffee.allCategories.First() 
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
                        Category =_categoryCoffee.allCategories.Last() 
                    }
                };
            }
            
        }

        public IEnumerable<Coffe> getFavCoffe { get; set; }
       
        public Coffe getObjectCoffe(int coffeId)
        {
            throw new System.NotImplementedException();
        }
    }
}