using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BtkAkademi.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications; // erişim için interface
        // numra edilebilir            
        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}