using System;

namespace DependencyInjectionInNet5.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public float? Error { get; set; }
    }
}
