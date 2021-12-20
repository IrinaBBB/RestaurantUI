using System.Collections.Generic;
using MvvmHelpers;

namespace RestaurantUI.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();
        }

        public List<Pick> Picks { get; set; }

        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick
                {
                    Title = "Breakfast", Image = "breakfast.jpg",
                    Description = "Order our healthy and warm breakfast menu for a great morning"
                },
                new Pick
                {
                    Title = "Lunch", Image = "lunch.jpg",
                    Description = "Delicious lunch to keep your day sweet and smooth"
                },
                new Pick
                {
                    Title = "BreakfastTime", Image = "food1.jpg",
                    Description = "Delicious breakfast to keep your day sweet and smooth"
                },
                new Pick
                {
                    Title = "LunchTime", Image = "food2.jpg",
                    Description = "Delicious lunch to keep your day sweet and smooth"
                },
                new Pick
                {
                    Title = "Dinner", Image = "food3.jpg",
                    Description = "Delicious dinner to keep your evening sweet and smooth"
                },
            };
        }
    }

    public class Pick
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}