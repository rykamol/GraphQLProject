using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class CategoryMutation : ObjectGraphType
    {
        public CategoryMutation(ICategoryRepository categoryRepository)
        {
            Field<MenuType>("CreateCategory")
               .Arguments(new QueryArguments(new QueryArgument<CategoryInputType> { Name = "category" }))
               .Resolve(context =>
               {
                   return categoryRepository.AddCategory(context.GetArgument<Category>("category"));
               });


            Field<MenuType>("UpdateCategory")
              .Arguments(new QueryArguments(
                  new QueryArgument<IntGraphType> { Name = "categoryId" },
                  new QueryArgument<CategoryInputType> { Name = "category" }))
              .Resolve(context =>
              {
                  return categoryRepository.UpdateCategory(
                      context.GetArgument<int>("categoryId"),
                      context.GetArgument<Category>("category")
                      );
              });


            Field<StringGraphType>("DeleteCategory")
              .Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId" }))
              .Resolve(context =>
              {
                  var categoryId = context.GetArgument<int>("categoryId");
                   categoryRepository.DeleteCategory(categoryId);
                  return "The category against this Id" + categoryId + " has been deleted!";
              });
        }
    }
}
