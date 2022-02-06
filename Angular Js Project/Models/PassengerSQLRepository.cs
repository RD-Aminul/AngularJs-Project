using Angular_Js_Project.Data;
using Angular_Js_Project.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Models
{
    public class PassengerSQLRepository : IPassengerRepository
    {
        private readonly ApplicationDbContext _context;
        public PassengerSQLRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Passsenger> GetAllPassenger()
        {
            IEnumerable<Passsenger> psngrList = _context.Passengers.Select(p => new Passsenger
            {
                PassengerID = p.PassengerID,
                PassengerName = p.PassengerName,
                PassengerEmail = p.PassengerEmail,
                PassengerPhone = p.PassengerPhone,
                JourneyDate = p.JourneyDate,
                TrainID = p.TrainID,
                TrainName = p.Train.TrainName,
                RouteID = p.RouteID,
                RouteName = p.Route.RouteName,
                ClassID = p.ClassID,
                ClassName = p.Class.ClassName,
                Fee = p.Fee

            }).ToList();
            return psngrList;
        }

        public Passsenger DeletePassenger(int id)
        {
            Passsenger psngr = GetPassengerById(id);
            if (psngr != null)
            {
                _context.Passengers.Remove(psngr);
                _context.SaveChanges();
            }
            return psngr;
        }

        public bool GetPassengerByEmail(string email)
        {
            Passsenger psngr = _context.Passengers.Where(p => p.PassengerEmail == email).FirstOrDefault();
            if (psngr != null)
            {
                return true;
            }
            return false;
        }

        public Passsenger GetPassengerById(int id)
        {
            Passsenger psngr = _context.Passengers.Find(id);
            return psngr;
        }

        public Passsenger SavePassenger(Passsenger obj)
        {
            _context.Passengers.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Passsenger UpdatePassenger(Passsenger upobj)
        {
            var emp = _context.Passengers.Attach(upobj);
            emp.State = EntityState.Modified;
            _context.SaveChanges();
            return upobj;
        }
        public Train SaveTrain(Train obj)
        {
            _context.Trains.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Route SaveRoute(Route obj)
        {
            _context.Routes.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Class SaveClass(Class obj)
        {
            _context.Classes.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public IEnumerable<Train> GetAllTrain()
        {
            return _context.Trains;
        }

        public IEnumerable<Route> GetAllRoute()
        {
            return _context.Routes;
        }

        public IEnumerable<Class> GetAllClass()
        {
            return _context.Classes;
        }

        
    }
}
