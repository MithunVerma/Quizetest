using System.Collections.Generic;

namespace Quize2.Models
{
    public class Question
    {
        public int Id { get; set; } 
        public List<Answer>  ans { get; set; }
             
        public string QTitle { get; set; }
        public bool ISMultiselect { get; set; }
        public decimal Masks { get; set; }
        public int deficultiLevel { get; set; }

    }
}
