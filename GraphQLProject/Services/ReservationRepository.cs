using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLProject.Services
{
    public class ReservationRepository : IReservationRepository
    {
        private GraphQLDbContext _dbcontext;
        public ReservationRepository(GraphQLDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Reservation AddReservation(Reservation reservation)
        {
            _dbcontext.Reservations.Add(reservation);
            _dbcontext.SaveChanges();
            
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return _dbcontext.Reservations.ToList();
        }
    }
}
