namespace chore.Controllers;

    [ApiController]
    [Route("api/chores")]
    public class ChoresController : ControllerBase
    {
        private readonly ChoresService _choresService;

        public ChoresController(ChoresService choresService)
        {
            this._choresService = choresService;
        }
        

        [HttpGet]
        public ActionResult<List<Chore>> Get()
        {
            try
            {
                List<Chore> chores = _choresService.Get();
                return Ok(chores);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Chore> GetOne(int id)
        {
            try
            {
                Chore chore = _choresService.GetOne(id);
                return Ok(chore);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]

        public ActionResult<Chore> Create([FromBody] Chore choreData)
        {
            try
            {
                Chore chore = _choresService.Create(choreData);
                return Ok(chore);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<string> Remove(int id)
        {
            try
            {
                string message = _choresService.Remove(id);
                return Ok(message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
    }
