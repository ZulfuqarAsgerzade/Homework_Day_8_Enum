using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

enum DbConnections
{
    [Display(Name = "connectionStringAWS")]
    AWS,

    [Display(Name = "connectionStringAzure")]
    Azure,

    [Display(Name = "connectionStringSQL")]
    SQL
}