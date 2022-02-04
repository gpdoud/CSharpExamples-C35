using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples {
    
    class DateTimeExamples {

        public static void Run() {

            // Get the current server local date and time
            DateTime now = DateTime.Now;
            
            // Get the universal coordinated time (GMT)
            DateTime utcNow = DateTime.UtcNow;
            
            // Create a specific date at midnight
            DateTime aDate = new DateTime(2022, 2, 3);
            
            // Create a specific date and time (9:30 PM)
            DateTime aDateTime = new DateTime(2022, 2, 3, 21, 30, 00);

            DateTime todayPlus7Days = DateTime.Today.AddDays(-7);
        }
    }
}
