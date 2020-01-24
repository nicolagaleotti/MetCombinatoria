﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
       public static long Fattoriale (int n)
        {
            long fatt = 1;
            for( int i = n ; i > 0 ; i--)
            {
                fatt = fatt * i;
            }
            return fatt;
        }
    }
}
