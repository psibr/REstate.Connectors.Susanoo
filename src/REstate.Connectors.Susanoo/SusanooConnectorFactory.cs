using REstate.Services;
using System.Threading.Tasks;

namespace REstate.Connectors.Susanoo
{
    public class SusanooConnectorFactory
        : IConnectorFactory
    {

        public string ConnectorKey { get; } = "REstate.Connectors.Susanoo";
        public bool IsActionConnector { get; } = true;
        public bool IsGuardConnector { get; } = true;
        public string ConnectorSchema { get; set; } = "{ }";

        public Task<IConnector> BuildConnector(string apiKey) => 
            Task.FromResult<IConnector>(new SusanooConnector(apiKey));
    }
}