using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VillaProject_Web.Models;
using VillaProject_Web.Models.DTO;
using VillaProject_Web.Services;
using VillaProject_Web.Services.IServices;

namespace VillaProject_Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IVillaNumberService _villaNumberService;

        public VillaNumberController(IVillaNumberService villaNumberService, IMapper mapper)
        {
            _mapper = mapper;
            _villaNumberService = villaNumberService;
        }

        public async Task<IActionResult> IndexVillaNumber()
        {
            List<VillaNumberDTO> list = new();

            var response = await _villaNumberService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }

        //  Number
    }
}
