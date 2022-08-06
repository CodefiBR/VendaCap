namespace VendaCap.Permissions;

public static class VendaCapPermissions
{
    public const string GroupName = "VendaCap";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public class TicketSet
    {
        public const string Default = GroupName + ".TicketSet";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }

    public class Person
    {
        public const string Default = GroupName + ".Person";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }

    public class Place
    {
        public const string Default = GroupName + ".Place";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
