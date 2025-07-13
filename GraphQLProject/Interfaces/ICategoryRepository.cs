using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category AddCategory(Category category);
        Category UpdateCategory(int menuId, Category category);
        void DeleteCategory(int id);
    }
}
