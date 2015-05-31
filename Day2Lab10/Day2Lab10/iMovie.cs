using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10
{
    public interface iMovie
    {
        // Writing a contract that the classes will have to 'sign'
        // They are ALL automatically public - they have to be
        string Director { get; set; }
        decimal TicketPrice { get; set; }
        string Title { get; set; }
    }

    public interface iActionMovie
    {

    }

    // Class build
    public class Bladerunner : ActionMovie, iActionMovie, iMovie
    {

    }

    public class ActionMovie : iMovie // iMovie is NOT inherited. iMovie is an interface,
    {                                 // therefore, it is IMPLEMENTED. The program will not build
                                      // unless everything is implemented correctly.
                                      // Unlike inheriting, you can implement multiple interfaces,
                                      // each of which is seperated by a comma
        public string Director { get; set; }
        public decimal TicketPrice { get; set; }
        public string Title { get; set; }
    }

    public class SciFiMovie : iMovie
    {
        public string Director { get; set; }
        public decimal TicketPrice { get; set; }
        public string Title { get; set; }
    }
}
