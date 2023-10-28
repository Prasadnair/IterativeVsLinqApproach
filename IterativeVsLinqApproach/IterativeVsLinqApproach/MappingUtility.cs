using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeVsLinqApproach
{
    internal class MappingUtility
    {

        public void IterarativeApproach()
        {
            List<SourceObject> sourceList = GetSourceList();
            List<DestinationObject> destinationList = new List<DestinationObject>();

            foreach (var sourceObject in sourceList)
            {
                var destinationObject = new DestinationObject
                {
                    Id = sourceObject.Id,
                    DisplayName = "Display " + sourceObject.Name // Perform any mapping here
                };
                destinationList.Add(destinationObject);
            }
        }


        public void LinqApproach()
        {
            List<SourceObject> sourceList = GetSourceList();
            List<DestinationObject> destinationList = sourceList.Select(sourceObject => new DestinationObject
            {
                Id = sourceObject.Id,
                DisplayName = "Display " + sourceObject.Name // Perform any mapping here
            }).ToList();
        }


        private List<SourceObject> GetSourceList()
        {
            return new List<SourceObject>
            {
                new SourceObject { Id = 1, Name = "Object 1" },
                new SourceObject { Id = 2, Name = "Object 2" },
                new SourceObject { Id = 3, Name = "Object 3" },
                new SourceObject { Id = 4, Name = "Object 4" },
                new SourceObject { Id = 5, Name = "Object 5" },
                new SourceObject { Id = 6, Name = "Object 6" },
                new SourceObject { Id = 7, Name = "Object 7" }
                // Additional items could be added here
            };
        }

    }
}
