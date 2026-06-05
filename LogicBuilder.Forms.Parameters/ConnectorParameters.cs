namespace LogicBuilder.Forms.Parameters
{
    public class ConnectorParameters(int id = 0, string? shortString = null, string? longString = null, object? connectorData = null)
    {
        public int Id { get; set; } = id;
        public string? ShortString { get; set; } = shortString;
        public string? LongString { get; set; } = longString;
        public object? ConnectorData { get; set; } = connectorData;
    }
}
