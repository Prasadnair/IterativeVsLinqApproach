using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeVsLinqApproach
{
    public class BenchMarkTest
    {
        private List<SourceObject> sourceList;
       
        [GlobalSetup]
        public void GlobalSetup()
        {
            sourceList = Enumerable.Range(1, 10000)
                .Select(i => new SourceObject { Id = i, Name = $"Object {i}" })
                .ToList();
        }

        [Benchmark]
        public void IterarativeApproach()
        {
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

        [Benchmark]
        public void LinqApproach()
        {
            List<DestinationObject> destinationList = sourceList.Select(sourceObject => new DestinationObject
            {
                Id = sourceObject.Id,
                DisplayName = "Display " + sourceObject.Name // Perform any mapping here
            }).ToList();
        }

    }
}
