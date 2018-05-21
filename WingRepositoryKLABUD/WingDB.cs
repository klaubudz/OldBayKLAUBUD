using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using ModelsKLABUD;

namespace WingRepositoryKLABUD
{
    public class WingDB : IWingDB
    {
        private readonly string _connectionString = @"C:\DB\SOA_WINGS";
        private readonly string _collectionName = "wings";

        public string CreateWing(Wing wing)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Wing>(_collectionName);

                collection.Insert(wing);
                return wing.Name;
            }
        }

        public Wing GetWing(string name)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Wing>(_collectionName);

                return collection.FindOne(e => e.Name.Equals(name));
            }
        }

        public List<Wing> GetAllWings()
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Wing>(_collectionName);

                return collection.FindAll().ToList();
            }
        }
    }
}
