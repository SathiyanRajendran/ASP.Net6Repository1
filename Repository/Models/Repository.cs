using System.ComponentModel.DataAnnotations;

namespace ASP.Net6Repository.Models
{
    public class Repository
    {
        [Key]
        public int SathyaId { get; set; }
        public string SathyaName { get; set; }
        public string SathyaLocation { get; set; }
    }
}
