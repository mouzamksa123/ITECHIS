using System;
using System.Net;

namespace Shared.Filters.Model
{
    public class ExceptionObj
    {
        public ExceptionObj(string errMessage)
        {
            ExceptionId = Guid.NewGuid();
            Message = errMessage;
            IsError = true;
        }
        public ExceptionObj(string errMessage,object model)
        {
            ExceptionId = Guid.NewGuid();
            Message = errMessage; 
            IsError = true; 
            Model = model;
        }
        public ExceptionObj(string errMessage, string detailErrorMessage, object model)
        {
            ExceptionId = Guid.NewGuid();
            Message = errMessage;
            DetailErrorMessage = detailErrorMessage;
            IsError = true;
            Model = model;
        }
        public ExceptionObj(string errMessage, string detailErrorMessage)
        {
            ExceptionId = Guid.NewGuid();
            Message = errMessage;
            DetailErrorMessage = detailErrorMessage;
            IsError = true; 
        }
        public Guid ExceptionId { get; set; }
        public string Message { get; set; }
        public string DetailErrorMessage { get; set; }
        public bool IsError { get; set; } = true; 
        public object Model { get; set; }
    }
}
