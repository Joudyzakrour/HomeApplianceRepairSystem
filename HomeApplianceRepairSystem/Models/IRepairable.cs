using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceRepairSystem.Models
{
    public interface IRepairable
    {
        decimal CalculateRepairCost();
        void StartRepair();
        void CompleteRepair();
    }
}
