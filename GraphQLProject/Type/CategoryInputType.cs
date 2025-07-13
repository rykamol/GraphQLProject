using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class CategoryInputType : InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");   
            Field<FloatGraphType>("imageUrl");         
        }
    }
}
