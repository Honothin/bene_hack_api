using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bene_hack_api
{
    public class User
    {
        public int id;
        public string username;

        public User(int _id,string _username)
        {
            id = _id;
            username = _username;
        }
    }
}