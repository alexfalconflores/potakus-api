namespace PotakusAPI.Utils;

public static class ApiVersion
{
    private readonly static string api = "api/";
    public static string V1(string prefix) => api + "V1/" + prefix;
}
