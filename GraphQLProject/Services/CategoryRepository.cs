using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private GraphQLDbContext _dbContext;
        public CategoryRepository(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Category AddCategory(Category category)
        {
            _dbContext.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            _dbContext.Categories.Remove(category);
        }

        public List<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category UpdateCategory(int id, Category category)
        {
            var updatedCategory = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            updatedCategory.Name = category.Name;
            updatedCategory.ImageUrl = category.ImageUrl;
            _dbContext.SaveChanges();

            return category;
        }
    }
}
