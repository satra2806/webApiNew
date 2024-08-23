using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyApi.Models;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SectionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSections()
        {
            // Define the data as a list of Section objects
            var sections = new List<Section>
            {
                new Section
                {
                    Title = "Collections",
                    Color = "yellow",
                    Items = new List<Item>
                    {
                        new Item { Label = "List", Value = "list", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "JCNSearch", Value = "jcnSearch", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "Actions", Value = "actions", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "Reports", Value = "reports", BgColor = "bg-gray-200", TextColor = "text-blue-600" }
                    }
                },
                new Section
                {
                    Title = "Project Details",
                    Color = "yellow",
                    Items = new List<Item>
                    {
                        new Item { Label = "Progress", Value = "progress", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "Actions", Value = "projectActions", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "Origination", Value = "origination", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "Schedule", Value = "schedule", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "Project Charter", Value = "projectCharter", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        // Add more items as needed
                    }
                },
                new Section
                {
                    Title = "Other Information",
                    Color = "blue",
                    Items = new List<Item>
                    {
                        new Item { Label = "Financials", Value = "financials", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "Resources", Value = "resources", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "Metrics", Value = "metrics", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "History", Value = "history", BgColor = "bg-gray-200", TextColor = "text-blue-600" },
                        new Item { Label = "OPPM", Value = "oppm", BgColor = "bg-gray-200", TextColor = "text-blue-600" }
                    }
                }
            };

            // Return the list of sections as JSON
            return Ok(sections);
        }
    }
}
