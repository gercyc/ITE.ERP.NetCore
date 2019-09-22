using ITSolution.Framework.Core.BaseClasses.CommonEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ITSolution.Framework.Servers.Core.CustomerApi.Model
{
    [Table("CliFor")]
    public class Customer : AbstractClient
    {
        public Customer()
        {

        }

        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdCliFor { get; set; }
    }
}
