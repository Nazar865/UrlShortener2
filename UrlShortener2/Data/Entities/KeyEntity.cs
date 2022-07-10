using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener2.Data.Entities
{
    public abstract class KeyEntity
    {
        [Key]
        public virtual Guid Id { get; set; }
    }
}