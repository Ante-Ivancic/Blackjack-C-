using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp3
{
    public class Korisnik
    {
        string _name, _surname, _username, _password, _balance;
        public string name
        {
            get { return _name; }
        }
        public string surname
        {
            get { return _surname; }
        }
        public string username
        {
            get { return _username; }
        }
        public string password
        {
            get { return _password; }
        }
        public string balance
        {
            get { return _balance; }
        }
        public Korisnik(string username, string password, string name, string surname)
        {
            _username = username;
            _password = password;
            _name = name;
            _surname = surname;
            _balance = "100000";
        }
        public Korisnik(string username, string password, string name, string surname,string balance)
        {
            _username = username;
            _password = password;
            _name = name;
            _surname = surname;
            _balance = balance;
        }
        public string InfoZaDatoteku()
        {
            return (_username + "|" + _password + "|" + _name + "|" + _surname+"|"+_balance);
        }
    }
}
