using DatingApp.Data;
using System.Collections.Generic;

namespace DatingAppFSDProject.Domain
{
    public class Censorship: BaseDomainModel
    {
        public string? CensoredWords { get; set; }
    }
}
