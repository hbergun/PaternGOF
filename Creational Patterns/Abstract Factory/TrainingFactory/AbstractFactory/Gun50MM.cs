using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Gun50MM : ITankGun
    {
        public string Fire()
        {
            return "Gun50MM Fired";
        }
    }
}
