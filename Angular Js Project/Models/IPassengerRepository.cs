using Angular_Js_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Models
{
    public interface IPassengerRepository
    {
        IEnumerable<Passsenger> GetAllPassenger();
        IEnumerable<Train> GetAllTrain();
        IEnumerable<Route> GetAllRoute();
        IEnumerable<Class> GetAllClass();
        Passsenger GetPassengerById(int id);
        Passsenger SavePassenger(Passsenger obj);
        Train SaveTrain(Train obj);
        Route SaveRoute(Route obj);
        Class SaveClass(Class obj);
        Passsenger UpdatePassenger(Passsenger upobj);
        Passsenger DeletePassenger(int id);
        bool GetPassengerByEmail(string email);
    }
}
