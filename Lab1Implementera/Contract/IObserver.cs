﻿using Lab1Implementera.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera.Contract
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
