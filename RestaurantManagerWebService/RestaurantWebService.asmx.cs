using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Data.Entity;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace RestaurantManagerWebService
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebService1 : System.Web.Services.WebService
    {
        RestaurantEntities entities = new RestaurantEntities();
        JavaScriptSerializer serializer = new JavaScriptSerializer();

        [WebMethod]
        public string Login(string username,string password)
        {

            /* Fetch the stored value */
            var dbUser = entities.Users.Select(u => new { u.Id, u.Username, u.Password })
                .FirstOrDefault(u => u.Username == username);
            if(dbUser != null)
            {
                string savedPasswordHash = dbUser.Password;
                byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);
                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                        return null;
                string userJson = JsonConvert.SerializeObject(dbUser);
                return userJson;
            }
            return null;
        }

        public string hashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }

        [WebMethod]
        public string getReservations(int id)
        {
            var dbReservations = entities.Reservations
                .Where(r => r.RestaurantId == id)
                .Select(r => new { r.ReservationId, r.ReservationDate, r.ReservationTime, r.PartySize, r.ReservationDetails, r.ClientId, r.Client.FirstName, r.Client.LastName,r.Client.PhoneNumber });
            string reservationJson = JsonConvert.SerializeObject(dbReservations);
            return reservationJson;
        }

        [WebMethod]
        public void deleteReservation (int id)
        {
            var reservation = entities.Reservations.Find(id);
            entities.Entry(reservation).State = EntityState.Deleted;
            entities.SaveChanges();
        }

        [WebMethod]
        public void addReservation(string Firstname,string Lastname,string Phonenumber,int PartySize,DateTime Date,int Hour,int Minute,string Description,int RestaurantId)
        {
            Client client = entities.Clients.FirstOrDefault(c => c.RestaurantId == RestaurantId && c.FirstName == Firstname && c.LastName == Lastname && c.PhoneNumber == Phonenumber);
            Reservation reservation = new Reservation();
            if (client is null)
            {
                client = new Client();
                client.FirstName = Firstname;
                client.LastName = Lastname;
                client.PhoneNumber = Phonenumber;
                client.RestaurantId = RestaurantId;
                entities.Clients.Add(client);
                entities.SaveChanges();
            }
            TimeSpan Time = new TimeSpan(Hour, Minute, 0);
            reservation.Client = client;
            reservation.PartySize = PartySize;
            reservation.ReservationDate = Date;
            reservation.ReservationTime = Time;
            reservation.ReservationDetails = Description;
            reservation.RestaurantId = RestaurantId;
            entities.Reservations.Add(reservation);
            entities.SaveChanges();
        }

        [WebMethod]
        public void editReservation(int ReservationId,int clientId,string Firstname, string Lastname, string Phonenumber, int PartySize, DateTime Date, int Hour, int Minute, string Description, int RestaurantId)
        {
            Client client = entities.Clients.FirstOrDefault(c => c.ClientId == clientId);
            Reservation reservation = entities.Reservations.FirstOrDefault(r => r.ReservationId == ReservationId);
            client.FirstName = Firstname;
            client.LastName = Lastname;
            client.PhoneNumber = Phonenumber;
            client.RestaurantId = RestaurantId;
            TimeSpan Time = new TimeSpan(Hour, Minute, 0);
            reservation.Client = client;
            reservation.PartySize = PartySize;
            reservation.ReservationDate = Date;
            reservation.ReservationTime = Time;
            reservation.ReservationDetails = Description;
            entities.SaveChanges();
        }
    }
}
