using Microsoft.AspNetCore.Mvc;
namespace tpmodul10_103022300058.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
           new Mahasiswa("LeBron James","1302000001"),
           new Mahasiswa("Stephen Curry","1302000002")
        };
        [HttpGet]
        //menoutputkan semua mahasiswa yang ada di list
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }
        [HttpPost]
        //menambahkan data mahasiswa ke dalam list
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            dataMahasiswa.Add(mahasiswa);
        }
        [HttpGet("{id}")]
        //mengoutputkan 1 mahasiswa yang diambil dari list sesuai dengan indexnya
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }
        //menghapus data mahasiswa dari list sesuai dengan indexnya
        [HttpDelete]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
