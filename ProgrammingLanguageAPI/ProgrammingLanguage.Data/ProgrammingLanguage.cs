using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLanguage.Data
{
    using System.ComponentModel.DataAnnotations;

    public class ProgrammingLanguage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string TypeSystem { get; set; } = string.Empty; // Static, Dynamic

        public int FirstAppeared { get; set; }

        [Required]
        public string Platform { get; set; } = string.Empty; // Web, Mobile, Backend

        public double UsagePercentage { get; set; }
    }

}
