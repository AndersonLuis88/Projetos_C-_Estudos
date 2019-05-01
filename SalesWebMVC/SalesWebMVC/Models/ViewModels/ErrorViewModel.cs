using System;


namespace SalesWebMVC.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string ResquestId { get; set; }
        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(ResquestId);
    }
}
