using System.Collections.Generic;

namespace App_9_2.Models.Contracts
{
    public interface IBird
    {
        string Name { get; set; }
        bool IsEndangered { get; set; }
        string EndangeredInfo { get; }
        string ResidesInAreas { get; set; }
        List<string> ImageUrls { get; set; }
        string Description { get; set; }
        string IsEndangeredLabelColor { get; }
    }
}
