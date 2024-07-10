using Implementation_1.Interface_Rules;

namespace Implementation_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rules Basetype = getbase();
            LogManager manager = new LogManager(Basetype);  // manager is handling whatever Basetype is instentiating.
            manager.WriteLog("Log send successfully");
        }
        public static Rules getbase()
        {
            string basename = "Database";
            if (basename == "Cloud")
            {
                return new Cloudlogger();
            }
            else
            {
                return new Databaselogger();
            }
        }
    }
}