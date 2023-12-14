using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.MockEntities
{
    public class MockSession
    {
        public Guid Id { get; set; }
        public string? IP { get; set; }
        public string? InventoryPath { get; set; }
        public string? PlaybooksPath { get; set; }
        public string? PlaybookExecutorsPath { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
