using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    //dependency inj is a design pattern that allows us to make a class fully intependent
    // of it's depedencies, rather that relaying on the concreate implementation we use 
    //interfaces which grately enhance the maintability of the code.
    public class MenuRepository : IMenuRepository
    {
        private GraphQLDbContext _dbContext;

        public MenuRepository(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Menu AddMenu(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int id)
        {
            var deleteMenu = _dbContext.Menus.FirstOrDefault(x => x.Id == id);
            _dbContext.Menus.Remove(deleteMenu);
        }

        public List<Menu> GetAllMenus()
        {
            return _dbContext.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            return _dbContext.Menus.FirstOrDefault(x => x.Id == id);
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            var updateMenu = _dbContext.Menus.FirstOrDefault(x => x.Id == id);
            updateMenu.Name = menu.Name;
            updateMenu.Description = menu.Description;
            updateMenu.Price = menu.Price;
            updateMenu.ImageUrl = menu.ImageUrl;
            updateMenu.CategoryId = menu.CategoryId;

            _dbContext.SaveChanges();

            return menu;
        }
    }
}
