﻿using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);
        Menu AddMenu(Menu name);
        Menu UpdateMenu(int menuId,Menu menu);
        void DeleteMenu(int id);
    }
}
