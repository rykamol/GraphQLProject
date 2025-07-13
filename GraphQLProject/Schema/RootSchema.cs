using GraphQLProject.Mutation;
using GraphQLProject.Query;

namespace GraphQLProject.Schema
{
    public class RootSchema : GraphQL.Types.Schema
    {
        //IServiceProvider is built in .net core that provides access
        //to all the registered services in the app dependency inj container.
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
