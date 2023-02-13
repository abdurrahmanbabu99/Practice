﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Class
{
    /*
    public class TimePeriod
    {
        private double _seconds;
        public double Hours
        {
            get {

                return _seconds / 3600;
            }


            set
            {
                if (value<0 || value>24)
                {
                    throw new ArgumentException(nameof(value),
                        "The valid range is between 0 and 24");
                    _seconds = value * 3600;
                }

              
            }
        }

         

    }

    */
    public class TimePeriod
    {
        private double _seconds;

        public double Hours
        {
            get { return _seconds / 3600; }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(nameof(value),
                          "The valid range is between 0 and 24.");

                _seconds = value * 3600;
            }
        }
    }


}
