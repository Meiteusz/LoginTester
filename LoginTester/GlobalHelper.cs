namespace LoginTester
{
    public class GlobalHelper
    {
        public static string BusinessAlert(string message, WarningType warningType)
        {
            if (warningType == WarningType.Success)
                return "Success!\n" + message;
            else if (warningType == WarningType.Info)
                return "Information!\n" + message;
            else if (warningType == WarningType.Warning)
                return "Warning!\n" + message;
            else
                return "Danger!\n" + message;
        }
    }
}
