using System.Collections.Generic;

namespace DeliverDancingGoatMVC.Models
{
    public class CoffeesFilterViewModel
    {
        public bool Natural { get; set; }
        public bool SemiWashed { get; set; }
        public bool Washed { get; set; }

        public IEnumerable<string> GetFilteredValues()
        {
            if (Washed)
            {
                yield return "Washed";
            }
            if (SemiWashed)
            {
                yield return "Semi-washed";
            }
            if (Natural)
            {
                yield return "Natural";
            }
        }
    }
}