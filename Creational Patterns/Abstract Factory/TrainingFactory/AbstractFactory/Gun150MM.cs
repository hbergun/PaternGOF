using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Gun150MM : ITankGun
    {
        public string Fire()
        {
            return "Gun150MM Fired";
        }
    }
}
