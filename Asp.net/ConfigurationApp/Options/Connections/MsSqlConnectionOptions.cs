#pragma warning disable CS8618

using ConfigurationApp.Options.Connections.Base;

namespace ConfigurationApp.Options.Connections;

public class MsSqlConnectionOptions : IConnectionOptions
{
    public string Database { get; set; }
    public string Server { get; set; }
    public string UserId { get; set; }
    public string Password { get; set; }
    public string? TrustServerCertificate { get; set; }

    public string ConnectionString {
        get {
            ArgumentException.ThrowIfNullOrEmpty(Database);
            ArgumentException.ThrowIfNullOrEmpty(Server);
            ArgumentException.ThrowIfNullOrEmpty(UserId);
            ArgumentException.ThrowIfNullOrEmpty(Password);

            var connectionString = $"Database={this.Database};Server={this.Server};User Id={this.UserId};Password={this.Password};";
            
            if(string.IsNullOrWhiteSpace(this.TrustServerCertificate) == false) {
                connectionString += $"TrustServerCertificate={this.TrustServerCertificate};";
            }

            return connectionString;
        }
    }
}