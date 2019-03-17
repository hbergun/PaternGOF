using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Gun80MM : ITankGun
    {
        public string Fire()
        {
            return "Gun80MM Fired";
        }
    }
}
