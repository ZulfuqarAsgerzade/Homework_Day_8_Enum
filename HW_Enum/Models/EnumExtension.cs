using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW_Enum.Models
{
    public static class EnumExtension
    {
        public static string GetDisplayName(Enum enumValue)
        {
            return enumValue.GetType().GetMember(enumValue.ToString())
                            .First().GetCustomAttribute<DisplayAttribute>()?.GetName();
        }
    }
}
