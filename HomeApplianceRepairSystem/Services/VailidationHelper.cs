using System;
using System.Text.RegularExpressions;

namespace HomeApplianceRepairSystem.Services
{
    public static class ValidationHelper
    {
        public static bool IsValidSerialNumber(string serialNumber)
        {
            if (string.IsNullOrWhiteSpace(serialNumber))
                return false;

            return Regex.IsMatch(
                serialNumber.Trim(),
                @"^[A-Za-z0-9-]{3,30}$");
        }

        public static bool IsValidCustomerName(string customerName)
        {
            return !string.IsNullOrWhiteSpace(customerName);
        }

        public static bool IsValidReceivedDate(DateTime receivedDate)
        {
            return receivedDate.Date <= DateTime.Today;
        }

        public static bool IsValidCost(decimal cost)
        {
            return cost >= 0;
        }
    }
}