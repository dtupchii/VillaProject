using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using VillaProject_Web.Models;
using VillaProject_Web.Models.DTO;
using VillaProject_Web.Services.IServices;

namespace VillaProject_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IVillaService _villaService;

        public HomeController(IVillaService villaService, IMapper mapper)
        {
            _mapper = mapper;
            _villaService = villaService;
        }
        public async Task<IActionResult> Index()
        {
            List<VillaDTO> list = new();

            var response = await _villaService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }
    }
}