﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DashStatistic
    {
        public int dailyTicket { get; set; }
        public double dailyMoney { get; set; }

        public string displayDailyMoney {
            get {
                return string.Format(System.Globalization.CultureInfo.CurrentCulture,
                    "{0:n0}", dailyMoney) + " VNĐ"; 
            }
        }
    }
}