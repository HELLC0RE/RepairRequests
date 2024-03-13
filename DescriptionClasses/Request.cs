using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairRequests.DescriptionClasses
{
    public class Request
    {
        public int Id { get; set; } 
        public string Description { get; set; }
        public string Requester_Full_Name { get; set; }
        public string Requester_Email { get; set; }
        public string Repaierer_Full_Name { get; set; }
        public string Equipment_type_title { get; set; }
        public string Severity_title { get; set; }
        public string Priority_title { get; set; }
        public string Status_title { get; set; }
        public DateTime Request_Date { get; set; }

        public Request() { }

        public Request(int id, string description, string requester_Full_Name, string requester_Email, string repaierer_Full_Name, string equipment_type_title, string severity_title, string priority_title, string status_title, DateTime request_Date)
        {
            Id = id;
            Description = description;
            Requester_Full_Name = requester_Full_Name;
            Requester_Email = requester_Email;
            Repaierer_Full_Name = repaierer_Full_Name;
            Equipment_type_title = equipment_type_title;
            Severity_title = severity_title;
            Priority_title = priority_title;
            Status_title = status_title;
            Request_Date = request_Date;
        }
    }
}
