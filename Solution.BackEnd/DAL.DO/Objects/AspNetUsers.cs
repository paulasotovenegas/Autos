﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DO.Objects
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            //AspNetUserClaims = new HashSet<AspNetUserClaims>();
            //AspNetUserLogins = new HashSet<AspNetUserLogins>();
            //AspNetUserRoles = new HashSet<AspNetUserRoles>();
            //AspNetUserTokens = new HashSet<AspNetUserTokens>();
            Autos = new HashSet<Autos>();
        }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string Nombre { get; set; }

        //public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        //public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        //public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        //public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<Autos> Autos { get; set; }
    }
}
