using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BusinessCore.helper;

public class JwtOptions
{
    public string Issure { get; set; }

    public string Audience { get; set; }
    public int LifeTime { get; set; }

    public string SigningKey { get; set; }
}
