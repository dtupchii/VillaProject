using Microsoft.AspNetCore.Mvc;
using static VillaProject_Utility.SD;

namespace VillaProject_Web.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
