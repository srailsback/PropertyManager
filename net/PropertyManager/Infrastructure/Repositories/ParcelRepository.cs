using PropertyManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
namespace PropertyManager.Infrastructure.Repositories
{
    public interface IParcelRepository
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <value>
        /// All.
        /// </value>
        IQueryable<Parcel> All { get;  }


        /// <summary>
        /// Finds the specified match.
        /// </summary>
        /// <param name="match">The match.</param>
        /// <returns></returns>
        Parcel Find(Expression<Func<Parcel, bool>> match);


        /// <summary>
        /// Inserts the specified parcel.
        /// </summary>
        /// <param name="parcel">The parcel.</param>
        void Insert(Parcel parcel);


        /// <summary>
        /// Updates the specified parcel.
        /// </summary>
        /// <param name="parcel">The parcel.</param>
        void Update(Parcel parcel);


        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(string id);


        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();

    }

    public class ParcelRepository : BaseRepository, IParcelRepository
    {
        public ParcelRepository(DataContext context) : base(context) { }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <value>
        /// All.
        /// </value>
        public IQueryable<Parcel> All
        {
            get { return _context.Parcels; }
        }


        /// <summary>
        /// Finds the specified match.
        /// </summary>
        /// <param name="match">The match.</param>
        /// <returns></returns>
        public Parcel Find(Expression<Func<Parcel, bool>> match)
        {
            return _context.Parcels.SingleOrDefault(match);
        }


        /// <summary>
        /// Inserts the specified parcel.
        /// </summary>
        /// <param name="parcel">The parcel.</param>
        public void Insert(Parcel parcel)
        {
            _context.Parcels.Add(parcel);
        }


        /// <summary>
        /// Updates the specified parcel.
        /// </summary>
        /// <param name="parcel">The parcel.</param>
        public void Update(Parcel parcel)
        {
            _context.Entry(parcel).State = System.Data.Entity.EntityState.Modified;
        }


        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(string id)
        {
            _context.Parcels.Remove(Find(x => x.MemberId == id));
        }


        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}