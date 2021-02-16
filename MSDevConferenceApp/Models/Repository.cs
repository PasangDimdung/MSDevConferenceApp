using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSDevConferenceApp.Models
{
    public class Repository
    {
        //List to store list after form registration
        private static List<WebinarInvites> responses = new List<WebinarInvites>();

        //To pass list of objects to the view
        public static IEnumerable<WebinarInvites> Responses => responses;
        public static void AddResponse(WebinarInvites response)
        {
            responses.Add(response);
        }
    }
}
