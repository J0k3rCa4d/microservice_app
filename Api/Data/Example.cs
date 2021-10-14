using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Data
{
    public class Example
    {
        public int ExampleId { get; set; }

        [MaxLength(10)]
        public string Name { get; set; } 

        public long Timestamp { get; set; } 

        public float Value { get; set; } 
    }
}