﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_24_TeamViolet.Shared.ViewModels {
    public class ManagerViewModel {


        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public bool Status { get; set; }

    }
}
