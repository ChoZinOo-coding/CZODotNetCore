using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace CZODotNetCore.RestApiWithNLayer.Features.DreamDictionary
{
    [Route("api/[controller]")]
    [ApiController]
    public class DreamDictionaryController : ControllerBase
    {
        private DreamDictionary _data;

        private async Task<DreamDictionary> GetDataAsync()
        {

            string jsonStr = await System.IO.File.ReadAllTextAsync("DreamDictionary.json");
            var model = JsonConvert.DeserializeObject<DreamDictionary>(jsonStr);
            return model;

        }

        // api/DreamDictionary/questions
        [HttpGet("questions")]
        public async Task<IActionResult> Questions()
        {
            var model = await GetDataAsync();
            return Ok(model.BlogHeader);
        }

        [HttpGet]
        public async Task<IActionResult> NumberList()
        {
            var model = await GetDataAsync();
            return Ok(model.BlogDetail);
        }
        [HttpGet("{questionNo}/{no}")]
        public async Task<IActionResult> Answser(int questionNo, int no)
        {
            var model = await GetDataAsync();
            return Ok(model.BlogDetail.FirstOrDefault(x => x.BlogId == questionNo && x.BlogDetailId == no));
        }
    }

        public class DreamDictionary
    {
        public Blogheader[] BlogHeader { get; set; }
        public Blogdetail[] BlogDetail { get; set; }
    }

    public class Blogheader
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
    }

    public class Blogdetail
    {
        public int BlogDetailId { get; set; }
        public int BlogId { get; set; }
        public string BlogContent { get; set; }
    }

}
