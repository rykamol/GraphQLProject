using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("customerName");   
            Field<StringGraphType>("email");   
            Field<FloatGraphType>("phoneNumber");         
            Field<FloatGraphType>("partySize");         
            Field<FloatGraphType>("specialRequest");         
            Field<FloatGraphType>("reservationDate");         
        }
    }
}
