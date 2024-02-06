namespace HW2
{
    internal class Categories
    {
        public string CategoryName { get; set; }
        public string DescriptionCategory { get; set; }

        //public Categories(string categoryName, string descritpionCategory)
        //{
        //    CategoryName = categoryName;
        //    DescriptionCategory = descritpionCategory;
        //}

        public void ShowCategoryInfo(string categoryName, string descriptionCategory)
        {
            CategoryName = categoryName;
            DescriptionCategory = descriptionCategory;
            Console.WriteLine($"{categoryName}, {descriptionCategory}");
        }
    }
}
