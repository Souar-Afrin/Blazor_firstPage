﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_firstPage.Shared
{
    public class User
    {
        //private static int nextId;
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public User()
        {
        }

        public User(int id, string name, string email)
        {
            //Id = nextId++;
            Id = id;
            Name = name;
            Email = email;
        }
    }
}