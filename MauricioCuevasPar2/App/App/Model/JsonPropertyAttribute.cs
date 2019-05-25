using System;

namespace App.Model
{
    internal class JsonPropertyAttribute : Attribute
    {
        public string PropertyName { get; set; }
    }
}