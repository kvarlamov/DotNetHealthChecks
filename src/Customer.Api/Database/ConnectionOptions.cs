namespace Customer.Api.Database;

public class ConnectionOptions
{
    public const string Connection = "ConnectionStrings";
    
    public string CustomerDB { get; set; }

    public string DockerConn { get; set; }
}