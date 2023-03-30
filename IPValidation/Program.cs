public class Program
{
    public static bool IsValidIp(string ipAddres)
    {
        var splittedIp = ipAddres.Split(".");
        if (splittedIp.Length != 4) return false;
        foreach (var ip in splittedIp)
        {
            if (ip.Contains(" ") || ip.StartsWith("-") || (ip.StartsWith("0") && ip.Length > 1)) return false;
            try
            {
                var number = int.Parse(ip);
                if (number > 255) return false;
            }
            catch
            {
                return false;
            }
        }
        return true;
    }
}